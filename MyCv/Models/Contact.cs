using System.ComponentModel.DataAnnotations;

namespace MyCv.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Web { get; set; }
        [Required]
        public string? WebLink { get; set; }
    }
}
