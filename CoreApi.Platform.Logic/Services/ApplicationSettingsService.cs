using Microsoft.Extensions.Options;

using CoreApi.Platform.Domain.ApplicationSettings;
using CoreApi.Platform.Domain.Models;
using CoreApi.Platform.Domain.Constants;

namespace CoreApi.Platform.Logic.Services
{
    public class ApplicationSettingsService(IOptions<BasicApplicationSettings> basicApplicationSettings, IOptions<ComplexApplicationSettings> complexApplicationSettings) : IApplicationSettingsService
    {
        private BasicApplicationSettings? _basicApplicationSettings;

        private ComplexApplicationSettings? _complexApplicationSettings;

        private BasicApplicationSettings BasicApplicationSettings => _basicApplicationSettings
            ?? basicApplicationSettings.Value
            ?? throw new InvalidOperationException($"{nameof(ApplicationSettingsService)}: '{nameof(BasicApplicationSettings)}' not defined in the application settings.");

        private ComplexApplicationSettings ComplexApplicationSettings => _complexApplicationSettings
            ?? complexApplicationSettings.Value
            ?? throw new InvalidOperationException($"{nameof(ApplicationSettingsService)}: '{nameof(ComplexApplicationSettings)}' not defined in the application settings.");

        public Food? GetFavoriteFood(ApplicationSettingsType applicationSettingsType)
        {
            if(applicationSettingsType is ApplicationSettingsType.Complex)
            {
                return ComplexApplicationSettings.Favorites?.Food;
            }

            if(string.IsNullOrEmpty(BasicApplicationSettings["FavoriteFood"]))
            {
                return null;
            }

            return new()
            {
                Name = BasicApplicationSettings["FavoriteFood"]
            };
        }

        public DateTime? GetBirthday(ApplicationSettingsType applicationSettingsType)
        {
            if (applicationSettingsType is ApplicationSettingsType.Complex)
            {
                return ComplexApplicationSettings.Birthday;
            }

            if (!DateTime.TryParse(BasicApplicationSettings["Birthday"], out DateTime birthday))
            {
                return null;
            }

            return birthday;
        }

        public Uri? GetHostName() => ComplexApplicationSettings.HostName;
    }
}
