using FlashcardsApp.Services;
using System.Web.Mvc;

namespace FlashcardsApp.Controllers
{
    public class FlashcardsController : Controller
    {
        private FlashcardsService _service = new FlashcardsService();

        public ActionResult Index(int languageId = 1)
        {
            var cards = _service.GetFlashcardsByLanguage(languageId);
            return View(cards);
        }
    }
}
