using RETAIL_STORE_BACKEND.Interfaces;
using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Task<Product> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Product>> GetProductsByBrand(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Product>> GetProductsByCategory(string name)
        {
            throw new NotImplementedException();
        }
    }
}
