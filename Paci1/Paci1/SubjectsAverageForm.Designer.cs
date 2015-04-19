namespace Paci1
{
    partial class SubjectsAverageForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsAverageForm));
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.ltbSubjects = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pcResultados = new System.Windows.Forms.PictureBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.ilstResultImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(13, 13);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(57, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Asignatura";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(16, 55);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(30, 13);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "Nota";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(74, 55);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(80, 20);
            this.txtGrade.TabIndex = 3;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(179, 52);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(66, 23);
            this.btnAddSubject.TabIndex = 4;
            this.btnAddSubject.Text = "Agregar";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // ltbSubjects
            // 
            this.ltbSubjects.FormattingEnabled = true;
            this.ltbSubjects.Location = new System.Drawing.Point(76, 91);
            this.ltbSubjects.Name = "ltbSubjects";
            this.ltbSubjects.Size = new System.Drawing.Size(169, 95);
            this.ltbSubjects.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 216);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pcResultados
            // 
            this.pcResultados.Location = new System.Drawing.Point(76, 245);
            this.pcResultados.Name = "pcResultados";
            this.pcResultados.Size = new System.Drawing.Size(169, 150);
            this.pcResultados.TabIndex = 7;
            this.pcResultados.TabStop = false;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(108, 225);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 8;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Items.AddRange(new object[] {
            "Matemáticas",
            "POO",
            "Estructura de datos",
            "Bases de datos",
            "Algoritmos",
            "Investigación de operaciones",
            "Física",
            "Cálculo",
            ".Net"});
            this.cmbSubject.Location = new System.Drawing.Point(77, 13);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(168, 21);
            this.cmbSubject.TabIndex = 9;
            // 
            // ilstResultImages
            // 
            this.ilstResultImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstResultImages.ImageStream")));
            this.ilstResultImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstResultImages.Images.SetKeyName(0, "Failed.jpg");
            this.ilstResultImages.Images.SetKeyName(1, "Success.jpg");
            // 
            // SubjectsAverageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 410);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.pcResultados);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.ltbSubjects);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblSubject);
            this.Name = "SubjectsAverageForm";
            this.Text = "Promedio de notas";
            ((System.ComponentModel.ISupportInitialize)(this.pcResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.ListBox ltbSubjects;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox pcResultados;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ImageList ilstResultImages;
    }
}

