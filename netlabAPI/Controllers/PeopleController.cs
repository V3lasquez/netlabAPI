using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netlabAPI.Models;
namespace netlabAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet(Name = "Listar")]
        public List<People> Listar()
        {
            List<People> personas = new List<People>();
            for (int i = 0; i < 100; i++)
            {
                personas.Add(new People { Name = "Noe" });
            }
            return personas;
        }

        [HttpPost(Name = "Listar2")]
        public List<People> Listar2([FromBody] People people)
        {
            List<People> personas = new List<People>();
            for (int i = 0; i < 100; i++)
            {
                personas.Add(new People { Name = "Noe" });
            }
            return personas;
        }
    }
}
