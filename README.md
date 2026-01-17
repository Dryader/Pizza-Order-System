# Pizza Order System

A web-based pizza ordering application built with ASP.NET Core MVC that allows customers to place pizza orders and automatically calculates pricing with discounts and taxes.

## Features

- **Interactive Order Form**: Easy-to-use interface for placing pizza orders
- **Multiple Pizza Options**: 
  - Pizza Types: Plain and Crispy
  - Pizza Sizes: Small, Medium, and Large
- **Automatic Price Calculation**: Real-time calculation based on type, size, and quantity
- **Volume Discount**: 10% discount applied automatically when ordering more than 2 pizzas
- **Tax Calculation**: Automatically applies 13% HST (Harmonized Sales Tax)
- **Receipt Generation**: Detailed receipt showing itemized pricing, discounts, and taxes

## Technology Stack

- **Framework**: ASP.NET Core 9.0
- **Language**: C#
- **Architecture**: MVC (Model-View-Controller)
- **Frontend**: Bootstrap, jQuery
- **Dependency Injection**: Built-in ASP.NET Core DI container

## Prerequisites

Before running this application, ensure you have the following installed:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- A code editor (e.g., Visual Studio, Visual Studio Code, or JetBrains Rider)

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Dryader/Pizza-Order-System.git
   cd Pizza-Order-System
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

## How to Run

1. Navigate to the project directory:
   ```bash
   cd "Pizza Order System"
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. Open your web browser and navigate to:
   - HTTPS: `https://localhost:5001`
   - HTTP: `http://localhost:5000`

## Project Structure

```
Pizza-Order-System/
├── Pizza Order System/
│   ├── Controllers/
│   │   └── HomeController.cs          # Main controller handling order requests
│   ├── Models/
│   │   ├── OrderInputModel.cs         # Input model for order form
│   │   ├── ReceiptModel.cs            # Model for receipt data
│   │   └── ErrorViewModel.cs          # Error handling model
│   ├── Services/
│   │   ├── IPizzaOrderService.cs      # Service interface
│   │   └── PizzaOrderService.cs       # Business logic for order calculations
│   ├── Views/
│   │   ├── Home/
│   │   │   ├── Index.cshtml           # Order form view
│   │   │   ├── Receipt.cshtml         # Receipt display view
│   │   │   └── Privacy.cshtml
│   │   └── Shared/
│   │       ├── _Layout.cshtml
│   │       └── Error.cshtml
│   ├── wwwroot/                       # Static files (CSS, JS, libraries)
│   ├── Program.cs                     # Application entry point
│   └── appsettings.json               # Configuration settings
└── Pizza Order System.sln             # Solution file
```

## Usage

1. **Enter Customer Information**: Provide the customer name in the order form
2. **Select Pizza Type**: Choose between Plain or Crispy pizza
3. **Select Pizza Size**: Choose from Small, Medium, or Large
4. **Enter Quantity**: Specify the number of pizzas (minimum 1)
5. **Submit Order**: Click the submit button to place the order
6. **View Receipt**: Review the detailed receipt with all pricing information

### Pricing

**Plain Pizza:**
- Small: $10.00
- Medium: $15.00
- Large: $20.00

**Crispy Pizza:**
- Small: $12.00
- Medium: $18.00
- Large: $25.00

**Discounts & Taxes:**
- Volume Discount: 10% off when ordering more than 2 pizzas
- HST: 13% tax applied after discount

## License

This project is a student assignment.

**Student**: Yuval Matasaro  
**ID**: 991735973
