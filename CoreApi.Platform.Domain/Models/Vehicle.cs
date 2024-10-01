namespace CoreApi.Platform.Domain.Models
{
    public abstract class Vehicle
    {
        public string? Manufacturer { get; set; }

        public int NumberOfWheels { get; set; }

        public float TopSpeed { get; set; }

        public DateTime Year { get; set; }

        public string? Color { get; set; }

        public bool NeedsFuel { get; set; }

        public bool HasEngine { get; set; }

        public string? Type { get; set; }
    }
}
