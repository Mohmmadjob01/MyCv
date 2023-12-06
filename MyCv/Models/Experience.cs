using System.ComponentModel.DataAnnotations;

namespace MyCv.Models
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        [Required]
        public string? ExpName { get; set; }
        [Required]
        public string? ExpDescription { get; set;}
    }
}
