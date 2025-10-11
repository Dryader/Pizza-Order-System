// Student: yuval matasaro, ID: 991735973

namespace Pizza_Order_System.Models;

public class ReceiptModel
{
    public string CustomerName { get; set; } = string.Empty;
    public PizzaType PizzaType { get; set; }
    public PizzaSize PizzaSize { get; set; }
    public int Quantity { get; set; }

    public decimal PricePerItem { get; set; }
    public decimal SubtotalBeforeDiscount { get; set; }
    public decimal DiscountRate { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal TaxRate { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal Total { get; set; }
}