using System.ComponentModel.DataAnnotations;

namespace MyCv.Models
{
    public class About
    {
        public int AboutId { get; set; }
        [Required]
        public string? AboutDec { get; set; }

    }
}
