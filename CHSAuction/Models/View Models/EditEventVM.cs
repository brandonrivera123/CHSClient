using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CHSAuction.Models
{
    public class EditEventVM
    {
        public IEnumerable<Events> CurrentEvents { get; set; }

        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventLocation { get; set; }
        public int EventTicketNum { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int EventGoal { get; set; }
        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTime EventStart { get; set; }
        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTime EventEnd { get; set; }
        public string EventURL { get; set; }
    }
}
