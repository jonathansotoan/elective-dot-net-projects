﻿namespace ParkNow.UI
{
    partial class ParkingManager
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
            this.components = new System.ComponentModel.Container();
            this.txtVehiclePlate = new System.Windows.Forms.TextBox();
            this.btnSaveParking = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtgrLastParkings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrLastParkings)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVehiclePlate
            // 
            this.txtVehiclePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiclePlate.Location = new System.Drawing.Point(13, 31);
            this.txtVehiclePlate.Name = "txtVehiclePlate";
            this.txtVehiclePlate.Size = new System.Drawing.Size(500, 158);
            this.txtVehiclePlate.TabIndex = 0;
            // 
            // btnSaveParking
            // 
            this.btnSaveParking.Location = new System.Drawing.Point(425, 217);
            this.btnSaveParking.Name = "btnSaveParking";
            this.btnSaveParking.Size = new System.Drawing.Size(88, 23);
            this.btnSaveParking.TabIndex = 1;
            this.btnSaveParking.Text = "Save Parking";
            this.btnSaveParking.UseVisualStyleBackColor = true;
            this.btnSaveParking.Click += new System.EventHandler(this.btnSaveParking_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dtgrLastParkings
            // 
            this.dtgrLastParkings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrLastParkings.Location = new System.Drawing.Point(13, 284);
            this.dtgrLastParkings.Name = "dtgrLastParkings";
            this.dtgrLastParkings.Size = new System.Drawing.Size(240, 150);
            this.dtgrLastParkings.TabIndex = 2;
            // 
            // ParkingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 471);
            this.Controls.Add(this.dtgrLastParkings);
            this.Controls.Add(this.btnSaveParking);
            this.Controls.Add(this.txtVehiclePlate);
            this.Name = "ParkingManager";
            this.Text = "ParkingManager";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrLastParkings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVehiclePlate;
        private System.Windows.Forms.Button btnSaveParking;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView dtgrLastParkings;
    }
}