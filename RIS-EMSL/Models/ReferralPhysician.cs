﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS_EMSL.Models
{
    public class ReferralPhysician
    {
        public int Id { get; set; }
        public string ReferralName { get; set; }
        public int TenantId { get; set; }
    }
}
