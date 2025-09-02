var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.MapGet("/hello", () =>
{
    return "Hello world";
});
app.MapGet("/api/products", () =>
{
    return new[]
        {
        new { Id =2 ,Name = "Tv",Price = 10.00 }
    };

});