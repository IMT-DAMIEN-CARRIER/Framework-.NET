using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
