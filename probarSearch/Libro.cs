using PubsLib.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PubsLib
{
    public class Libro : Conexion
    {
        /*-----------------------------
        * ATRIBUTOS DE LA CLASE
        * -----------------------------
        */
        //public List<LibroModel> CurrentData { get; }
        public Libro(string setting) : base(setting)
        {
        }
        public List<LibroModel> Read(string criterio)
        {
            return Read(criterio, false);
        }
        public List<LibroModel> Read(string criterio, bool indPK)
        {
            List<LibroModel> lista = new List<LibroModel>();
            string strWhere = "(pub_name + title + cast(notes as varchar) + type) LIKE '%" + criterio + "%'; ";

        if (indPK)

            strWhere = "title_id = '" + criterio + "'; "; // puntual por PK
            DataTable tabla = Buscar("titles INNER JOIN publishers on publishers.pub_id = titles.pub_id ", "titles.*, publishers.pub_name", strWhere);

        foreach (DataRow row in tabla.Rows)
            {
                LibroModel obj1 = new LibroModel();
                obj1.Titleid = row["title_id"].ToString();
                obj1.Name = row["title"].ToString();
                obj1.Type = row["type"].ToString();
                obj1.EditorID = row["pub_id"].ToString();
                obj1.Editora = row["pub_name"].ToString();
                try
                {
                    obj1.Price = double.Parse(row["price"].ToString());
                    obj1.Avance = double.Parse(row["advance"].ToString());
                    obj1.Royal = double.Parse(row["royalty"].ToString());
                    obj1.YearSales = double.Parse(row["ytd_sales"].ToString());
                    obj1.Notas = row["notes"].ToString();

                    obj1.FechaPublicado = DateTime.Parse(row["pubdate"].ToString());

                }
                catch { }
                lista.Add(obj1);
            }
            return lista;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="criterio"> el criterio de busqueda</param>
        /// <param name="indCRUD"> indicador si la data es full para create and update</param>
        /// <returns></returns>
        public AddLibroModel ReadModel(string criterio)
        {
            AddLibroModel fullModel = new AddLibroModel();
            LibroModel oneLibro = null;

            if (criterio != "") /*se interpreta modify*/
            {
                // busqueda por PK
                List<LibroModel> oList = Read(criterio, true);
                oneLibro = oList[0]; //primer record
            }
            else
            {
                oneLibro = new LibroModel(); // blanck
            }
            fullModel.DataModel = oneLibro;
            fullModel.Editors = getEditors();
            fullModel.Types = getTypes();
            return fullModel;
        }
        private List<EditorModel> getEditors()
        {
            Editor objEditor = new Editor(connsetting);
            List<EditorModel> listEditor = objEditor.Read(""); // todas las editoras
            objEditor = null; // no esperar el garbage collector

        return listEditor;
        }
        public bool Crear(Models.LibroModel objnew)
        {
            string sqlstm = "INSERT INTO titles(title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate)";
            sqlstm += "VALUES('" + objnew.Titleid + "'";
            sqlstm += ",'" + objnew.Name + "'";
            sqlstm += ",'" + objnew.Type + "'";
            sqlstm += ",'" + objnew.EditorID + "'";
            sqlstm += "," + objnew.Price.ToString();
            sqlstm += "," + objnew.Avance.ToString();
            sqlstm += "," + objnew.Royal.ToString();
            sqlstm += "," + objnew.YearSales.ToString();
            sqlstm += ",'" + objnew.Notas + "'";
            sqlstm += ",'" + objnew.FechaPublicado + "');";
            return Cambiar(sqlstm);
        }
        public bool Update(Models.LibroModel objupdate)
        {
            string sqlstm = "UPDATE titles";
            sqlstm += "\n SET title ='" + objupdate.Name + "'";
            sqlstm += ", type = '" + objupdate.Type + "'";
            sqlstm += ",pub_id = '" + objupdate.EditorID + "'";
            sqlstm += ",price = " + objupdate.Price.ToString();
            sqlstm += ",advance =" + objupdate.Avance.ToString();
            sqlstm += ", royalty =" + objupdate.Royal.ToString();
            sqlstm += ",ytd_sales =" + objupdate.YearSales.ToString();
            sqlstm += ",notes ='" + objupdate.Notas + "'";
            sqlstm += ",pubdate = '" + objupdate.FechaPublicado + "'";
            sqlstm += " \n WHERE title_id = '" + objupdate.Titleid + "';"; /*PK mandatorio para update */
            return Cambiar(sqlstm);
        }
        public bool Delete(Models.LibroModel objdel)
        {
            throw new NotImplementedException();
        }
        private List<string> getTypes()
        {
            List<string> lista = new List<string>();
            DataTable tabla = Buscar("titles", "DISTINCT type", "1=1");
            foreach (DataRow row in tabla.Rows)
            {
                LibroModel obj1 = new LibroModel();
                lista.Add(row["type"].ToString());
            }
            return lista;
        }
    }
}