using System.Threading.Tasks;
using System.Web.Mvc;
using Laboratorio192.Services;

namespace Laboratorio192.Controllers
{
    public class ValuesController : Controller
    {
        private const string ApiBase = "https://localhost:44360/"; // cambia el puerto

        public async Task<ActionResult> Index()
        {
            var client = new ApiClient(ApiBase);
            var json = await client.GetAsync("api/values");
            ViewBag.RawJson = json;
            return View();
        }
    }
}