using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JD.com.Models
{
    public class Exams
    {
        [Key]
        public int ExamId { get; set; }

        public string ExamName { get; set; }
        public int CourseGroupId { get; set; }
        [ForeignKey("CourseGroupId")]
        public CourseGroup CourseGroup { get; set; }
    }
}
