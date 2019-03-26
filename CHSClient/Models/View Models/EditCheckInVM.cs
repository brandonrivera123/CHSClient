using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHSAuction.Models
{
    public class EditCheckInVM
    {
        public IEnumerable<CheckIns> CheckIns { get; set; }

        public int CheckInId { get; set; }
        public int CheckInBidderNumber { get; set; }
        public int GuestId { get; set; }
        public int EventId { get; set; }
    }
}
