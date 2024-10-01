using CoreApi.Platform.Domain.Models;
using CoreApi.Platform.Domain.Constants;
using CoreApi.Platform.Logic.Factories;
using CoreApi.Platform.Logic.Services;
using CoreApi.Platform.Logic.Providers;

namespace CoreApi.Platform.Logic.Managers
{
    public class ResponseManager(IVehicleFactory vehicleFactory, IIpAddressProvider ipAddressProvider, IApplicationSettingsService applicationSettingsService) : IResponseManager
    {
        public BasicResponse GetBasicResponse(string? queryValue = null) => new()
        {
            RequestId = Guid.NewGuid(),
            ResponseTime = DateTime.UtcNow,
            Birthday = applicationSettingsService.GetBirthday(ApplicationSettingsType.Basic)?.ToString(),
            FavoriteFood = applicationSettingsService.GetFavoriteFood(ApplicationSettingsType.Basic)?.Name,
            QueryValue = queryValue
        };

        public ComplexResponse GetComplexResponse(string? vehicleType = null) => new()
        {
            RequestId = Guid.NewGuid(),
            ResponseTime = DateTime.UtcNow,
            IpAddress = ipAddressProvider.GetPublicIpAddress().ToString(),
            Colors = [ColorConstants.Red, ColorConstants.Blue],
            Vehicle = GetVehicle(vehicleType),
            HostName = applicationSettingsService.GetHostName(),
            Birthday = applicationSettingsService.GetBirthday(ApplicationSettingsType.Complex) ?? DateTime.MinValue,
            FavoriteFood = applicationSettingsService.GetFavoriteFood(ApplicationSettingsType.Complex)
        };

        private Vehicle GetVehicle(string? vehicleType = null)
        {
            if (string.Equals(vehicleType, "boat", StringComparison.OrdinalIgnoreCase))
            {
                return vehicleFactory.CreateVehicle(VehicleType.Boat);
            }

            if (string.Equals(vehicleType, "car", StringComparison.OrdinalIgnoreCase))
            {
                return vehicleFactory.CreateVehicle(VehicleType.Car);
            }

            return vehicleFactory.CreateVehicle(VehicleType.Bicycle);
        }
    }
}
