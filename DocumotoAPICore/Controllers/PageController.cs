using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using System;

namespace DocumotoAPI.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class PageController : Controller
    {
        [HttpGet]
        public IEnumerable<Page> Get()
        {
            return PagesDAL.Pages;
        }

        [HttpGet("{name}")]
        public IEnumerable<Page> Get(string name)
        {
            return PagesDAL.Pages.Where(page => page.Name.Contains(name));
        }
    }
}
