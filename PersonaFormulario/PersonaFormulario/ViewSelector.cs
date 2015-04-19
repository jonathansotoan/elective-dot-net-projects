using PersonaFormulario.Computadores;
using PersonaFormulario.Personas;
using PersonaFormulario.Universidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersonaFormulario.Estudiantes;
using PersonaFormulario.Facturas;

namespace PersonaFormulario
{
    public partial class ViewSelector : Form
    {
        public ViewSelector()
        {
            InitializeComponent();
        }

        private void btnPersonasView_Click(object sender, EventArgs e)
        {
            new PersonasView().Show();
        }

        private void btnComputadoresView_Click(object sender, EventArgs e)
        {
            new ComputadoresView().Show();
        }

        private void btnUniversidadesView_Click(object sender, EventArgs e)
        {
            new UniversidadesView().Show();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            new EstudiantesView().Show();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            new FacturasView().Show();
        }
    }
}
