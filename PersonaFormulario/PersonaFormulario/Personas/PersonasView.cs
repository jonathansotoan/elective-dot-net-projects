using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonaFormulario.Personas
{
    public partial class PersonasView : Form
    {
        private List<Persona> personas;

        public PersonasView()
        {
            personas = new List<Persona>();
            InitializeComponent();
        }

        private void UpdateDataGridView()
        {
            dtgrPersonas.DataSource = null;
            dtgrPersonas.DataSource = personas;
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombreYapellidos.Text = txtIdentificacion.Text = "";
            dtFechaNacimiento.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            personas.Add(new Persona
            {
                FechaNacimiento = dtFechaNacimiento.Value,
                Identificacion = int.Parse(txtIdentificacion.Text),
                NombresYapellidos = txtNombreYapellidos.Text
            });

            UpdateDataGridView();
        }

        private void dtgrPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona personaSeleccionada = (Persona)dtgrPersonas.Rows[e.RowIndex].DataBoundItem;

            txtNombreYapellidos.Text = personaSeleccionada.NombresYapellidos;
            txtIdentificacion.Text = personaSeleccionada.Identificacion + "";
            dtFechaNacimiento.Value = personaSeleccionada.FechaNacimiento;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona personaEditada = personas.Find(persona => persona.Identificacion == int.Parse(txtIdentificacion.Text));
            personaEditada.FechaNacimiento = dtFechaNacimiento.Value;
            personaEditada.NombresYapellidos = txtNombreYapellidos.Text;

            UpdateDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            personas.Remove(personas.Find(persona => persona.Identificacion == int.Parse(txtIdentificacion.Text)));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dtgrPersonas.CurrentCell = dtgrPersonas.Rows[personas.FindIndex(persona => persona.NombresYapellidos == txtNombreYapellidos.Text)].Cells[0];
        }
    }
}
