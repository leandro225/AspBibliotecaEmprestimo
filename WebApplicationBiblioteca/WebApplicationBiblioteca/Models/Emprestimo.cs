using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace WebApplicationBiblioteca.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }

        public string PessoaEmprestimo { get; set; }

        [Display(Name = "Data do Empréstimo")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataEmprestimo { get; set; }

        [Display(Name = "Data da Devolução")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDevolucao { get; set; }


        [Display(Name = "Livro")]
        public int LivroID { get; set; }
        [ForeignKey("LivroID")]
        public virtual Livro Livro { get; set; }
    }
}