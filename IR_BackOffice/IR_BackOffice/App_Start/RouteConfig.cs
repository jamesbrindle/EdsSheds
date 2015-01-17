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

            routes.MapRoute("Contact", "contact", new { controller = "Home", action = "Contact" }
               );

            routes.MapRoute("FindingUs", "finding-us", new { controller = "Home", action = "FindingUs" }
               );

            routes.MapRoute("PriceLists", "price-lists", new { controller = "Home", action = "PriceLists" }
               );

            routes.MapRoute("Gallery", "gallery", new { controller = "Home", action = "Gallery" }
               );

            // ADMIN

            routes.MapRoute("OffersAdmin", "offers-admin", new { controller = "Offers", action = "Index" }
                );

            routes.MapRoute("OfferItemAdmin", "offers-admin/{id}", new { controller = "Offer", action = "OfferItem", id = UrlParameter.Optional }
               );

            // MISC

            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}