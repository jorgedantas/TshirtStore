using System;
using System.Collections.Generic;
using System.Linq;
using TshirtStore.Domain.Enums;
using TshirtStore.Domain.Scopes;
using TshirtStore.SharedKernel.Events;
using TshirtStore.SharedKernel.Validation;

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

        public ICollection<OrderItem> OrderItem
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
            //AssertionConcern.AssertLength("123456", 2, 5, "Minimo 2 caracteres");
            if (item.Register())
                _orderItems.Add(item);
            // Sem utilizar AssertionConcern
            // if (item.Price <= 0)
            //    new DomainNotification("Price", "Preço deve ser maior que zero!");


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

        public void Place()
        {
            if (!this.PlaceOrderScopeIsValid())
                return;
        }


        public void MarkAsPaid()
        {

            this.Status = EOrderStatus.Paid;
        }

        public void MarkAsDelivered()
        {

            this.Status = EOrderStatus.Delivered;
        }

        public void Cancel()
        {
            this.Status = EOrderStatus.Canceled;
        }
    }

   
}
