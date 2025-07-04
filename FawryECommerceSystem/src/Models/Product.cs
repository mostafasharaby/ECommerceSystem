namespace FawryECommerceSystem.src.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int QuantityAvailable { get; set; }

        public Product(string name, double price, int quantityAvailable)
        {
            Name = name;
            Price = price;
            QuantityAvailable = quantityAvailable;
        }

        public virtual bool IsExpired() => false;
    }
}
