using Microsoft.AspNetCore.Mvc;

namespace FullStack.Controllers
{
    public class DashboardController : Controller
    {
        // this sets access levels
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin,Lecturer,Student")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
