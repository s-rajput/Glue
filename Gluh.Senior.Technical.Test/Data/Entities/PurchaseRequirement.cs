using System;

namespace Gluh.TechnicalTest.Data.Entities
{
    public class PurchaseRequirement
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Required quantity of product
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// ID of the product to purchase
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Miscellaneous Notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Created Timestamp
        /// </summary>
        public DateTime Created { get; set; }
    }
}