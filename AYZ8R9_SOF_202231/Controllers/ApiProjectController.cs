using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Hubs;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AYZ8R9_SOF_202231.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiProjectController : ControllerBase
    {
        IProjectLogic logic;
        IHubContext<EventHub> hub;

        public ApiProjectController(IProjectLogic logic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }

        [HttpGet]
        public IEnumerable<Project> GetProjects(){
            return this.logic.GetAllProjects();
        }

        [HttpGet("{id}")]
        public Project GetProjects(string id)
        {
            return this.logic.GetOneProject(id);
        }

        [HttpPost]
        public void CreateNewProject([FromBody] Project value)
        {
            logic.CreateProject(value);

        }

        [HttpPut]
        public void ChangeProject([FromBody] Project value)
        {
            logic.ChangeProject(value);

        }

        [HttpDelete("{id}")]
        public void DeleteProject(string id)
        {
            this.logic.DeleteProject(id);
        }
    }
}
