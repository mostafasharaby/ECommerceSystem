using FawryECommerceSystem.src.Models;

namespace FawryECommerceSystem.src.Services
{
    public static class CheckoutService
    {
        public static void Checkout(Customer customer, Cart cart)
        {
            if (!cart.Items.Any())
            {
                Console.WriteLine("Error: Cart is empty");
                return;
            }

            double subtotal = 0, shipping = 0;
            var shippingList = new List<IShippable>();

            foreach (var item in cart.Items)
            {
                if (item.Product.IsExpired())
                {
                    Console.WriteLine($"Error: {item.Product.Name} is expired.");
                    return;
                }
                if (item.Quantity > item.Product.QuantityAvailable)
                {
                    Console.WriteLine($"Error: Not enough stock for {item.Product.Name}.");
                    return;
                }
                subtotal += item.Product.Price * item.Quantity;

                if (item.Product is IShippable shippable)
                {
                    for (int i = 0; i < item.Quantity; i++)
                        shippingList.Add(shippable);
                }
            }

            var shippingFeePerItem = 10;
            shipping = shippingList.Count * shippingFeePerItem;
            double total = subtotal + shipping;

            if (customer.Balance < total)
            {
                Console.WriteLine("Error: Insufficient balance.");
                return;
            }

            customer.Balance -= total;
            ShippingService.Ship(shippingList);

            PrintReceipt(cart, subtotal, shipping, total, customer.Balance);
        }
        private static void PrintReceipt(Cart cart, double subtotal, double shipping, double total, double remainingBalance)
        {
            Console.WriteLine("\n** Checkout receipt **");
            foreach (var item in cart.Items)
            {
                double itemTotal = item.Product.Price * item.Quantity;
                Console.WriteLine($"{item.Quantity}x {item.Product.Name} {itemTotal}");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Subtotal {subtotal}");
            Console.WriteLine($"Shipping {shipping}");
            Console.WriteLine($"Amount {total}");
            Console.WriteLine($"Customer Remaining Balance {remainingBalance}");
        }
    }
}
