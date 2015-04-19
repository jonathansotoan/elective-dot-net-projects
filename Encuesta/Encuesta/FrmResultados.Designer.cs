namespace Encuesta
{
    partial class FrmResultados
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
            this.lblQuantityOfQuestions = new System.Windows.Forms.Label();
            this.lblQuantityOfRightQuestions = new System.Windows.Forms.Label();
            this.lblQuantityOfWrongQuestions = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblLastNames = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblBirthCity = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblUndergraduates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuantityOfQuestions
            // 
            this.lblQuantityOfQuestions.AutoSize = true;
            this.lblQuantityOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityOfQuestions.Location = new System.Drawing.Point(16, 165);
            this.lblQuantityOfQuestions.Name = "lblQuantityOfQuestions";
            this.lblQuantityOfQuestions.Size = new System.Drawing.Size(135, 13);
            this.lblQuantityOfQuestions.TabIndex = 0;
            this.lblQuantityOfQuestions.Text = "Cantidad de preguntas";
            // 
            // lblQuantityOfRightQuestions
            // 
            this.lblQuantityOfRightQuestions.AutoSize = true;
            this.lblQuantityOfRightQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityOfRightQuestions.Location = new System.Drawing.Point(16, 198);
            this.lblQuantityOfRightQuestions.Name = "lblQuantityOfRightQuestions";
            this.lblQuantityOfRightQuestions.Size = new System.Drawing.Size(195, 13);
            this.lblQuantityOfRightQuestions.TabIndex = 1;
            this.lblQuantityOfRightQuestions.Text = "Cantidad de preguntas acertadas";
            // 
            // lblQuantityOfWrongQuestions
            // 
            this.lblQuantityOfWrongQuestions.AutoSize = true;
            this.lblQuantityOfWrongQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityOfWrongQuestions.Location = new System.Drawing.Point(16, 228);
            this.lblQuantityOfWrongQuestions.Name = "lblQuantityOfWrongQuestions";
            this.lblQuantityOfWrongQuestions.Size = new System.Drawing.Size(202, 13);
            this.lblQuantityOfWrongQuestions.TabIndex = 2;
            this.lblQuantityOfWrongQuestions.Text = "Cantidad de preguntas incorrectas";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(13, 13);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(49, 13);
            this.lblNames.TabIndex = 3;
            this.lblNames.Text = "Nombres";
            // 
            // lblLastNames
            // 
            this.lblLastNames.AutoSize = true;
            this.lblLastNames.Location = new System.Drawing.Point(13, 30);
            this.lblLastNames.Name = "lblLastNames";
            this.lblLastNames.Size = new System.Drawing.Size(49, 13);
            this.lblLastNames.TabIndex = 4;
            this.lblLastNames.Text = "Apellidos";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(13, 47);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(106, 13);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Fecha de nacimiento";
            // 
            // lblBirthCity
            // 
            this.lblBirthCity.AutoSize = true;
            this.lblBirthCity.Location = new System.Drawing.Point(13, 64);
            this.lblBirthCity.Name = "lblBirthCity";
            this.lblBirthCity.Size = new System.Drawing.Size(109, 13);
            this.lblBirthCity.TabIndex = 6;
            this.lblBirthCity.Text = "Ciudad de nacimiento";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(13, 81);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Edad";
            // 
            // lblUndergraduates
            // 
            this.lblUndergraduates.AutoSize = true;
            this.lblUndergraduates.Location = new System.Drawing.Point(13, 98);
            this.lblUndergraduates.Name = "lblUndergraduates";
            this.lblUndergraduates.Size = new System.Drawing.Size(55, 13);
            this.lblUndergraduates.TabIndex = 8;
            this.lblUndergraduates.Text = "Pregrados";
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblUndergraduates);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBirthCity);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLastNames);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.lblQuantityOfWrongQuestions);
            this.Controls.Add(this.lblQuantityOfRightQuestions);
            this.Controls.Add(this.lblQuantityOfQuestions);
            this.Name = "FrmResultados";
            this.Text = "FrmResultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantityOfQuestions;
        private System.Windows.Forms.Label lblQuantityOfRightQuestions;
        private System.Windows.Forms.Label lblQuantityOfWrongQuestions;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblLastNames;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblBirthCity;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblUndergraduates;
    }
}