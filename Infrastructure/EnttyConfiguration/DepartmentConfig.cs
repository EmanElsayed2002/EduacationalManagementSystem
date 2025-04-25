using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EnttyConfiguration
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(d => d.Instructor)
               .WithOne()
               .HasForeignKey<Department>(d => d.InsManager)
               .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(x => x.Instructors).WithOne(x => x.Department).HasForeignKey(x => x.DID).OnDelete(DeleteBehavior.ClientSetNull);
            //builder.HasOne(x => x.DepartmentManger).WithOne().HasForeignKey<Instructor>(x => x.DepartmentId).OnDelete(DeleteBehavior.ClientSetNull);
            //builder.HasOne(x => x.Supervisor).WithMany(x => x.Instructors).HasForeignKey(x => x.SupervisorId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
