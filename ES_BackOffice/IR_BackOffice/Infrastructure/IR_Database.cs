using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using ES_BackOffice_Data;

namespace ES_BackOffice.Infrastructure
{
    public class ES_Database : DbContext, IBackOfficeDataSource
    {
        public ES_Database()
            : base("DefaultConnection")
        {

        }
        
        public DbSet<OfferItem> OfferItems { get; set; }
        
        /* */

        IQueryable<OfferItem> IBackOfficeDataSource.OfferItems
        {
            get { return OfferItems; }
        }
    }
}