using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalApp
{
    class Eps
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public decimal DeudaActual { get; set; }
        public int CantidadPacientesAtendidos { get; set; }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Dirección: {1}, DeudaActual: {2}, Cantidad de pacientes atendidos: {3}",
                Nombre, Direccion, DeudaActual, CantidadPacientesAtendidos);
        }
    }
}
