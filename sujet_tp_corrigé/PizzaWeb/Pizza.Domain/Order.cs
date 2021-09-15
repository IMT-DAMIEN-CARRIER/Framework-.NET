using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
    }
}
