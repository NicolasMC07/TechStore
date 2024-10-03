using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class User
    {   
        [Key] // Define esta propiedad como clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Genera el valor automáticamente
        public int Id { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        [StringLength(100)] // Limita la longitud del nombre a 100 caracteres
        public string? Name { get; set; }
        
        [Required] // Hace que esta propiedad sea obligatoria
        [StringLength(256)] // Limita la longitud de la contraseña a 256 caracteres (ajusta según tu política de almacenamiento)
        public string? Password { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        public int IdRole { get; set; }
    }
}