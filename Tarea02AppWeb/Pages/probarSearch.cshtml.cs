using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PubsLib.Models;
using PubsLib;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Tarea02AppWeb.Pages
{
    public class probarSearchModel : PageModel
    {
        public List<LibroModel> ListaLibro;
        private IConfigurationRoot ConfigRoot;
        public string MessageText { get; set; }
        public string SearchText { get; set; }
        public probarSearchModel(IConfiguration pconfig)
        {
            ConfigRoot = (IConfigurationRoot)pconfig;
        }
        public void OnGet()
        {
            ListaLibro = new List<LibroModel>();
        }
        public void OnPost()
        {
            if (Request.Form["search"] != "")
            {
                SearchText = Request.Form["search"];
                string setting = ConfigRoot["AppSettings:serverconn"].ToString();
                Libro eltitle = new Libro(setting);
                ListaLibro = eltitle.Read(SearchText);
            
            } else 
      
            {
                ListaLibro = new List<LibroModel>();
            }
        }

    }
}