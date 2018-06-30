using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace WebApplicationBiblioteca.Models
{
    public class Autor
    {

        public int AutorId { get; set; }

        [Required(ErrorMessage = "Informe o Autor")]
        [Display(Name = "Autor")]
        public string Nome { get; set; }
    }
}