using System.ComponentModel.DataAnnotations;
using WebApplication3.Data.enums;

namespace WebApplication3.Models
{
    public class Voiture
    {
        [Key]
        public int Id { get; set; }
        public string image { get; set; }
        public string nom { get; set; }
        public double prix { get; set; }
        public int nombre { get; set; }
        public categorieVoiture categorie { get; set; }
        public decimal TotalPrice => (decimal)(prix * nombre);
    }
}
