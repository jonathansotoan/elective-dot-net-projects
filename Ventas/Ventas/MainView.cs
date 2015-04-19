using System;
using System.Data.Objects.DataClasses;
using System.Windows.Forms;
using System.Linq;

namespace Ventas
{
    public partial class MainView : Form
    {
        private readonly EntityCollection<DetalleFacturas> _detallesFacturas;
        private readonly VentasEntities _context;

        public MainView()
        {
            InitializeComponent();

            _detallesFacturas = new EntityCollection<DetalleFacturas>();
            _context = new VentasEntities();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _detallesFacturas.Add(
                new DetalleFacturas
                {
                    NombreProducto = cmbProducto.Text,
                    Precio = int.Parse(txtPrecio.Text),
                    Cantidad = int.Parse(txtCantidad.Text)
                }
            );

            dtgrDetallesFacturas.DataSource = null;
            dtgrDetallesFacturas.DataSource = _detallesFacturas;
            //dtgrDetallesFacturas.Columns.
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtValorTotal.Text = "" + (int.Parse(txtPrecio.Text) * int.Parse(txtCantidad.Text));
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            decimal valorTotal = 0;
            _detallesFacturas.ToList().ForEach(detalleFactura => valorTotal += detalleFactura.Cantidad * detalleFactura.Precio);

            var facturaToSave = new Facturas
            {
                Fecha = dtFecha.Value,
                ValorTotal = valorTotal,
                Ciudad = cmbCiudad.Text
            };

            _context.AddToFacturas(facturaToSave);
            _context.SaveChanges();
        }
    }
}
