using ParkNow.DataAccess;

namespace ParkNow.Application
{
    public class VehicleService
    {
        private readonly Repository<Vehicle> _vehiclesRepository;

        public VehicleService(Repository<Vehicle> vehiclesRepository = null)
        {
            _vehiclesRepository = vehiclesRepository ?? new ParkNowRepo<Vehicle>();
        }

        public Vehicle InsertVehicle(Vehicle vehicle)
        {
            return _vehiclesRepository.Insert(vehicle);
        }
    }
}
