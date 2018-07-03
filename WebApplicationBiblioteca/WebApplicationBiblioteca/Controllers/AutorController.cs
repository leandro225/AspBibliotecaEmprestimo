using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using WebApplicationBiblioteca.Models.DAL;
using WebApplicationBiblioteca.Models;

namespace WebApplicationBiblioteca.Controllers
{
    public class AutorController : Controller
    {
        private Contexto db = new Contexto();
  
        public ActionResult Index()
        {
            using (Contexto ctx = new Contexto())
            {

                List<Autor> lista = ctx.Autores.ToList();
                return View(lista);
            }

        }
     
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AutorId,Nome")] Autor autor)
        {
            if (ModelState.IsValid)
            {
                db.Autores.Add(autor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(autor);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autor autor = db.Autores.Find(id);
            if (autor == null)
            {
                return HttpNotFound();
            }
            return View(autor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            Autor autor = db.Autores.Find(id);

            db.Autores.Remove(autor);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}