using System.Data.Entity;

namespace WebApplicationBiblioteca.Models.DAL
{
    public class Contexto :DbContext
    {
        public Contexto() : base("BaseBiblioteca555")
        {
            //DropCreateDatabaseAlways 

            //DropCreateDatabaseIfModelChanges

            //Migrations (pra produção)


            Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());
        }


        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
    }
}