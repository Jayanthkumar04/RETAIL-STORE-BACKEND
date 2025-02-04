using RETAIL_STORE_BACKEND.Interfaces;
using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Repository
{
    public class PowerRepository : IPowerRepository
    {
        public Task<Power> AddPower(Power power)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Power>> GetAllPowers()
        {
            throw new NotImplementedException();
        }

        public Task<Power> GetPowerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Power> GetPowerByRating(string name)
        {
            throw new NotImplementedException();
        }
    }
}
