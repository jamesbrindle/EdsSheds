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
using System.IO;
using System.Web.Hosting;
using System;

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

        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult PriceLists()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult FindingUs()
        {
            return View();
        }

        // GALLERIES

        public ActionResult Sheds()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\Sheds", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/Sheds/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\Sheds", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        public ActionResult Summerhouses()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\Summerhouses", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/Summerhouses/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\Summerhouses", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        public ActionResult Playhouses()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\Playhouses", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/Playhouses/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\Playhouses", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        public ActionResult LogCabins()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\LogCabins", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/LogCabins/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\LogCabins", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        public ActionResult Lugarde()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\LogCabins\Lugarde", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/LogCabins/Lugarde/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\LogCabins\Lugarde", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        public ActionResult Workshops()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\Workshops", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/Workshops/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\Workshops", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        public ActionResult Furniture()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\Furniture", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/Furniture/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\Furniture", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        public ActionResult GatesAndFencing()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\GatesAndFencing", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/GatesAndFencing/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\GatesAndFencing", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        public ActionResult Decking()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\Decking", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/Decking/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\Decking", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        public ActionResult BrightIdeas()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\BrightIdeas", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/BrightIdeas/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\BrightIdeas", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        //

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
