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
        IProjectAppUserLogic projectAppUserLogic;

        public ProjectController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SCRUMDbContext db, IProjectLogic projectLogic, IProjectAppUserLogic projectAppUserLogic)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            this.projectLogic = projectLogic;
            this.projectAppUserLogic = projectAppUserLogic;
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
            var thisUser = this.User;
            var user = await _userManager.GetUserAsync(thisUser);
            project.Owner = user;

            if (!ModelState.IsValid)
            {
                return View(project);
            }

            projectLogic.CreateProject(project);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult DeleteProject(string id)
        {
            projectLogic.DeleteProject(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Change(string id)
        {
            var project = projectLogic.GetOneProject(id);
            return View(project);
        }

        [HttpPost]
        public async Task<IActionResult> Change(Project project)
        {
            var thisUser = this.User;
            var user = await _userManager.GetUserAsync(thisUser);
            project.Owner = user;

            if (!ModelState.IsValid)
            {
                return View();
            }

            projectLogic.ChangeProject(project);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> SignUp(string id)
        {
            var project = projectLogic.GetOneProject(id);
            var user =  await _userManager.GetUserAsync(this.User);

            

            ProjectAppUser pa = new ProjectAppUser()
            {
                ProjectId = project.ProjectId,
                Project = project,
                User = user,
                AppUserId = user.Id
            };

            projectAppUserLogic.CreatePA(pa);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> SignDown(string id)
        {
            var project = projectLogic.GetOneProject(id);
            var user = await _userManager.GetUserAsync(this.User);

            projectAppUserLogic.DeletePA(project.ProjectId,user.Id);

            return RedirectToAction(nameof(Index));
        }



        
    }
}
