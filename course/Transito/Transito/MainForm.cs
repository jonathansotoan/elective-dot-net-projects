using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transito
{
    public partial class Form1 : Form
    {
        private List<Transito> transitos;

        public Form1()
        {
            InitializeComponent();
            transitos = new List<Transito>();

            transitos.Add(new Transito()
            {
                Codigo = "001",
                Nombre = "Trans Caribe",
                CiudadSede = new Ciudad()
                {
                    Codigo = "01",
                    Nombre = "Medellín"
                }
            });

            transitos.Add(new Transito()
            {
                Codigo = "0001",
                Nombre = "Trans Municipal",
                CiudadSede = new Ciudad()
                {
                    Codigo = "01",
                    Nombre = "Medellín"
                }
            });

            transitos.Add(new Transito()
            {
                Codigo = "002",
                Nombre = "Trans Bello",
                CiudadSede = new Ciudad()
                {
                    Codigo = "02",
                    Nombre = "Bello"
                }
            });

            transitos.Add(new Transito()
            {
                Codigo = "003",
                Nombre = "Trans Envigado",
                CiudadSede = new Ciudad()
                {
                    Codigo = "03",
                    Nombre = "Envigado"
                }
            });

            transitos.Add(new Transito()
            {
                Codigo = "004",
                Nombre = "Trans Itagüí",
                CiudadSede = new Ciudad()
                {
                    Codigo = "04",
                    Nombre = "Itagüí"
                }
            });

            transitos.Add(new Transito()
            {
                Codigo = "005",
                Nombre = "Trans Capital",
                CiudadSede = new Ciudad()
                {
                    Codigo = "05",
                    Nombre = "Bogotá"
                }
            });

            transitos.Add(new Transito()
            {
                Codigo = "0005",
                Nombre = "Trans Cundinamarca",
                CiudadSede = new Ciudad()
                {
                    Codigo = "05",
                    Nombre = "Bogotá"
                }
            });

            /*List<string> ciudades = new List<string>();
            transitos.ForEach(transito => ciudades.Add(transito.CiudadSede.Nombre));
            cmbCiudades.Items.AddRange(ciudades.Distinct().ToArray());*/
            List<Ciudad> ciudades = new List<Ciudad>();
            transitos.ForEach(transito =>
                {
                    if(!ciudades.Contains(transito.CiudadSede))
                    {
                        ciudades.Add(transito.CiudadSede);
                    }
                });
            cmbCiudades.DataSource = ciudades.ToArray();
            cmbCiudades.ValueMember = "Codigo";
            cmbCiudades.DisplayMember = "Nombre";

            /*List<string> nombresDeTransitos = new List<string>();
            transitos.ForEach(transito => nombresDeTransitos.Add(transito.Nombre.Replace("Trans ", "")));
            cmbTransitos.Items.AddRange(nombresDeTransitos.Distinct().ToArray());*/

            cmbTransitos.DataSource = transitos;
            cmbTransitos.ValueMember = "Codigo";
            cmbTransitos.DisplayMember = "Nombre";
        }

        private void cmbCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Transito> transitosPorCiudadActual = transitos.Where(transito => transito.CiudadSede.Codigo == cmbCiudades.SelectedValue).ToList();
            cmbTransitos.DataSource = transitosPorCiudadActual;
            cmbTransitos.ValueMember = "Codigo";
            cmbTransitos.DisplayMember = "Nombre";
        }
    }
}
