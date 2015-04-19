namespace Encuesta
{
    partial class FrmBasicInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBirthCity = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.checkedListBoxUndergraduates = new System.Windows.Forms.CheckedListBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres completos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos completos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seleccione el (los) pregrado(s) que está cursando";
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(185, 37);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(200, 20);
            this.txtNames.TabIndex = 6;
            // 
            // txtLastNames
            // 
            this.txtLastNames.Location = new System.Drawing.Point(185, 84);
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(200, 20);
            this.txtLastNames.TabIndex = 7;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(185, 130);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtBirthDate.TabIndex = 8;
            this.dtBirthDate.ValueChanged += new System.EventHandler(this.dtBirthDate_ValueChanged);
            // 
            // cmbBirthCity
            // 
            this.cmbBirthCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirthCity.FormattingEnabled = true;
            this.cmbBirthCity.Items.AddRange(new object[] {
            "Medellín",
            "Bogotá",
            "Manizales",
            "Cali",
            "Barranquilla",
            "Cartagena"});
            this.cmbBirthCity.Location = new System.Drawing.Point(185, 178);
            this.cmbBirthCity.Name = "cmbBirthCity";
            this.cmbBirthCity.Size = new System.Drawing.Size(200, 21);
            this.cmbBirthCity.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(185, 231);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 20);
            this.txtAge.TabIndex = 10;
            // 
            // checkedListBoxUndergraduates
            // 
            this.checkedListBoxUndergraduates.FormattingEnabled = true;
            this.checkedListBoxUndergraduates.Items.AddRange(new object[] {
            "Ingeniería de Sistemas",
            "Ingeniería Mecánica",
            "Ingeniería Mecatrónica",
            "Psicología",
            "Ciencias políticas",
            "Licenciatura en preescolar"});
            this.checkedListBoxUndergraduates.Location = new System.Drawing.Point(45, 320);
            this.checkedListBoxUndergraduates.Name = "checkedListBoxUndergraduates";
            this.checkedListBoxUndergraduates.Size = new System.Drawing.Size(340, 94);
            this.checkedListBoxUndergraduates.TabIndex = 11;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(229, 429);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(310, 429);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 12;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // FrmBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 464);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.checkedListBoxUndergraduates);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.cmbBirthCity);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.txtLastNames);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicInfo";
            this.Text = "FrmBasicInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.ComboBox cmbBirthCity;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.CheckedListBox checkedListBoxUndergraduates;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
    }
}