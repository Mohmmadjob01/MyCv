using Microsoft.AspNetCore.Mvc;
using MyCv.Data;

namespace MyCv.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {
        private CvDb db;
        public CourseViewComponent(CvDb _db)
        {
            db= _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Courses);
        }
    }
}
