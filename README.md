# E-Commerce System

A simple and extendable **C# Console E-Commerce System** that manages products with support for **shipping**, **expiration**, and **inventory control**.

## ✨ Features

* Define products with:
  * Name
  * Price
  * Quantity
* Support for two types of products:
  * Expirable products (e.g. Cheese, Biscuits)
  * Non-expirable products (e.g. TV, Mobile)
* Some products require shipping
* Interface-based design for flexible extension
* Console-based user interface for interaction

## 📦 Technologies Used

* C#
* .NET Core / .NET 6+
* Object-Oriented Programming (OOP)
* Interface & Inheritance
* SOLID principles

## 🏗️ Architecture

```text
FawryECommerceSystem/          
├── Program.cs
├── Interfaces/
│   ├── IShippable.cs
├── Models/
│   ├── Product.cs
│   ├── ExpirableProduct.cs
│   ├── NonExpirableProduct.cs
│   ├── Cheese.cs
│   ├── Biscuits.cs
│   ├── TV.cs
│   ├── ScratchCard.cs
│   ├── Customer.cs
│   └── CartItem.cs
├── Services/
│   ├── Cart.cs
│   ├── CheckoutService.cs
│   └── ShippingService.cs
```
## 🚀 Getting Started

### Prerequisites

* [.NET SDK 6+](https://dotnet.microsoft.com/download)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/ECommerceSystem.git
   cd ECommerceSystem
   ```
2. Run unit tests:
```bash
dotnet run
```




