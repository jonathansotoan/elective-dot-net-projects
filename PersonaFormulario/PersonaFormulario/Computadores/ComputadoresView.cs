using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonaFormulario.Computadores
{
    public partial class ComputadoresView : Form
    {
        private List<Computador> computadores;
        private List<Marca> marcas;

        public ComputadoresView()
        {
            computadores = new List<Computador>();
            marcas = new List<Marca>
            {
                new Marca
                {
                    Codigo = 1,
                    Nombre = "Dell"
                },
                new Marca
                {
                    Codigo = 2,
                    Nombre = "Toshiba"
                },
                new Marca
                {
                    Codigo = 3,
                    Nombre = "Hp"
                }
            };
            InitializeComponent();
            cmbMarca.ValueMember = "Codigo";
            cmbMarca.DisplayMember = "Nombre";
            cmbMarca.DataSource = marcas;
        }

        private void UpdateDataGridView()
        {
            dtgrComputadores.DataSource = null;
            dtgrComputadores.DataSource = computadores;
            Limpiar();
        }

        private void Limpiar()
        {
            txtReferencia.Text = txtModelo.Text = cmbMarca.Text = cmbTipo.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            computadores.Add(new Computador
            {
                Referencia = txtReferencia.Text,
                Marca = marcas.Find(marca=>marca.Codigo==(int)cmbMarca.SelectedValue),
                Modelo = int.Parse(txtModelo.Text),
                Tipo = cmbTipo.SelectedItem.ToString()
            });

            UpdateDataGridView();
        }

        private void dtgrComputadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Computador computadorSeleccionado = (Computador)dtgrComputadores.Rows[e.RowIndex].DataBoundItem;

            txtReferencia.Text = computadorSeleccionado.Referencia;
            cmbMarca.Text = computadorSeleccionado.Marca.Nombre;
            txtModelo.Text = computadorSeleccionado.Modelo + "";
            cmbTipo.Text = computadorSeleccionado.Tipo;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Computador computadorEditado = computadores.Find(computador => computador.Referencia == txtReferencia.Text);
            computadorEditado.Marca = marcas.Find(marca => marca.Codigo == (int) cmbMarca.SelectedValue);
            computadorEditado.Modelo = int.Parse(txtModelo.Text);
            computadorEditado.Tipo = cmbTipo.Text;

            UpdateDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            computadores.Remove(computadores.Find(computador => computador.Referencia == txtReferencia.Text));
            UpdateDataGridView();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int indiceComputadorBuscado = -1;

            if (txtReferencia.Text != "")
            {
                indiceComputadorBuscado = computadores.FindIndex(
                    computador => computador.Referencia == txtReferencia.Text);
            }
            else if (cmbMarca.Text != "")
            {
                indiceComputadorBuscado = computadores.FindIndex(
                    computador => computador.Marca.Codigo == (int)cmbMarca.SelectedValue);
            }
            else if (txtModelo.Text != "")
            {
                indiceComputadorBuscado = computadores.FindIndex(
                    computador => computador.Modelo + "" == txtModelo.Text);
            }
            else if (cmbTipo.Text != "")
            {
                indiceComputadorBuscado = computadores.FindIndex(
                    computador => computador.Tipo == cmbTipo.Text);
            }
            else
            {
                MessageBox.Show("Para consultar, debes llenar el campo por el que quieres buscar");
                return;
            }

            if (indiceComputadorBuscado == -1)
            {
                MessageBox.Show("No fue encontrado un computador con la característica especificada");
                return;
            }

            dtgrComputadores.CurrentCell = dtgrComputadores.Rows[indiceComputadorBuscado].Cells[0];
        }
    }
}
