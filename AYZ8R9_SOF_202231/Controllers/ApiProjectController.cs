using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Mvc;

namespace AYZ8R9_SOF_202231.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiProjectController : ControllerBase
    {
        IProjectLogic logic;

        public ApiProjectController(IProjectLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<Project> GetProjects(){
            return this.logic.GetAllProjects();
        }
    }
}
