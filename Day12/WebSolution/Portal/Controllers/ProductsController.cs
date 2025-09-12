using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 10.99m, Description = "Description for Product 1", ImageUrl="https://via.placeholder.com/150" },
            new Product { Id = 2, Name = "Product 2", Price = 20.99m, Description = "Description for Product 2", ImageUrl="https://via.placeholder.com/150" },
            new Product { Id = 3, Name = "Product 3", Price = 30.99m, Description = "Description for Product 3", ImageUrl="https://via.placeholder.com/150" }
        };
       return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = new Product { Id = id, Name = $"Product {id}", Price = 10.99m * id, Description = $"Description for Product {id}", ImageUrl="https://via.placeholder.com/150" };
        return View(product);
    }
}