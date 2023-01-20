using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
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
        private readonly IAppUserLogic appUserLogic;
        private readonly IProjectLogic projectLogic;
        private readonly ISprintLogic sprintLogic;
        private readonly IUserStoryLogic storyLogic;
        private readonly IProjectAppUserLogic paLogic;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SCRUMDbContext db, IAppUserLogic appUserLogic, IProjectLogic projectLogic, ISprintLogic sprintLogic, IUserStoryLogic storyLogic, IProjectAppUserLogic paLogic)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            this.appUserLogic = appUserLogic;
            this.projectLogic = projectLogic;
            this.sprintLogic = sprintLogic;
            this.storyLogic = storyLogic;
            this.paLogic = paLogic;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Privacy()
        {
            var principal = this.User;
            var user = await _userManager.GetUserAsync(principal);
            return View();
        }

        public async Task<IActionResult> GetImage(string userid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.Id == userid);
            if (user != null) 
            {
                return new FileContentResult(user.PhotoData, user.PhotoContentType);
            }
            else
                return View();
        }



        //roles control
        public IActionResult Promote()
        {

            return View(_db.AppUsers.Where(auser => auser.EmailConfirmed == true));
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        public async Task<IActionResult> PromoteMaster(string userId) 
        {
            var toPromote = _db.AppUsers.FirstOrDefault(u => u.Id == userId);
            if (toPromote != null /* and isnt in role? (possible problem) */) 
            {
                await _userManager.AddToRoleAsync(toPromote, "Scrum_Master");
                await _userManager.RemoveFromRoleAsync(toPromote, "Developer");

            }
            return RedirectToAction(nameof(Promote));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DemoteMaster(string userId) 
        {
            var toPromote = _db.AppUsers.FirstOrDefault(u => u.Id == userId);
            if (toPromote != null)
            {
                await _userManager.RemoveFromRoleAsync(toPromote, "Scrum_Master");
                await _userManager.AddToRoleAsync(toPromote, "Developer");
            }

            return RedirectToAction(nameof(Promote));

        }
        public IActionResult EditProfilePics()
        {
            return View();
        }

        public async Task<IActionResult> EditProfilePicsAction(string userId)
        {
            var toedit = _db.AppUsers.FirstOrDefault(u => u.Id == userId);
            


            if (Input.File != null)
            {
                user.PhotoContentType = Input.File.ContentType;

                byte[] data = new byte[(int)Input.File.Length];
                using (var stream = Input.File.OpenReadStream())
                {
                    stream.Read(data, 0, data.Length);
                }
                user.PhotoData = data;
            }
            else
            {
                user.PhotoContentType = "image/jpeg";
                user.PhotoData = imgToByteArray(Image.FromFile("DefaultProfile.jpg"));
            }

            return RedirectToAction(nameof(EditProfilePics));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}