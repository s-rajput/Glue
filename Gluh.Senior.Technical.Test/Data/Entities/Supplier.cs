namespace Gluh.TechnicalTest.Data.Entities
{
    public class Supplier
    {
        public int ID { get; set; }

        /// <summary>
        /// name of supplier
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Freight/Shipping Rate to charge per CubicWeight
        /// </summary>
        public decimal CubicRate { get; set; }
    }
}