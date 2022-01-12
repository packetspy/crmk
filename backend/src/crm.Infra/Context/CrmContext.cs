using crm.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace crm.Infra.Context
{
    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions options) :base(options) => Database.Migrate();

        public DbSet<User>? Users { get; set; }

    }
}
