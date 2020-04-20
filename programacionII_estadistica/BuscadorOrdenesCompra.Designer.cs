namespace programacionII_estadistica
{
    partial class BuscadorOrdenesCompra
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
            this.grdBusquedaOrdencompra = new System.Windows.Forms.DataGridView();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.txtbusquedaordencompra = new System.Windows.Forms.TextBox();
            this.lblbusqueda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaOrdencompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaOrdencompra
            // 
            this.grdBusquedaOrdencompra.AllowUserToAddRows = false;
            this.grdBusquedaOrdencompra.AllowUserToDeleteRows = false;
            this.grdBusquedaOrdencompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaOrdencompra.Location = new System.Drawing.Point(15, 76);
            this.grdBusquedaOrdencompra.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaOrdencompra.Name = "grdBusquedaOrdencompra";
            this.grdBusquedaOrdencompra.ReadOnly = true;
            this.grdBusquedaOrdencompra.RowHeadersWidth = 102;
            this.grdBusquedaOrdencompra.RowTemplate.Height = 40;
            this.grdBusquedaOrdencompra.Size = new System.Drawing.Size(611, 346);
            this.grdBusquedaOrdencompra.TabIndex = 33;
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = global::programacionII_estadistica.Properties.Resources.degradado;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Location = new System.Drawing.Point(498, 19);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 31);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackgroundImage = global::programacionII_estadistica.Properties.Resources.degradado;
            this.btnseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionar.Location = new System.Drawing.Point(402, 19);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionar.TabIndex = 31;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // txtbusquedaordencompra
            // 
            this.txtbusquedaordencompra.Location = new System.Drawing.Point(99, 25);
            this.txtbusquedaordencompra.Name = "txtbusquedaordencompra";
            this.txtbusquedaordencompra.Size = new System.Drawing.Size(270, 20);
            this.txtbusquedaordencompra.TabIndex = 30;
            this.txtbusquedaordencompra.TextChanged += new System.EventHandler(this.txtbusquedaordencompra_TextChanged);
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.AutoSize = true;
            this.lblbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblbusqueda.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbusqueda.Location = new System.Drawing.Point(41, 25);
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(52, 18);
            this.lblbusqueda.TabIndex = 29;
            this.lblbusqueda.Text = "Buscar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::programacionII_estadistica.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(368, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // BuscadorOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programacionII_estadistica.Properties.Resources.degrado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdBusquedaOrdencompra);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txtbusquedaordencompra);
            this.Controls.Add(this.lblbusqueda);
            this.Name = "BuscadorOrdenesCompra";
            this.Text = "BuscadorOrdenesCompra";
            this.Load += new System.EventHandler(this.BuscadorOrdenesCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaOrdencompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBusquedaOrdencompra;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox txtbusquedaordencompra;
        private System.Windows.Forms.Label lblbusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}