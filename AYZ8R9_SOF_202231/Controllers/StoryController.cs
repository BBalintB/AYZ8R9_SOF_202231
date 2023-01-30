using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace AYZ8R9_SOF_202231.Controllers
{
    public class StoryController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SCRUMDbContext _db;
        private readonly IUserStoryLogic storyLogic;

        public StoryController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SCRUMDbContext db, IUserStoryLogic storyLogic)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            this.storyLogic = storyLogic;
        }
        

        private static string SprintId { get; set; }

        [Authorize]
        [HttpGet]
        public IActionResult OpenStory(string id)
        {
            SprintId = id;
            return RedirectToAction(nameof(SprintViewIndex));
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(_db.UserStories.Where(story => story.Sprint == null));
        }
        [Authorize]
        [HttpGet]
        public IActionResult StoriesToSprint(string? id)
        {
            StoryPass storyPass = new StoryPass()
            {
                Sprint = _db.Sprints.FirstOrDefault(x => x.SprintId == (id == null ? SprintId : id)),
                Stories = _db.UserStories.Where(story => story.Sprint == null)
            };

            return View(storyPass);
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        public IActionResult AddToSprint(string sprintid, string storyid)
        { 
            storyLogic.AddToSprint(sprintid, storyid);
            return RedirectToAction(nameof(StoriesToSprint), new {id = sprintid});
        }
        [Authorize(Roles = "Admin,Scrum_Master")]
        public IActionResult RemoveFromSprint(string id)
        {
            storyLogic.RemoveFromSprint(id);
            return RedirectToAction(nameof(SprintViewIndex));
        }

        [Authorize]
        public IActionResult SprintViewIndex()
        {
            return View(_db.UserStories.Where(stories => stories.SprintId == SprintId));
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpGet]
        public IActionResult CreateInSprint()
        {

            return View();
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpPost]
        public IActionResult CreateInSprint(UserStory story)
        {
            var sprint = _db.Sprints.Where(sp => sp.SprintId == SprintId).FirstOrDefault();
            story.SprintId = SprintId;
            story.Sprint = sprint;

            if (!ModelState.IsValid)
            {
                return View();
            }

            storyLogic.CreateStory(story);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpPost]
        public IActionResult Create(UserStory story)
        {

            if (!ModelState.IsValid)
            {
                return View(story);
            }

            storyLogic.CreateStory(story);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpGet]
        public IActionResult DeleteStory(string id)
        {
            storyLogic.DeleteStory(id);
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        [HttpPost]
        public IActionResult Status(UserStory newStatus)
        {
            newStatus.SprintId = SprintId;
            storyLogic.ChangeStory(newStatus);
            return RedirectToAction(nameof(SprintViewIndex));
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpGet]
        public IActionResult Change(string id)
        {
            var story = storyLogic.GetOneStory(id);
            return View(story);
        }

        [Authorize(Roles = "Admin,Scrum_Master")]
        [HttpPost]
        public IActionResult Change(UserStory story)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            storyLogic.ChangeStory(story);
            return RedirectToAction(nameof(Index));
        }
    }
}
