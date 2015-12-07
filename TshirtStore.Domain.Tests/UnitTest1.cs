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

            // Erro : Private on Model Title
            //category.Title = "";
        }
    }
}
