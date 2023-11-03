using Microsoft.EntityFrameworkCore;
using RecipeWidget.Models;

namespace RecipeWidget.Context
{
    public class InMemoryContext : DbContext 
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        public InMemoryContext(DbContextOptions<InMemoryContext> options) : base(options) 
        { 
            
        }
    }
}
