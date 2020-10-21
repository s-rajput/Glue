using Gluh.TechnicalTest.Data;
using Gluh.TechnicalTest.Interfaces;
using Gluh.TechnicalTest.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Linq;

namespace Glue.TechnicalTest.Tests
{
    [TestClass]
    public class PurchaserTests
    {
        Context _context;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            DataGenerator.Initialize(DependencyInjection.Container());

        }

        [TestInitialize()]
        public void Initialize()
        {
            _context = DependencyInjection.Container().GetService<Context>();
        }


        [TestMethod()]
        public void PurchaseRequirements_Created_Yesterday_Test()
        {

            ////Assemble
            var Yesterday = DateTime.Now.AddDays(-1);
            var ToDay = DateTime.Today;
          

            // Arrange
            var mockService = Substitute.For<Purchaser>(_context);

            /////Act
            var purchases = mockService.  GetCurrentPurchaseRequirements();

            ////Assert
            Assert.IsTrue(purchases.All(req => req.Created >= Yesterday && req.Created < ToDay));
        }

        [TestMethod()]
        public void One_Purchase_Order_Per_Supplier_Test()
        {

            ////Assemble
            var MaxOrderPerSupplier = 1;

            // Arrange
            var mockService = Substitute.For<Purchaser>(_context);

            /////Act
            var purchases = mockService.GetCurrentPurchaseRequirements();
            var orders = mockService.Optimize(purchases);
            var InValidSellers  = orders.GroupBy(x => x.Supplier).Where(g => g.Count() > MaxOrderPerSupplier);

            ////Assert
            Assert.IsNotNull(purchases);
            Assert.AreEqual(InValidSellers.Count(), 0);
        }

        [TestMethod()]
        public void Verify_NetCost_Test()
        {
            // Arrange
            var mockService = Substitute.For<Purchaser>(_context);

            /////Act
            var purchases = mockService.GetCurrentPurchaseRequirements();
            var orders = mockService.Optimize(purchases);

            ////Assert
            Assert.IsNotNull(purchases);
            Assert.IsTrue(orders.All(req => req.Total == req.Shipping + req.SubTotal)); 
        }

    }

    internal class DependencyInjection
    {
        /// <summary>
        /// container to register dependencies
        /// </summary> 
        /// <returns>Service provider</returns>
        public static ServiceProvider Container()
        {

            var serviceProvider = new ServiceCollection()
               .AddDbContext<Context>(o => o.UseInMemoryDatabase(databaseName: "Optimizer3000"))
               .AddSingleton<IPurchaseOptimizer, Purchaser>()
               .BuildServiceProvider();

            //register services here
            return serviceProvider;

        }
    }
}