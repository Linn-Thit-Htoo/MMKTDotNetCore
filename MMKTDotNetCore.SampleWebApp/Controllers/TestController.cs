using Microsoft.AspNetCore.Mvc;

namespace MMKTDotNetCore.SampleWebApp.Controllers
{
    public class TestController : Controller
    {
        [ActionName("TestIndex")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
