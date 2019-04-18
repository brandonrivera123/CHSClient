using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CHSAuction.Models
{
    public class EditGuestVM
    {
        public IEnumerable<Guests> Guests { get; set; }

        public int GuestId { get; set; }
        public string GuestFirstName { get; set; }
        public string GuestLastName { get; set; }
        public string GuestEmail { get; set; }
        [DisplayFormat(DataFormatString = "{0:###-###-####}")]
        public string GuestPhone { get; set; }
        public int? OrganizationId { get; set; }
        public string GuestAddress { get; set; }
        public string GuestCity { get; set; }
        public string GuestState { get; set; }
        public int GuestZip { get; set; }
    }
}
