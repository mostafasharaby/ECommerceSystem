using FawryECommerceSystem.src.Models;
using FawryECommerceSystem.src.Services;

var customer = new Customer("Mostafa", 1000);

var cheese = new Cheese("Cheese", 100, 5, new DateTime(2025, 7, 12), 0.2);
var biscuits = new Biscuits("Biscuits", 150, 3, new DateTime(2025, 7, 20), 0.7);
var tv = new TV("TV", 300, 2, 7.0);
var scratchCard = new ScratchCard("Scratch Card", 50, 10);

var cart = new Cart();
cart.AddProduct(cheese, 2);
cart.AddProduct(biscuits, 1);
cart.AddProduct(tv, 1);
cart.AddProduct(scratchCard, 1);

CheckoutService.Checkout(customer, cart);

#region test for empty cart 
var emptyCart = new Cart();
CheckoutService.Checkout(customer, emptyCart);
#endregion

#region  test for insufficient balance
var customer2 = new Customer("Muhammed", 500);
CheckoutService.Checkout(customer2, cart);
#endregion


#region  test for out of stock 
var cart2 = new Cart();
cart2.AddProduct(cheese, 50);
CheckoutService.Checkout(customer, cart2);
#endregion


