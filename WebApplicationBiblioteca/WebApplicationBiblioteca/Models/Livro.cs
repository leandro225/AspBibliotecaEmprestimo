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

        [Required(ErrorMessage = "Informe o Titulo")]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Informe o ISBN")]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        
        




    }
}