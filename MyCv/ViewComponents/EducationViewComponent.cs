using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyCv.Data;

namespace MyCv.ViewComponents
{
    public class EducationViewComponent:ViewComponent
    {
        private CvDb db;
        public EducationViewComponent(CvDb _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Educations);
        }
    }
}
