using System;
using System.Collections.Generic;

namespace EFPubDBLib.Models
{
    public partial class Getallsales
    {
        public string OrdNum { get; set; }
        public DateTime OrdDate { get; set; }
        public short Qty { get; set; }
        public string StorId { get; set; }
        public string TitleId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public decimal? Price { get; set; }
        public string PubId { get; set; }
        public string Autor { get; set; }
        public string StorName { get; set; }
        public string PubName { get; set; }
        public decimal? Total { get; set; }
        public string Fulltextterm { get; set; }
    }
}
