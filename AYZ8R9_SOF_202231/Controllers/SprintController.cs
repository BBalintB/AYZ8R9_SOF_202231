using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Logic.Exceptions;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AYZ8R9_SOF_202231.Controllers
{
    public class SprintController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SCRUMDbContext _db;
        private readonly ISprintLogic sprintLogic;
        private static string ProjectId { get; set; }

        public SprintController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SCRUMDbContext db, ISprintLogic sprintLogic)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            this.sprintLogic = sprintLogic;
        }

        public IActionResult Index()
        {
            return View(_db.Sprints.Where(sprint => sprint.ProjectId == ProjectId));
        }


        [HttpGet]
        public IActionResult OpenSprint(string id)
        {
            ProjectId = id;
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Sprint sprint)
        {
            var currentDate = DateTime.Now;
            var sprintDate = DateTime.Parse(sprint.SprintDueDate);
            if (sprintDate < currentDate)
            {
                throw new DateIsSmalerThanTodaysDate("The sprint due date can't be smaler than todays date!");
            }

            var project = _db.Projects.Where(proj => proj.ProjectId == ProjectId).FirstOrDefault();
            sprint.Project = project;
            sprint.ProjectId = ProjectId;


            if (!ModelState.IsValid)
            {
                return View(sprint);
            }

            sprintLogic.CreateSprint(sprint);

            

            return RedirectToAction("StoriesToSprint","Story",new { id = sprint.SprintId });
        }

        [HttpGet]
        public IActionResult DeleteSprint(string id)
        {
            sprintLogic.DeleteSprint(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Change(string id)
        {
            var sprint = sprintLogic.GetOneSprint(id);
            return View(sprint);
        }

        [HttpPost]
        public async Task<IActionResult> Change(Sprint sprint)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            sprintLogic.ChangeSprint(sprint);
            return RedirectToAction(nameof(Index));
        }


    }
}
