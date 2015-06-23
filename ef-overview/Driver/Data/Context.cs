using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Context : DbContext
    {
        public Context()
            : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=SimplotTestDatabase;Integrated Security=True;MultipleActiveResultSets=True")
        {
        }

        public IDbSet<Project> Projects { get; set; }
        public IDbSet<ProjectTask> ProjectTasks { get; set; }
    }
}
