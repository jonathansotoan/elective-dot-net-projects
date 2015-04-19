using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersonaFormulario.Universidades;

namespace PersonaFormulario.Estudiantes
{
    public partial class EstudiantesView : Form
    {
        private List<Estudiante> estudiantes;
        private List<Estudiante> estudiantesOcultos;
        private List<Universidad> universidades;

        public EstudiantesView()
        {
            InitializeComponent();
            estudiantes = new List<Estudiante>();
            estudiantesOcultos = new List<Estudiante>();
            universidades = new List<Universidad>
            {
                new Universidad
                {
                    Nit = 1,
                    Nombre = "Funlam"
                },
                new Universidad
                {
                    Nit = 2,
                    Nombre = "Eafit"
                },
                new Universidad
                {
                    Nit = 3,
                    Nombre = "Udem"
                },
            };
            cmbUniversidad.ValueMember = "Nit";
            cmbUniversidad.DisplayMember = "Nombre";
            cmbUniversidad.DataSource = universidades;
        }

        private void UpdateDataGridView(bool limpiar = true)
        {
            dtgrEstudiantes.DataSource = null;
            dtgrEstudiantes.DataSource = estudiantes;

            if (limpiar)
            {
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtIdentificacion.Text = txtNombre.Text = txtValorMatricula.Text = cmbUniversidad.Text = "";
            dtFechaMatricula.Value = DateTime.Now;
        }

        private void ReestablecerOcultos()
        {
            foreach (Estudiante estudiante in estudiantesOcultos)
            {
                estudiantes.Add(estudiante);
            }

            estudiantesOcultos = new List<Estudiante>();
            UpdateDataGridView(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estudiantes.Add(new Estudiante
            {
                Identificacion = int.Parse(txtIdentificacion.Text),
                Nombre = txtNombre.Text,
                FechaMatricula = dtFechaMatricula.Value,
                Universidad = universidades.Find(
                    universidad => universidad.Nit == (int)cmbUniversidad.SelectedValue),
                ValorMatricula = int.Parse(txtValorMatricula.Text)
            });

            UpdateDataGridView();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Estudiante estudianteModificado = estudiantes.Find(
                estudiante => estudiante.Identificacion == int.Parse(txtIdentificacion.Text));
            txtIdentificacion.Enabled = true;
            estudianteModificado.Nombre = txtNombre.Text;
            estudianteModificado.FechaMatricula = dtFechaMatricula.Value;
            estudianteModificado.Universidad = universidades.Find(
                universidad => universidad.Nit == (int)cmbUniversidad.SelectedValue);
            estudianteModificado.ValorMatricula = int.Parse(txtValorMatricula.Text);
            
            UpdateDataGridView();
        }

        private void dtgrEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Estudiante estudianteSeleccionado = (Estudiante)dtgrEstudiantes.Rows[e.RowIndex].DataBoundItem;

            txtIdentificacion.Text = estudianteSeleccionado.Identificacion + "";
            txtIdentificacion.Enabled = false;
            txtNombre.Text = estudianteSeleccionado.Nombre;
            txtValorMatricula.Text = estudianteSeleccionado.ValorMatricula + "";
            cmbUniversidad.SelectedValue = estudianteSeleccionado.Universidad.Nit;
            dtFechaMatricula.Value = estudianteSeleccionado.FechaMatricula;
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            ReestablecerOcultos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgrEstudiantes.SelectedRows)
            {
                estudiantes.Remove((Estudiante)row.DataBoundItem);
            }

            UpdateDataGridView();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ReestablecerOcultos();
            List<Estudiante> tempEstudiantes = new List<Estudiante>(estudiantes);
            List<Estudiante> estudiantesAmostrar = tempEstudiantes.FindAll(
                estudiante => estudiante.Identificacion == int.Parse(txtIdentificacion.Text));

            foreach (Estudiante estudiante in tempEstudiantes)
            {
                if (!estudiantesAmostrar.Contains(estudiante))
                {
                    estudiantes.Remove(estudiante);
                    estudiantesOcultos.Add(estudiante);
                }
            }

            UpdateDataGridView();
        }
    }
}
