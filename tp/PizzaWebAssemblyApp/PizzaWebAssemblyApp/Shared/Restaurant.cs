using System.ComponentModel.DataAnnotations;

namespace PizzaWebAssemblyApp.Shared
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}