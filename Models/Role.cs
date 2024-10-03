using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Role
    {   
        [Key] // Define esta propiedad como clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Genera el valor automáticamente
        public int Id { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        [StringLength(50)] // Limita la longitud del nombre a 50 caracteres
        public string? Name { get; set; }
    }
}