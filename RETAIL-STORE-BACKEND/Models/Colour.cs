namespace RETAIL_STORE_BACKEND.Models
{
    public class Colour
    {
        public int? Id { get; set; }
        public string? Shade { get; set; }

        public ICollection<ProductColours>? ProCol { get; set; } = new List<ProductColours>();
    }
}
