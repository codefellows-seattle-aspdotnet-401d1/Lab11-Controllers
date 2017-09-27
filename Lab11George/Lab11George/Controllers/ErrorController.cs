using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11George.Controllers
{
    public class ErrorController
    {
        // attribute routing replaces the routes
        [Route("Error")]
        public string Index() => "This is an error!";
    }
}
// Error controller can only have 1 (at least)
// Add Custom/Attribute routing to the Error page and one of the Student Actions.