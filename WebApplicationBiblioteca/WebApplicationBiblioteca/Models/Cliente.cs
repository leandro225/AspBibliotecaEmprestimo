using System.ComponentModel.DataAnnotations;


namespace WebApplicationBiblioteca.Models
{
    public class Cliente
    {


        public int ClienteID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

       
    }
}