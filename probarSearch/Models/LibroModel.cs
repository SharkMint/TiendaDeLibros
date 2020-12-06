using System;
using System.Collections.Generic;
using System.Text;
namespace PubsLib.Models
{
    public class LibroModel
    {
        public string Titleid { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string EditorID { get; set; }
        public string Editora { get; set; }
        public double Price { get; set; }
        public double Avance { get; set; }
        public double Royal { get; set; }
        public double YearSales { get; set; }
        public string Notas { get; set; }

        public DateTime FechaPublicado { get; set; }
        public LibroModel()
        {
            // default si no se coloca no deja construcciones basicas.
        }
        public LibroModel(string id, string name, string type, string pubid, string
        sprecio, string savanc, string sroyal, string sysales, string notes, string sdtepub)
        {
            this.Titleid = id;
            this.Name = name;
            this.Type = type;
            this.EditorID = pubid;
            this.Notas = notes;
            try
            {
                this.Price = double.Parse(sprecio);
                this.Avance = double.Parse(savanc);
                this.Royal = double.Parse(sroyal);
                this.YearSales = double.Parse(sysales);
                this.FechaPublicado = DateTime.Parse(sdtepub);
            }
            catch (Exception e)
            {
                throw new Exception("Error en los datos numericos o fecha...." +
                e.Message);
            }
        }
    }
}