namespace BancosEF
{
    partial class AdministrarBanco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgrBancos = new System.Windows.Forms.DataGridView();
            this.codigoBancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreBancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionPrincipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCiudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancosEFContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancosEFContainerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosEFContainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosEFContainerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(117, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(117, 87);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ciudad";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Items.AddRange(new object[] {
            "Medellín",
            "Bello",
            "Envigado",
            "Itagüí",
            "Sabaneta"});
            this.cmbCiudad.Location = new System.Drawing.Point(117, 126);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(97, 167);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(178, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dtgrBancos
            // 
            this.dtgrBancos.AutoGenerateColumns = false;
            this.dtgrBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrBancos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoBancoDataGridViewTextBoxColumn,
            this.nombreBancoDataGridViewTextBoxColumn,
            this.direccionPrincipalDataGridViewTextBoxColumn,
            this.nombreCiudadDataGridViewTextBoxColumn});
            this.dtgrBancos.DataSource = this.bancoBindingSource;
            this.dtgrBancos.Location = new System.Drawing.Point(16, 212);
            this.dtgrBancos.Name = "dtgrBancos";
            this.dtgrBancos.Size = new System.Drawing.Size(240, 150);
            this.dtgrBancos.TabIndex = 11;
            // 
            // codigoBancoDataGridViewTextBoxColumn
            // 
            this.codigoBancoDataGridViewTextBoxColumn.DataPropertyName = "CodigoBanco";
            this.codigoBancoDataGridViewTextBoxColumn.HeaderText = "CodigoBanco";
            this.codigoBancoDataGridViewTextBoxColumn.Name = "codigoBancoDataGridViewTextBoxColumn";
            // 
            // nombreBancoDataGridViewTextBoxColumn
            // 
            this.nombreBancoDataGridViewTextBoxColumn.DataPropertyName = "NombreBanco";
            this.nombreBancoDataGridViewTextBoxColumn.HeaderText = "NombreBanco";
            this.nombreBancoDataGridViewTextBoxColumn.Name = "nombreBancoDataGridViewTextBoxColumn";
            // 
            // direccionPrincipalDataGridViewTextBoxColumn
            // 
            this.direccionPrincipalDataGridViewTextBoxColumn.DataPropertyName = "DireccionPrincipal";
            this.direccionPrincipalDataGridViewTextBoxColumn.HeaderText = "DireccionPrincipal";
            this.direccionPrincipalDataGridViewTextBoxColumn.Name = "direccionPrincipalDataGridViewTextBoxColumn";
            // 
            // nombreCiudadDataGridViewTextBoxColumn
            // 
            this.nombreCiudadDataGridViewTextBoxColumn.DataPropertyName = "NombreCiudad";
            this.nombreCiudadDataGridViewTextBoxColumn.HeaderText = "NombreCiudad";
            this.nombreCiudadDataGridViewTextBoxColumn.Name = "nombreCiudadDataGridViewTextBoxColumn";
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataSource = typeof(BancosEF.Banco);
            // 
            // bancosEFContainerBindingSource
            // 
            this.bancosEFContainerBindingSource.DataSource = typeof(BancosEF.BancosEFContainer);
            // 
            // bancosEFContainerBindingSource1
            // 
            this.bancosEFContainerBindingSource1.DataSource = typeof(BancosEF.BancosEFContainer);
            // 
            // AdministrarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 370);
            this.Controls.Add(this.dtgrBancos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "AdministrarBanco";
            this.Text = "AdministrarBanco";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosEFContainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosEFContainerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dtgrBancos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreBancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionPrincipalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCiudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bancoBindingSource;
        private System.Windows.Forms.BindingSource bancosEFContainerBindingSource;
        private System.Windows.Forms.BindingSource bancosEFContainerBindingSource1;
    }
}