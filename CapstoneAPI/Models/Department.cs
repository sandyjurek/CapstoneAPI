using System;
using System.Collections.Generic;

#nullable disable

namespace CapstoneAPI.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Hire { get; set; }
        public string Location { get; set; }
    }
}
