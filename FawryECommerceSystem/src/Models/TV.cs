using FawryECommerceSystem.src.Interfaces;

namespace FawryECommerceSystem.src.Models
{
    public class TV : Product, IShippable
    {
        public double Weight { get; set; }

        public TV(string name, double price, int quantity, double weight) : base(name, price, quantity)
        {
            Weight = weight;
        }

        public string GetName() => Name;
        public double GetWeight() => Weight;
    }
}
