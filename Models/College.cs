using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JD.com.Models
{
    public class College
    {
        [Key]
        public int CollegeId { get; set; }

        public string CollegeName { get; set; }

        public int StateId { get; set; }
        [ForeignKey("StateId")]
        public State state { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public ICollection<Courses> Courses { get; set; }
       
    }
}
