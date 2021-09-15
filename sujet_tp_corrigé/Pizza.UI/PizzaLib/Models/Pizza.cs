using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib
{
    public class Pizza
    {
        public Guid Key { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
