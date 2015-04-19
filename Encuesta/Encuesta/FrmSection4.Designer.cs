using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Encuesta
{
    partial class FrmSection4
    {
        private Point START_POINT = new Point(20, 20);
        private const int LABEL_HEIGHT = 15;
        private Label[] lblsQuestions;
        

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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(266, 376);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(347, 376);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // FrmSection4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Name = "FrmSection4";
            this.Text = "FrmSection4";
            this.ResumeLayout(false);

        }

        #endregion

        #region Hand-written code
        private void addQuestions(string[] questions) {
            int maxwidth = 0;
            int separation = (this.ClientSize.Height - LABEL_HEIGHT * 2 - START_POINT.Y) / (questions.Length + 1);
            const int QUALIFICATION_SEPARATION = 80;
            lblsQuestions = new Label[questions.Length];
            string[] qualifications = new string[] {
                "Insuficiente",
                "Regular",
                "Bueno",
                "Excelente"
            };
            int[] qualificationsSizes = new int[qualifications.Length];

            // Question labels
            for (int index = 0; index < questions.Length; ++index)
            {
                lblsQuestions[index] = new Label();
                lblsQuestions[index].AutoSize = true;
                lblsQuestions[index].Location = new Point(
                    START_POINT.X, LABEL_HEIGHT * 2 + START_POINT.Y + (index + 1) * separation);
                lblsQuestions[index].Name = "lblsQuestions" + index;
                lblsQuestions[index].Text = (index + 1) + ". " + questions[index];
                Controls.Add(lblsQuestions[index]);
                maxwidth = Math.Max(maxwidth, lblsQuestions[index].Width);
            }

            // Qualification labels
            for (int index = 0; index < qualifications.Length; ++index)
            {
                Label lblQualification = new Label();
                lblQualification.AutoSize = true;
                lblQualification.Location = new Point(
                    START_POINT.X + maxwidth + index * QUALIFICATION_SEPARATION, START_POINT.Y);
                lblQualification.Name = "lblQualification" + index;
                lblQualification.Text = qualifications[index];
                Controls.Add(lblQualification);
                qualificationsSizes[index] = lblQualification.Width;
            }

            // RadioButtons
            panels = new Control[questions.Length];

            for (int row = 0; row < questions.Length; ++row)
            {
                panels[row] = new Panel();
                panels[row].Size = new System.Drawing.Size(500, 20);

                for (int column = 0; column < qualifications.Length; ++column)
                {
                    panels[row].Location = new Point(maxwidth + lblsQuestions[row].Location.X, lblsQuestions[row].Location.Y);
                    RadioButton rdQualification = new RadioButton();
                    rdQualification.AutoSize = true;
                    rdQualification.Location = new Point(
                        QUALIFICATION_SEPARATION * column + qualificationsSizes[column] / 2, 0);
                    rdQualification.Name = "rdQualification" + row + "_" + column;
                    rdQualification.Size = new Size(14, 13);
                    rdQualification.TabStop = true;
                    rdQualification.UseVisualStyleBackColor = true;
                    panels[row].Controls.Add(rdQualification);
                }

                Controls.Add(panels[row]);
            }

            this.ClientSize = new Size(
                QUALIFICATION_SEPARATION * qualifications.Length + maxwidth + START_POINT.X,
                this.ClientSize.Height + 50);
            btnSiguiente.Location = new Point(
                this.ClientSize.Width - START_POINT.X - btnSiguiente.Width,
                this.ClientSize.Height - START_POINT.Y - btnSiguiente.Height
            );
            btnAtras.Location = new Point(
                btnSiguiente.Location.X - START_POINT.X - btnAtras.Width,
                btnSiguiente.Location.Y
            );
        }
        #endregion

        private Button btnAtras;
        private Button btnSiguiente;




    }
}