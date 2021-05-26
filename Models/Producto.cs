namespace Pc3.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre{get; set;}
        public string Fotoproducto{get; set;}
        public string Descripcion{get;set;}
        public int Precio { get; set; }
        public string N_celular { get; set; }
        public string lugar_compra { get; set; }
        public string nombre_comprador { get; set; }
        public Categoria Categoria{get; set;}
        //shadow property
        
        public int CategoriaId{get;set;}
        

    }
}