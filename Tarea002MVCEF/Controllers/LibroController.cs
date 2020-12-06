using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EFPubDBLib.Models;
using EFPubDBLib.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Tarea002MVCEF.Controllers
{
    public class LibroController : Controller
    {
        readonly dblibrosContext db = null;
        private readonly IConfigurationRoot ConfigRoot;
        private readonly string cnnkey;
        public LibroController(IConfiguration serviceconfig)
        {
            ConfigRoot = (IConfigurationRoot)serviceconfig; // casting de objeto
            cnnkey = ConfigRoot["AppSettings:serverconn"];
            db = new dblibrosContext(cnnkey);
        }
        // GET: HomeController1
        public ActionResult Buscar()
        {
            var libro = db.Titles
            .Where(term => term.Title == "1===2")
            .ToList();
            return View(libro);
        }
        // post: LibroController1/Details/5
        [HttpPost]
        public ActionResult Buscar(string searchterm)
        {
            var libro = db.Titles
            .Where(term => term.Title.Contains(searchterm))
            .ToList(); ;
            return View(libro);

        }
        [HttpGet]
        public ActionResult Buscar(string id, string va)
        {

            var libro = db.Titles
            .Where(term => term.TitleId == id)
            .ToList(); ;
            return View(libro);

        }
        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var model = new BookHelp
            {
                /* Vamos al abc de LINQ . . . */
                Pubs = db.Publishers.ToList(),
                Types = (from ta in db.Titles
                         select ta.Type).Distinct()
            };
            return View(model);
        }
        // POST: LibroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection thisForm)
        {
            var libro = new Titles();
            try
            {
                libro.TitleId = thisForm["titleid"];
                libro.Title = thisForm["name"];
                libro.Type = thisForm["type"];
                libro.PubId = thisForm["pub_id"];
                libro.Price = decimal.Parse(thisForm["price"]);
                libro.Advance = decimal.Parse(thisForm["Avance"]);
                libro.Royalty = int.Parse(thisForm["royal"]);
                libro.YtdSales = int.Parse(thisForm["yearsales"]);
                libro.Notes = thisForm["notes"];
                libro.Pubdate = DateTime.Parse(thisForm["pubdate"]);
                db.Titles.Add(libro);
                db.SaveChanges();
                return RedirectToAction(nameof(Buscar), new
                {
                    id = libro.TitleId,
                    va =
                "__view"
                });
            }
            catch (Exception e)
            {
                var model = new BookHelp
                {
                    Model = libro,
                    Pubs = db.Publishers.ToList(),
                    Types = (from ta in db.Titles
                             select ta.Type).Distinct()
                };
                ViewData["MessageText"] = e.Message;
                return View(libro);
            }
        }

        // GET: LibroController/Edit/5
        public ActionResult Edit(string id)
        {
            var model = new BookHelp
            {
                Model = db.Titles.Where(t => t.TitleId == id).First(),
                Pubs = db.Publishers.ToList(),
                Types = (from ta in db.Titles
                         select ta.Type).Distinct()
            };
            return View(model);
        }
        // POST: LibroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection thisForm)
        {
            var libro = db.Titles.Find(id);

            try
            {
                libro.Title = thisForm["name"];
                libro.Type = thisForm["type"];
                libro.PubId = thisForm["pub_id"];
                libro.Price = decimal.Parse(thisForm["price"]);
                libro.Advance = decimal.Parse(thisForm["Avance"]);
                libro.Royalty = int.Parse(thisForm["royal"]);
                libro.YtdSales = int.Parse(thisForm["yearsales"]);
                libro.Notes = thisForm["notes"];
                libro.Pubdate = DateTime.Parse(thisForm["pubdate"]);
                db.SaveChanges();
                return RedirectToAction(nameof(Buscar), new { id = id, va = "__view" });
            }
            catch (Exception e)
            {
                var model = new BookHelp
                {
                    Model = libro,
                    Pubs = db.Publishers.ToList(),
                    Types = (from ta in db.Titles
                             select ta.Type).Distinct()
                };
                ViewData["MessageText"] = e.Message;
                return View(libro);
            }
        }
        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Listar()
        {
            var libro = db.Getallsales
            .Where(term => term.Title == "1===2")
            .ToList();
            return View(libro);
        }
        // post: LibroController1/Details/5
        [HttpPost]
        public ActionResult Listar(IFormCollection thisForm)
        {
            var SearchText = thisForm["searchTerm"];
            ViewData["SearchTerm"] = SearchText;
            ViewData["dtedesde"] = thisForm["dtedesde"];
            ViewData["dtehasta"] = thisForm["dtehasta"];
            var dtein = DateTime.Parse(thisForm["dtedesde"]);
            var dteto = DateTime.Parse(thisForm["dtehasta"]);
            var libro = db.Getallsales

            .Where(term => term.Fulltextterm.Contains(SearchText) && term.OrdDate
            >= dtein && term.OrdDate <= dteto)
            .ToList();
            return View(libro);
        }
    }
}