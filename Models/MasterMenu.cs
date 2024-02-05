using System;
using System.Collections.Generic;

namespace Restorent.Models
{
    public partial class MasterMenu
    {
        public int MasterMenuId { get; set; }
        public string MasterMenuName { get; set; } = null!;
        public string MasterMenuUrl { get; set; } = null!;
    }
}
