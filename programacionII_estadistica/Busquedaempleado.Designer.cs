namespace programacionII_estadistica
{
    partial class Busquedaempleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busquedaempleado));
            this.grdBusquedaEmpleados = new System.Windows.Forms.DataGridView();
            this.btncancelarempleado = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.lblbusqueda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaEmpleados
            // 
            this.grdBusquedaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaEmpleados.Location = new System.Drawing.Point(12, 88);
            this.grdBusquedaEmpleados.Name = "grdBusquedaEmpleados";
            this.grdBusquedaEmpleados.Size = new System.Drawing.Size(596, 274);
            this.grdBusquedaEmpleados.TabIndex = 23;
            // 
            // btncancelarempleado
            // 
            this.btncancelarempleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncancelarempleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelarempleado.BackgroundImage")));
            this.btncancelarempleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelarempleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarempleado.Location = new System.Drawing.Point(497, 26);
            this.btncancelarempleado.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelarempleado.Name = "btncancelarempleado";
            this.btncancelarempleado.Size = new System.Drawing.Size(111, 40);
            this.btncancelarempleado.TabIndex = 22;
            this.btncancelarempleado.Text = "CANCELAR";
            this.btncancelarempleado.UseVisualStyleBackColor = false;
            this.btncancelarempleado.Click += new System.EventHandler(this.btncancelarempleado_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnseleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnseleccionar.BackgroundImage")));
            this.btnseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionar.Location = new System.Drawing.Point(367, 26);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(128, 40);
            this.btnseleccionar.TabIndex = 21;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(93, 36);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(270, 20);
            this.txtbusqueda.TabIndex = 20;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.AutoSize = true;
            this.lblbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblbusqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbusqueda.Location = new System.Drawing.Point(12, 34);
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(75, 22);
            this.lblbusqueda.TabIndex = 19;
            this.lblbusqueda.Text = "Buscar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::programacionII_estadistica.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(333, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Busquedaempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdBusquedaEmpleados);
            this.Controls.Add(this.btncancelarempleado);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.lblbusqueda);
            this.Name = "Busquedaempleado";
            this.Text = "Busquedaempleado";
            this.Load += new System.EventHandler(this.Busquedaempleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBusquedaEmpleados;
        private System.Windows.Forms.Button btncancelarempleado;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label lblbusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}