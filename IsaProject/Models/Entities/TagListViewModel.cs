using IsaProject.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace IsaProject.Models
{
    public class TagListViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<SelectListItem> Tags { get; set; }
    }
}
