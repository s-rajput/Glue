namespace Gluh.TechnicalTest.Data.Entities
{
    public class Stock
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Product represented by this object relates to
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Supplier of the stock
        /// </summary>
        public Supplier Supplier { get; set; }

        /// <summary>
        /// Total units of stock on hand available
        /// </summary>
        public int? StockOnHand { get; set; }

        /// <summary>
        /// Cost per unit
        /// </summary>
        public decimal Cost { get; set; }
    }
}