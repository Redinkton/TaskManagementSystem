using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Domain.Entities.Task>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Task> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasMaxLength(255).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(1000);
            builder.Property(t => t.DueDate);

            builder.HasOne(t => t.Category)
                .WithMany(c => c.Tasks)
                .HasForeignKey(t => t.CategoryId)
                .IsRequired();

            builder.HasMany(e => e.Dependencies)
                .WithOne(e => e.Task)
                .HasForeignKey(e => e.TaskId)
                .IsRequired();

            builder.Property(t => t.Status)
                .IsRequired()
                .HasConversion(
                v => v.ToString(),
                v => (Status)Enum.Parse(typeof(Status), v));
        }
    }
}
