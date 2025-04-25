namespace DATA.Models
{
    public class Std_Instructor
    {
        public int StudentId { get; set; }
        public int InstructorId { get; set; }
        public Student Student { get; set; }
        public Instructor Instructor { get; set; }
    }
}
