namespace Encuesta
{
    partial class FrmGeneral
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónBásicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarEncuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónBásicaToolStripMenuItem,
            this.iniciarEncuestaToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // informaciónBásicaToolStripMenuItem
            // 
            this.informaciónBásicaToolStripMenuItem.Name = "informaciónBásicaToolStripMenuItem";
            this.informaciónBásicaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.informaciónBásicaToolStripMenuItem.Text = "Login";
            this.informaciónBásicaToolStripMenuItem.Click += new System.EventHandler(this.informaciónBásicaToolStripMenuItem_Click);
            // 
            // iniciarEncuestaToolStripMenuItem
            // 
            this.iniciarEncuestaToolStripMenuItem.Name = "iniciarEncuestaToolStripMenuItem";
            this.iniciarEncuestaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.iniciarEncuestaToolStripMenuItem.Text = "Iniciar encuesta";
            // 
            // FrmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGeneral";
            this.Text = "Bienvenido a la encuesta FUNLAM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónBásicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarEncuestaToolStripMenuItem;
    }
}