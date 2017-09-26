using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11Tom.Controllers
{
    [Route("Students")]
    public class StudentsController
    {

        public string Index()
        {
            return "This is a list of registered students";
        }

        [Route("Stats")]
        public string Stats(string name, int age)
        {
            return $"{name} is a student and is {age} years old.";
        }
    }
}
