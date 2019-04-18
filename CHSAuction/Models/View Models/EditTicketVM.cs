using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CHSAuction.Models
{
    public class EditTicketVM
    {
        public IEnumerable<Tickets> Tickets { get; set; }

        public int TicketId { get; set; }
        public int GuestId { get; set; }
        public int EventId { get; set; }
        public int TicketQuantity { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int TicketPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int TicketTotalPrice { get; set; }
        public int TransactionId { get; set; }
    }
}
