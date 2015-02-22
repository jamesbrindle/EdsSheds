using System;

namespace ES_BackOffice_Data
{
    public class OfferItem
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }
        public virtual byte[] Image { get; set; }
        public virtual DateTime DateAdded { get; set; }
        public virtual bool IsLive { get; set; }
    }
}
