using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pizza> Pizzas { get; set; }
    }
}