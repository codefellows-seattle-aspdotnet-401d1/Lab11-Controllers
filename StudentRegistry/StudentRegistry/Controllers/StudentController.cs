using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistry.Controllers
{
    public class StudentController : Controller
    {
        StudentRegistry registry = new StudentRegistry();

        public string Register(string name, int age, int course)
        {
            return registry.RegisterStudent(name, age, course);
        }

        public string ViewAll()
        {
            return registry.ShowStudents();
        }

        public string Error()
        {
            return "Oh noes! An 3rr04!!!!";
        }
    }
}
