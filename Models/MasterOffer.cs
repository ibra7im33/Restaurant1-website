using System;
using System.Collections.Generic;

namespace Restorent.Models
{
    public partial class MasterOffer
    {
        public int MasterOfferId { get; set; }
        public string? MasterOfferTitle { get; set; }
        public string? MasterOfferBreef { get; set; }
        public string? MasterOfferDesc { get; set; }
        public string? MasterOfferImageUrl { get; set; }
    }
}
