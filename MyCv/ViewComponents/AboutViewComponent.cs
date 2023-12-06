using Microsoft.AspNetCore.Mvc;
using MyCv.Data;
using MyCv.Models;

namespace MyCv.ViewComponents
{
    public class AboutViewComponent :ViewComponent
    {
        private CvDb db;
        public AboutViewComponent(CvDb _db)
        {
           db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Abouts);
        }
    }
}
