using TshirtStore.Domain.Scopes;

namespace TshirtStore.Domain.Entities
{
    public class Product
    {
        public Product(string title, string description, decimal price, int quantityOnHand,int category)
        {
            this.Title = title;
            this.Description = description;
            this.Price = price;
            this.QuantityOnhand = quantityOnHand;
            this.CategotyId = category;
        }
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOnhand { get; private set; }
        public int CategotyId { get; private set; }
        public Category Category { get; private set; }

        public void UpdateQuantityOnHand(int amount)
        {
            if (!this.UpdateQuantityOnHandScopeIsValid(amount))
                return;
            this.QuantityOnhand = amount;
        }

        public void Register()
        {
            this.RegisterProductScopeIsValid();
            
        }

        //public void UpdatePrice(decimal price)
        //{
        //    if (!this.UpdatePriceScopeIsValid)
        //        return;
        //    this.QuantityOnhand = amount;
        //}
        public void Updateprice(decimal price)
        {
            if (!this.UpdatePriceScopeIsValid(price))
                return;

            this.Price = price;
        
        }

        public void UpdateInfo(string title, string description, int category)
        {
            if (!this.UpdateInfoScopeIsValid(title, description, category))
                return;

            this.Title = title;
            this.Description = description;
            this.CategotyId = category;
        }
    }
}
