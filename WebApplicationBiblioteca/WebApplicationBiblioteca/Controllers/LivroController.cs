using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationBiblioteca.Models.DAL;
using WebApplicationBiblioteca.Models;

namespace WebApplicationBiblioteca.Controllers
{
    public class LivroController : Controller
    {
        
        public ActionResult Index()
        {
            Contexto contexto = new Contexto();
            List<Livro> livros = contexto.Livros.ToList();

            return View(livros);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Livro livro)
        {
            if (ModelState.IsValid)
            {
                Contexto contexto = new Contexto();
                contexto.Livros.Add(livro);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(livro);
        }

    }
}