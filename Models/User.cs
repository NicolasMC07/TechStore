using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class User
    {
        public int Id { get; set; }

        public int Name { get; set; }
        
        public int Password { get; set; }

        public int IdRole { get; set; }
    }
}