using System.Web.Http;
using FlashcardsApp.Services;

namespace FlashcardsApp.Controllers
{
    public class StatsApiController : ApiController
    {
        private readonly StatsService _service;

        public StatsApiController()
        {
            _service = new StatsService();
        }

        [HttpGet]
        [Route("api/hardest/{userId}")]
        public IHttpActionResult GetHardest(int userId)
        {
            var result = _service.GetHardestFlashcards(userId);
            return Ok(result);
        }
    }
}
