﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHSAuction.Models
{
    public class EditCategoryVM
    {
        public IEnumerable<Categories> Categories { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
