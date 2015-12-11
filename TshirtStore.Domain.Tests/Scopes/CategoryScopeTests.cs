using Microsoft.VisualStudio.TestTools.UnitTesting;
using TshirtStore.Domain.Entities;
using TshirtStore.Domain.Scopes;

namespace TshirtStore.Domain.Tests.Scopes
{
    /// <summary>
    /// Summary description for CategoryScopeTests
    /// </summary>
    [TestClass]
    public class CategoryScopeTests
    {
 

        [TestMethod]
        [TestCategory("Category")]
        public void ShouldRegisterCategory()
        {
            var category = new Category("Desenvolvedor");
            category.Register();

            Assert.AreEqual(true,CategoryScopes.CreateCategoryScopeIsValid(category));
        }

        [TestMethod]
        [TestCategory("Category")]
        public void ShouldUpdateCategory()
        {
            var category = new Category("Desenvolvedor");
            category.Register();

            Assert.AreEqual(true, CategoryScopes.UpdateCategoryScopeIsValid(category));
        }
    }
}
