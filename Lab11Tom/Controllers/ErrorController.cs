using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11Tom.Controllers
{
    [Route("Error")]
    public class ErrorController
    {
        [Route("Error")]
        public string Index()
        {
            return "Oops, there was an error! Please contact the school";
        }
    }
}
