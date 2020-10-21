using Gluh.TechnicalTest.Data.Entities;

namespace Gluh.TechnicalTest.Models
{
    public class OrderLine
    {
        /// <summary>
        /// Product to order
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Quantity of products being ordered
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Unit price of product being ordered
        /// </summary>
        public decimal Price { get; set; }

    }
}