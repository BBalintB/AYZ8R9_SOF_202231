using AYZ8R9_SOF_202231.Hubs;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AYZ8R9_SOF_202231.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiUserController : ControllerBase
    {
        IAppUserLogic logic;
        IHubContext<EventHub> hub;

        public ApiUserController(IAppUserLogic logic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }

        [HttpGet]
        public IEnumerable<AppUser> GetUsers()
        {
            return this.logic.GetAllUsers();
        }

        [HttpGet("{id}")]
        public AppUser GetUser(string id)
        {
            return this.logic.GetOneUser(id);
        }

        [HttpPost]
        public void CreateNewUser([FromBody] AppUser value)
        {
            logic.CreateUser(value);

        }

        [HttpPut]
        public void ChangeUser([FromBody] AppUser value)
        {
            logic.ChangeUser(value);

        }

        [HttpDelete("{id}")]
        public void DeleteUser(string id)
        {
            this.logic.DeleteUser(id);
        }
    }
}
