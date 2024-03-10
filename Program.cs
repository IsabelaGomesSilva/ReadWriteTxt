
// See https://aka.ms/new-console-template for more information

using ReadWriteTxt.Models;
using ReadWriteTxt.Read;
using ReadWriteTxt.Write;

Product[] products =
        [
            new Product { Id = 1, Description = "Smartphone", Amount = 50, Price = 1200 },
            new Product { Id = 2, Description = "Laptop", Amount = 20, Price = 2500 },
            new Product { Id = 3, Description = "Tablet", Amount = 30, Price = 800 },
            new Product { Id = 4, Description = "ram memory", Amount = 40, Price = 656 },
            new Product { Id = 5, Description = "External hd", Amount = 35, Price = 800 },
            new Product { Id = 6, Description = "Mouse", Amount = 24, Price = 600 },
            new Product { Id = 7, Description = "Mouse pad", Amount = 67, Price = 900 },
            new Product { Id = 8, Description = "Monitor", Amount = 33, Price = 1000 },
            new Product { Id = 9, Description = "Keyboards", Amount = 77, Price = 200 },
            new Product { Id = 10, Description = "Headset", Amount = 90, Price = 350 },
        ];
ReadTxt readTxt = new();
WriteTxt writeTxt = new();
Console.WriteLine("Add products to the table:");
writeTxt.Write(products);
Console.WriteLine("Read the file: ");
readTxt.Read();