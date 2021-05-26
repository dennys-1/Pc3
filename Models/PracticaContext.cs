using Microsoft.EntityFrameworkCore;

namespace Pc3.Models
{
    public class PracticaContext :DbContext
    {
        public DbSet<Producto> Productos{get; set;}

        public DbSet<Categoria> Categorias{get;set;}

        public PracticaContext(DbContextOptions dco):base (dco){
            
        }
    }
}