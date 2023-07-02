using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using NUnit.Framework;
using System.IdentityModel.Tokens.Jwt;

namespace AYZ8R9_SOF_202231.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserMethodsController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        IAppUserLogic logic;

        public UserMethodsController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IAppUserLogic logic)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            this.logic = logic;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRole(string id)
        {
            var user = logic.GetOneUser(id);
            if (user != null)
            {
                var role = await _userManager.GetRolesAsync(user);
                return Ok(new
                {
                    role = role.FirstOrDefault()
                });
            }
            return Unauthorized();

        }

        [HttpPut("{id}")]
        public async Task Promote(string id)
        {
            var user = logic.GetOneUser(id);
            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, "Scrum_Master");
                await _userManager.RemoveFromRoleAsync(user, "Developer");
            }

        }

        [HttpDelete("{id}")]
        public async Task Demote(string id)
        {
            var user = logic.GetOneUser(id);
            if (user != null)
            {
                await _userManager.RemoveFromRoleAsync(user, "Scrum_Master");
                await _userManager.AddToRoleAsync(user, "Developer");
            }
        }
    }
}
