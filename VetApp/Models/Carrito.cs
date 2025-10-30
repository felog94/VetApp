namespace VetApp.Models
{
    public class Carrito
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<DetalleCarrito> Detalles { get; set; }
    }
}
