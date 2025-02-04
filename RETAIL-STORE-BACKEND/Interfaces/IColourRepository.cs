using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Interfaces
{
    public interface IColourRepository
    {
        Task<Colour> AddColour(Colour colour);

        Task<ICollection<Colour>> GetAllColours();

        Task<Colour> GetColourById(int id);

        Task<Colour> GetColourByName(string name);
    }
}
