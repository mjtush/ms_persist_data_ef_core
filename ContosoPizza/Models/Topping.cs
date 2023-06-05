using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ContosoPizza.Models;

public class Topping
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public decimal Calories { get; set; }

    // to omit circular reference
    [JsonIgnore]
    // to make Pizza-Topping a many-to-many relationship
    public ICollection<Pizza>? Pizzas { get; set; }
}