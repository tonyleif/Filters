using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    [SimpleMessage(Message = "A")]
    public class CustomerController : Controller
    {
        //[SimpleMessage(Message = "A", Order = 1)]
        //[SimpleMessage(Message = "B", Order = 2)]
        public string Index()
        {
            return "This is the Customer controller";
        }

        [CustomOverrideActionFilters]
        [SimpleMessage(Message = "B")]
        public string OtherAction()
        {
            return "This is the other Action in the Customer controller";
        }
    }
}