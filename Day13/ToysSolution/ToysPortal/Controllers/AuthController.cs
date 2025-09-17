namespace ToysPortal.Controllers;

using CatologEntities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using System.IO;
using File = System.IO.File;
public class AuthController : Controller
{
    // public static string CustomersFilePath =>
    //     Path.Combine(AppContext.BaseDirectory, "Data", "customers.json");
    private readonly string _customersFilePath;
 public AuthController(IWebHostEnvironment env)
        {
            _customersFilePath = Path.Combine(env.ContentRootPath, "Data", "customers.json");
        }


    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var customers = new List<Customers>();
         if (System.IO.File.Exists(_customersFilePath))
        {
            var json = System.IO.File.ReadAllText(_customersFilePath    );
            if (!string.IsNullOrWhiteSpace(json))
                customers = JsonSerializer.Deserialize<List<Customers>>(json) ?? new List<Customers>();
        }
        foreach (var customer in customers)
        {
            if (customer.Email == email && customer.Password == password)
            {
                this.Response.Redirect("/Products/Index");
            }
        }
        return View();
    }
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(string firstName, string lastName, string email, string password)
    {
        var customers = new List<Customers>();
        if (System.IO.File.Exists(_customersFilePath))
        {
            var json = System.IO.File.ReadAllText(_customersFilePath);
            if (!string.IsNullOrWhiteSpace(json))
                customers = JsonSerializer.Deserialize<List<Customers>>(json) ?? new List<Customers>();
        }

        customers.Add(new Customers
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        });
        Directory.CreateDirectory(Path.GetDirectoryName(_customersFilePath)!);
        var outJson = JsonSerializer.Serialize(customers);
        System.IO.File.WriteAllText(_customersFilePath, outJson);
        return RedirectToAction("Login", "Auth");
    }
}
