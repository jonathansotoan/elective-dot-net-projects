using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BancosEF
{
    public partial class AdministrarBanco : Form
    {
        public AdministrarBanco()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using(var context = new BancosEFContainer())
            {
                context.Banco.AddObject(Banco.CreateBanco(int.Parse(txtCodigo.Text), txtNombre.Text, txtDireccion.Text, cmbCiudad.Text));
                context.SaveChanges();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new BancosEFContainer())
            {
                var codigoBancoAModificar = int.Parse(txtCodigo.Text);
                Banco bancoAModificar = context.Banco.Single(banco => banco.CodigoBanco == codigoBancoAModificar);
                bancoAModificar.NombreBanco = txtNombre.Text;
                bancoAModificar.NombreCiudad = cmbCiudad.Text;
                bancoAModificar.DireccionPrincipal = txtDireccion.Text;
                context.SaveChanges();
            }
        }
    }
}
