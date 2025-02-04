using RETAIL_STORE_BACKEND.Interfaces;
using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Repository
{
    public class ColourRepository : IColourRepository
    {
        public Task<Colour> AddColour(Colour colour)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Colour>> GetAllColours()
        {
            throw new NotImplementedException();
        }

        public Task<Colour> GetColourById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Colour> GetColourByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
