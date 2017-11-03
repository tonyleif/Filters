using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        //[CustomAuth(true)]
        [Authorize (Users = "admin")]
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }
    }
}