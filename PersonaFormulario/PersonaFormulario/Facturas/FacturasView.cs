using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonaFormulario.Facturas
{
    public partial class FacturasView : Form
    {
        private List<Factura> facturas;
        private List<Factura> facturasOcultas;
        private List<Ciudad> ciudades;

        public FacturasView()
        {
            InitializeComponent();
            facturas = new List<Factura>();
            facturasOcultas = new List<Factura>();
            ciudades = new List<Ciudad>
            {
                new Ciudad
                {
                    Id = 1,
                    Nombre = "Medellín"
                },
                new Ciudad
                {
                    Id = 2,
                    Nombre = "Bucaramanga"
                },
                new Ciudad
                {
                    Id = 3,
                    Nombre = "Quibdó"
                },
                new Ciudad
                {
                    Id = 4,
                    Nombre = "Buenaventura"
                },
            };

            cmbCiudad.ValueMember = "Id";
            cmbCiudad.DisplayMember = "Nombre";
            cmbCiudad.DataSource = ciudades;
        }

        private void UpdateDataGridView(bool limpiar = true)
        {
            dtgrFacturas.DataSource = null;
            dtgrFacturas.DataSource = facturas;

            if (limpiar)
            {
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtCodigo.Enabled = true;
            txtCodigo.Text = txtNombreCliente.Text = txtProducto.Text = txtValor.Text = cmbCiudad.Text = "";
            dtFecha.Value = DateTime.Now;
        }

        private void ReestablecerOcultos()
        {
            foreach (Factura factura in facturasOcultas)
            {
                facturas.Add(factura);
            }

            facturasOcultas = new List<Factura>();
            UpdateDataGridView(false);
        }

        private bool SonCamposValidos()
        {
            errorProvider.CustomClear();

            if (txtCodigo.Text == string.Empty)
            {
                errorProvider.CustomSetError(txtCodigo, "El código de la factura no puede estar vacío");
            }
            else
            {
                try
                {
                    if (int.Parse(txtCodigo.Text) <= 0)
                    {
                        errorProvider.CustomSetError(txtCodigo, "El código debe ser al menos 1");
                    }
                }
                catch (FormatException)
                {
                    errorProvider.CustomSetError(txtCodigo, "El código debe ser un valor numérico");
                }
            }

            if (txtValor.Text == string.Empty)
            {
                errorProvider.CustomSetError(txtValor, "El valor no puede estar vacío");
            }
            else
            {
                try
                {
                    if (decimal.Parse(txtValor.Text) <= 0)
                    {
                        errorProvider.CustomSetError(txtValor, "El valor debe ser de al menos 1");
                    }
                }
                catch (FormatException)
                {
                    errorProvider.CustomSetError(txtValor, "El valor debe ser numérico");
                }
            }

            if (txtNombreCliente.Text == string.Empty)
            {
                errorProvider.CustomSetError(txtNombreCliente, "El nombre del cliente no puede estar vacío");
            }

            if (txtProducto.Text == string.Empty)
            {
                errorProvider.CustomSetError(txtProducto, "El producto no puede estar vacío");
            }

            if (cmbCiudad.Text == string.Empty)
            {
                errorProvider.CustomSetError(cmbCiudad, "La ciudad no puede estar vacía");
            }

            if (dtFecha.Value > DateTime.Now)
            {
                errorProvider.CustomSetError(dtFecha, "La fecha ingresada no puede ser mayor a la fecha actual");
            }

            return !errorProvider.ExistsError();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (SonCamposValidos())
            {
                if (facturas.Find(factura => factura.Codigo == int.Parse(txtCodigo.Text)) != null)
                {
                    errorProvider.CustomSetError(txtCodigo, "El código ya está en uso");
                }
                else
                {
                    facturas.Add(new Factura
                    {
                        Codigo = int.Parse(txtCodigo.Text),
                        Ciudad = ciudades.Find(ciudad => ciudad.Id == (int)cmbCiudad.SelectedValue),
                        Fecha = dtFecha.Value,
                        NombreCliente = txtNombreCliente.Text,
                        Producto = txtProducto.Text,
                        Valor = int.Parse(txtValor.Text)
                    });

                    UpdateDataGridView();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dtgrFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Enabled = false;
            Factura facturaSeleccionada = (Factura)dtgrFacturas.Rows[e.RowIndex].DataBoundItem;

            txtCodigo.Text = facturaSeleccionada.Codigo + "";
            txtNombreCliente.Text = facturaSeleccionada.NombreCliente;
            txtProducto.Text = facturaSeleccionada.Producto;
            txtValor.Text = facturaSeleccionada.Valor + "";
            cmbCiudad.SelectedValue = facturaSeleccionada.Ciudad.Id;
            dtFecha.Value = facturaSeleccionada.Fecha;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgrFacturas.SelectedRows.Count == 0)
            {
                errorProvider.CustomSetError(dtgrFacturas, "Seleccione una fila");
            }

            foreach (DataGridViewRow row in dtgrFacturas.SelectedRows)
            {
                facturas.Remove((Factura)row.DataBoundItem);
            }

            UpdateDataGridView();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ReestablecerOcultos();
            errorProvider.CustomClear();

            List<Factura> tempFacturas = new List<Factura>(facturas);
            List<Factura> FacturasAmostrar;

            if (txtCodigo.Text != string.Empty)
            {
                FacturasAmostrar = tempFacturas.FindAll(factura => factura.Codigo == int.Parse(txtCodigo.Text));
            }
            else if (txtNombreCliente.Text != string.Empty)
            {
                FacturasAmostrar = tempFacturas.FindAll(factura => factura.NombreCliente.Contains(txtNombreCliente.Text));
            }
            else
            {
                errorProvider.CustomSetError(txtCodigo, "Este campo debe ser llenado para poder buscar");
                errorProvider.CustomSetError(txtNombreCliente, "O este");
                return;
            }

            foreach (Factura factura in tempFacturas)
            {
                if (!FacturasAmostrar.Contains(factura))
                {
                    facturas.Remove(factura);
                    facturasOcultas.Add(factura);
                }
            }

            UpdateDataGridView();
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            ReestablecerOcultos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (SonCamposValidos())
            {
                Factura facturaModificada = facturas.Find(factura => factura.Codigo == int.Parse(txtCodigo.Text));

                facturaModificada.Codigo = int.Parse(txtCodigo.Text);
                facturaModificada.Ciudad = ciudades.Find(ciudad => ciudad.Id == (int)cmbCiudad.SelectedValue);
                facturaModificada.Fecha = dtFecha.Value;
                facturaModificada.NombreCliente = txtNombreCliente.Text;
                facturaModificada.Producto = txtProducto.Text;
                facturaModificada.Valor = int.Parse(txtValor.Text);

                UpdateDataGridView();
            }
        }
    }
}
