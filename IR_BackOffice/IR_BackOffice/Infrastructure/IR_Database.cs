using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using IR_BackOffice_Data;

namespace IR_BackOffice.Infrastructure
{
    public class IR_Database : DbContext, IBackOfficeDataSource
    {
        public IR_Database()
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