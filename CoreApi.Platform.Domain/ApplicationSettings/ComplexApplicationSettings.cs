using CoreApi.Platform.Domain.Models;

namespace CoreApi.Platform.Domain.ApplicationSettings
{
    public class ComplexApplicationSettings
    {
        public Uri? HostName { get; set; }

        public DateTime Birthday { get; set; }

        public Favorites? Favorites { get; set; }

        public bool ShowFavoriteFood { get; set; }
    }
}
