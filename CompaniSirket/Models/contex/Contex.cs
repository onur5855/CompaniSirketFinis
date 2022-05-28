using CompaniSirket.Models.Entity.Entitiler;
using CompaniSirket.Models.EntityTypeConfiguration.Concreate;
using Microsoft.EntityFrameworkCore;

namespace CompaniSirket.Models.contex
{
    public class Contex:DbContext
    {
        public Contex(DbContextOptions<Contex> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyEntityTypeConfiguration() );
            modelBuilder.ApplyConfiguration(new EmployeeEntityTypeConfiguration() );
            base.OnModelCreating(modelBuilder);
        }

    }
}
