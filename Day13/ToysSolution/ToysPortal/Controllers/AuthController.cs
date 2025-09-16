namespace ToysPortal.Controllers;

using CatologEntities;
using CatologServices;
using Microsoft.AspNetCore.Mvc;
public class AuthController : Controller
{


    public AuthController()
    {

    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
     [HttpPost]
    public IActionResult Login(string email, string password)
    {
        if(email == "akshathashetty@gmail.com" && password == "Password@123")
        {
            this.Response.Redirect("/Products/Index");
        }
       return View(); 
    }

    public IActionResult Register()
    {
        return View();
    }
}
