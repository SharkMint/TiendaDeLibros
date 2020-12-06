using PubsLib.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PubsLib
{
    public class Editor : Conexion
    {
        /*-----------------------------
        * ATRIBUTOS DE LA CLASE
        * -----------------------------
        */

        //public List<LibroModel> CurrentData { get; }
        public Editor(string setting) : base(setting)
        {
        }
        public List<EditorModel> Read(string criterio, bool indPK)
        {
            List<EditorModel> lista = new List<EditorModel>();
            string strWhere = "pub_name LIKE '%" + criterio + "%';";
            if (indPK)
                strWhere = " pub_id = '" + criterio + "';";
            DataTable tabla = Buscar("publishers", "*", strWhere);
            foreach (DataRow row in tabla.Rows)
            {
                EditorModel obj1 = new EditorModel();
                obj1.Pubid = row["pub_id"].ToString();
                obj1.Name = row["Pub_Name"].ToString();
                obj1.City = row["city"].ToString();
                obj1.State = row["state"].ToString();
                obj1.Country = row["country"].ToString();
                lista.Add(obj1);
            }
            return lista;
        }
        public List<EditorModel> Read(string criterio)
        {
            //esclavo overload o sobre carga
            return Read(criterio, false);
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