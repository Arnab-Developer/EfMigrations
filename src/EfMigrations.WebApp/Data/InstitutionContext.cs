using EfMigrations.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EfMigrations.WebApp.Data
{
    public class InstitutionContext : DbContext
    {
        public DbSet<Student>? Students { get; set; }

        public InstitutionContext(DbContextOptions<InstitutionContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }
    }
}
