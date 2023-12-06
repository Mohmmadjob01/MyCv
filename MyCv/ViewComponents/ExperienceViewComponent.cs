using Microsoft.AspNetCore.Mvc;
using MyCv.Data;

namespace MyCv.ViewComponents
{
    public class ExperienceViewComponent:ViewComponent
    {
        private CvDb db;
        public ExperienceViewComponent(CvDb _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View (db.Experiences);
        }
    }
}
