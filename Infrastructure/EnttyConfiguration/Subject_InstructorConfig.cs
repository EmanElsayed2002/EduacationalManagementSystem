using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EnttyConfiguration
{
    public class Subject_InstructorConfig : IEntityTypeConfiguration<Ins_Subject>
    {
        public void Configure(EntityTypeBuilder<Ins_Subject> builder)
        {
            builder.HasOne(x => x.Instructor).WithMany(x => x.Ins_Subjects).HasForeignKey(x => x.InstructorId);
            builder.HasOne(x => x.Subject).WithMany(x => x.Ins_Subjects).HasForeignKey(x => x.SubjectID);
            builder.HasKey(x => new { x.InstructorId, x.SubjectID });
        }
    }
}
