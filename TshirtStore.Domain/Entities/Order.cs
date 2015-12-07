using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TshirtStore.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            this.OrderItem = new List<OrderItem>();
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }

   
}
