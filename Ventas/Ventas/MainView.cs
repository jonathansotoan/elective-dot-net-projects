using System;
using System.Data.Objects.DataClasses;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ventas
{
    public partial class MainView : Form
    {
        private readonly EntityCollection<DetalleFacturas> _detallesFacturas;
        private readonly VentasEntities _context;
        private readonly List<decimal> _totales;

        public MainView()
        {
            InitializeComponent();

            _context = new VentasEntities();
            _detallesFacturas = new EntityCollection<DetalleFacturas>();
            _totales = new List<decimal>();

            dtgrDetallesFacturas.Columns.Add("total", "Total");
            ResetDataGridView();
        }

        private void ResetDataGridView()
        {
            dtgrDetallesFacturas.DataSource = null;
            dtgrDetallesFacturas.DataSource = _detallesFacturas;
            dtgrDetallesFacturas.Columns["total"].DisplayIndex = dtgrDetallesFacturas.Columns.Count - 1;
            dtgrDetallesFacturas.Columns[1].Visible = false;
            dtgrDetallesFacturas.Columns[2].Visible = false;
            dtgrDetallesFacturas.Columns[6].Visible = false;

            for(var index = 0; index < _totales.Count; ++index)
            {
                dtgrDetallesFacturas.Rows[index].Cells["total"].Value = _totales[index];
            }
        }

        private bool CalcularTotalDetalle()
        {
            var areValid = true;

            errorProvider.Clear();

            if (!Regex.IsMatch(txtCantidad.Text, "^[0-9]+$"))
            {
                errorProvider.SetError(txtCantidad, "Debe ser un número positivo");
                areValid = false;
            }

            if(!Regex.IsMatch(txtPrecio.Text, "^[0-9]+$"))
            {
                errorProvider.SetError(txtPrecio, "Debe ser un número positivo");
                areValid = false;
            }

            if(cmbProducto.Text == string.Empty)
            {
                errorProvider.SetError(cmbProducto, "Debes seleccionar un producto primero");
                areValid = false;
            }

            if(!areValid)
            {
                return false;
            }

            txtValorTotal.Text = "" + (int.Parse(txtPrecio.Text) * int.Parse(txtCantidad.Text));
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!CalcularTotalDetalle())
            {
                return;
            }

            var detalleFacturasInsertado = new DetalleFacturas
            {
                NombreProducto = cmbProducto.Text,
                Precio = int.Parse(txtPrecio.Text),
                Cantidad = int.Parse(txtCantidad.Text)
            };

            _detallesFacturas.Add(detalleFacturasInsertado);
            _totales.Add(detalleFacturasInsertado.Precio * detalleFacturasInsertado.Cantidad);
            ResetDataGridView();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularTotalDetalle();
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            var areValid = true;

            errorProvider.Clear();

            if(cmbCiudad.Text == string.Empty)
            {
                errorProvider.SetError(cmbCiudad, "La ciudad no puede estar vacía");
                areValid = false;
            }

            if(!Regex.IsMatch(txtIdFactura.Text, "^[0-9]+$"))
            {
                errorProvider.SetError(txtIdFactura, "Debe ser un número positivo");
                areValid = false;
            }

            if(!areValid)
            {
                return;
            }

            var idFactura = int.Parse(txtIdFactura.Text);

            if(_context.Facturas.Any(factura => factura.Id == idFactura))
            {
                errorProvider.SetError(txtIdFactura, "El id especificado ya existe, selecciona otro");
                return;
            }

            decimal valorTotalFactura = 0;
            _detallesFacturas.ToList().ForEach(detalleFactura => valorTotalFactura += detalleFactura.Cantidad * detalleFactura.Precio);
            txtTotal.Text = valorTotalFactura + "";

            var facturaToSave = new Facturas
            {
                Id = idFactura,
                Fecha = dtFecha.Value,
                ValorTotal = valorTotalFactura,
                Ciudad = cmbCiudad.Text,
                DetalleFacturas = _detallesFacturas.ToList()
            };

            _context.Facturas.Add(facturaToSave);
            _context.SaveChanges();
            _detallesFacturas.Clear();
            ResetDataGridView();
        }
    }
}
