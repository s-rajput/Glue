using Gluh.TechnicalTest.Data;
using Gluh.TechnicalTest.Data.Entities;
using Gluh.TechnicalTest.Interfaces;
using Gluh.TechnicalTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

//for unit testing
[assembly: InternalsVisibleTo("Glue.TechnicalTest.Tests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Gluh.TechnicalTest.Services
{
    /// <summary>
    /// Implementation of purchase optimiser
    /// </summary>
    internal class Purchaser : IPurchaseOptimizer
    {
        private Context _context;

        /// <summary>
        /// constructor injection
        /// </summary> 
        public Purchaser(Context context)
        {
            _context = context;

        }

        #region PUBLIC
        /// <summary>
        /// The current PurchaseRequirements to be purchased (these are all requirements created 'yesterday')
        /// </summary>
        /// <returns>set of purchase requirements</returns>
        public IEnumerable<PurchaseRequirement> GetCurrentPurchaseRequirements()
        {
            //return all purchase requirements created 'yesterday'.
            return (from req in _context.PurchaseRequirements.AsEnumerable()
                    where req.Quantity > 0 && req.Created >= DateTime.Now.AddDays(-1) && req.Created < DateTime.Today
                    select req);
        }

        /// <summary>
        /// Calculates the optimal set of supplier to purchase products from
        /// </summary>
        /// <returns>set of purchase orders</returns>
       public  IEnumerable<PurchaseOrder> Optimize(IEnumerable<PurchaseRequirement> purchaseRequirements)
        {
            var ProductsToPurchase = from SupplierRqs in purchaseRequirements 
                                         where SupplierRqs.Quantity > 0
                                         group SupplierRqs by new { SupplierRqs.ProductID } into SupplierProductRqs
                                     select new
                                     {
                                         ProductID = SupplierProductRqs.Key.ProductID,
                                         Quantity = SupplierProductRqs.Sum(x => x.Quantity)
                                     };

            var stocks = GetStockItems();

            //‘Optimal’ in this case means the lowest calculated cost of suppliers capable of fulfilling the stock required.
            var cheapestSuppliers = from stock in stocks
                                         group stock by new { stock.Product } into g
                                   let MinCost = g.Min(x => x.Cost)
                                   select new
                                   {
                                       CheapestPrice =  g.Min(x => x.Cost),
                                       Product = g.Key.Product,
                                       Supplier = g.Where(X=> X.Cost == MinCost).Select(y=>y.Supplier).FirstOrDefault()
                                   };

        

            return
                        from supplier in cheapestSuppliers
                                 group supplier by new { supplier.Supplier } into g //Only 1 purchase order per supplier may be created.
                        let Orders = (from Prod in ProductsToPurchase
                                      from cheapProd in cheapestSuppliers
                                            where cheapProd.Supplier == g.Key.Supplier && Prod.ProductID == cheapProd.Product.ID
                                      select new OrderLine
                                      {
                                          Product = cheapProd.Product,
                                          Quantity = Prod.Quantity,
                                          Price = cheapProd.CheapestPrice
                                      }).ToList()
                        let SubTotal = Orders.Sum(x => x.Price * x.Quantity)
                        let Shipping = Orders.Sum(x => x.Quantity * decimal.Multiply(x.Product.CubicWeight.GetValueOrDefault(), g.Key.Supplier.CubicRate))
                        where Orders.Count() > 0
                        select new PurchaseOrder
                        {
                            Supplier = g.First().Supplier,
                            OrderLines = Orders,
                            Shipping = Shipping,
                            SubTotal = SubTotal,
                            Total = SubTotal + Shipping
                        };

        }


        #endregion

        #region PRIVATE

        /// <summary>
        /// Get the stock items from inventory
        /// </summary>
        /// <returns>collection of stock</returns>
        IEnumerable<Stock> GetStockItems()
        {
            return  _context.Stocks.Include(lu => lu.Supplier).Include(lu => lu.Product).AsEnumerable();
        }


        #endregion

    }
}
