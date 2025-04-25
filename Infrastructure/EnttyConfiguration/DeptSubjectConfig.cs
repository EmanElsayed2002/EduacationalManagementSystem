using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EnttyConfiguration
{
    public class DeptSubjectConfig : IEntityTypeConfiguration<Dept_Sub>
    {
        public void Configure(EntityTypeBuilder<Dept_Sub> builder)
        {
            builder.HasOne(x => x.Department).WithMany(x => x.Dept_Subs).HasForeignKey(x => x.DepartmentId);
            builder.HasOne(x => x.Subject).WithMany(x => x.Dept_Subs).HasForeignKey(x => x.SubjectId);
            builder.HasKey(x => new { x.DepartmentId, x.SubjectId });

        }
    }
}
