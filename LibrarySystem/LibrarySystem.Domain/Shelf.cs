using System;

namespace LibrarySystem.Domain
{
    public class Shelf
    {
        public virtual string ShelfCode { get; set; }
        public virtual bool Public { get; set; }
        public virtual string Campus { get; set; }
        public virtual int PropertyNumber { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string Area { get; set; }
        public virtual string Property { get; set; }

        public string PostCode
        {
            get { return String.Format("{0} {1}", Area, Property); }
        }

    }
}
