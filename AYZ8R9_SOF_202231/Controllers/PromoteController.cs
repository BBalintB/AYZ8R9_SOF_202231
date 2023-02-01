using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AYZ8R9_SOF_202231.Controllers
{
    public class PromoteController : Controller
    {
        private readonly SCRUMDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public PromoteController(SCRUMDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

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

    }
}
