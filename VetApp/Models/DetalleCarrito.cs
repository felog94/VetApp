namespace VetApp.Models
{
    public class DetalleCarrito
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int CarritoId { get; set; }
        public virtual Carrito Carrito { get; set; }

        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
