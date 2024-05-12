using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JD.com.Models
{
    [Table("CollegeCourse")]
    public class CollegeCourse
    {
        
        public int CollegeId { get; set; }
        [ForeignKey("CollegeId")]
        public College College { get; set; }

        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Courses Course { get; set; }




    }
}
