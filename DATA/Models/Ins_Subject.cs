namespace DATA.Models
{
    public class Ins_Subject
    {
        public int InstructorId { get; set; }
        public int SubjectID { get; set; }
        public Instructor Instructor { get; set; }
        public Subject Subject { get; set; }
    }
}
