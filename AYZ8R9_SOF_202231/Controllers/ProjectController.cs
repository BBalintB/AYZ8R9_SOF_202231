using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Hubs;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Logic.Exceptions;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AYZ8R9_SOF_202231.Controllers
{
    public class ProjectController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SCRUMDbContext _db;
        IProjectLogic projectLogic;
        IProjectAppUserLogic projectAppUserLogic;
        IHubContext<EventHub> hub;

        public ProjectController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SCRUMDbContext db, IProjectLogic projectLogic, IProjectAppUserLogic projectAppUserLogic, IHubContext<EventHub> hub)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            this.projectLogic = projectLogic;
            this.projectAppUserLogic = projectAppUserLogic;
            this.hub = hub;
        }

        [Authorize]
        public IActionResult Index()
        {
            
            return View(_db.Projects);
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
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
            await hub.Clients.All.SendAsync("projectCreated", project);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpGet]
        public async Task<IActionResult> DeleteProject(string id)
        {
            projectLogic.DeleteProject(id);
            await hub.Clients.All.SendAsync("projectDeleted", id);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpGet]
        public IActionResult Change(string id)
        {
            var project = projectLogic.GetOneProject(id);
            
            return View(project);
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
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
            await hub.Clients.All.SendAsync("projectModified", project);
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
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
            await hub.Clients.All.SendAsync("projectModified", project);
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> SignDown(string id)
        {
            var project = projectLogic.GetOneProject(id);
            var user = await _userManager.GetUserAsync(this.User);

            var allPA = projectAppUserLogic.GetAllPA().Where(x => x.ProjectId == project.ProjectId && x.AppUserId == user.Id).FirstOrDefault();
            if (allPA != null)
            {
                projectAppUserLogic.DeletePA(allPA.ConnectionId);
                await hub.Clients.All.SendAsync("projectModified", project);
            }
            
            return RedirectToAction(nameof(Index));
        }



        
    }
}
