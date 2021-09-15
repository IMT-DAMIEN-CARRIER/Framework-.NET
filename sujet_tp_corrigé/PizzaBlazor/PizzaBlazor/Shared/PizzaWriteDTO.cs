using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Shared
{
    public class PizzaWriteDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
