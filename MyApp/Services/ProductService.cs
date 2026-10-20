using MyApp.Models;
using System;

namespace MyApp.Services;

class ProductService
{
    public void DisplayProduct(Product product)
    {
        Console.WriteLine($"Name : { product.Name}");
        Console.WriteLine($"Price : { product.Price}");
    }
}