using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ambulancia ambulanciaUrgencias = new Ambulancia();
            ambulanciaUrgencias.DescripcionDotacion = "Extintor, camilla, zuero y anestesia";
            ambulanciaUrgencias.Matricula = "OEQ351";
            ambulanciaUrgencias.estaOcupada = false;
            ambulanciaUrgencias.FechaUltimoMantenimiento = new DateTime(2014, 3, 23);

            Eps sura = new Eps();
            sura.Nombre = "Sura";
            sura.Direccion = "Cl industriales";
            sura.DeudaActual = 36000000;
            sura.CantidadPacientesAtendidos = 46;

            Especialidad cirugia = new Especialidad();
            cirugia.Nombre = "Cirugía";
            cirugia.Descripcion = "Lugar dónde se hacen intervenciones quirurgicas a los pacientes";
            cirugia.Piso = 3;

            Medicamento dolex = new Medicamento
            {
                Nombre = "dolex",
                Uso = "1 vez cada 2 horas",
                Contraindicaciones = "No se permite para mujeres embarazadas",
                MiligramosMaximos = 300
            };

            Hospital unidadIntermedia = new Hospital();
            unidadIntermedia.Nombre = "Unidad Itermedia";
            unidadIntermedia.Direccion = "Cl falsa N 43";
            unidadIntermedia.Nit = "234-4523476-1";
            unidadIntermedia.Especialidades.Add(cirugia);

            Console.WriteLine(string.Format(
                "Ambulancia: {0}\nEps: {1}\nEspecialidad: {2}\nMedicamento: {3}\nHospital: {4}",
                ambulanciaUrgencias, sura, cirugia, dolex, unidadIntermedia
            ));
            Console.WriteLine("Presione Enter para terminar...");
            Console.ReadKey();
        }
    }
}
