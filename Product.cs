using System;
using System.Linq;
using System.Web.Mvc;

namespace FirstRepository.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult DisplayError(string msg = null)
        {
            ViewBag.Message = (msg == null) ? "Something went wrong" : msg;

            return View();
        }
    }
}
