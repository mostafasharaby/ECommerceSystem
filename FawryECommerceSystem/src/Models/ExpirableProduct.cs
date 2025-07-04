namespace FawryECommerceSystem.src.Models
{
    public class ExpirableProduct : Product
    {
        public DateTime ExpiryDate { get; set; }

        public ExpirableProduct(string name, double price, int quantityAvailable, DateTime expiryDate) : base(name, price, quantityAvailable)
        {
            ExpiryDate = expiryDate;
        }

        public override bool IsExpired() => DateTime.Now > ExpiryDate;
    }
}
