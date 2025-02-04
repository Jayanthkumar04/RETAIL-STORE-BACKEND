using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RETAIL_STORE_BACKEND.Models
{
    public class Product
    {
        
        public int? Id { get; set; }
        public string? Name { get; set; }

        public string? Brand { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public float? Price { get; set; }

        //public int ColourId { get; set; }

        //public Colour Colour { get; set; }

        //public int PowerId { get; set; }

        //public Power Power { get; set; }

        public ICollection<ProductColours>? ProCol { get; set; } = new List<ProductColours>();

        public ICollection<ProductPowers>? ProPow { get; set; } = new List<ProductPowers>();
    }
}
