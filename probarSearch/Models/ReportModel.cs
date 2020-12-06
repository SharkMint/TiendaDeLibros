using System;
using System.Collections.Generic;
using System.Text;
namespace PubsLib.Models
{
    public class ReportModel
    {
        public string Titleid { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string EditorID { get; set; }
        public string Editora { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Total { get; set; }
        public string Notas { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNO { get; set; }
        public string Storeid { get; set; }
        public string Autor { get; set; }
        public string StoreName { get; set; }
    }
}