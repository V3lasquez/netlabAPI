using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace netlabAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public List<string> Get()
        {
            List<string> strings = new List<string>();
            strings.Add("Manzana");
            return strings;
        }
    }
}
