using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parqueadero
{
    class Vehiculo
    {
        public string TipoVehiculo { get; set; }
        public int CantidadHoras { get; set; }
        public string NombreCliente { get; set; }
        public string Identificacion { get; set; }
        public string Placa { get; set; }
        public int TarifaVehiculo
        {
            get
            {
                return TipoVehiculo == "Carro" ? 3000 : 1500;
            }
        }

        public override string ToString()
        {
            return string.Format("--------- Vehículo ---------\nTipo: {0}\nCantidad de horas: {1}\n" +
                "Placa: {2}\nTarifa: {3}\nNombre del cliente: {4}\nIdentificación: {5}",
                TipoVehiculo, CantidadHoras, Placa, TarifaVehiculo, NombreCliente, Identificacion);
        }
    }
}
