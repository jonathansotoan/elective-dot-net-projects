namespace FiveCiclicForms
{
    partial class OpenerForm
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
            this.welcomeMessage = new System.Windows.Forms.TextBox();
            this.openerFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.Location = new System.Drawing.Point(36, 18);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(149, 20);
            this.welcomeMessage.TabIndex = 0;
            // 
            // openerFormButton
            // 
            this.openerFormButton.Location = new System.Drawing.Point(110, 55);
            this.openerFormButton.Name = "openerFormButton";
            this.openerFormButton.Size = new System.Drawing.Size(75, 23);
            this.openerFormButton.TabIndex = 1;
            this.openerFormButton.Text = "Open Form 2";
            this.openerFormButton.UseVisualStyleBackColor = true;
            this.openerFormButton.Click += new System.EventHandler(this.openerFormButton_Click);
            // 
            // OpenerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 90);
            this.Controls.Add(this.openerFormButton);
            this.Controls.Add(this.welcomeMessage);
            this.Name = "OpenerForm";
            this.Text = "Default title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox welcomeMessage;
        private System.Windows.Forms.Button openerFormButton;
    }
}

