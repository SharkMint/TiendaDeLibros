using PubsLib.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace PubsLib
{
    public class Sales : Conexion
    {
        /*-----------------------------
        * ATRIBUTOS DE LA CLASE
        * -----------------------------
        */

        //public List<LibroModel> CurrentData { get; }
        public Sales(string setting) : base(setting)
        {

        }

        public List<ReportModel> GetReport(DateTime dtein, DateTime dteto, string criterio)
        {
            List<ReportModel> lista = new List<ReportModel>();
            string strWhere = "ord_date between '" + dtein + "' AND '" + dteto + "' AND fulltextterm LIKE '%" + criterio + "%'";
            strWhere += "\n ORDER BY TITLE,Ord_date, ord_num;";
            DataTable tabla = Buscar("getallsales", "*", strWhere);

            foreach (DataRow row in tabla.Rows)
            {
                ReportModel obj1 = new ReportModel();
                obj1.Titleid = row["title_id"].ToString();
                obj1.Title = row["title"].ToString();
                obj1.Type = row["type"].ToString();
                obj1.EditorID = row["pub_id"].ToString();
                obj1.Editora = row["pub_name"].ToString();
                obj1.Storeid = row["stor_id"].ToString();
                obj1.StoreName = row["stor_name"].ToString();
                obj1.Autor = row["autor"].ToString();
                obj1.Editora = row["pub_name"].ToString();
                try
                {
                    obj1.Price = double.Parse(row["price"].ToString());
                    obj1.Quantity = double.Parse(row["qty"].ToString());
                    obj1.Total = double.Parse(row["total"].ToString());
                    obj1.OrderNO = row["ord_num"].ToString();
                    obj1.OrderDate = DateTime.Parse(row["ord_date"].ToString());
                }
                catch { }
                lista.Add(obj1);
            }
            return lista;
        }

        public bool Crear(Models.LibroModel objnew)
        {
            throw new NotImplementedException();
        }
        public bool Update(Models.LibroModel objupdate)
        {
            throw new NotImplementedException();
        }
        public bool Delete(Models.LibroModel objdel)
        {
            throw new NotImplementedException();
        }

    }
}