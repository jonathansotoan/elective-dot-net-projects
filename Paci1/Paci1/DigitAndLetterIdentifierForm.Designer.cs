namespace Paci1
{
    partial class DigitAndLetterIdentifierForm
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
            this.txtCharInput = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCharInput
            // 
            this.txtCharInput.Location = new System.Drawing.Point(141, 12);
            this.txtCharInput.Name = "txtCharInput";
            this.txtCharInput.Size = new System.Drawing.Size(100, 20);
            this.txtCharInput.TabIndex = 0;
            this.txtCharInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCharInput_KeyUp);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(36, 15);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(99, 13);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Ingrese un caracter";
            // 
            // DigitAndLetterIdentifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 58);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtCharInput);
            this.Name = "DigitAndLetterIdentifierForm";
            this.Text = "DigitAndLetterIdentifierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCharInput;
        private System.Windows.Forms.Label lblInstructions;
    }
}