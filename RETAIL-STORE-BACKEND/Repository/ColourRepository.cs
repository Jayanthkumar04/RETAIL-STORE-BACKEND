using Microsoft.EntityFrameworkCore;
using RETAIL_STORE_BACKEND.Data;
using RETAIL_STORE_BACKEND.Interfaces;
using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Repository
{
    public class ColourRepository(AppDbContext _context) : IColourRepository
    {
        public async Task<Colour> AddColour(Colour colour)
        {
            var result = await _context.Colours.AddAsync(colour);

            await _context.SaveChangesAsync();

            return colour;
        }

        public async Task<ICollection<Colour>> GetAllColours()
        {
            var result = await _context.Colours.ToListAsync();

            return result;
        }

        public async Task<Colour> GetColourById(int id)
        {
            var result = await _context.Colours.FindAsync(id);
            return result;
        }

        public async Task<Colour> GetColourByName(string name)
        {
            var result = await _context.Colours.FirstOrDefaultAsync(x => x.Shade == name);

            return result;
        }
    }
}
