using CoreApi.Platform.Domain.Constants;
using CoreApi.Platform.Domain.Models;

namespace CoreApi.Platform.Logic.Factories
{
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(VehicleType vehicleType);
    }
}
