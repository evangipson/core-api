namespace CoreApi.Platform.Domain.Models
{
    public class ComplexResponse : Response
    {
        public string? IpAddress { get; set; }

        public IEnumerable<Color>? Colors { get; set; }

        public Vehicle? Vehicle { get; set; }

        public Food? FavoriteFood { get; set; }

        public Uri? HostName { get; set; }

        public DateTime Birthday { get; set; }
    }
}
