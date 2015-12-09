using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TshirtStore.Domain.Commands.ProductCommands
{
    public class CreateProductCommand
    {
        public CreateProductCommand(string title,string description, decimal price,int quantityOnhand,int categoryid)
        {
            this.Title = title;
            this.Description = description;
            this.Price = price;
            this.QuantityOnHand = quantityOnhand;
            this.CategoryId = categoryid;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityOnHand { get; set; }
        public int CategoryId { get; set; }
    }
}
