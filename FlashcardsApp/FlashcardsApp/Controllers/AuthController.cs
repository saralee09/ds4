using System.Web.Mvc;

namespace FlashcardsApp.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username)
        {
            // Login fake
            Session["UserId"] = 1;
            return RedirectToAction("SelectLanguage", "Study");
        }
    }
}
