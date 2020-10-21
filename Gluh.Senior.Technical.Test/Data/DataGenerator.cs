using System;
using Gluh.TechnicalTest.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Gluh.TechnicalTest.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>());
            context.Products.AddRange(
                new Product
                {
                    ID = 1001,
                    Name = "512GB AData M2 NVME SSD - Retail Pack",
                    Type = ProductType.Physical,
                    CubicWeight = 0.35m
                },
                new Product
                {
                    ID = 1002,
                    Name = "Luxe 13 Notebook Bag BLUE",
                    Type = ProductType.Physical,
                    CubicWeight = 4.3m
                },
                new Product
                {
                    ID = 1003,
                    Name = "Luxe 13 Notebook Bag RED",
                    Type = ProductType.Physical,
                    CubicWeight = 4.31m
                },
                new Product
                {
                    ID = 1004,
                    Name = "Symantec Antivius Pro Plus Corporate Edition",
                    Type = ProductType.NonPhysical,
                    CubicWeight = 1m
                },
                new Product
                {
                    ID = 1005,
                    Name = "OEM 18RU Rack Black - w/ Lock, Pedestal",
                    Type = ProductType.Physical,
                    CubicWeight = 46.50m
                },
                new Product
                {
                    ID = 1006,
                    Name = "OEM 48RU Rack Black - w/ Lock, Pedestal",
                    Type = ProductType.Physical,
                    CubicWeight = 102.15m
                },
                new Product
                {
                    ID = 1007,
                    Name = "40mm * 5mm 11 Blade Silent Fan 3pin",
                    Type = ProductType.Physical,
                    CubicWeight = 0.1m
                },
                new Product
                {
                    ID = 1008,
                    Name = "HP 32\" LCD LED Professional Series Monitor",
                    Type = ProductType.Physical,
                    CubicWeight = 11.4m
                },
                new Product
                {
                    ID = 1009,
                    Name = "Microsoft Office 365 Business Premium",
                    Type = ProductType.NonPhysical,
                    CubicWeight = default
                },
                new Product
                {
                    ID = 1010,
                    Name = "Lenovo X1 Carbon Laptop",
                    Type = ProductType.Physical,
                    CubicWeight = 7.65m
                },
                new Product
                {
                    ID = 1011,
                    Name = "Google Pixel 4a Handset",
                    Type = ProductType.Physical,
                    CubicWeight = 1m
                },
                new Product
                {
                    ID = 1012,
                    Name = "Cherry WASD replacement set - MX Brown",
                    Type = ProductType.Physical,
                    CubicWeight = 0.2m
                },
                new Product
                {
                    ID = 1013,
                    Name = "C9200L DNA Essentials License",
                    Type = ProductType.NonPhysical,
                    CubicWeight = 0m
                },
                new Product
                {
                    ID = 1014,
                    Name = "256GB AData M2 NVME SSD - Retail Pack",
                    Type = ProductType.Physical,
                    CubicWeight = 0.35m
                },
                new Product
                {
                    ID = 1015,
                    Name = "Office Chair Black",
                    Type = ProductType.Physical,
                    CubicWeight = 66m
                }
            );

            context.SaveChanges();

            context.Suppliers.AddRange(
                new Supplier
                {
                    ID = 1,
                    Name = "IngramMicro",
                    CubicRate = 1.40m
                },
                new Supplier
                {
                    ID = 2,
                    Name = "AData International",
                    CubicRate = 2.75m
                },
                new Supplier
                {
                    ID = 3,
                    Name = "TechData",
                    CubicRate = 1.45m
                },
                new Supplier
                {
                    ID = 4,
                    Name = "Tech 7",
                    CubicRate = 0.55m
                },
                new Supplier
                {
                    ID = 5,
                    Name = "Vince Co",
                    CubicRate = 0.95m
                },
                new Supplier
                {
                    ID = 6,
                    Name = "CN Licensing",
                    CubicRate = 9.95m
                },
                new Supplier
                {
                    ID = 7,
                    Name = "Multimedia Technology",
                    CubicRate = 1.45m
                },
                new Supplier
                {
                    ID = 8,
                    Name = "J Wholesale",
                    CubicRate = 1.30m
                }
            );
            context.SaveChanges();

            context.Stocks.AddRange(
                new Stock
                {
                    ID = 1,
                    Product = context.Products.Find(1001),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 303,
                    Cost = 271.55m
                },
                new Stock
                {
                    ID = 2,
                    Product = context.Products.Find(1001),
                    Supplier = context.Suppliers.Find(2),
                    StockOnHand = 1240,
                    Cost = 250.50m
                },
                new Stock
                {
                    ID = 3,
                    Product = context.Products.Find(1001),
                    Supplier = context.Suppliers.Find(5),
                    StockOnHand = 70,
                    Cost = 260.75m
                },
                new Stock
                {
                    ID = 4,
                    Product = context.Products.Find(1001),
                    Supplier = context.Suppliers.Find(8),
                    StockOnHand = 42,
                    Cost = 254.80m
                },
                new Stock
                {
                    ID = 5,
                    Product = context.Products.Find(1001),
                    Supplier = context.Suppliers.Find(7),
                    StockOnHand = 3,
                    Cost = 270.10m
                },
                new Stock
                {
                    ID = 6,
                    Product = context.Products.Find(1002),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 2,
                    Cost = 67.50m
                },
                new Stock
                {
                    ID = 7,
                    Product = context.Products.Find(1002),
                    Supplier = context.Suppliers.Find(3),
                    StockOnHand = 2,
                    Cost = 66.50m
                },
                new Stock
                {
                    ID = 8,
                    Product = context.Products.Find(1002),
                    Supplier = context.Suppliers.Find(7),
                    StockOnHand = 30,
                    Cost = 80.0m
                },
                new Stock
                {
                    ID = 9,
                    Product = context.Products.Find(1002),
                    Supplier = context.Suppliers.Find(8),
                    StockOnHand = 2,
                    Cost = 50.54m
                },
                new Stock
                {
                    ID = 10,
                    Product = context.Products.Find(1003),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 1,
                    Cost = 67.50m
                },
                new Stock
                {
                    ID = 11,
                    Product = context.Products.Find(1003),
                    Supplier = context.Suppliers.Find(3),
                    StockOnHand = 3,
                    Cost = 66.50m
                },
                new Stock
                {
                    ID = 12,
                    Product = context.Products.Find(1003),
                    Supplier = context.Suppliers.Find(7),
                    StockOnHand = 25,
                    Cost = 79.90m
                },
                new Stock
                {
                    ID = 13,
                    Product = context.Products.Find(1004),
                    Supplier = context.Suppliers.Find(6),
                    StockOnHand = 1000,
                    Cost = 91.40m
                },
                new Stock
                {
                    ID = 14,
                    Product = context.Products.Find(1004),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 15,
                    Cost = 95.10m
                },
                new Stock
                {
                    ID = 15,
                    Product = context.Products.Find(1004),
                    Supplier = context.Suppliers.Find(3),
                    StockOnHand = 30,
                    Cost = 92.35m
                },
                new Stock
                {
                    ID = 16,
                    Product = context.Products.Find(1005),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 2,
                    Cost = 410m
                },
                new Stock
                {
                    ID = 17,
                    Product = context.Products.Find(1005),
                    Supplier = context.Suppliers.Find(5),
                    StockOnHand = 3,
                    Cost = 435m
                },
                new Stock
                {
                    ID = 18,
                    Product = context.Products.Find(1005),
                    Supplier = context.Suppliers.Find(4),
                    StockOnHand = 22,
                    Cost = 440m
                },
                new Stock
                {
                    ID = 19,
                    Product = context.Products.Find(1006),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 0,
                    Cost = 770m
                },
                new Stock
                {
                    ID = 20,
                    Product = context.Products.Find(1006),
                    Supplier = context.Suppliers.Find(5),
                    StockOnHand = 12,
                    Cost = 905m
                },
                new Stock
                {
                    ID = 21,
                    Product = context.Products.Find(1006),
                    Supplier = context.Suppliers.Find(4),
                    StockOnHand = 10,
                    Cost = 928m
                },
                new Stock
                {
                    ID = 22,
                    Product = context.Products.Find(1007),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 40,
                    Cost = 4.10m
                },
                new Stock
                {
                    ID = 23,
                    Product = context.Products.Find(1007),
                    Supplier = context.Suppliers.Find(2),
                    StockOnHand = 20,
                    Cost = 4.35m
                },
                new Stock
                {
                    ID = 24,
                    Product = context.Products.Find(1007),
                    Supplier = context.Suppliers.Find(3),
                    StockOnHand = 25,
                    Cost = 4.65m
                },
                new Stock
                {
                    ID = 25,
                    Product = context.Products.Find(1007),
                    Supplier = context.Suppliers.Find(4),
                    StockOnHand = 30,
                    Cost = 4.70m
                },
                new Stock
                {
                    ID = 26,
                    Product = context.Products.Find(1007),
                    Supplier = context.Suppliers.Find(5),
                    StockOnHand = 18,
                    Cost = 7.20m
                },
                new Stock
                {
                    ID = 27,
                    Product = context.Products.Find(1007),
                    Supplier = context.Suppliers.Find(6),
                    StockOnHand = 10,
                    Cost = 5.15m
                },
                new Stock
                {
                    ID = 28,
                    Product = context.Products.Find(1007),
                    Supplier = context.Suppliers.Find(7),
                    StockOnHand = 26,
                    Cost = 4.92m
                },
                new Stock
                {
                    ID = 29,
                    Product = context.Products.Find(1007),
                    Supplier = context.Suppliers.Find(8),
                    StockOnHand = 102,
                    Cost = 5.55m
                },
                new Stock
                {
                    ID = 30,
                    Product = context.Products.Find(1008),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 16,
                    Cost = 311.60m
                },
                new Stock
                {
                    ID = 31,
                    Product = context.Products.Find(1008),
                    Supplier = context.Suppliers.Find(3),
                    StockOnHand = 11,
                    Cost = 299.10m
                },
                new Stock
                {
                    ID = 32,
                    Product = context.Products.Find(1008),
                    Supplier = context.Suppliers.Find(7),
                    StockOnHand = 8,
                    Cost = 303.80m
                },
                new Stock
                {
                    ID = 33,
                    Product = context.Products.Find(1008),
                    Supplier = context.Suppliers.Find(4),
                    StockOnHand = 24,
                    Cost = 344.50m
                },
                new Stock
                {
                    ID = 34,
                    Product = context.Products.Find(1008),
                    Supplier = context.Suppliers.Find(8),
                    StockOnHand = 32,
                    Cost = 316.60m
                },
                new Stock
                {
                    ID = 35,
                    Product = context.Products.Find(1009),
                    Supplier = context.Suppliers.Find(3),
                    StockOnHand = 32,
                    Cost = 403m
                },
                new Stock
                {
                    ID = 36,
                    Product = context.Products.Find(1009),
                    Supplier = context.Suppliers.Find(6),
                    StockOnHand = 32,
                    Cost = 402m
                },
                new Stock
                {
                    ID = 37,
                    Product = context.Products.Find(1009),
                    Supplier = context.Suppliers.Find(7),
                    StockOnHand = 32,
                    Cost = 404m
                },
                new Stock
                {
                    ID = 38,
                    Product = context.Products.Find(1009),
                    Supplier = context.Suppliers.Find(4),
                    StockOnHand = 40,
                    Cost = 407m
                },
                new Stock
                {
                    ID = 39,
                    Product = context.Products.Find(1009),
                    Supplier = context.Suppliers.Find(8),
                    StockOnHand = 30,
                    Cost = 415m
                },
                new Stock
                {
                    ID = 40,
                    Product = context.Products.Find(1010),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 26,
                    Cost = 2740m
                },
                new Stock
                {
                    ID = 41,
                    Product = context.Products.Find(1010),
                    Supplier = context.Suppliers.Find(7),
                    StockOnHand = 6,
                    Cost = 2738m
                },
                new Stock
                {
                    ID = 42,
                    Product = context.Products.Find(1010),
                    Supplier = context.Suppliers.Find(3),
                    StockOnHand = 5,
                    Cost = 2725m
                },
                new Stock
                {
                    ID = 43,
                    Product = context.Products.Find(1010),
                    Supplier = context.Suppliers.Find(8),
                    StockOnHand = 12,
                    Cost = 2810m
                },
                new Stock
                {
                    ID = 44,
                    Product = context.Products.Find(1010),
                    Supplier = context.Suppliers.Find(5),
                    StockOnHand = 1,
                    Cost = 2755.80m
                },
                new Stock
                {
                    ID = 45,
                    Product = context.Products.Find(1011),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 3,
                    Cost = 555.05m
                },
                new Stock
                {
                    ID = 46,
                    Product = context.Products.Find(1011),
                    Supplier = context.Suppliers.Find(5),
                    StockOnHand = 5,
                    Cost = 556.95m
                },
                new Stock
                {
                    ID = 47,
                    Product = context.Products.Find(1011),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = 3,
                    Cost = 555.00m
                },
                new Stock
                {
                    ID = 48,
                    Product = context.Products.Find(1012),
                    Supplier = context.Suppliers.Find(3),
                    StockOnHand = 2,
                    Cost = 7.66m
                },
                new Stock
                {
                    ID = 49,
                    Product = context.Products.Find(1012),
                    Supplier = context.Suppliers.Find(4),
                    StockOnHand = 2,
                    Cost = 7.95m
                },
                new Stock
                {
                    ID = 50,
                    Product = context.Products.Find(1013),
                    Supplier = context.Suppliers.Find(7),
                    StockOnHand = 999,
                    Cost = 3225.88m
                }, 
                new Stock
                {
                    ID = 51,
                    Product = context.Products.Find(1013),
                    Supplier = context.Suppliers.Find(6),
                    StockOnHand = 9999,
                    Cost = 3225.00m
                },
                new Stock
                {
                    ID = 53,
                    Product = context.Products.Find(1013),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = default,
                    Cost = 3220.00m
                },
                new Stock
                {
                    ID = 54,
                    Product = context.Products.Find(1014),
                    Supplier = context.Suppliers.Find(2),
                    StockOnHand = 105,
                    Cost = 121.00m
                },
                new Stock
                {
                    ID = 55,
                    Product = context.Products.Find(1014),
                    Supplier = context.Suppliers.Find(1),
                    StockOnHand = default,
                    Cost = 121.00m
                },
                new Stock
                {
                    ID = 56,
                    Product = context.Products.Find(1014),
                    Supplier = context.Suppliers.Find(3),
                    StockOnHand = 24,
                    Cost = 124.10m
                },
                new Stock
                {
                    ID = 57,
                    Product = context.Products.Find(1014),
                    Supplier = context.Suppliers.Find(4),
                    StockOnHand = 18,
                    Cost = 125.90m
                },
                new Stock
                {
                    ID = 58,
                    Product = context.Products.Find(1014),
                    Supplier = context.Suppliers.Find(5),
                    StockOnHand = 10,
                    Cost = 125.00m
                },
                new Stock
                {
                    ID = 59,
                    Product = context.Products.Find(1014),
                    Supplier = context.Suppliers.Find(7),
                    StockOnHand = 5,
                    Cost = 125.00m
                },
                new Stock
                {
                    ID = 60,
                    Product = context.Products.Find(1014),
                    Supplier = context.Suppliers.Find(8),
                    StockOnHand = 5,
                    Cost = 124.80m
                },
                new Stock
                {
                    ID = 61,
                    Product = context.Products.Find(1015),
                    Supplier = context.Suppliers.Find(8),
                    StockOnHand = 15,
                    Cost = 120.33m
                },
                new Stock
                {
                    ID = 62,
                    Product = context.Products.Find(1015),
                    Supplier = context.Suppliers.Find(4),
                    StockOnHand = 2,
                    Cost = 155.80m
                }
                );
            context.SaveChanges();

            context.PurchaseRequirements.AddRange(
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1001,
                    Created = DateTime.Today.Add(new TimeSpan(-2,16,1,1))
                },
                new PurchaseRequirement
                {
                    Quantity = 3,
                    ProductID = 1001,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 11, 51, 33))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1001,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 12, 1, 1))
                },
                new PurchaseRequirement
                {
                    Quantity = 10,
                    ProductID = 1001,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 14, 15, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1001,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 15, 1, 1))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1001,
                    Created = DateTime.Today.Add(new TimeSpan(0, 9, 1, 1))
                },
                new PurchaseRequirement
                {
                    Quantity = 2,
                    ProductID = 1002,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 23, 59, 30))
                },
                new PurchaseRequirement
                {
                    Quantity = 6,
                    ProductID = 1002,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 12, 0, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 6,
                    ProductID = 1003,
                    Created = DateTime.Today.Add(new TimeSpan(0, 9, 0, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 5,
                    ProductID = 1003,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 12, 0, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1004,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 13, 5, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 5,
                    ProductID = 1004,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 13, 10, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 5,
                    ProductID = 1004,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 16, 59, 59))
                },
                new PurchaseRequirement
                {
                    Quantity = 3,
                    ProductID = 1004,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 14, 15, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 3,
                    ProductID = 1004,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 15, 25, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 4,
                    ProductID = 1004,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 15, 30, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 2,
                    ProductID = 1004,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 15, 30, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1004,
                    Created = DateTime.Today.Add(new TimeSpan(-0, 0, 5, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 2,
                    ProductID = 1005,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 9, 15, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 8,
                    ProductID = 1005,
                    Created = DateTime.Today.Add(new TimeSpan(0, 9, 15, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1006,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 9, 15, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1006,
                    Created = DateTime.Today.Add(new TimeSpan(-3, 9, 15, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1006,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 9, 15, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1006,
                    Created = DateTime.Today.Add(new TimeSpan(0, 9, 15, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1007,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 15, 45, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 10,
                    ProductID = 1007,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 20, 50, 35))
                },
                new PurchaseRequirement
                {
                    Quantity = 2,
                    ProductID = 1007,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 22, 45, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 6,
                    ProductID = 1008,
                    Created = DateTime.Today.Add(new TimeSpan(-7, 22, 45, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 2,
                    ProductID = 1008,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 16, 57, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 16,
                    ProductID = 1008,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 23, 22, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 7,
                    ProductID = 1009,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 23, 22, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 11,
                    ProductID = 1010,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 23, 24, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1011,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 23, 24, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 3,
                    ProductID = 1011,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 23, 24, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 3,
                    ProductID = 1011,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 18, 18, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 2,
                    ProductID = 1011,
                    Created = DateTime.Today.Add(new TimeSpan(0, 1, 1, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1011,
                    Created = DateTime.Today.Add(new TimeSpan(0, 1, 2, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 4,
                    ProductID = 1012,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 17, 30, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1013,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 13, 44, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1014,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 13, 44, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 1,
                    ProductID = 1014,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 11, 40, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 2,
                    ProductID = 1014,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 12, 45, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 2,
                    ProductID = 1014,
                    Created = DateTime.Today.Add(new TimeSpan(-2, 23, 45, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 3,
                    ProductID = 1014,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 2, 02, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 3,
                    ProductID = 1015,
                    Created = DateTime.Today.Add(new TimeSpan(-1, 2, 02, 0))
                },
                new PurchaseRequirement
                {
                    Quantity = 3,
                    ProductID = 1015,
                    Created = DateTime.Today.Add(new TimeSpan(0, 2, 15, 0))
                }
            );
            context.SaveChanges();
        }
    }
}