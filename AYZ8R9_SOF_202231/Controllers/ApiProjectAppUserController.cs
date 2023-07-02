using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Mvc;

namespace AYZ8R9_SOF_202231.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiProjectAppUserController : ControllerBase
    {
        IProjectAppUserLogic logic;

        public ApiProjectAppUserController(IProjectAppUserLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<ProjectAppUser> GetPA()
        {
            return this.logic.GetAllPA();
        }

        [HttpGet("{id}")]
        public ProjectAppUser GetOnePa(string id)
        {
            return this.logic.GetOnePA(id);
        }

        [HttpPost]
        public void CreateNewPA([FromBody] ProjectAppUser value)
        {
            logic.CreatePA(value);

        }

        [HttpDelete("{id}")]
        public void DeletePa(string id)
        {
            this.logic.DeletePA(id);
        }
    }

}
