using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistry.Controllers
{
    public class ErrorController : Controller
    {
        public string Error()
        {
            return "Something has gone wrong! Please contact support.";
        }
    }
}
