using System;
using System.Collections.Generic;

namespace EFPubDBLib.Models
{
    public partial class SalesTitleView
    {
        public string StorId { get; set; }
        public string OrdNum { get; set; }
        public DateTime OrdDate { get; set; }
        public short Qty { get; set; }
        public string Payterms { get; set; }
        public string TitleId { get; set; }
        public decimal? Price { get; set; }
    }
}
