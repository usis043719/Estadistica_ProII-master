namespace programacionII_estadistica
{
    partial class Busquedacategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busquedacategoria));
            this.grdbusquedacategoria = new System.Windows.Forms.DataGridView();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.lblbusqueda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdbusquedacategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdbusquedacategoria
            // 
            this.grdbusquedacategoria.AllowUserToAddRows = false;
            this.grdbusquedacategoria.AllowUserToDeleteRows = false;
            this.grdbusquedacategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdbusquedacategoria.Location = new System.Drawing.Point(10, 82);
            this.grdbusquedacategoria.Margin = new System.Windows.Forms.Padding(1);
            this.grdbusquedacategoria.Name = "grdbusquedacategoria";
            this.grdbusquedacategoria.ReadOnly = true;
            this.grdbusquedacategoria.RowHeadersWidth = 102;
            this.grdbusquedacategoria.RowTemplate.Height = 40;
            this.grdbusquedacategoria.Size = new System.Drawing.Size(611, 346);
            this.grdbusquedacategoria.TabIndex = 35;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(89, 32);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(270, 20);
            this.txtbusqueda.TabIndex = 32;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.AutoSize = true;
            this.lblbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblbusqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbusqueda.Location = new System.Drawing.Point(12, 28);
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(75, 22);
            this.lblbusqueda.TabIndex = 31;
            this.lblbusqueda.Text = "Buscar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::programacionII_estadistica.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(358, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Location = new System.Drawing.Point(512, 14);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(109, 54);
            this.btncancelar.TabIndex = 34;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnseleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnseleccionar.BackgroundImage")));
            this.btnseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionar.Location = new System.Drawing.Point(392, 14);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(118, 54);
            this.btnseleccionar.TabIndex = 33;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // Busquedacategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdbusquedacategoria);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.lblbusqueda);
            this.Name = "Busquedacategoria";
            this.Text = "Busquedacategoria";
            this.Load += new System.EventHandler(this.Busquedacategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdbusquedacategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grdbusquedacategoria;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label lblbusqueda;
    }
}