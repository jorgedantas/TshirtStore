using System;
using System.Collections.Generic;
using System.Linq;
using TshirtStore.Domain.Enums;

namespace TshirtStore.Domain.Entities
{
    public class Order
    {
        private IList<OrderItem> _orderItems; 

        public Order(IList<OrderItem> orderItems, int userId )
        {
            this.Date = DateTime.Now;
            this._orderItems = new List<OrderItem>();
            orderItems.ToList().ForEach(x => AddItem(x));
            this.UserId = userId;
            this.Status = EOrderStatus.Created;
        }

        public int Id { get; private set; }
        public DateTime Date { get; private set; }

        public IEnumerable<OrderItem> OrderItem
        {
            get { return _orderItems; }
            private set { _orderItems = new List<OrderItem>();}
        }

        public int UserId { get; private set; }
        public User User { get; private set; }

        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (var item in _orderItems)
                    total += (item.Price*item.Quantity);
                
                return total;
                
            }
        }

        public EOrderStatus Status { get; private set; }
        public void AddItem(OrderItem item)
        {
            
            
            //Error : Problema Interrupção da Execução
            //if (item == null)
            //{
            //    throw  new Exception("Item Inválido");
            //}
            //if (item.Price <= 0)
            //{
            //    throw new Exception("Item Inválido");
            //}
            //if (item.Quantity <= 0)
            //{
            //    throw new Exception("Item Inválido");
            //}
            //_orderItems.Add(item);
        }
    }

   
}
