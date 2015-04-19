using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Parqueadero
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo vehiculo = new Vehiculo
                {
                    TipoVehiculo = cmbTipoVehiculo.Text,
                    CantidadHoras = (int)Math.Round(dtSalida.Value.Subtract(dtEntrada.Value).TotalMinutes / 60.0),
                    NombreCliente = txtNombreCliente.Text,
                    Identificacion = txtClienteId.Text,
                    Placa = txtPlaca.Text
                };

                txtCantidadHoras.Text = vehiculo.CantidadHoras + "";
                txtTarifa.Text = vehiculo.TarifaVehiculo + "";
                txtValorTotal.Text = (vehiculo.TarifaVehiculo * vehiculo.CantidadHoras) + "";

                using (StreamWriter writer = new StreamWriter("Reporte.txt"))
                {
                    vehiculo.ToString().Split('\n').ToList().ForEach(line => writer.WriteLine(line));

                    //System.Diagnostics.Process.Start("cmd.exe", "/C notepad Reporte.txt");
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C notepad Reporte.txt";
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
            catch (FormatException nre)
            {
                MessageBox.Show("Parece que te faltó llenar un campo");
            }
        }
    }
}
