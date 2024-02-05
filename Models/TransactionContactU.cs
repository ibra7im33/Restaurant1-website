using System;
using System.Collections.Generic;

namespace Restorent.Models
{
    public partial class TransactionContactU
    {
        public int TransactionContactUsId { get; set; }
        public string? TransactionContactUsFullName { get; set; }
        public string? TransactionContactUsEmail { get; set; }
        public string? TransactionContactUsSubject { get; set; }
        public string? TransactionContactUsMessage { get; set; }
    }
}
