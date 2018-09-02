using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DocumotoAPI.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class TagController : Controller
    {
        [HttpGet]
        public IEnumerable<Tag> Get()
        {
            return PagesDAL.Tags;
        }
        [HttpGet("{id}")]
        public Tag Get(int id)
        {
            return PagesDAL.Tags.SingleOrDefault(t=>t.Id == id);
        }
    }
}
