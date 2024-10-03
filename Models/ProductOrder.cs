using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class ProductOrder
    {   
        [Key] // Define esta propiedad como clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Genera el valor automáticamente
        public int Id { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        public int IdProduct { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        public int IdOrder { get; set; }

        [ForeignKey(nameof(IdOrder))] // Establece la relación con la tabla Order
        public Order? Order { get; set; }

        [ForeignKey(nameof(IdProduct))] // Establece la relación con la tabla Product
        public Product? Product { get; set; }
    }
}