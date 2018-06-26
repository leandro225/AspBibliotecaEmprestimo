using System.Data.Entity;

namespace WebApplicationBiblioteca.Models.DAL
{
    public class Contexto :DbContext
    {
        public Contexto() : base("BaseBiblioteca")
        {
            //DropCreateDatabaseAlways 

            //DropCreateDatabaseIfModelChanges

            //Migrations (pra produção)


            Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());
        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Livro> Livros { get; set; }
    }
}