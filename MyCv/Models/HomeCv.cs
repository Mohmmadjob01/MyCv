using System.ComponentModel.DataAnnotations;

namespace MyCv.Models
{
    public class HomeCv
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Dept { get; set; }
        [Required]
        public string? Fb { get; set; }
        [Required]
        public string? GitHub { get; set; }
        [Required]
        public string? LI { get; set; }
        [Required]
        public string? Cvimg { get; set; }
    }
}
