using System.Collections.Generic;

namespace Pc3.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // propiedad oculta

        public ICollection<Producto> Productos{get;set;}
    }
}