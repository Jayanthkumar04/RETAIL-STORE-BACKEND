using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Interfaces
{
    public interface IPowerRepository
    {
        Task<Power> AddPower(Power power);

        Task<ICollection<Power>> GetAllPowers();

        Task<Power> GetPowerById(int id);

        Task<Power> GetPowerByRating(string name);
    }
}
