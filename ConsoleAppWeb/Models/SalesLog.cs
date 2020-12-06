using System;
using System.Collections.Generic;

namespace ConsoleAppWeb.Models
{
    public partial class SalesLog
    {
        public int SalesLogId { get; set; }
        public string StorId { get; set; }
        public string OrdNum { get; set; }
        public string TitleId { get; set; }
        public string AuId { get; set; }
        public DateTime LogFecha { get; set; }
        public decimal Price { get; set; }
        public short Quantity { get; set; }

        public virtual Authors Au { get; set; }
        public virtual Sales Sales { get; set; }
    }
}
