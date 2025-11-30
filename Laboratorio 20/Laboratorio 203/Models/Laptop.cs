using System.ComponentModel.DataAnnotations;

namespace Laboratorio203.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public decimal Precio { get; set; }

        [Required]
        public int Stock { get; set; }
    }
}