namespace Gluh.TechnicalTest.Data.Entities
{
    public class Product
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of product
        /// </summary>
        public ProductType Type { get; set; }

        /// <summary>
        /// Cubic weight per unit of product
        /// </summary>
        public decimal? CubicWeight { get; set; }
    }

    /// <summary>
    /// Product Type
    /// </summary>
    public enum ProductType
    {
        Physical,
        NonPhysical,
        Service
    }
}