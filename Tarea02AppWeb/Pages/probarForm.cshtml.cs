using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Tarea02AppWeb.Pages
{
    public class probarFormModel : PageModel
    {

        private IConfigurationRoot ConfigRoot;

        public string MessageText { get; set; }
        public probarFormModel(IConfigurationRoot configRoot)
        {
            ConfigRoot = (IConfigurationRoot)configRoot;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (postData(Request.Form["name"].ToString(), Request.Form["edad"].ToString(), Request.Form["profesion"].ToString(),
                Request.Form["estadocivil"].ToString())){ 
                MessageText = "Datos Procesados Exitosamente";

            }
        }

        private bool postData(string p_name, string p_edad, string p_profesion, string p_estadocivil )
        {
            //throw new NotImplementedException();
            try
            {
                string path = ConfigRoot["AppSettings:filepath"].ToString();
                path = ConfigRoot["AppSettings:filepath"].ToString();
                StreamWriter miarchivo = new StreamWriter(path + "\\student.txt", true);
                miarchivo.WriteLine("{0}|{1}|{2}|{3}", p_name, p_edad, p_profesion, p_estadocivil);
                miarchivo.Close();
                return true;
            } catch(Exception e)
            {
                MessageText = e.Message;
                return false;

            }
        }
    }
}
