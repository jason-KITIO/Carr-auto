using System.ComponentModel.DataAnnotations;
using WebApplication3.Data.enums;

namespace WebApplication3.Models.Produits
{
    public class TurboCompresseur
    {
        [Key]
        public int Id { get; set; }
        public string image { get; set; }
        public double prix { get; set; }
        public int nombre { get; set; }
        public marque marque { get; set; }
        public decimal TotalPrice => (decimal)(prix * nombre);
    }
}
