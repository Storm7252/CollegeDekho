using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JD.com.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }

        public string CourseName { get; set; }
        public int CollegeId { get; set; }
        [ForeignKey("CollegeId")]
        public ICollection<College> Colleges { get; set; }

        public int CourseGroupId { get; set; }
        [ForeignKey("CourseGroupId")]
        public CourseGroup CourseGroup { get; set; }
       

        


    }
}
