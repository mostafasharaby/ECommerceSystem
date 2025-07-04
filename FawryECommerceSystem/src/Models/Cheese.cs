using FawryECommerceSystem.src.Interfaces;

namespace FawryECommerceSystem.src.Models
{
    public class Cheese : ExpirableProduct, IShippable
    {
        public double Weight { get; set; }

        public Cheese(string name, double price, int quantity, DateTime expiry, double weight) : base(name, price, quantity, expiry)
        {
            Weight = weight;
        }

        public string GetName() => Name;
        public double GetWeight() => Weight;
    }
}
