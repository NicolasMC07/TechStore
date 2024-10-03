using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Order
    {   
        [Key] // Define esta propiedad como clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Genera el valor automáticamente
        public int Id { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        [StringLength(20)] // Limita la longitud del estado a 20 caracteres
        public string? Status { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        public DateTime DateOrder { get; set; }

        [Range(1, int.MaxValue)] // Asegura que la cantidad sea al menos 1
        public int QuantityProduct { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        public int IdClient { get; set; }

        public ICollection<ProductOrder>? ProductOrders { get; set; } // Colección de ProductOrder
    }
}