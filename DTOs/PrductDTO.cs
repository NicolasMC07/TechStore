using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.DTOs
{
    public class PrductDTO
    {
        [Required] // Hace que esta propiedad sea obligatoria
        [StringLength(100)] // Limita la longitud del nombre a 100 caracteres
        public string? Name { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")] // Asegura que el precio sea positivo
        public double Price { get; set; }

        [StringLength(500)] // Limita la longitud de la descripción a 500 caracteres
        public string? Description { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser negativa.")] // Asegura que la cantidad no sea negativa
        public int Quantity { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        public int IdCategory { get; set; }
    }
}