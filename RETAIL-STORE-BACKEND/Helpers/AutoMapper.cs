using AutoMapper;
using RETAIL_STORE_BACKEND.DTO;
using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Helpers
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<Power, PowerDto>();

            CreateMap<Colour, ColourDto>();
            
        }
    }
}
