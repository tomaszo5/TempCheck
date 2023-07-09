using Microsoft.EntityFrameworkCore;
using AmplituderChecker.Entities; 

namespace MotoApp.Data
{
    public class TemperatureCheckerDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            object value = optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }


    }
}
