using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml;
using dnCustom45;
using IR_BackOffice.Infrastructure;
using IR_BackOffice.Models;
using System.Threading.Tasks;
using IR_BackOffice_Data;

namespace IR_BackOffice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBackOfficeDataSource _repository = new IR_Database();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Offers()
        {
            return View();
        }

        public ActionResult TermsAndConditions()
        {
            return View();
        }

        public ActionResult Sitemap()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(EnquiryModel collection)
        {
            //Add send mail. collection[0]

            if (ModelState.IsValid)
            {
                var body = "name: " + collection.ContactName + "<br /> Company: " +
                           collection.TelephoneNumber +
                           "<br /> Email: " + collection.EmailAddress + "<br /> Enquiry: " + collection.Enquiry;
                var mail = new IRMail(collection.EmailAddress, true, body, "Web Enquiry");

                mail.AddToo("edssheds@ntlworld.com");

                if (collection.SendToSelf)
                {
                    mail.AddCC(collection.EmailAddress);
                }
                mail.SendMail();

                return RedirectToAction("ThankYou");
            }

            return View(collection);
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
