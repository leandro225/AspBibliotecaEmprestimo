using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationBiblioteca.Models.DAL;
using WebApplicationBiblioteca.Models;

namespace WebApplicationBiblioteca.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            Contexto contexto = new Contexto();
            List<Cliente> clientes = contexto.Clientes.ToList();

            return View(clientes);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                Contexto contexto = new Contexto();
                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

    }
}