using Data;
using Data.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            //var project = new Project()
            //{
            //    Name = "Test Project",
            //    Tasks = new List<ProjectTask>()
            //    {
            //        new ProjectTask()
            //        {
            //            Name = "Task One"                        
            //        }
            //    }
            //};

            //context.Projects.Add(project);
            //context.SaveChanges();

            //var project = context.Projects
            //    .Include(p => p.Tasks)
            //    .FirstOrDefault(p => p.Id == 1);

            //project.Tasks[0].Hours = 4M;

            //context.SaveChanges();

            var projects = context.Projects.ToList();

            Console.ReadLine();
        }
    }
}
