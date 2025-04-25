namespace DATA.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Image { get; set; }
        public int SupervisorId { get; set; }
        public int DID { get; set; }
        public Department Department { get; set; }
        public Instructor Supervisor { get; set; }
        public ICollection<Std_Instructor> Std_Instructors { get; set; }
        public ICollection<Ins_Subject> Ins_Subjects { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }



    }
}
