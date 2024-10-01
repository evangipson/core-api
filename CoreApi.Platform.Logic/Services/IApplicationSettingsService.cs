using CoreApi.Platform.Domain.Constants;
using CoreApi.Platform.Domain.Models;

namespace CoreApi.Platform.Logic.Services
{
    public interface IApplicationSettingsService
    {
        Food? GetFavoriteFood(ApplicationSettingsType applicationSettingsType);

        DateTime? GetBirthday(ApplicationSettingsType applicationSettingsType);

        Uri? GetHostName();
    }
}
