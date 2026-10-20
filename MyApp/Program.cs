using System;
using MyApp.Models;
using MyApp.Services;

Product product = new Product
{
    Name = "Iphone",
    Price = 1500m
};


ProductService productService = new ProductService();

productService.DisplayProduct(product);

