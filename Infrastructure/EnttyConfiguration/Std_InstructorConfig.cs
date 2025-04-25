using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EnttyConfiguration
{
    public class Std_InstructorConfig : IEntityTypeConfiguration<Std_Instructor>
    {
        public void Configure(EntityTypeBuilder<Std_Instructor> builder)
        {
            builder.HasOne(x => x.Instructor).WithMany(x => x.Std_Instructors).HasForeignKey(x => x.InstructorId);
            builder.HasOne(x => x.Student).WithMany(x => x.std_Instructors).HasForeignKey(x => x.StudentId);
            builder.HasKey(x => new { x.StudentId, x.InstructorId });
        }
    }
}
