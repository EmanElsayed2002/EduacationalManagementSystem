using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EnttyConfiguration
{
    public class StudentSubjectConfig : IEntityTypeConfiguration<Std_Subject>
    {
        public void Configure(EntityTypeBuilder<Std_Subject> builder)
        {
            builder.HasOne(x => x.Student).WithMany(x => x.Std_Subjects).HasForeignKey(x => x.StudentId);
            builder.HasOne(x => x.Subject).WithMany(x => x.Std_Subjects).HasForeignKey(x => x.SubjectID);
            builder.HasKey(x => new { x.StudentId, x.SubjectID });
        }
    }
}
