using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using System.Text.Json;
using System.IO;
using File = System.IO.File;

namespace Portal.Controllers;

public class CustomersController : Controller
{
    private readonly ILogger<CustomersController> _logger;

    public CustomersController(ILogger<CustomersController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Charlie", Email="charlie@gmail.com", Phone="5555555555", Address="789 Oak St" },
            new Customer { Id = 2, Name = "Alice", Email="jnbn@g.com", Phone="1234567890", Address="123 Main St" },
        new Customer { Id = 3, Name = "Sky", Email="Sky@gmail.com", Phone="8787897987", Address="105         Pine St" },
            new Customer { Id = 4, Name = "Bob", Email="bob@gmail.com", Phone="0987654321", Address="456 Elm St" },
           new Customer { Id = 5, Name = "Diana", Email="Daina@gmail.com", Phone="2223334444", Address="101 Pine St" }
        };
        customers.Sort((c1, c2) => c1.Name.CompareTo(c2.Name));
        string serializedData = JsonSerializer.Serialize(customers);
        Console.WriteLine($"Serialized Customer: {serializedData}");
      System.IO.File.WriteAllText("customersList.json", serializedData);

        return View(customers);
    }
    

    
}