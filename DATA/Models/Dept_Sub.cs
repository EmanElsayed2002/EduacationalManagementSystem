namespace DATA.Models
{
    public class Dept_Sub
    {
        public int DepartmentId { get; set; }
        public int SubjectId { get; set; }
        public Department Department { get; set; }
        public Subject Subject { get; set; }
    }
}
