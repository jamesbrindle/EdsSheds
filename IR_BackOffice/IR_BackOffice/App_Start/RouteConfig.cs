using System.Web.Mvc;
using System.Web.Routing;

namespace IR_BackOffice.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // HOME

            routes.MapRoute("Home", "", new { controller = "Home", action = "Index" }
               );

            routes.MapRoute("Offers", "Offers", new { controller = "Home", action = "Offers" }
               );

            routes.MapRoute("TermsAndConditions", "terms-and-conditions", new { controller = "Home", action = "TermsAndConditions" }
               );

            routes.MapRoute("Sitemap", "sitemap", new { controller = "Home", action = "Sitemap" }
               );

            routes.MapRoute("PrivacyPolicy", "privacy-policy", new { controller = "Home", action = "PrivacyPolicy" }
               );

            routes.MapRoute("Contact", "contact-us", new { controller = "Home", action = "Contact" }
               );

            routes.MapRoute("FindingUs", "finding-us", new { controller = "Home", action = "FindingUs" }
               );

            routes.MapRoute("PriceLists", "price-lists", new { controller = "Home", action = "PriceLists" }
               );

            routes.MapRoute("Gallery", "gallery", new { controller = "Home", action = "Gallery" }
               );

            // GALLERIES

            routes.MapRoute("Sheds", "standard-sheds", new { controller = "Home", action = "Sheds" }
               );

            routes.MapRoute("Summerhouses", "summerhouses", new { controller = "Home", action = "Summerhouses" }
               );

            routes.MapRoute("Playhouses", "playhouses", new { controller = "Home", action = "Playhouses" }
               );

            routes.MapRoute("LogCabins", "log-cabins", new { controller = "Home", action = "LogCabins" }
               );

            routes.MapRoute("Lugarde", "lugarde", new { controller = "Home", action = "Lugarde" }
               );

            routes.MapRoute("Workshops", "workshops", new { controller = "Home", action = "Workshops" }
               );

            routes.MapRoute("Furniture", "garden-furniture", new { controller = "Home", action = "Furniture" }
               );

            routes.MapRoute("GatesAndFencing", "gates-and-fencing", new { controller = "Home", action = "GatesAndFencing" }
               );

            routes.MapRoute("Decking", "decking", new { controller = "Home", action = "Decking" }
               );

            routes.MapRoute("BrightIdeas", "bright-ideas", new { controller = "Home", action = "BrightIdeas" }
               );

            routes.MapRoute("PetBuildings", "pet-buildings", new { controller = "Home", action = "PetBuildings" }
               );

            //

            // ADMIN

            routes.MapRoute("Admin", "admin", new { controller = "Admin", action = "Index" }
                );

            routes.MapRoute("OffersAdmin", "offers-admin", new { controller = "Offers", action = "Index" }
                );

            routes.MapRoute("OfferItemAdmin", "offers-admin/{id}", new { controller = "Offers", action = "OfferItem", id = UrlParameter.Optional }
               );

            // MISC

            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}