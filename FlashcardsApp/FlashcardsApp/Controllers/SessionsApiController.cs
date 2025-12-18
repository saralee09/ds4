using FlashcardsApp.Models.DTO;
using FlashcardsApp.Services;
using System.Web.Http;

namespace FlashcardsApp.Controllers
{
    [RoutePrefix("api/sessions")]
    public class SessionsApiController : ApiController
    {
        private SessionService _service = new SessionService();

        // POST api/sessions
        [HttpPost]
        [Route("")]
        public IHttpActionResult SaveSession(SessionRequest request)
        {
            if (request == null)
                return BadRequest();

            int sessionId = _service.SaveSession(request.UserId, request.Score);
            return Ok(new { SessionId = sessionId });
        }
    }
}
