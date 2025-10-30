using Microsoft.EntityFrameworkCore;
using VetApp.Models;

namespace VetApp.Data
{
    public class VeterinariaContext : DbContext
    {
        public VeterinariaContext(DbContextOptions<VeterinariaContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Carrito> Carritos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Turno>()
                .HasOne(t => t.Cliente)
                .WithMany()
                .HasForeignKey(t => t.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Turno>()
                .HasOne(t => t.Mascota)
                .WithMany()
                .HasForeignKey(t => t.MascotaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}