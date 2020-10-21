using System;
using System.Collections.Generic;
using System.Linq;
using Gluh.TechnicalTest.Interfaces;
using Gluh.TechnicalTest.Models;

namespace Gluh.TechnicalTest
{
    public class Optimizer3000
    {
        // Fields

        private readonly IPurchaseOptimizer _purchaseOptimizer;

        // Constructors

        public Optimizer3000(IPurchaseOptimizer purchaseOptimizer) => _purchaseOptimizer = purchaseOptimizer;

        // Public

        public void Run()
        {
            var purchaseRequirements = _purchaseOptimizer.GetCurrentPurchaseRequirements();

            var purchaseOrders = _purchaseOptimizer.Optimize(purchaseRequirements);

            WriteToConsole(purchaseOrders);
        }

        // Private

        /// <summary>
        /// Write Results to Console
        /// </summary>
        private static void WriteToConsole(IEnumerable<PurchaseOrder> purchaseOrders)
        {
            Console.WriteLine("Optimized Purchase Order Results:");
            foreach (var purchaseOrder in purchaseOrders)
            {
                Console.WriteLine($"\nSupplier: {purchaseOrder.Supplier.Name}");
                Console.WriteLine("Items:");
                purchaseOrder.OrderLines.ForEach(
                    line =>
                        Console.WriteLine($"{line.Quantity} X [{line.Product.ID}] {line.Product.Name} @ {line.Price:C}"));
                Console.WriteLine($"SubTotal: {purchaseOrder.SubTotal:C}");
                Console.WriteLine($"Shipping: {purchaseOrder.Shipping:C}");
                Console.WriteLine($"   Total: {purchaseOrder.Total:C}\n");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nAll ({purchaseOrders.Count()}) Orders Total: {purchaseOrders.Sum(x => x.Total):C}");
        }
    }
}