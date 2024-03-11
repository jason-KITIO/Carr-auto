using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WebApplication3.Models
{
    public class NombreModel
    {
        [Key]
        public int Id { get; set; }
        public int Nombre { get; set; }
    }
}
