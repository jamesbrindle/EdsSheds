using System;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;
using IR_BackOffice.Infrastructure;
using IR_BackOffice.Models;
using IR_BackOffice_Data;
using OfferItem = IR_BackOffice_Data.OfferItem;

namespace IR_BackOffice.Controllers
{
    public class ManageOffersController : Controller
    {
        private readonly IBackOfficeDataSource _repository = new IR_Database();
        [Authorize]

        public ActionResult Index()
        {
            var offerItems = _repository.OfferItems;
            return View(offerItems);
        }

        [Authorize]
        public ActionResult Create()
        {
            var model = new CreateOfferViewModel();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CreateOfferViewModel input)
        {
            if (ModelState.IsValid)
            {
                WebImage image = null;

                try
                {
                    image = WebImage.GetImageFromRequest();
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine("Error uploading image: " + e.Message);
                }

                var offerItem = new OfferItem();

                if (image != null)
                {
                    byte[] toPutInDb = image.GetBytes();
                    offerItem.Image = toPutInDb;
                }

                offerItem.Text = input.Text;
                offerItem.DateAdded = input.DateAdded;
                offerItem.IsLive = input.IsLive;

                var data = new IR_Database();
                data.OfferItems.Add(offerItem);
                data.SaveChanges();

                return View("Index", data.OfferItems);
            }

            return View(input);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            OfferItem n = _repository.OfferItems.Single(u => u.Id == id);
            var model = new EditOfferViewModel
            {
                Title = n.Title,
                Text = n.Text,
                DateAdded = n.DateAdded,
                IsLive = n.IsLive,
                Id = n.Id
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Edit(EditOfferViewModel input)
        {
            if (ModelState.IsValid)
            {
                var data = new IR_Database();
                OfferItem n = data.OfferItems.Single(u => u.Id == input.Id);

                WebImage image = null;

                try
                {
                    image = WebImage.GetImageFromRequest();
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine("Error uploading image: " + e.Message);
                }

                if (image != null)
                {
                    byte[] toPutInDb = image.GetBytes();
                    n.Image = toPutInDb;
                }

                n.Title = input.Title;
                n.Text = input.Text;
                n.DateAdded = input.DateAdded;
                n.IsLive = input.IsLive;

                data.SaveChanges();

                return View("Index", data.OfferItems);
            }

            return View(input);
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            var data = new IR_Database();
            OfferItem n = data.OfferItems.Single(u => u.Id == id);

            return View(n);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var data = new IR_Database();
            OfferItem n = data.OfferItems.Single(u => u.Id == id);

            data.OfferItems.Remove(n);
            data.SaveChanges();

            return View("Index", data.OfferItems);
        }

        [Authorize]
        public ActionResult Details(int id)
        {
            var data = new IR_Database();
            OfferItem n = data.OfferItems.Single(u => u.Id == id);

            return View(n);
        }
    }
}
