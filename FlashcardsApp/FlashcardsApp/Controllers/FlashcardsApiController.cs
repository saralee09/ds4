using FlashcardsApp.Services;
using System.Web.Http;

namespace FlashcardsApp.Controllers
{
    [RoutePrefix("api/flashcards")]
    public class FlashcardsApiController : ApiController
    {
        private FlashcardsService _service = new FlashcardsService();

        // GET api/flashcards/adaptive/1/1
        [HttpGet]
        [Route("adaptive/{languageId:int}/{userId:int}")]
        public IHttpActionResult GetAdaptiveFlashcards(int languageId, int userId)
        {
            var cards = _service.GetAdaptiveFlashcards(languageId, userId);
            return Ok(cards);
        }
    }
}

