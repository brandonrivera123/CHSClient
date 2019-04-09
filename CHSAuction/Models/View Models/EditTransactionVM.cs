using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHSAuction.Models
{
    public class EditTransactionVM
    {
        public IEnumerable<Transactions> Transactions { get; set; }

        public int TransactionId { get; set; }
        public int TransactionTotalPrice { get; set; }
        public int GuestId { get; set; }
        public int EventId { get; set; }
        public Boolean TransactionSent { get; set; }
        public Boolean TransactionPaid { get; set; }
    }
}
