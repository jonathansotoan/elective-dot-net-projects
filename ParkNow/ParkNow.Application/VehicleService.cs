namespace ParkNow.Application
{
    using DataAccess;
    using System.Text.RegularExpressions;

    public class VehicleService
    {
        private readonly Repository<Vehicle> _vehiclesRepository;

        public VehicleService(Repository<Vehicle> vehiclesRepository = null)
        {
            _vehiclesRepository = vehiclesRepository ?? new ParkNowRepo<Vehicle>();
        }

        public Vehicle GetByPlateOrCreate(string plate)
        {
            Vehicle vehicle = _vehiclesRepository.GetById(plate);

            if (vehicle != null)
            {
                return vehicle;
            }

            if (Regex.IsMatch(plate, "[A-Z]{3}[0-9]{3}"))
            {
                vehicle = new Car { Plate = plate };
            }
            else if(Regex.IsMatch(plate, "[A-Z]{3}[0-9]{2}[A-D]"))
            {
                vehicle = new Motorcicle { Plate = plate };
            }

            return vehicle;
        }

        public Vehicle InsertVehicle(Vehicle vehicle)
        {
            return _vehiclesRepository.Insert(vehicle);
        }
    }
}
