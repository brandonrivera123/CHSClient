﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CHSAuction.Models
{
    public class EventDetailsVM
    {
        public Events Events { get; set; }
        public Packages GetPackageLocations { get; set; }
        public IEnumerable<Packages> Packages { get; set; }

        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string PackageDescription { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int PackageStartBid { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int PackageBidIncrement { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int? PackageFinalPrice { get; set; }
        public int EventId { get; set; }
        public int? TransactionId { get; set; }
    }
}
