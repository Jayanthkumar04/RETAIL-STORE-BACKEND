using Microsoft.EntityFrameworkCore;
using RETAIL_STORE_BACKEND.Data;
using RETAIL_STORE_BACKEND.Interfaces;
using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Repository
{
    public class ProductRepository(AppDbContext _context) : IProductRepository
    {
        public async Task<Product> AddProduct(Product product)
        {

            var result = await _context.Products.AddAsync(product);

            await _context.SaveChangesAsync();

            return product;


        }

        //public async Task<Product> DeleteProduct(int id)
        //{
        //    var product = await _context.Products.FindAsync(id);

        //    var result = await _context.Products.RemoveAsync(product);
        //}

        public async Task<ICollection<Product>> GetAllProducts()
        {

            var result = await _context.Products.ToListAsync();

            return result;
        
        }

        public async Task<Product> GetProductById(int id)
        {
            var result = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<ICollection<Product>> GetProductsByBrand(string name)
        {
            var result = await _context.Products.Where(x => x.Brand == name).ToListAsync();

            return result;
        }

        public async Task<ICollection<Product>> GetProductsByCategory(string name)
        {
            var result = await _context.Products.Where(x => x.Category == name).ToListAsync();

            return result;
        }
    }
}
