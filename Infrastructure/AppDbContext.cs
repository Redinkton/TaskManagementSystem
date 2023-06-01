using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Task = Domain.Entities.Task;

namespace Infrastructure
{
    public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }

            public DbSet<Employee> Employees { get; set; }
            public DbSet<Task> Tasks { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Dependency> Dependencies { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Employee>()
                            .HasMany(e => e.Tasks)
                            .WithMany(t => t.Employees);

                modelBuilder.Entity<Task>()
                            .HasOne(t => t.Category)
                            .WithMany(c => c.Tasks)
                            .HasForeignKey(t => t.CategoryId);

                modelBuilder.Entity<Dependency>()
                            .HasOne(d => d.Task) // HasOne указываем, что Dependency имеет одну задачу, а с помощью метода WithMany - что в задаче может быть много Dependencies

                            .WithMany()
                            .HasForeignKey(d => d.TaskId);

                modelBuilder.Entity<Task>()
                            .HasMany(t => t.Dependencies)
                            .WithOne()
                            .HasForeignKey(d => d.DependentTaskId)
                            .OnDelete(DeleteBehavior.Restrict); // Метод OnDelete выдаёт ошибку при удалении
            }
        }
}