using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersMVC.Controllers
{
    public class ErrorController
    {
        [Route("dang")]
        public string CustomError()
        {
            return "You done did it now! This is a custom error!";
        }
    }
}
