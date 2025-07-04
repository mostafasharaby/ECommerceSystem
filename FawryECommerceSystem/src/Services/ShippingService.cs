using FawryECommerceSystem.src.Interfaces;

namespace FawryECommerceSystem.src.Services
{
    public static class ShippingService
    {
        public static void Ship(List<IShippable> items)
        {
            Console.WriteLine("\n** Shipment notice **");
            var groupedItems = items.GroupBy(i => i.GetName());
            double totalWeight = 0;

            foreach (var group in groupedItems)
            {
                var item = group.First();
                double weight = item.GetWeight();
                int count = group.Count();
                Console.WriteLine($"{count}x {item.GetName()} {weight * count * 1000}g");
                totalWeight += weight * count;
            }
            Console.WriteLine($"Total package weight {totalWeight}kg\n");
        }
    }
}
