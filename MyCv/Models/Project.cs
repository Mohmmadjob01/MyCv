using System.ComponentModel.DataAnnotations;

namespace MyCv.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Required]
        public string? ProjectTitle { get; set; }
        [Required]
        public string? ProjectDescription { get; set;}
        [Required]
        public string? ProjectLink { get; set; }

    }
}
