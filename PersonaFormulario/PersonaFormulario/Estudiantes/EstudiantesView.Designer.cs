namespace PersonaFormulario.Estudiantes
{
    partial class EstudiantesView
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUniversidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgrEstudiantes = new System.Windows.Forms.DataGridView();
            this.Universidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Universidad";
            // 
            // cmbUniversidad
            // 
            this.cmbUniversidad.FormattingEnabled = true;
            this.cmbUniversidad.Location = new System.Drawing.Point(229, 12);
            this.cmbUniversidad.Name = "cmbUniversidad";
            this.cmbUniversidad.Size = new System.Drawing.Size(200, 21);
            this.cmbUniversidad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre estudiante";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(229, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(229, 87);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(200, 20);
            this.txtIdentificacion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identificación";
            // 
            // txtValorMatricula
            // 
            this.txtValorMatricula.Location = new System.Drawing.Point(229, 121);
            this.txtValorMatricula.Name = "txtValorMatricula";
            this.txtValorMatricula.Size = new System.Drawing.Size(200, 20);
            this.txtValorMatricula.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Matrícula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Matrícula";
            // 
            // dtFechaMatricula
            // 
            this.dtFechaMatricula.Location = new System.Drawing.Point(229, 161);
            this.dtFechaMatricula.Name = "dtFechaMatricula";
            this.dtFechaMatricula.Size = new System.Drawing.Size(200, 20);
            this.dtFechaMatricula.TabIndex = 9;
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Location = new System.Drawing.Point(294, 205);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(75, 23);
            this.btnReestablecer.TabIndex = 24;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(376, 245);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(375, 205);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(294, 245);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(212, 245);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(131, 245);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgrEstudiantes
            // 
            this.dtgrEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Universidad,
            this.Nombre,
            this.Identificacion,
            this.ValorMatricula,
            this.FechaMatricula});
            this.dtgrEstudiantes.Location = new System.Drawing.Point(16, 287);
            this.dtgrEstudiantes.Name = "dtgrEstudiantes";
            this.dtgrEstudiantes.Size = new System.Drawing.Size(545, 150);
            this.dtgrEstudiantes.TabIndex = 25;
            this.dtgrEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrEstudiantes_CellClick);
            // 
            // Universidad
            // 
            this.Universidad.DataPropertyName = "Universidad";
            this.Universidad.HeaderText = "Universidad";
            this.Universidad.Name = "Universidad";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "Identificación";
            this.Identificacion.Name = "Identificacion";
            // 
            // ValorMatricula
            // 
            this.ValorMatricula.DataPropertyName = "ValorMatricula";
            this.ValorMatricula.HeaderText = "Valor matrícula";
            this.ValorMatricula.Name = "ValorMatricula";
            // 
            // FechaMatricula
            // 
            this.FechaMatricula.DataPropertyName = "FechaMatricula";
            this.FechaMatricula.HeaderText = "Fecha matrícula";
            this.FechaMatricula.Name = "FechaMatricula";
            // 
            // EstudiantesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 452);
            this.Controls.Add(this.dtgrEstudiantes);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtFechaMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUniversidad);
            this.Controls.Add(this.label1);
            this.Name = "EstudiantesView";
            this.Text = "EstudiantesView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUniversidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaMatricula;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgrEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Universidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaMatricula;
    }
}