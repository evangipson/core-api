using CoreApi.Platform.Domain.Constants;
using CoreApi.Platform.Domain.Models;

namespace CoreApi.Platform.Logic.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle(VehicleType vehicleType)
        {
            if(vehicleType is VehicleType.Boat)
            {
                return CreateBoat();
            }

            if(vehicleType is VehicleType.Car)
            {
                return CreateCar();
            }

            return CreateBicycle();
        }

        private static Boat CreateBoat() => new()
        {
            NumberOfWheels = 0,
            NeedsFuel = true,
            HasEngine = true,
            TopSpeed = 50,
            Manufacturer = $"{nameof(VehicleType.Boat)} Manufacturer",
            Type = nameof(VehicleType.Boat)
        };

        private static Car CreateCar() => new()
        {
            NumberOfWheels = 4,
            NeedsFuel = true,
            HasEngine = true,
            TopSpeed = 120,
            Manufacturer = $"{nameof(VehicleType.Car)} Manufacturer",
            HasLeatherSeats = true,
            MilesPerGallon = 25,
            Type = nameof(VehicleType.Car)
        };

        private static Bicycle CreateBicycle() => new()
        {
            NumberOfWheels = 2,
            NeedsFuel = false,
            HasEngine = false,
            TopSpeed = 20,
            Manufacturer = $"{nameof(VehicleType.Bicycle)} Manufacturer",
            Type = nameof(VehicleType.Bicycle)
        };
    }
}
