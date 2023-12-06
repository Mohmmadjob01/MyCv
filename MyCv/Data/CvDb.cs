using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCv.Models;

namespace MyCv.Data
{
    public class CvDb : IdentityDbContext
    {
        public CvDb(DbContextOptions<CvDb>options) :base(options) 
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<HomeCv> Homes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skill> Skills { get; set; }

    }
}
