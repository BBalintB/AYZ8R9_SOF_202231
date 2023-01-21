﻿using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Xml.Linq;

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

        [BindProperty]
        public UglyInputModel Input { get; set; }

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
        public IActionResult EditProfilePic()
        {
            return View();
        }

        public async Task<IActionResult> EditProfilePicAction()
        {
            var toUpdate = _db.AppUsers.FirstOrDefault(u => u.Id == Input.CurrentUser);
            if (toUpdate != null && Input.File != null)
            {
                toUpdate.PhotoContentType = Input.File.ContentType;

                byte[] data = new byte[(int)Input.File.Length];
                using (var stream = Input.File.OpenReadStream())
                {
                    stream.Read(data, 0, data.Length);
                }
                toUpdate.PhotoData = data;
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(EditProfilePic));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }
    }
    public class UglyInputModel 
    {
        public string CurrentUser { get; set; }

        [DataType(DataType.ImageUrl)]
        public IFormFile File { get; set; }
    }
}