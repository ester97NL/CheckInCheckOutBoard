using Microsoft.EntityFrameworkCore;
using CheckInCheckOutBoard6.Models;


namespace CheckInCheckOutBoard6
{
    public class DbEmployeeContext :DbContext
    {

        public DbEmployeeContext(DbContextOptions<DbEmployeeContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employee{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlite(connectionString);
        }
        
    }
}