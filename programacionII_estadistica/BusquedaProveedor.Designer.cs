namespace programacionII_estadistica
{
    partial class BusquedaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaProveedor));
            this.grdBusquedaProveedores = new System.Windows.Forms.DataGridView();
            this.btncancelarpro = new System.Windows.Forms.Button();
            this.btnseleccionarproveedor = new System.Windows.Forms.Button();
            this.txtbusquedaproveedor = new System.Windows.Forms.TextBox();
            this.lblbusquedapro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaProveedores
            // 
            this.grdBusquedaProveedores.AllowUserToAddRows = false;
            this.grdBusquedaProveedores.AllowUserToDeleteRows = false;
            this.grdBusquedaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaProveedores.Location = new System.Drawing.Point(12, 78);
            this.grdBusquedaProveedores.Name = "grdBusquedaProveedores";
            this.grdBusquedaProveedores.ReadOnly = true;
            this.grdBusquedaProveedores.Size = new System.Drawing.Size(634, 331);
            this.grdBusquedaProveedores.TabIndex = 28;
            // 
            // btncancelarpro
            // 
            this.btncancelarpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncancelarpro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelarpro.BackgroundImage")));
            this.btncancelarpro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelarpro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarpro.Location = new System.Drawing.Point(530, 17);
            this.btncancelarpro.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelarpro.Name = "btncancelarpro";
            this.btncancelarpro.Size = new System.Drawing.Size(104, 44);
            this.btncancelarpro.TabIndex = 27;
            this.btncancelarpro.Text = "CANCELAR";
            this.btncancelarpro.UseVisualStyleBackColor = false;
            this.btncancelarpro.Click += new System.EventHandler(this.btncancelarpro_Click);
            // 
            // btnseleccionarproveedor
            // 
            this.btnseleccionarproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnseleccionarproveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnseleccionarproveedor.BackgroundImage")));
            this.btnseleccionarproveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionarproveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionarproveedor.Location = new System.Drawing.Point(412, 17);
            this.btnseleccionarproveedor.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionarproveedor.Name = "btnseleccionarproveedor";
            this.btnseleccionarproveedor.Size = new System.Drawing.Size(116, 44);
            this.btnseleccionarproveedor.TabIndex = 26;
            this.btnseleccionarproveedor.Text = "SELECCIONAR";
            this.btnseleccionarproveedor.UseVisualStyleBackColor = false;
            this.btnseleccionarproveedor.Click += new System.EventHandler(this.btnseleccionarproveedor_Click);
            // 
            // txtbusquedaproveedor
            // 
            this.txtbusquedaproveedor.Location = new System.Drawing.Point(119, 28);
            this.txtbusquedaproveedor.Name = "txtbusquedaproveedor";
            this.txtbusquedaproveedor.Size = new System.Drawing.Size(270, 20);
            this.txtbusquedaproveedor.TabIndex = 25;
            this.txtbusquedaproveedor.TextChanged += new System.EventHandler(this.txtbusquedaproveedor_TextChanged);
            // 
            // lblbusquedapro
            // 
            this.lblbusquedapro.AutoSize = true;
            this.lblbusquedapro.BackColor = System.Drawing.Color.Transparent;
            this.lblbusquedapro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbusquedapro.Location = new System.Drawing.Point(38, 26);
            this.lblbusquedapro.Name = "lblbusquedapro";
            this.lblbusquedapro.Size = new System.Drawing.Size(75, 22);
            this.lblbusquedapro.TabIndex = 24;
            this.lblbusquedapro.Text = "Buscar";
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
            // BusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdBusquedaProveedores);
            this.Controls.Add(this.btncancelarpro);
            this.Controls.Add(this.btnseleccionarproveedor);
            this.Controls.Add(this.txtbusquedaproveedor);
            this.Controls.Add(this.lblbusquedapro);
            this.Name = "BusquedaProveedor";
            this.Text = "BusquedaProveedor";
            this.Load += new System.EventHandler(this.BusquedaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBusquedaProveedores;
        private System.Windows.Forms.Button btncancelarpro;
        private System.Windows.Forms.Button btnseleccionarproveedor;
        private System.Windows.Forms.TextBox txtbusquedaproveedor;
        private System.Windows.Forms.Label lblbusquedapro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}