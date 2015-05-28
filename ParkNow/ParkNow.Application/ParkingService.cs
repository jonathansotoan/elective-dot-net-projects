namespace ParkNow.Application
{
    using ParkNow.DataAccess;
    using System;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// The service that operates the inputs and outputs of vehicles to the parking
    /// </summary>
    /// <!-- Author: Jonathan Soto<theja29@hotmail.com>. For licensing, e-mail me -->
    public class ParkingService
    {
        private readonly Repository<Parking> _parkingsRepository;
        private readonly UserService _userService;

        public ParkingService(Repository<Parking> parkingsRepository = null)
        {
            _parkingsRepository = parkingsRepository ?? new ParkNowRepo<Parking>();
            _userService = DependenciesContainer.UserService;
        }

        public IQueryable<Parking> GetParkings(string includeProperties = "")
        {
            return _parkingsRepository.Get(includeProperties);
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

        public void OpenReportBetween(DateTime startDate, DateTime endDate)
        {
            var reportBody = new StringBuilder();

            GetParkings("User, Vehicle").Where(parking =>
                (parking.InDate >= startDate && parking.InDate <= endDate)
                || (parking.OutDate >= startDate && parking.OutDate <= endDate)).ToList().ForEach(parking =>
                reportBody.Append("\n\n--- Report ---\n")
                .Append("\nId:                  ").Append(parking.Id)
                .Append("\nPlate:               ").Append(parking.VehiclePlate)
                .Append("\nEmployee:            ").Append(parking.User)
                .Append("\nEntrance time:       ").Append(parking.InDate)
                .Append("\nOutput time:         ").Append(parking.OutDate == null ? "Still inside" : parking.OutDate.ToString())
                .Append("\nTotal time:          ").Append(parking.TotalTime)
                .Append("\nCost:                ").Append(parking.Cost));

            new PdfService().OpenPdfReport("ReportByDates - " + DateTime.Now + ".pdf", "Report by dates", reportBody.ToString());
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
            var reportBody = new StringBuilder()
                .Append("\nId:                  ").Append(parking.Id)
                .Append("\nType:                ").Append(parking.Vehicle.GetType().Name.Split('_').First())
                .Append("\nPlate:               ").Append(parking.VehiclePlate)
                .Append("\nEmployee:            ").Append(parking.User)
                .Append("\nEntrance time:       ").Append(parking.InDate)
                .Append("\nOutput time:         ").Append(parking.OutDate)
                .Append("\nTotal time:          ").Append(parking.TotalTime)
                .Append("\nTotal money:         ").Append(parking.Cost);

            new PdfService().OpenPdfReport("OutputReport" + parking.Id + ".pdf", "Output Report of vehicle with plate " + parking.VehiclePlate, reportBody.ToString());
        }
    }
}
