using Artikli.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Artikli.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public ActionResult Index()
        {
            List<Artikal> artikli = _context.Artikli.ToList();
            return View(artikli);
        }

        [HttpPost]
        public ActionResult SpremiArtikal(Artikal artikal)
        {
            if (ModelState.IsValid)
            {
                _context.Artikli.Add(artikal);
                _context.SaveChanges();
                return Json(new { success = true });
            }

            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(new { success = false, errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });
        }
    }
}