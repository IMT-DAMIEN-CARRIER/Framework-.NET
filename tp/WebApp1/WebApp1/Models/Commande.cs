using System;
using System.Collections.Generic;

namespace WebApp1.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
    }
}
