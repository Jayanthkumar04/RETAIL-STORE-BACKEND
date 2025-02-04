namespace RETAIL_STORE_BACKEND.Models
{
    public class Power
    {
        public int? Id { get; set; }
        public string? Rating { get; set; }

        public ICollection<ProductPowers>? ProPow { get; set; } = new List<ProductPowers>();
    }
}
