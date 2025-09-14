namespace CatologRepositories;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using CatologEntities;

public class ProductRepository: IProductRepository 
{

   
    public IEnumerable<Product> GetAllProducts()
    {
        return JsonCatologManager.LoadProducts();
    }

    public Product? GetProductById(int id)
    {
        IEnumerable<Product> products = GetAllProducts();
        foreach (var product in products)
        {
            if (product.Id == id)
            {
                return product;
            }
        }
        return null;
    }

    public void AddProduct(Product product)
    {
        var products = JsonCatologManager.LoadProducts();
        products.Add(product);
        JsonCatologManager.SaveProducts(products);
        
    }

    public void UpdateProduct(Product product)
    {
        var products = JsonCatologManager.LoadProducts();
        var existingProduct = products.Find(p => p.Id == product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.Stock = product.Stock;
            JsonCatologManager.SaveProducts(products);
        }
       
    }

    public void DeleteProduct(int id)
    {
        var products = JsonCatologManager.LoadProducts();
        var productToRemove = products.Find(p => p.Id == id);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            JsonCatologManager.SaveProducts(products);
        }
    }   
}