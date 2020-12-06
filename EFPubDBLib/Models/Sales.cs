﻿using System;
using System.Collections.Generic;

namespace EFPubDBLib.Models
{
    public partial class Sales
    {
        public Sales()
        {
            SalesLog = new HashSet<SalesLog>();
        }

        public string StorId { get; set; }
        public string OrdNum { get; set; }
        public DateTime OrdDate { get; set; }
        public short Qty { get; set; }
        public string Payterms { get; set; }
        public string TitleId { get; set; }

        public virtual Stores Stor { get; set; }
        public virtual Titles Title { get; set; }
        public virtual ICollection<SalesLog> SalesLog { get; set; }
    }
}
