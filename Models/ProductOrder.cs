using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }

        public int IdProduct { get; set; }

        public int IdOrder { get; set; }
    }
}