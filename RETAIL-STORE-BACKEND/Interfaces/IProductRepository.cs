using Microsoft.AspNetCore.Mvc;
using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Interfaces
{
    public interface IProductRepository
    {
       Task<Product> AddProduct(Product product);

        Task<ICollection<Product>> GetAllProducts();

        Task<Product> GetProductById(int id);

        Task<ICollection<Product>> GetProductsByCategory(string name);

        Task<ICollection<Product>> GetProductsByBrand(string name);
    }
}
