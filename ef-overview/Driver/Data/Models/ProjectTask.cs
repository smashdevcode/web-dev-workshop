using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public decimal? Hours { get; set; }
        public bool Completed { get; set; }

        public Project Project { get; set; }
    }
}
