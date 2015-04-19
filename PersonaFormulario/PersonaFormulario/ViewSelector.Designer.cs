namespace PersonaFormulario
{
    partial class ViewSelector
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
            this.btnPersonasView = new System.Windows.Forms.Button();
            this.btnComputadoresView = new System.Windows.Forms.Button();
            this.btnUniversidadesView = new System.Windows.Forms.Button();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonasView
            // 
            this.btnPersonasView.Location = new System.Drawing.Point(13, 22);
            this.btnPersonasView.Name = "btnPersonasView";
            this.btnPersonasView.Size = new System.Drawing.Size(75, 23);
            this.btnPersonasView.TabIndex = 0;
            this.btnPersonasView.Text = "Personas";
            this.btnPersonasView.UseVisualStyleBackColor = true;
            this.btnPersonasView.Click += new System.EventHandler(this.btnPersonasView_Click);
            // 
            // btnComputadoresView
            // 
            this.btnComputadoresView.Location = new System.Drawing.Point(116, 22);
            this.btnComputadoresView.Name = "btnComputadoresView";
            this.btnComputadoresView.Size = new System.Drawing.Size(75, 23);
            this.btnComputadoresView.TabIndex = 1;
            this.btnComputadoresView.Text = "Computadores";
            this.btnComputadoresView.UseVisualStyleBackColor = true;
            this.btnComputadoresView.Click += new System.EventHandler(this.btnComputadoresView_Click);
            // 
            // btnUniversidadesView
            // 
            this.btnUniversidadesView.Location = new System.Drawing.Point(12, 75);
            this.btnUniversidadesView.Name = "btnUniversidadesView";
            this.btnUniversidadesView.Size = new System.Drawing.Size(75, 23);
            this.btnUniversidadesView.TabIndex = 2;
            this.btnUniversidadesView.Text = "Universidades";
            this.btnUniversidadesView.UseVisualStyleBackColor = true;
            this.btnUniversidadesView.Click += new System.EventHandler(this.btnUniversidadesView_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.Location = new System.Drawing.Point(116, 75);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnEstudiante.TabIndex = 3;
            this.btnEstudiante.Text = "Estudiante";
            this.btnEstudiante.UseVisualStyleBackColor = true;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(12, 117);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(75, 23);
            this.btnFactura.TabIndex = 4;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // ViewSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 154);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnEstudiante);
            this.Controls.Add(this.btnUniversidadesView);
            this.Controls.Add(this.btnComputadoresView);
            this.Controls.Add(this.btnPersonasView);
            this.Name = "ViewSelector";
            this.Text = "ViewSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonasView;
        private System.Windows.Forms.Button btnComputadoresView;
        private System.Windows.Forms.Button btnUniversidadesView;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnFactura;
    }
}