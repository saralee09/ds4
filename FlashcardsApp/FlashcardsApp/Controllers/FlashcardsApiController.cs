using FlashcardsApp.Services;
using System.Web.Http;

namespace FlashcardsApp.Controllers
{
    [RoutePrefix("api/flashcards")]
    public class FlashcardsApiController : ApiController
    {
        private FlashcardsService _service = new FlashcardsService();

        // GET api/flashcards/1?userId=1
        [HttpGet]
        [Route("{languageId:int}")]
        public IHttpActionResult Get(int languageId, int userId)
        {
            var cards = _service.GetAdaptiveFlashcards(languageId, userId);
            return Ok(cards);
        }
    }
}
