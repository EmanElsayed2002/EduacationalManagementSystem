using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EnttyConfiguration
{
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Department).WithMany(x => x.Instructors).HasForeignKey(x => x.DID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Supervisor).WithMany(x => x.Instructors).HasForeignKey(x => x.SupervisorId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
