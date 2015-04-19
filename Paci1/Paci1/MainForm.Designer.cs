namespace Paci1
{
    partial class MainForm
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
            this.btnSubjectsAverage = new System.Windows.Forms.Button();
            this.btnDigitAndLetterIdentifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubjectsAverage
            // 
            this.btnSubjectsAverage.Location = new System.Drawing.Point(27, 32);
            this.btnSubjectsAverage.Name = "btnSubjectsAverage";
            this.btnSubjectsAverage.Size = new System.Drawing.Size(215, 23);
            this.btnSubjectsAverage.TabIndex = 0;
            this.btnSubjectsAverage.Text = "Punto 1: Promedio de notas";
            this.btnSubjectsAverage.UseVisualStyleBackColor = true;
            this.btnSubjectsAverage.Click += new System.EventHandler(this.btnSubjectsAverage_Click);
            // 
            // btnDigitAndLetterIdentifier
            // 
            this.btnDigitAndLetterIdentifier.Location = new System.Drawing.Point(27, 72);
            this.btnDigitAndLetterIdentifier.Name = "btnDigitAndLetterIdentifier";
            this.btnDigitAndLetterIdentifier.Size = new System.Drawing.Size(215, 23);
            this.btnDigitAndLetterIdentifier.TabIndex = 1;
            this.btnDigitAndLetterIdentifier.Text = "Punto 2: Identificador de letras y números";
            this.btnDigitAndLetterIdentifier.UseVisualStyleBackColor = true;
            this.btnDigitAndLetterIdentifier.Click += new System.EventHandler(this.btnDigitAndLetterIdentifier_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.btnDigitAndLetterIdentifier);
            this.Controls.Add(this.btnSubjectsAverage);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubjectsAverage;
        private System.Windows.Forms.Button btnDigitAndLetterIdentifier;
    }
}