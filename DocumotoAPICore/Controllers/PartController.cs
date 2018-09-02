using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DocumotoAPI.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class PartController : Controller
    {
        [HttpGet]
        public IEnumerable<Part> Get()
        {
            return PagesDAL.Parts;
        }
        [HttpGet("{id}")]
        public Part Get(int id)
        {
            return PagesDAL.Parts.SingleOrDefault(part=> part.Id == id);
        }
    }
}
