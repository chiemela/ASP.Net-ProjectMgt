using FullStack.Data;
using FullStack.Models;
using FullStack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static NuGet.Packaging.PackagingConstants;

namespace FullStack.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDBContext _context;

        public DashboardController(ApplicationDBContext context)
        {
            _context = context;
        }

        // this sets access levels
        // [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin,Lecturer,Student")]
        public IActionResult Index()
        {
            var NewFeedbacks = _context.NewFeedbacks.ToList();
            var sum = NewFeedbacks.Sum(x => x.Grade);

            DashboardViewModel vm = new DashboardViewModel
            {
                FeedbacksVM = NewFeedbacks,
                Sum = sum
            };

            return View(vm);
        }
    }
}
