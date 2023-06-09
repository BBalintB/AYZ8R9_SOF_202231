using AYZ8R9_SOF_202231.Hubs;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AYZ8R9_SOF_202231.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiSprintController : ControllerBase
    {
        ISprintLogic logic;
        IHubContext<EventHub> hub;

        public ApiSprintController(ISprintLogic logic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }

        [HttpGet]
        public IEnumerable<Sprint> GetSprints()
        {
            return this.logic.GetAllSprints();
        }

        [HttpGet("{id}")]
        public Sprint GetSprint(string id)
        {
            return this.logic.GetOneSprint(id);
        }

        [HttpPost]
        public void CreateNewSprint([FromBody] Sprint value)
        {
            logic.CreateSprint(value);

        }

        [HttpPut]
        public void ChangeSprint([FromBody] Sprint value)
        {
            logic.ChangeSprint(value);

        }

        [HttpDelete("{id}")]
        public void DeleteSprint(string id)
        {
            this.logic.DeleteSprint(id);
        }
    }
}
