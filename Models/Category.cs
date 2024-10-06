using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Category
    {

        [Key] // Define esta propiedad como clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Genera el valor automáticamente
        public int Id { get; set; }
        
        [Required] // Hace que esta propiedad sea obligatoria
        [StringLength(100)] // Limita la longitud del nombre a 100 caracteres
        public string? Name { get; set; }

        [StringLength(500)] // Limita la longitud de la descripción a 500 caracteres
        public string? Description { get; set; }
        public Category(string name, string description)
        {
            Name = name.ToLower().Trim();
            Description = description.ToLower().Trim();
        }

        public Category()
        {
        }
    }
}