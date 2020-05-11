namespace programacionII_estadistica
{
    partial class Busquedaproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busquedaproductos));
            this.grdBusquedaProductos = new System.Windows.Forms.DataGridView();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.lblbusqueda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaProductos
            // 
            this.grdBusquedaProductos.AllowUserToAddRows = false;
            this.grdBusquedaProductos.AllowUserToDeleteRows = false;
            this.grdBusquedaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaProductos.Location = new System.Drawing.Point(20, 79);
            this.grdBusquedaProductos.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaProductos.Name = "grdBusquedaProductos";
            this.grdBusquedaProductos.ReadOnly = true;
            this.grdBusquedaProductos.RowHeadersWidth = 102;
            this.grdBusquedaProductos.RowTemplate.Height = 40;
            this.grdBusquedaProductos.Size = new System.Drawing.Size(611, 346);
            this.grdBusquedaProductos.TabIndex = 28;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(523, 22);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(107, 47);
            this.btncancelar.TabIndex = 27;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnseleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnseleccionar.BackgroundImage")));
            this.btnseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionar.Location = new System.Drawing.Point(406, 22);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(115, 47);
            this.btnseleccionar.TabIndex = 26;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(103, 28);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(270, 20);
            this.txtbusqueda.TabIndex = 25;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.AutoSize = true;
            this.lblbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblbusqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbusqueda.Location = new System.Drawing.Point(16, 28);
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(75, 22);
            this.lblbusqueda.TabIndex = 24;
            this.lblbusqueda.Text = "Buscar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::programacionII_estadistica.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(372, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Busquedaproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdBusquedaProductos);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.lblbusqueda);
            this.Name = "Busquedaproductos";
            this.Text = "Busquedaproductos";
            this.Load += new System.EventHandler(this.Busquedaproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBusquedaProductos;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label lblbusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}