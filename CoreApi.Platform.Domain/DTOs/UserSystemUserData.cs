namespace CoreApi.Platform.Domain.DTOs
{
    public class UserSystemUserData
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; }

        public UserSystemAddress? Address { get; set; }

        public string? Phone { get; set; }

        public Uri? Website { get; set; }

        public UserSystemCompany? Company { get; set; }
    }
}
