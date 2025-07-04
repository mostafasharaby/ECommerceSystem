using FawryECommerceSystem.src.Models;

namespace FawryECommerceSystem.src.Services
{
    public class Cart
    {
        public List<CartItem> Items { get; } = new();

        public void AddProduct(Product product, int quantity)
        {
            if (quantity > product.QuantityAvailable)
            {
                Console.WriteLine($"Error: Not enough stock for {product.Name}");
                return;
            }
            Items.Add(new CartItem(product, quantity));
        }
    }
}
