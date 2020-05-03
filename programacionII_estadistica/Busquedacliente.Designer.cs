namespace programacionII_estadistica
{
    partial class Busquedacliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busquedacliente));
            this.grdBusquedaClientes = new System.Windows.Forms.DataGridView();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.lblbusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaClientes
            // 
            this.grdBusquedaClientes.AllowUserToAddRows = false;
            this.grdBusquedaClientes.AllowUserToDeleteRows = false;
            this.grdBusquedaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaClientes.Location = new System.Drawing.Point(12, 80);
            this.grdBusquedaClientes.Name = "grdBusquedaClientes";
            this.grdBusquedaClientes.ReadOnly = true;
            this.grdBusquedaClientes.Size = new System.Drawing.Size(584, 262);
            this.grdBusquedaClientes.TabIndex = 35;
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Location = new System.Drawing.Point(519, 17);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 31);
            this.btncancelar.TabIndex = 34;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnseleccionar.BackgroundImage")));
            this.btnseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionar.Location = new System.Drawing.Point(412, 17);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionar.TabIndex = 33;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(119, 23);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(270, 20);
            this.txtbusqueda.TabIndex = 32;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.AutoSize = true;
            this.lblbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblbusqueda.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbusqueda.Location = new System.Drawing.Point(61, 25);
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(52, 18);
            this.lblbusqueda.TabIndex = 31;
            this.lblbusqueda.Text = "Buscar";
            // 
            // Busquedacliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 354);
            this.Controls.Add(this.grdBusquedaClientes);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.lblbusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Busquedacliente";
            this.Text = "Busquedacliente";
            this.Load += new System.EventHandler(this.Busquedacliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdBusquedaClientes;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label lblbusqueda;
    }
}