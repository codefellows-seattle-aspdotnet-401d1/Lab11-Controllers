using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistry.Controllers
{
    public class StudentController
    {
        public string Find(string name, int age, int course)
        {
            return $"{name} is a {age} year old student in a {course} course at Code Fellows.";
        }

        public string Error()
        {
            return "Oh noes! An 3rr04!!!!";
        }
    }
}
