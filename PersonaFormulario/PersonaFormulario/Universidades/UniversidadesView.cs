using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonaFormulario.Universidades
{
    public partial class UniversidadesView : Form
    {
        private List<Universidad> universidades;
        private List<Universidad> universidadesOcultas;
        private List<Municipio> municipios;

        public UniversidadesView()
        {
            InitializeComponent();
            universidades = new List<Universidad>();
            universidadesOcultas = new List<Universidad>();
            municipios = new List<Municipio>
            {
                new Municipio
                {
                    Id = 1,
                    Nombre = "Itagüí"
                },
                new Municipio
                {
                    Id = 2,
                    Nombre = "Medellín"
                },
                new Municipio
                {
                    Id = 3,
                    Nombre = "Bello"
                },
            };
            cmbMunicipio.ValueMember = "Id";
            cmbMunicipio.DisplayMember = "Nombre";
            cmbMunicipio.DataSource = municipios;
        }

        private void UpdateDataGridView(bool limpiar = true)
        {
            dtgrUniversidades.DataSource = null;
            dtgrUniversidades.DataSource = universidades;

            if (limpiar)
            {
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtNit.Text = txtDireccion.Text = txtNombre.Text = cmbMunicipio.Text = "";
        }

        private void ReestablecerOcultos()
        {
            foreach (Universidad universidad in universidadesOcultas)
            {
                universidades.Add(universidad);
            }

            universidadesOcultas = new List<Universidad>();
            UpdateDataGridView(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            universidades.Add(new Universidad
            {
                Nit = int.Parse(txtNit.Text),
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Municipio = municipios.Find(municipio => municipio.Id == (int)cmbMunicipio.SelectedValue)
            });

            UpdateDataGridView();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dtgrUniversidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Universidad universidadSeleccionada = (Universidad)dtgrUniversidades.Rows[e.RowIndex].DataBoundItem;

            txtNit.Text = universidadSeleccionada.Nit + "";
            txtNombre.Text = universidadSeleccionada.Nombre;
            txtDireccion.Text = universidadSeleccionada.Direccion;
            cmbMunicipio.SelectedValue = universidadSeleccionada.Municipio.Id;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgrUniversidades.SelectedRows)
            {
                universidades.Remove((Universidad)row.DataBoundItem);
            }

            UpdateDataGridView();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ReestablecerOcultos();
            List<Universidad> tempUniversidades = new List<Universidad>(universidades);
            List<Universidad> universidadesAmostrar = tempUniversidades.FindAll(
                universidad => universidad.Nit == int.Parse(txtNit.Text));

            foreach (Universidad universidad in tempUniversidades)
            {
                if (!universidadesAmostrar.Contains(universidad))
                {
                    universidades.Remove(universidad);
                    universidadesOcultas.Add(universidad);
                }
            }

            UpdateDataGridView();
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            ReestablecerOcultos();
        }
    }
}
