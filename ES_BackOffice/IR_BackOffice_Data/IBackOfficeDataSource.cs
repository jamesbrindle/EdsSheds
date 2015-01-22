using System.Linq;

namespace ES_BackOffice_Data
{
    public interface IBackOfficeDataSource
    {
        IQueryable<OfferItem> OfferItems { get; }
    }
}
