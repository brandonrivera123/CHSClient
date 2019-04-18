using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CHSAuction.Models
{
    public class EditTransactionVM
    {
        public IEnumerable<Transactions> Transactions { get; set; }
        public IEnumerable<Tickets> Tickets { get; set; }
        public IEnumerable<Packages> Packages { get; set; }

        public int TransactionId { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int TransactionTotalPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int TransactionAmountPaid { get; set; }
        public int GuestId { get; set; }
        public int EventId { get; set; }
        public Boolean TransactionSent { get; set; }
        public Boolean TransactionPaid { get; set; }
        public int PackageId { get; set; }
        public int TicketId { get; set; }
    }
}
