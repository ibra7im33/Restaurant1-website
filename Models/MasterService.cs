using System;
using System.Collections.Generic;

namespace Restorent.Models
{
    public partial class MasterService
    {
        public int MasterServicesId { get; set; }
        public string? MasterServicesTitle { get; set; }
        public string? MasterServicesDesc { get; set; }
        public string? MasterServicesImage { get; set; }
    }
}
