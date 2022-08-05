using Microsoft.EntityFrameworkCore;
using PracticaAula.Models;

namespace PracticaAula.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var employee = new Employee()
            {
                Id = 1,
                FullName = "Enmanuel Celedonio",
                Position = "Especialista Software Jr",
                DateOfAdmission = System.DateTime.Now
            };
            modelBuilder.Entity<Employee>().HasData(employee);

            base.OnModelCreating(modelBuilder);

            var vacation = new Vacations()
            {
                Id = 1,
                DepartureDate = System.DateTime.Today,
                DateOfAdmission = System.DateTime.Now,
                EmployeeId = 1
            };
            modelBuilder.Entity<Vacations>().HasData(vacation);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Vacations> Vacations { get; set; }
    }
}
