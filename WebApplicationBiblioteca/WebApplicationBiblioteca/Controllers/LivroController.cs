using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using WebApplicationBiblioteca.Models.DAL;
using WebApplicationBiblioteca.Models;

namespace WebApplicationBiblioteca.Controllers
{
    public class LivroController : Controller
    {
        private Contexto db = new Contexto();

        public ActionResult Index()
        {
            using (Contexto ctx = new Contexto())
            {         
                List<Livro> lista = ctx.Livros.Include(x => x.Autor).ToList();
                return View(lista);
            }

        }

        public ActionResult Create()
        {
            using (Contexto ctx = new Contexto())
            {
                ViewBag.AutorId = new SelectList(db.Autores, "AutorId", "Nome");
                return View();
            }
        }
   
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "LivroID,Titulo,ISBN,AutorId")] Livro livro)
        {
            using (Contexto ctx = new Contexto())
            {
                if (ModelState.IsValid)
                {                  
                        db.Livros.Add(livro);
                        db.SaveChanges();
                                 
                    ViewBag.AutorId = new SelectList(db.Autores, "AutorId", "Nome", livro.AutorId);
                    return RedirectToAction("Index");
                }

                return View(livro);
            }
        }

    }
}