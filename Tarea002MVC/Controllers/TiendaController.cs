using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PubsLib.Models;
using PubsLib;
using Microsoft.Extensions.Configuration;

namespace Tarea002MVC.Controllers
{
    public class TiendaController : Controller
    {
        public string MessageText { get; set; }
        public string SearchText { get; set; }
        public List<LibroModel> TitlesList { get; set; }
        public AddLibroModel elCRUDModel { get; set; }
        private readonly IConfigurationRoot ConfigRoot;
        private readonly string cnnkey;
        public TiendaController(IConfiguration serviceconfig)
        {
            ConfigRoot = (IConfigurationRoot)serviceconfig; // casting de objeto
            cnnkey = ConfigRoot["AppSettings:serverconn"];
        }
        public IActionResult Buscar()
        {
            TitlesList = new List<LibroModel>();
            SearchText = "";
            ViewData["SearchTerm"] = "";
            return View(TitlesList);
        }
        [HttpPost]
        public IActionResult Buscar(IFormCollection thisForm)
        {
            SearchText = thisForm["searchterm"];
            ViewData["SearchTerm"] = SearchText;
            Libro objlibro = new Libro(cnnkey);
            TitlesList = objlibro.Read(SearchText);
            return View(TitlesList);
        }
        public IActionResult Crear()
        {
            //SearchText = thisForm["searchterm"];
            ViewData["SearchTerm"] = "";
            Libro objlibro = new Libro(cnnkey);
            elCRUDModel = objlibro.ReadModel("");
            ViewData["isPostProcess"] = "__begin";
            return View(elCRUDModel);
        }
        [HttpPost]
        public IActionResult Crear(IFormCollection thisForm)
        {
            SearchText = thisForm["Titleid"];
            ViewData["SearchTerm"] = "";
            try
            {
            Libro objlibro = new Libro(cnnkey);
                LibroModel objData = new LibroModel(SearchText, thisForm["name"],
                thisForm["type"], thisForm["pub_id"], thisForm["price"], thisForm["Avance"],
                thisForm["royal"], thisForm["yearsales"], thisForm["notes"], thisForm["pubdate"]);
                ViewData["isPostProcess"] = 1;
                if (!objlibro.Crear(objData))
                {
                    ViewData["MessageText"] = "No se pudo craer el Libro" +
                    objlibro.getMensaje();
                    ViewData["isPostProcess"] = "0";
                }
                elCRUDModel = objlibro.ReadModel(SearchText);
            }
            catch (Exception e)
            {
                elCRUDModel = new AddLibroModel();
                ViewData["MessageText"] = "Error Procesando los datos" + e.Message;
                ViewData["isPostProcess"] = "0";
            }
            return View(elCRUDModel);
        }
        public IActionResult Modificar()
        {
            SearchText = Request.Query["id"];
            if (SearchText == "")
                return View();
            ViewData["SearchTerm"] = SearchText;
            Libro objlibro = new Libro(cnnkey);
            elCRUDModel = objlibro.ReadModel(SearchText);
            ViewData["isPostProcess"] = "__begin";
            return View(elCRUDModel);
        }
        [HttpPost]
        public IActionResult Modificar(IFormCollection thisForm)
        {
            SearchText = thisForm["Titleid"];
            ViewData["SearchTerm"] = "";
            try
            {
                Libro objlibro = new Libro(cnnkey);
                LibroModel objData = new LibroModel(SearchText, thisForm["name"],
                thisForm["type"], thisForm["pub_id"], thisForm["price"], thisForm["Avance"],
                thisForm["royal"], thisForm["yearsales"], thisForm["notes"], thisForm["pubdate"]);
                ViewData["isPostProcess"] = "1";
                ViewData["MessageText"] = "Datos Actualizados Exitosamente!!!";
                if (!objlibro.Update(objData))
                {
                    ViewData["MessageText"] = "No se pudo craer el Libro" +
                    objlibro.getMensaje();
                    ViewData["isPostProcess"] = "0";
                }
                elCRUDModel = objlibro.ReadModel(SearchText);
            }
            catch (Exception e)
            {
                elCRUDModel = new AddLibroModel();
                ViewData["MessageText"] = "Error Procesando los datos" + e.Message;
                ViewData["isPostProcess"] = "0";
            }
            return View(elCRUDModel);
        }
        public IActionResult Listar()
        {
            SearchText = "";
            ViewData["SearchTerm"] = "";
            List<ReportModel> elModel = new List<ReportModel>(); // vacia
            return View(elModel);
        }
        [HttpPost]
        public IActionResult Listar(IFormCollection thisForm)
        {
            SearchText = thisForm["searchTerm"];
            ViewData["SearchTerm"] = SearchText;
            ViewData["dtedesde"] = thisForm["dtedesde"];
            ViewData["dtehasta"] = thisForm["dtehasta"];
            List<ReportModel> elModel;
            try
            {
                Sales objsales = new Sales(cnnkey);
                DateTime dtein = DateTime.Parse(thisForm["dtedesde"]);
                DateTime dteTo = DateTime.Parse(thisForm["dtehasta"]);
                ViewData["isPostProcess"] = "1";
                ViewData["MessageText"] = "No hay ventas en ese periodo!!!";
                elModel = objsales.GetReport(dtein, dteTo, SearchText);
                if (elModel.Count > 0)
                    ViewData["MessageText"] = "Total de records en este periodo es:" +
                    elModel.Count;
            }
            catch (Exception e)
            {
                elModel = new List<ReportModel>();
                ViewData["MessageText"] = "Error, No se ha podido realizar la busqueda." + e.Message;
                ViewData["isPostProcess"] = "0";
            }
            return View(elModel);
        }
    }
}