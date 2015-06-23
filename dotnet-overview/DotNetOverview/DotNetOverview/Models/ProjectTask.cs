using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOverview.Models
{
    public class ProjectTask
    {
        public ProjectTask(string name, decimal hours)
        {
            Name = name;
            Hours = hours;
        }

        public string Name { get; set; }
        public decimal Hours { get; set; }
        public bool Completed { get; set; }
    }
}
