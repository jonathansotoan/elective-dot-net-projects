namespace ParkNow.Application
{
    using ParkNow.DataAccess;
    using System;
    using System.Linq;
    using System.Text;

    public class ParkingService
    {
        private readonly Repository<Parking> _parkingsRepository;
        private readonly UserService _userService;

        public ParkingService(Repository<Parking> parkingsRepository = null)
        {
            _parkingsRepository = parkingsRepository ?? new ParkNowRepo<Parking>();
            _userService = DependenciesContainer.UserService;
        }

        public Parking InsertParking(Parking parking)
        {
            if (parking.Vehicle == null && parking.VehiclePlate == string.Empty)
            {
                throw new InvalidOperationException("You cannot insert a parking without a valid vehicle");
            }

            parking.InDate = DateTime.Now;
            parking.UserNationalId = _userService.GetLoggedUser().NationalId;

            _parkingsRepository.Insert(parking);
            Parking insertedParking = _parkingsRepository.Get("User").First(parkingLinq => parking.Id == parkingLinq.Id);
            OpenEntranceReport(insertedParking);
            
            return insertedParking;
        }


        private void OpenEntranceReport(Parking parking)
        {
            var reportBody = new StringBuilder()
                .Append("\nId:            ").Append(parking.Id)
                .Append("\nEntrance time: ").Append(parking.InDate)
                .Append("\nPlate:         ").Append(parking.VehiclePlate)
                .Append("\nEmployee:      ").Append(parking.User);

            new PdfService().OpenPdfReport("EntranceReport" + parking.Id + ".pdf", "Entrance Report of parking " + parking.Id, reportBody.ToString());
        }
    }
}
