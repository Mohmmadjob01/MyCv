using Microsoft.AspNetCore.Mvc;
using MyCv.Data;

namespace MyCv.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private CvDb db;
        public ContactViewComponent(CvDb _db)
        {
                db= _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Contacts);
        }

    }
}
