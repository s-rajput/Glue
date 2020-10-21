using System.Collections.Generic;
using Gluh.TechnicalTest.Data.Entities;
using Gluh.TechnicalTest.Models;

namespace Gluh.TechnicalTest.Interfaces
{
    public interface IPurchaseOptimizer
    {
        /// <summary>
        /// The current PurchaseRequirements to be purchased (these are all requirements created 'yesterday')
        /// </summary>
        public IEnumerable<PurchaseRequirement> GetCurrentPurchaseRequirements();

        /// <summary>
        /// Calculates the optimal set of supplier to purchase products from
        /// </summary>
        public IEnumerable<PurchaseOrder> Optimize(IEnumerable<PurchaseRequirement> purchaseRequirements);
    }
}
