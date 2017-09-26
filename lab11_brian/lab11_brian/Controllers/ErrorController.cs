using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab11_brian.Controllers
{
    [Route("Error")]
    public class ErrorController : Controller
    {
        [Route("Support")]
        public string Index()
        {
            return "OMG you did a bad thing .... STAP IT!";
        }
    }
}
