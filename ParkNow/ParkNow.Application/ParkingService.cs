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

        public Parking OperateParking(string vehiclePlate)
        {
            if (vehiclePlate == null && vehiclePlate == string.Empty)
            {
                throw new InvalidOperationException("You cannot operate a parking without a valid vehicle plate");
            }

            Parking attachedParking =
                _parkingsRepository.Get("User")
                    .FirstOrDefault(
                        parkingLinq => parkingLinq.VehiclePlate == vehiclePlate && parkingLinq.OutDate == null);

            if (attachedParking == null)
            {
                attachedParking = new Parking
                {
                    InDate = DateTime.Now,
                    UserNationalId = _userService.GetLoggedUser().NationalId,
                    Vehicle = new VehicleService().GetByPlateOrCreate(vehiclePlate)
                };

                _parkingsRepository.Insert(attachedParking);
                Parking insertedParking =
                    _parkingsRepository.Get("User").First(parkingLinq => attachedParking.Id == parkingLinq.Id);
                OpenEntranceReport(insertedParking);

                return insertedParking;
            }

            attachedParking.OutDate = DateTime.Now;
            _parkingsRepository.Update(attachedParking);
            OpenOutputReport(attachedParking);

            return attachedParking;
        }


        private void OpenEntranceReport(Parking parking)
        {
            var reportBody = new StringBuilder()
                .Append("\nId:                  ").Append(parking.Id)
                .Append("\nPlate:               ").Append(parking.VehiclePlate)
                .Append("\nEmployee:            ").Append(parking.User)
                .Append("\nEntrance time:       ").Append(parking.InDate);

            new PdfService().OpenPdfReport("EntranceReport" + parking.Id + ".pdf", "Entrance Report of vehicle with plate " + parking.VehiclePlate, reportBody.ToString());
        }

        private void OpenOutputReport(Parking parking)
        {
            TimeSpan? parkingTime = parking.OutDate - parking.InDate;

            var reportBody = new StringBuilder()
                .Append("\nId:                  ").Append(parking.Id)
                .Append("\nType:                ").Append(parking.Vehicle.GetType().Name.Split('_').First())
                .Append("\nPlate:               ").Append(parking.VehiclePlate)
                .Append("\nEmployee:            ").Append(parking.User)
                .Append("\nEntrance time:       ").Append(parking.InDate)
                .Append("\nOutput time:         ").Append(parking.OutDate)
                .Append("\nTotal time:          ").Append(parkingTime)
                .Append("\nTotal money:         ").Append(parking.Vehicle.HourPrice * (decimal) Math.Ceiling(parkingTime.Value.TotalHours));

            new PdfService().OpenPdfReport("OutputReport" + parking.Id + ".pdf", "Output Report of vehicle with plate " + parking.VehiclePlate, reportBody.ToString());
        }
    }
}
