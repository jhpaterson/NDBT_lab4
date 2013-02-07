using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Domain
{
    public class Fine
    {
        public virtual int FineId { get; set; }
        public virtual DateTime FineDate { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual Loan Loan { get; set; }
    }
}
