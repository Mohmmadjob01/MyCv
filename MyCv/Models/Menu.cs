using System.ComponentModel.DataAnnotations;

namespace MyCv.Models
{
    public class Menu
    {
        public Guid MenuId { get; set; }
        [Required(ErrorMessage = "Enter Title")]
        [Display(Name = "Menu Title")]
        public string? MenuTitle { get; set;}
        public int ParentId { get; set; }
    }
}
