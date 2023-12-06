using Microsoft.AspNetCore.Mvc;
using MyCv.Data;

namespace MyCv.ViewComponents
{
    public class SkillViewComponent:ViewComponent
    {
        private CvDb db;
        public SkillViewComponent(CvDb _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Skills);
        }
    }
}
