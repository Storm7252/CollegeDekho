using System.ComponentModel.DataAnnotations;

namespace JD.com.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        public string StateName { get; set; }
        public ICollection<College> Colleges { get; set; }
       


    }
}
