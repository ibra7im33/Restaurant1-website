using System;
using System.Collections.Generic;

namespace Restorent.Models
{
    public partial class MasterSocialMedium
    {
        public int MasterSocialMediaId { get; set; }
        public string MasterSocialMediaImageUrl { get; set; } = null!;
        public string MasterSocialMediaUrl { get; set; } = null!;
    }
}
