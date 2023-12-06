using System.ComponentModel.DataAnnotations;

namespace MyCv.Models
{
    public class Education
    {

        public int EducationId { get; set; }
        [Required]
        public string? EducationDescription { get; set; }
    }
}
