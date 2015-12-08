using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var category = new Category("Desenvolvimento");
            var product = new Product("Camisa", "Estampa 01", 100,10,1);

            var order = new Order(new List<OrderItem>(),1 );

            var orderItem = new OrderItem(1,20);

            order.AddItem(orderItem);
            //Erro : IEnumerator não existe o metodo ADD
            //order.OrderItem.Add(orderItem);

            Assert.AreNotEqual(0,order.OrderItem);
            // Erro : Private on Model Title
            //category.Title = "";
        }
    }
}
