using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11Tom.Controllers
{
    public class HomeController
    {
        public string Index()
        {
            return "This is the homepage where you can register students";
        }

        [Route("Register")]
        public string Register()
        {
            return "Register your student";
        }


    }
}
