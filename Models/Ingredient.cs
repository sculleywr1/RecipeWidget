using System.ComponentModel.DataAnnotations;

namespace RecipeWidget.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Quantity { get; set; }
        public double Cost { get; set; }

    }
}
