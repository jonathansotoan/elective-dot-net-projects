using ParkNow.DataAccess;
using System;

namespace ParkNow.Application
{
    public class ParkingService
    {
        private readonly Repository<Parking> _parkingsRepository;
        private readonly UserService _userService;

        public ParkingService(Repository<Parking> parkingsRepository = null)
        {
            _parkingsRepository = parkingsRepository ?? new ParkNowRepo<Parking>();
            _userService = new UserService();
        }

        public Parking InsertParking(Parking parking)
        {
            if (parking.Vehicle == null && parking.VehiclePlate == string.Empty)
            {
                throw new InvalidOperationException("You cannot insert a parking without a vehicle");
            }

            parking.UserNationalId = _userService.GetLoggedUser().NationalId;
            return _parkingsRepository.Insert(parking);
        }
    }
}
