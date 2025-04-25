namespace DATA.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ICollection<Std_Subject> Std_Subjects { get; set; }
        public ICollection<Std_Instructor> std_Instructors { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
