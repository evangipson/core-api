namespace CoreApi.Platform.Domain.Models
{
    /// <summary>
    /// A domain representation of the <see cref="DTOs.UserSystemUserData"/> DTO.
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? Street { get; set; }

        public string? Suite { get; set; }

        public string? City { get; set; }

        public string? ZipCode { get; set; }

        public float? Latitude { get; set; }

        public float? Longitude { get; set; }

        public string? Phone { get; set; }

        public Uri? Website { get; set; }

        public string? CompanyName { get; set; }
    }
}
