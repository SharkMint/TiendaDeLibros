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
    public class AutorController : Controller
    {
        readonly dblibrosContext db = null;
        private readonly IConfigurationRoot ConfigRoot;
        private readonly string cnnkey;

        public AutorController(IConfiguration serviceconfig)
        {
            ConfigRoot = (IConfigurationRoot)serviceconfig; // casting de objeto
            cnnkey = ConfigRoot["AppSettings:serverconn"];
            db = new dblibrosContext(cnnkey);
        }
        // GET: HomeController1
        public ActionResult Buscar()
        {
            var libro = db.Authors
            .Where(term => term.AuFname == "1===2")
            .ToList();
            return View(libro);
        }
        // post: LibroController1/Details/5
        [HttpPost]
        public ActionResult Buscar(string searchterm)
        {
            var libro = db.Authors
            .Where(term => term.AuFname.Contains(searchterm) ||
            term.AuLname.Contains(searchterm))
            .ToList(); ;
            return View(libro);
        }
        // GET: HomeController1/Create
        public ActionResult Create()
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
        // POST: LibroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection thisForm)
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

        // GET: LibroController/Edit/5
        public ActionResult Edit(string id)
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
        // POST: LibroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection thisForm)
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
            try
            {
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }
        // post: LibroController1/Details/5
        [HttpGet]
        public ActionResult Listar(string id)
        {
            //Include(term => term.Titleauthor)
            var autor = db.Titleauthor

            .Where(term => term.AuId == id)
            .Include(term => term.Title)
            .Include(term => term.Au)
            .ToList();
            ///db.Entry(autor).Collection(ta => ta.Titleauthor).Reference(lb => lb.Title).Load();

            return View(autor);

        }
    }
}