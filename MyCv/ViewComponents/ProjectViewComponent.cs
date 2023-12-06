using Microsoft.AspNetCore.Mvc;
using MyCv.Data;

namespace MyCv.ViewComponents
{
    public class ProjectViewComponent:ViewComponent
    {
        private CvDb db;
        public ProjectViewComponent(CvDb _db)
        {
            db= _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Projects);
        }
    }
}
