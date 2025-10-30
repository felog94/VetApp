namespace VetApp.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public Estado Estado { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public int MascotaId { get; set; }
        public virtual Mascota Mascota { get; set; }

        public int ServicioId { get; set; }
        public virtual Servicio Servicio { get; set; }
    }
}