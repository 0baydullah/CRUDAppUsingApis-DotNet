using Microsoft.AspNetCore.Mvc;

namespace CRUDAppUsingApis.Controllers
{
    public class StudentController : Controller
    {
        private string url = "https://localhost:7134/api/Students/";
        private HttpClient client = new HttpClient();

        [HttpGet]
        public IActionResult Index()
        {
            Lis
            return View();
        }
    }
}
