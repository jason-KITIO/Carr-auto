using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.roue
{
    public class Pneus
    {
        [Key]
        public int Id { get; set; }
        public string image { get; set; }
        public double prix { get; set; }
        public int nombre { get; set; }
        public decimal TotalPrice => (decimal)(prix * nombre);
    }
}
