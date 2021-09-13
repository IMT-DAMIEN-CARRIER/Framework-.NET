using System;
using System.Collections.Generic;

namespace WebApp1.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public Restaurant Restaurant { get; set; }
        public Pizza Pizza { get; set; }
    }
}
