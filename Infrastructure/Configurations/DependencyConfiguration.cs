using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    internal class DependencyConfiguration : IEntityTypeConfiguration<Dependency>
    {
        public void Configure(EntityTypeBuilder<Dependency> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasOne(d => d.Task)
                   .WithMany(t => t.Dependencies)
                   .HasForeignKey(d => d.TaskId)
                   .IsRequired();

            builder.HasOne(d => d.DependentTask)
                   .WithMany()
                   .HasForeignKey(d => d.DependentTaskId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
