using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Controllers;
using WebApplication3.Models;
using WebApplication3.Models.Produits;
using WebApplication3.Models.roue;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<NombreModel> Nombres { get; set; }

        public DbSet<MainsOeuvre> mainsOeuvres { get; set;}
        public DbSet<Roue> roue { get; set; }
        public DbSet<Gentes> gentes { get; set; }
        public DbSet<Pneus> pneus { get; set; }
        public DbSet<Pneu> Pneu { get; set; }

        public DbSet<Voiture> voitures { get; set; }
        public DbSet<devis> devis { get; set; }

        public DbSet<freins> freins { get; set; }
        public DbSet<batterie> batteries { get; set; }
        public DbSet<moteur> moteurs { get; set; }
        public DbSet<Suspension> suspensions { get; set; }
        public DbSet<TurboCompresseur> turboCompresseur { get; set; }

        public DbSet<Reparation> reparations { get; set; }
    }
}
