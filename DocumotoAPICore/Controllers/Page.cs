using System;
using System.Collections.Generic;
namespace DocumotoAPI.Controllers
{
    public class Page
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Part> Parts { get; set; }
        public List<Translation> Translations { get; set; }
        public List<Tag> Tags { get; set; }
    }
}