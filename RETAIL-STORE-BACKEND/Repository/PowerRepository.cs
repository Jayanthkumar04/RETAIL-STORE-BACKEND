using Microsoft.EntityFrameworkCore;
using RETAIL_STORE_BACKEND.Data;
using RETAIL_STORE_BACKEND.Interfaces;
using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Repository
{
    public class PowerRepository(AppDbContext _context) : IPowerRepository
    {
        public async Task<Power> AddPower(Power power)
        {
            await _context.Powers.AddAsync(power);

            await _context.SaveChangesAsync();

            return power;
        }

        public async Task<ICollection<Power>> GetAllPowers()
        {
            var result = await _context.Powers.ToListAsync();

            return result;
        }

        public async Task<Power> GetPowerById(int id)
        {
            var result = await _context.Powers.FindAsync(id);

            return result;
        }

        public async Task<Power> GetPowerByRating(string name)
        {
            var result = await _context.Powers.FirstOrDefaultAsync(x => x.Rating == name);

            return result;
        }
    }
}
