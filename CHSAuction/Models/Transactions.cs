using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CHSAuction.Models
{
    public partial class Transactions
    {
        public Transactions()
        {
            Packages = new HashSet<Packages>();
            Tickets = new HashSet<Tickets>();
        }

        public int TransactionId { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int TransactionTotalPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int TransactionAmountPaid { get; set; }
        public int GuestId { get; set; }
        public int EventId { get; set; }
        public Boolean TransactionSent { get; set; }
        public Boolean TransactionPaid { get; set; }

        public Guests Guest { get; set; }
        public Events Event { get; set; }
        public ICollection<Packages> Packages { get; set; }
        public ICollection<Tickets> Tickets { get; set; }
    }
}
