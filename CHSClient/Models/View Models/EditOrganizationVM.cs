﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHSAuction.Models
{
    public class EditOrganizationsVM
    {
        public IEnumerable<Organizations> Organizations { get; set; }

        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
    }
}
