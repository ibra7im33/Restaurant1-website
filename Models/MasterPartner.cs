using System;
using System.Collections.Generic;

namespace Restorent.Models
{
    public partial class MasterPartner
    {
        public int MasterPartnerId { get; set; }
        public string? MasterPartnerName { get; set; }
        public string? MasterPartnerLogoImageUrl { get; set; }
        public string? MasterPartnerWebsiteUrl { get; set; }
    }
}
