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
