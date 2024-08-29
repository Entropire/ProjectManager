using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Objects
{
    public class Project
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public string? location { get; set; }

        public Project(string name, string description, string location)
        {
            this.name = name;
            this.description = description;
            this.location = location;
        }
    }
}
