using System;
using System.Collections.Generic;

namespace EFPubDBLib.Models
{
    public partial class Discounts
    {
        public string Discounttype { get; set; }
        public string StoreId { get; set; }
        public short? Lowqty { get; set; }
        public short? Highqty { get; set; }
        public decimal Discount { get; set; }

        public virtual Stores Store { get; set; }
    }
}
