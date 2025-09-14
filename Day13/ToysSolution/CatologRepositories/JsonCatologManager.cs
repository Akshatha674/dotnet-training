namespace CatologRepositories;
using System.IO;
using System.Text.Json; 
using CatologEntities;

public static class JsonCatologManager
{
    public static string GetJsonFilePath()
        => Path.Combine(AppContext.BaseDirectory, "Data", "Product.json");
    public static List<Product> LoadProducts()
    {
        var filePath = GetJsonFilePath();
        if (!File.Exists(filePath))
        {
            return new List<Product>();
        }

        var jsonData = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Product>>(jsonData) ?? new List<Product>();
    }
    
    public static void SaveProducts(List<Product> products)
    {
        var filePath = GetJsonFilePath();
        var jsonData = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonData);
    }
}