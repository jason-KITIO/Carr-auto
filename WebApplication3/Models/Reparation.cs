using System.ComponentModel.DataAnnotations;
using WebApplication3.Data.enums;

namespace WebApplication3.Models
{
    public class Reparation
    {
        [Key]
        public int Id { get; set; }
        public string image { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public bool statut { get; set; } = false;
        public double prix { get; set; }
        public int nombre { get; set; }
        public categorieVoiture categorie { get; set; }
        public decimal TotalPrice => (decimal)(prix * nombre);
    }
}
