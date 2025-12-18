using System.Web.Mvc;

namespace FlashcardsApp.Controllers
{
    public class StudyController : Controller
    {
        public ActionResult SelectLanguage()
        {
            return View();
        }

        public ActionResult Flashcards(int languageId)
        {
            ViewBag.LanguageId = languageId;
            return View();
        }

        public ActionResult Result(int score)
        {
            ViewBag.Score = score;
            return View();
        }

        public ActionResult Stats()
        {
            return View();
        }
    }
}
