using System;
using System.Linq.Expressions;
using TshirtStore.Domain.Entities;
using TshirtStore.Domain.Enums;

namespace TshirtStore.Domain.Specs
{
   public static class OrderSpecs
    {
        public static Expression<Func<Order, bool>> GetCreatedOrders(string email)
        {
           return x => x.User.Email == email && x.Status == EOrderStatus.Created;
        }

        public static Expression<Func<Order, bool>> GetPaidOrders(string email)
        {
            return x => x.User.Email == email && x.Status == EOrderStatus.Paid;
        }

        public static Expression<Func<Order, bool>> GetDeliveredOrders(string email)
        {
            return x => x.User.Email == email && x.Status == EOrderStatus.Delivered;
        }

        public static Expression<Func<Order, bool>> GetCancelOrders(string email)
        {
            return x => x.User.Email == email && x.Status == EOrderStatus.Canceled;
        }

        public static Expression<Func<Order, bool>> GetDetails(int id,string email)
        {
            return x => x.User.Email == email && x.Id == id;
        }

        public static Expression<Func<Order, bool>> GetOrdersFromUser(string email)
        {
            return x => x.User.Email == email;
        }
    }
}
