using crm.Domain.Interface;
using crm.Domain.Service;
using Microsoft.Extensions.DependencyInjection;

namespace crm.Infra.Extensions
{ 
    public class ApiDepencyInjection
    {
        public static void Boot (IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}