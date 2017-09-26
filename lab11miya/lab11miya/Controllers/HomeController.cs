using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab11miya.Controllers
{
    public class HomeController
    {
        public string Index()
        {
            return "You are at the home page.";
        }
        public string Options()
        {
            return "Familiarize yourself with the site. This will be your primary student portal.";
        }
    }
}
