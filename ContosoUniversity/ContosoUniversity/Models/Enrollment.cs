using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; } // defaults to pk
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No Grade")]
        public Grade? Grade { get; set; } // ? can be nullable

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
