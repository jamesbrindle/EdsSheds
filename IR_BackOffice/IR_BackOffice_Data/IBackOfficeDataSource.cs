using System.Linq;

namespace IR_BackOffice_Data
{
    public interface IBackOfficeDataSource
    {
        IQueryable<OfferItem> OfferItems { get; }
    }
}
