namespace VetApp.Models
{
    public class Cliente : Usuario
    {
        public virtual ICollection<Mascota> Mascotas { get; set; }
        public virtual Carrito Carrito { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}