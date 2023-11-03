using System.ComponentModel.DataAnnotations;

namespace RecipeWidget.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public double? TotalCost { get; set; }
        public int? Servings { get; set; }
        public double? UnitCost { get; set; }
    }
}
