

using FlashcardsApp.Services;
using System.Web.Http;

namespace FlashcardsApp.Controllers
{
    [RoutePrefix("api/stats")]
    public class StatsApiController : ApiController
    {
        private readonly StatsService _service = new StatsService();

        // GET api/stats/1
        [HttpGet]
        [Route("{userId:int}")]
        public IHttpActionResult GetStats(int userId)
        {
            return Ok(_service.GetStats(userId));
        }
    }
}
