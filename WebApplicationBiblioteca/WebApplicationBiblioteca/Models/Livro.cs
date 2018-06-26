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

        
        public string Autor{ get; set; }

        [Required(ErrorMessage = "Digite a Data da Compra do Livro")]
        [Display(Name = "Data da Compra")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCompra { get; set; }



    }
}