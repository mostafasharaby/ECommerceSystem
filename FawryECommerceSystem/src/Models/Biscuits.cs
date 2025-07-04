namespace FawryECommerceSystem.src.Models
{
    public class Biscuits : ExpirableProduct, IShippable
    {
        public double Weight { get; set; }

        public Biscuits(string name, double price, int quantity, DateTime expiry, double weight) : base(name, price, quantity, expiry)
        {
            Weight = weight;
        }

        public string GetName() => Name;
        public double GetWeight() => Weight;
    }
}
