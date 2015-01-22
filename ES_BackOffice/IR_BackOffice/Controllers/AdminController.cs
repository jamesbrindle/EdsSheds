using System.Web.Mvc;

namespace ES_BackOffice.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}
