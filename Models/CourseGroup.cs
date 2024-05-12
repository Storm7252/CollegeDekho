using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JD.com.Models
{
    public class CourseGroup
    {
        [Key]
        public int CourseGroupId { get; set; }
        public string CourseGroupName { get; set; }

        //------------course
        public ICollection<Courses> Courses { get; set; }

    }
}
