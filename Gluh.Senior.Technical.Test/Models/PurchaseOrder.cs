using System.Collections.Generic;
using Gluh.TechnicalTest.Data.Entities;

namespace Gluh.TechnicalTest.Models
{
    public class PurchaseOrder
    {
        /// <summary>
        /// Supplier this purchase order will purchase from
        /// </summary>
        public Supplier Supplier { get; set; }

        /// <summary>
        /// Lines of products & their quantities & price to order
        /// </summary>
        public List<OrderLine> OrderLines { get; set; }

        /// <summary>
        /// Sum of all order lines ex-shipping
        /// </summary>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Sum of all shipping costs
        /// </summary>
        public decimal Shipping { get; set; }

        /// <summary>
        /// Sum of purchase order
        /// </summary>
        public decimal Total { get; set; }
    }
}
