using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Client
    {   
        [Key] // Define esta propiedad como clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Genera el valor automáticamente
        public int Id { get; set; }

        [Required] // Hace que esta propiedad sea obligatoria
        [StringLength(100)] // Limita la longitud del nombre a 100 caracteres
        public string? Name { get; set; }

        [StringLength(200)] // Limita la longitud de la dirección a 200 caracteres
        public string? Address { get; set; }

        [StringLength(15)] // Limita la longitud del número de teléfono a 15 caracteres
        public string? PhoneNumber { get; set; } 

        [EmailAddress] // Valida que el formato sea de una dirección de correo electrónico
        [StringLength(100)] // Limita la longitud del email a 100 caracteres
        public string? Email { get; set; }
    }
}