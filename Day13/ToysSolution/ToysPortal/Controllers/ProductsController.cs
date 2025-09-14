namespace ToysPortal.Controllers;

using CatologEntities;
using CatologServices;
using Microsoft.AspNetCore.Mvc;
public class ProductsController : Controller
{

    
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }
    public IActionResult Index()
    {
        var products = _productService.GetAllProducts();
         Console.WriteLine($"Products count: {products.Count()}");

        return View(products);
    }
    public IActionResult Details(int id)
    {
        var product = _productService.GetProductById(id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }
}