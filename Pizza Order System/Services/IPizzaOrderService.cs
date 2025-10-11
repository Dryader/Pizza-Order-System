// Student: yuval matasaro, ID: 991735973

using Pizza_Order_System.Models;

namespace Pizza_Order_System.Services;

public interface IPizzaOrderService
{
    ReceiptModel CalculateReceipt(OrderInputModel input);
}