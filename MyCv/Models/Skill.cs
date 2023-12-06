using System.ComponentModel.DataAnnotations;

namespace MyCv.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        [Required]
        public string? SkillName { get; set; }
    }
}
