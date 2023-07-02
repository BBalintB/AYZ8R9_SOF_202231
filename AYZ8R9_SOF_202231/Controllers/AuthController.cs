using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Model.Helpers;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using AYZ8R9_SOF_202231.Logic;
using static System.Net.WebRequestMethods;
using System.Net;

namespace AYZ8R9_SOF_202231.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly HttpClient client;
        private readonly IAppUserLogic userLogic;

        public AuthController(UserManager<AppUser> userManager, HttpClient client, IAppUserLogic userLogic)
        {
            this.userManager = userManager;
            this.client = client;
            this.userLogic = userLogic;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var claim = new List<Claim> { 
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.NameId, user.UserName) 
                };
                foreach (var role in await userManager.GetRolesAsync(user))
                {
                    claim.Add(new Claim(ClaimTypes.Role, role));
                }
                var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("nagyonhosszutitkoskodhelye"));
                var token = new JwtSecurityToken(
                issuer: "http://www.security.org", audience: "http://www.security.org",
                claims: claim, expires: DateTime.Now.AddMinutes(60),
                signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
                );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }

        [HttpPost("LoginWithFacebook")]
        public async Task<IActionResult> LoginWithFacebook([FromBody] string credential) {
            HttpResponseMessage resp = await client.GetAsync("https://graph.facebook.com/debug_token?input_token=" + credential + "&access_token=2804343803062000|6502c46acfba3fa1a7b905b22cc3c75d");
            var stringThing = await resp.Content.ReadAsStringAsync();
            var userOBJ = JsonConvert.DeserializeObject<FBUser>(stringThing);

            if (userOBJ.Data.IsValid == false)
            {
                return Unauthorized();
            }

            HttpResponseMessage meResp = await client.GetAsync("https://graph.facebook.com/me?fields=first_name,last_name,email,id&access_token="+credential);
            var userContent = await meResp.Content.ReadAsStringAsync();
            var userContentObj = JsonConvert.DeserializeObject<FBUserInfo>(userContent);

            if (userContentObj == null)
            {
                return Unauthorized();
            }

            var user = await userManager.FindByNameAsync(userContentObj.Email);

            if (user == null)
            {
                var wc = new WebClient();
                var registerUser = new AppUser
                {
                    Email = userContentObj.Email,
                    UserName = userContentObj.Email,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = userContentObj.FirstName,
                    LastName = userContentObj.LastName,
                    PhotoData = wc.DownloadData($"https://graph.facebook.com/{userContentObj.Id}/picture?type=square"),
                    PhotoContentType = wc.ResponseHeaders["Content-Type"]
                };
                ;
                var test = await userManager.CreateAsync(registerUser, Guid.NewGuid().ToString());
                await userManager.AddToRoleAsync(registerUser, "Developer");


                user = registerUser;
            }

            var claim = new List<Claim> {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.NameId, user.UserName)
                };
            foreach (var role in await userManager.GetRolesAsync(user))
            {
                claim.Add(new Claim(ClaimTypes.Role, role));
            }
            var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("nagyonhosszutitkoskodhelye"));
            var token = new JwtSecurityToken(
            issuer: "http://www.security.org", audience: "http://www.security.org",
            claims: claim, expires: DateTime.Now.AddMinutes(60),
            signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
            );
            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expiration = token.ValidTo
            });

        }

        [HttpPut]
        public async Task<IActionResult> InsertUser([FromBody] RegisterViewModel model)
        {
            var user = new AppUser
            {
                Email = model.Email,
                UserName = model.UserName,
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhotoContentType = model.PhotoContentType,
                PhotoData = model.PhotoData
            };
            await userManager.CreateAsync(user, model.Password);
            await userManager.AddToRoleAsync(user, "Developer");
            return Ok();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUserInfos()
        {
            var test = HttpContext.User;
            var user = userManager.Users.FirstOrDefault(t => t.UserName == this.User.Identity.Name);
            if (user != null)
            {
                return Ok(new
                {
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    PhotoData = user.PhotoData,
                    PhotoContentType = user.PhotoContentType,
                    Roles = await userManager.GetRolesAsync(user)
                });
            }
            return Unauthorized();
            
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteMyself()
        {
            var user = userManager.Users.FirstOrDefault(t => t.UserName == this.User.Identity.Name);
            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateProfile([FromBody] RegisterViewModel model)
        {
            var user = userManager.Users.FirstOrDefault(t => t.UserName == this.User.Identity.Name);
            if (user != null)
            {
                user.Email = model.Email;
                user.UserName = model.UserName;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.PhotoContentType = model.PhotoContentType;
                user.PhotoData = model.PhotoData;
                await userManager.UpdateAsync(user);
                return Ok();
            }
            return BadRequest();
            
        }
    }
}
