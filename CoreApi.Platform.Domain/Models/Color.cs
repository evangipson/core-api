namespace CoreApi.Platform.Domain.Models
{
    public class Color
    {
        public string? Name { get; set; }

        public string? Hex { get; set; }

        public IEnumerable<float>? RGB { get; set; }
    }
}
