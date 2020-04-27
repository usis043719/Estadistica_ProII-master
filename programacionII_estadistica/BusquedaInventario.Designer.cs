namespace programacionII_estadistica
{
    partial class BusquedaInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaInventario));
            this.grdBusquedaInventario = new System.Windows.Forms.DataGridView();
            this.btncancelarinventario = new System.Windows.Forms.Button();
            this.btnseleccionarinventario = new System.Windows.Forms.Button();
            this.txtbusquedainventario = new System.Windows.Forms.TextBox();
            this.lblbusquedainventario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaInventario
            // 
            this.grdBusquedaInventario.AllowUserToAddRows = false;
            this.grdBusquedaInventario.AllowUserToDeleteRows = false;
            this.grdBusquedaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaInventario.Location = new System.Drawing.Point(12, 80);
            this.grdBusquedaInventario.Name = "grdBusquedaInventario";
            this.grdBusquedaInventario.ReadOnly = true;
            this.grdBusquedaInventario.Size = new System.Drawing.Size(584, 262);
            this.grdBusquedaInventario.TabIndex = 28;
            // 
            // btncancelarinventario
            // 
            this.btncancelarinventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelarinventario.BackgroundImage")));
            this.btncancelarinventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelarinventario.Location = new System.Drawing.Point(519, 17);
            this.btncancelarinventario.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelarinventario.Name = "btncancelarinventario";
            this.btncancelarinventario.Size = new System.Drawing.Size(77, 31);
            this.btncancelarinventario.TabIndex = 27;
            this.btncancelarinventario.Text = "CANCELAR";
            this.btncancelarinventario.UseVisualStyleBackColor = true;
            this.btncancelarinventario.Click += new System.EventHandler(this.btncancelarinventario_Click);
            // 
            // btnseleccionarinventario
            // 
            this.btnseleccionarinventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnseleccionarinventario.BackgroundImage")));
            this.btnseleccionarinventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionarinventario.Location = new System.Drawing.Point(412, 17);
            this.btnseleccionarinventario.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionarinventario.Name = "btnseleccionarinventario";
            this.btnseleccionarinventario.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionarinventario.TabIndex = 26;
            this.btnseleccionarinventario.Text = "SELECCIONAR";
            this.btnseleccionarinventario.UseVisualStyleBackColor = true;
            this.btnseleccionarinventario.Click += new System.EventHandler(this.btnseleccionarinventario_Click);
            // 
            // txtbusquedainventario
            // 
            this.txtbusquedainventario.Location = new System.Drawing.Point(119, 28);
            this.txtbusquedainventario.Name = "txtbusquedainventario";
            this.txtbusquedainventario.Size = new System.Drawing.Size(270, 20);
            this.txtbusquedainventario.TabIndex = 25;
            this.txtbusquedainventario.TextChanged += new System.EventHandler(this.txtbusquedainventario_TextChanged);
            // 
            // lblbusquedainventario
            // 
            this.lblbusquedainventario.AutoSize = true;
            this.lblbusquedainventario.BackColor = System.Drawing.Color.Transparent;
            this.lblbusquedainventario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbusquedainventario.Location = new System.Drawing.Point(61, 30);
            this.lblbusquedainventario.Name = "lblbusquedainventario";
            this.lblbusquedainventario.Size = new System.Drawing.Size(52, 18);
            this.lblbusquedainventario.TabIndex = 24;
            this.lblbusquedainventario.Text = "Buscar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::programacionII_estadistica.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(378, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // BusquedaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programacionII_estadistica.Properties.Resources.degrado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdBusquedaInventario);
            this.Controls.Add(this.btncancelarinventario);
            this.Controls.Add(this.btnseleccionarinventario);
            this.Controls.Add(this.txtbusquedainventario);
            this.Controls.Add(this.lblbusquedainventario);
            this.Name = "BusquedaInventario";
            this.Text = "BusquedaInventario";
            this.Load += new System.EventHandler(this.BusquedaInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBusquedaInventario;
        private System.Windows.Forms.Button btncancelarinventario;
        private System.Windows.Forms.Button btnseleccionarinventario;
        private System.Windows.Forms.TextBox txtbusquedainventario;
        private System.Windows.Forms.Label lblbusquedainventario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}