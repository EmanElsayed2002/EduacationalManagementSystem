namespace DATA.Models
{
    public class Std_Subject
    {
        public int StudentId { get; set; }
        public int SubjectID { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
