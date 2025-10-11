// Student: yuval matasaro, ID: 991735973

using Pizza_Order_System.Models;

namespace Pizza_Order_System.Services;

public class PizzaOrderService : IPizzaOrderService
{
    private const decimal DiscountThresholdQty = 3;
    private const decimal DiscountRate = 0.10m;
    private const decimal TaxRateHst = 0.13m;

    public ReceiptModel CalculateReceipt(OrderInputModel input)
    {
        var pricePerItem = GetBasePrice(input.PizzaType, input.PizzaSize);
        var subtotal = pricePerItem * input.Quantity;

        var eligibleForDiscount = input.Quantity > 2;
        var discountRate = eligibleForDiscount ? DiscountRate : 0m;
        var discountAmount = RoundCurrency(subtotal * discountRate);

        var afterDiscount = subtotal - discountAmount;
        var taxAmount = RoundCurrency(afterDiscount * TaxRateHst);
        var total = RoundCurrency(afterDiscount + taxAmount);

        return new ReceiptModel
        {
            CustomerName = input.CustomerName,
            PizzaType = input.PizzaType,
            PizzaSize = input.PizzaSize,
            Quantity = input.Quantity,
            PricePerItem = pricePerItem,
            SubtotalBeforeDiscount = RoundCurrency(subtotal),
            DiscountRate = discountRate,
            DiscountAmount = discountAmount,
            TaxRate = TaxRateHst,
            TaxAmount = taxAmount,
            Total = total
        };
    }

    private static decimal GetBasePrice(PizzaType type, PizzaSize size)
    {
        return type switch
        {
            PizzaType.Plain => size switch
            {
                PizzaSize.Small => 10m,
                PizzaSize.Medium => 15m,
                PizzaSize.Large => 20m,
                _ => 0m
            },
            PizzaType.Crispy => size switch
            {
                PizzaSize.Small => 12m,
                PizzaSize.Medium => 18m,
                PizzaSize.Large => 25m,
                _ => 0m
            },
            _ => 0m
        };
    }

    private static decimal RoundCurrency(decimal value)
    {
        return decimal.Round(value, 2, MidpointRounding.AwayFromZero);
    }
}