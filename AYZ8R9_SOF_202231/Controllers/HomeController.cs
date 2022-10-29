using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace AYZ8R9_SOF_202231.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SCRUMDbContext _db;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SCRUMDbContext db)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        public async Task<IActionResult> PromoteMaster() 
        {
            var actual = this.User;
            var user = await _userManager.GetUserAsync(actual);
            await _userManager.AddToRoleAsync(user, "Scrum_Master");
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DemoteMaster(string userId) 
        {
            var item = _db.AppUsers.FirstOrDefault(u => u.Id == userId);
            if (item != null)
            {
                await _userManager.RemoveFromRoleAsync(item, "Scrum_Master");
            }

            return RedirectToAction(nameof(Index));

        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        public IActionResult Promote() 
        {


            return View(_db.Users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}