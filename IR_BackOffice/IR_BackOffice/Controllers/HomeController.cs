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
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

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

        public ActionResult PetBuildings()
        {
            string directory = HostingEnvironment.ApplicationPhysicalPath;
            string[] files = Directory.GetFiles(directory + @"Images\Content\Gallery\PetBuildings", "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = "Images/Content/Gallery/PetBuildings/" + new DirectoryInfo(Directory.GetFiles(directory + @"Images\Content\Gallery\PetBuildings", "*", SearchOption.TopDirectoryOnly)[i]).Name;
            }

            return View(files);
        }

        //

        [HttpPost]
        public ActionResult Contact(EnquiryModel collection)
        {

            if (ModelState.IsValid)
            {
                try
                {

                    SmtpClient client = new SmtpClient();
                    client.Port = 587;

                    client.Host = "smtp.gmail.com";

                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;

                    // TODO: replace password on debug mode with privateclass.emailpassword
#if DEBUG
                    client.Credentials = new System.Net.NetworkCredential("jamie.brindle7.work@gmail.com", "");

#else
                client.Credentials = new System.Net.NetworkCredential("jamie.brindle7.work@gmail.com", privateclass.emailpassword);
#endif

                    MailMessage mm = new MailMessage("Web Message - " + collection.ContactName + " " + collection.EmailAddress, "edssheds@ntlworld.com", collection.ContactName + (string.IsNullOrEmpty(collection.TelephoneNumber) ? "" : " - "
                        + collection.TelephoneNumber), GetMessageBody(collection, false));

                    mm.ReplyToList.Add(new MailAddress(collection.EmailAddress, collection.ContactName));

                    mm.BodyEncoding = UTF8Encoding.UTF8;
                    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                    client.Send(mm);

                    if (collection.SendToSelf)
                    {
                        SmtpClient clientSelf = new SmtpClient();
                        clientSelf.Port = 587;

                        clientSelf.Host = "smtp.gmail.com";

                        clientSelf.EnableSsl = true;
                        clientSelf.Timeout = 10000;
                        clientSelf.DeliveryMethod = SmtpDeliveryMethod.Network;
                        clientSelf.UseDefaultCredentials = false;

                        // TODO: make sure you remove password before a commit
                        // TODO: replace password on debug mode with privateclass.emailpassword
#if DEBUG
                        clientSelf.Credentials = new System.Net.NetworkCredential("webmessage@edssheds", "");

#else
                    clientSelf.Credentials = new System.Net.NetworkCredential("webmessage@edssheds", privateclass.emailpassword);
#endif

                        MailMessage mmSelf = new MailMessage("Ed's Sheds - Web Message edssheds@ntlworld.com", collection.EmailAddress, "Ed's Sheds Webform Email - " + collection.ContactName + (string.IsNullOrEmpty(collection.TelephoneNumber) ? "" : " - "
                            + collection.TelephoneNumber), GetMessageBody(collection, true));

                        mmSelf.ReplyToList.Add(new MailAddress("edssheds@ntlworld.com", "Ed's Sheds - Web Message edssheds@ntlworld.com"));

                        mmSelf.BodyEncoding = UTF8Encoding.UTF8;
                        mmSelf.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                        client.Send(mmSelf);
                    }

                    return View("ThankYou");
                }
                catch
                {
                    MessageBox.Show("Mail Send Error", "Error sender email. Possible server issue. Please try again later", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return View(collection);
                }
            }
            else
            {
                return View(collection);
            }
        }

        private string GetMessageBody(EnquiryModel colleciton, bool copyToSelf)
        {
            string message = string.Empty;

            if (!string.IsNullOrEmpty(colleciton.EmailAddress))
            {
                message += "Ed's Sheds Webform email.\n\n";

                if (copyToSelf)
                {
                    message += "Thank you for your enquiry. This is a copy for yorself:\n\n";
                }

                if (!copyToSelf)
                {
                    message += "Reply to: " + colleciton.EmailAddress + "\n\n";
                }

                message += colleciton.Enquiry;
            }

            return message;
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
