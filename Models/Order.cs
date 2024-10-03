using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string? Status { get; set; }

        public DateTime DateOrder { get; set; }

        public int QuantityProduct { get; set; }

        public int IdClient { get; set; }
    }
}