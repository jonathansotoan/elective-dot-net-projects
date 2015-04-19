namespace ListViewAndListBoxExample
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Azul", "sea.jpg");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Verde", "Atlético_Nacional_logo.svg.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Rojo", "fire.jpg");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTargetForChangingColor = new System.Windows.Forms.TextBox();
            this.lstvColors = new System.Windows.Forms.ListView();
            this.ltbColors = new System.Windows.Forms.ListBox();
            this.imglColors = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txtTargetForChangingColor
            // 
            this.txtTargetForChangingColor.Location = new System.Drawing.Point(13, 13);
            this.txtTargetForChangingColor.Name = "txtTargetForChangingColor";
            this.txtTargetForChangingColor.Size = new System.Drawing.Size(100, 20);
            this.txtTargetForChangingColor.TabIndex = 0;
            // 
            // lstvColors
            // 
            this.lstvColors.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstvColors.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstvColors.LargeImageList = this.imglColors;
            this.lstvColors.Location = new System.Drawing.Point(13, 60);
            this.lstvColors.Name = "lstvColors";
            this.lstvColors.Size = new System.Drawing.Size(121, 97);
            this.lstvColors.TabIndex = 1;
            this.lstvColors.UseCompatibleStateImageBehavior = false;
            this.lstvColors.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ltbColors
            // 
            this.ltbColors.FormattingEnabled = true;
            this.ltbColors.Items.AddRange(new object[] {
            "Azul",
            "Verde",
            "Rojo"});
            this.ltbColors.Location = new System.Drawing.Point(141, 60);
            this.ltbColors.Name = "ltbColors";
            this.ltbColors.Size = new System.Drawing.Size(120, 95);
            this.ltbColors.TabIndex = 2;
            this.ltbColors.SelectedIndexChanged += new System.EventHandler(this.ltbColors_SelectedIndexChanged);
            // 
            // imglColors
            // 
            this.imglColors.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglColors.ImageStream")));
            this.imglColors.TransparentColor = System.Drawing.Color.Transparent;
            this.imglColors.Images.SetKeyName(0, "Atlético_Nacional_logo.svg.png");
            this.imglColors.Images.SetKeyName(1, "sea.jpg");
            this.imglColors.Images.SetKeyName(2, "fire.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ltbColors);
            this.Controls.Add(this.lstvColors);
            this.Controls.Add(this.txtTargetForChangingColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTargetForChangingColor;
        private System.Windows.Forms.ListView lstvColors;
        private System.Windows.Forms.ListBox ltbColors;
        private System.Windows.Forms.ImageList imglColors;
    }
}

