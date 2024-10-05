namespace CoreApi.Platform.Domain.DTOs
{
    public class UserSystemAddress
    {
        public string? Street { get; set; }

        public string? Suite { get; set; }

        public string? City { get; set; }

        public string? ZipCode { get; set; }

        public UserSystemCoordinates? Geo { get; set; }
    }
}
