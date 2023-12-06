using System.ComponentModel.DataAnnotations;

namespace MyCv.Models
{
    public class Course
    {
        
        public Guid CourseId { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public string? CourseName { get; set;}
        [Required]
        [Display(Name = "Course Description")]
        public string? CourseDescription { get;set; }

    }
}
