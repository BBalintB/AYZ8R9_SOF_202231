using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AYZ8R9_SOF_202231.Controllers
{
    public class ProjectController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SCRUMDbContext _db;
        IProjectLogic projectLogic;

        public ProjectController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SCRUMDbContext db, IProjectLogic projectLogic)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            this.projectLogic = projectLogic;
        }

        public IActionResult Index()
        {
            
            return View(_db.Projects);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Project project)
        {
            ;
            var thisUser = this.User;
            var user = await _userManager.GetUserAsync(thisUser);
            project.OwnerId = user.Id;
            if (!ModelState.IsValid) { 
                return View(project);
            }
            projectLogic.CreateProject(project);
            return RedirectToAction(nameof(Index));
        }




    }
}
