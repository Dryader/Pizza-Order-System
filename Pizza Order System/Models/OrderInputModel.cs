// Student: yuval matasaro, ID: 991735973

using System.ComponentModel.DataAnnotations;

namespace Pizza_Order_System.Models;

public enum PizzaType
{
    Plain = 1,
    Crispy = 2
}

public enum PizzaSize
{
    Small = 1,
    Medium = 2,
    Large = 3
}

public class OrderInputModel
{
    [Required(ErrorMessage = "Customer name is required")]
    [Display(Name = "Customer Name")]
    public string CustomerName { get; set; } = string.Empty;

    [Display(Name = "Pizza Type")] public PizzaType PizzaType { get; set; } = PizzaType.Plain;

    [Display(Name = "Pizza Size")] public PizzaSize PizzaSize { get; set; } = PizzaSize.Small;

    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive number")]
    public int Quantity { get; set; } = 1;
}