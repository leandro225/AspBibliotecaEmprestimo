using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationBiblioteca.Models;
using WebApplicationBiblioteca.Models.DAL;

namespace WebApplicationBiblioteca.Controllers
{
    public class EmprestimoController : Controller
    {
        private Contexto db = new Contexto();


        public ActionResult Index()
        {
            using (Contexto ctx = new Contexto())
            {   
                List<Emprestimo> lista = ctx.Emprestimos.Include(x => x.Livro).ToList();
                return View(lista);
            }

        }
        public ActionResult Create()
        {

            using (Contexto ctx = new Contexto())
            {

                ViewBag.LivroId = new SelectList(db.Livros, "LivroID", "Titulo");
                return View();
            }
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "EmprestimoId,PessoaEmprestimo,DataEmprestimo,DataDevolucao,LivroID")] Emprestimo emprestimo)
        {
            using (Contexto ctx = new Contexto())
            {
                if (ModelState.IsValid)
                {

                    db.Emprestimos.Add(emprestimo);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
              
                return View(emprestimo);
            }
        }
    }
}