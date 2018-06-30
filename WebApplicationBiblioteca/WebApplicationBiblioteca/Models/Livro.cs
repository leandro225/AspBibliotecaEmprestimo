using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace WebApplicationBiblioteca.Models
{
    public class Livro
    {

        public int LivroID { get; set; }
        
        public string Titulo { get; set; }
       
        public string ISBN { get; set; }

        //vindo do autor
              
        public int AutorId { get; set; }
        
        [ForeignKey("AutorId")]
        public virtual Autor Autor { get; set; }





    }
}