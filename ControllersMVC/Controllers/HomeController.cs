using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllersMVC.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "This is my default homepage.\n" +
                "OPTIONS: \n" +
                "/welcome \n" +
                "/students/add?name=____&age=____ \n" +
                "/students/viewstudents \n" +
                "/dang";
        } 

        [Route("welcome")]
        public string Welcome()
        {
            return "This is the Welcome action method.";
        }
    }
}
