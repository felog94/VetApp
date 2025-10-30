namespace VetApp.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; } // Duración en minutos
        public double Precio { get; set; }
    }
}