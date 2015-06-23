using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOverview.Models
{
    public class Project
    {
        public Project()
        {
            Tasks = new List<ProjectTask>();
        }

        public string Name { get; set; }
        public string Details { get; set; }

        public List<ProjectTask> Tasks { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, # of Tasks: {1}", 
                Name, Tasks.Count);
        }
    }
}
