using System.Web.Mvc;
using Xunku.DIS.Common.Utility;

namespace Xunku.DIS.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var input = "123";
            var ret = DataUtility.GetInt(input);

            if (ret.HasValue)
            {
                return View();
            }

            return View();
        }
    }
}