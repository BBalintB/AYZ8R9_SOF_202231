using AYZ8R9_SOF_202231.Hubs;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AYZ8R9_SOF_202231.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiStoryController : ControllerBase
    {
        IUserStoryLogic logic;
        IHubContext<EventHub> hub;

        public ApiStoryController(IUserStoryLogic logic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }

        [HttpGet]
        public IEnumerable<UserStory> GetStories()
        {
            return this.logic.GetAllStories();
        }

        [HttpGet("{id}")]
        public UserStory GetStory(string id)
        {
            return this.logic.GetOneStory(id);
        }

        [HttpPost]
        public void CreateNewStory([FromBody] UserStory value)
        {
            logic.CreateStory(value);

        }

        [HttpPut]
        public void ChangeStory([FromBody] UserStory value)
        {
            logic.ChangeStory(value);

        }

        [HttpDelete("{id}")]
        public void DeleteStory(string id)
        {
            this.logic.DeleteStory(id);
        }
    }
}
