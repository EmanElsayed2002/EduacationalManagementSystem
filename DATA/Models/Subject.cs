namespace DATA.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Period { get; set; }
        public ICollection<Dept_Sub> Dept_Subs { get; set; }
        public ICollection<Ins_Subject> Ins_Subjects { get; set; }
        public ICollection<Std_Subject> Std_Subjects { get; set; }
    }
}
