namespace DATA.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int InsManager { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public ICollection<Dept_Sub> Dept_Subs { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }


    }
}
