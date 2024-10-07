using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.DTOs
{
    public class UserDTO
    {
        [Required] // Hace que esta propiedad sea obligatoria
        [StringLength(100)] // Limita la longitud del nombre a 100 caracteres
        public string? Name { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        [DataType(DataType.EmailAddress)] // Valida que el email sea válido
        [EmailAddress] // Valida que el email tenga un formato válido
        public string Email { get; set; }
        
        [Required] // Hace que esta propiedad sea obligatoria
        [StringLength(256)] // Limita la longitud de la contraseña a 256 caracteres (ajusta según tu política de almacenamiento)
        public string? Password { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        public int IdRole { get; set; }
    }
}