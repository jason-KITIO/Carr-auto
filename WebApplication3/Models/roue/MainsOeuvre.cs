using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.roue
{
    public class MainsOeuvre
    {
        [Key]
        public int Id { get; set; }
        public string image { get; set; }
        public string nom { get; set; }
        public double prix { get; set; }
        public int nombre { get; set; }
        public decimal TotalPrice => (decimal)(prix * nombre);
    }
}
