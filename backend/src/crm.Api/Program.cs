using crm.Infra.Context;
using crm.Infra.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

{
    var services = builder.Services;
    var configuration = builder.Configuration;

    services.AddCors();
    services.AddCors();
    services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();


    //Connect Database
    services.AddDbContext<CrmContext>(options =>
    {
        options.UseMySql(configuration.GetConnectionString("CrmConnection"), ServerVersion.Parse("8.0.26"));
    });


    // Add services to the container.
    ApiDepencyInjection.Boot(services);
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

