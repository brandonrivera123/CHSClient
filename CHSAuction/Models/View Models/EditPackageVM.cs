using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CHSAuction.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class EditPackageVM
    {
        public IEnumerable <Packages> Packages { get; set; }

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
