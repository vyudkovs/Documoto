using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DocumotoAPI.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class TranslationController : Controller
    {
        [HttpGet]
        public IEnumerable<Translation> Get()
        {
            return PagesDAL.Translations;
        }
        [HttpGet("{id}")]
        public Translation Get(int id)
        {
            return PagesDAL.Translations.SingleOrDefault(t=>t.Id == id);
        }
    }
}
