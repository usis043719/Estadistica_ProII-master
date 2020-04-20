namespace programacionII_estadistica
{
    partial class libreria
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
            this.btnbusquedaclientes = new System.Windows.Forms.Button();
            this.btnbusquedaempleados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btninventario = new System.Windows.Forms.Button();
            this.btndesc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbusquedaclientes
            // 
            this.btnbusquedaclientes.Location = new System.Drawing.Point(3, 12);
            this.btnbusquedaclientes.Name = "btnbusquedaclientes";
            this.btnbusquedaclientes.Size = new System.Drawing.Size(133, 44);
            this.btnbusquedaclientes.TabIndex = 1;
            this.btnbusquedaclientes.Text = "CLIENTES";
            this.btnbusquedaclientes.UseVisualStyleBackColor = true;
            this.btnbusquedaclientes.Click += new System.EventHandler(this.btnbusquedaclientes_Click);
            // 
            // btnbusquedaempleados
            // 
            this.btnbusquedaempleados.Location = new System.Drawing.Point(3, 129);
            this.btnbusquedaempleados.Name = "btnbusquedaempleados";
            this.btnbusquedaempleados.Size = new System.Drawing.Size(133, 42);
            this.btnbusquedaempleados.TabIndex = 2;
            this.btnbusquedaempleados.Text = "PRODUCTOS";
            this.btnbusquedaempleados.UseVisualStyleBackColor = true;
            this.btnbusquedaempleados.Click += new System.EventHandler(this.btnbusquedaempleados_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "EMPLEADOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "PROVEEDORES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btninventario
            // 
            this.btninventario.Location = new System.Drawing.Point(344, 129);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(138, 44);
            this.btninventario.TabIndex = 5;
            this.btninventario.Text = "INVENTARIO";
            this.btninventario.UseVisualStyleBackColor = true;
            this.btninventario.Click += new System.EventHandler(this.btninventario_Click);
            // 
            // btndesc
            // 
            this.btndesc.Location = new System.Drawing.Point(344, 252);
            this.btndesc.Name = "btndesc";
            this.btndesc.Size = new System.Drawing.Size(138, 44);
            this.btndesc.TabIndex = 8;
            this.btndesc.Text = "DESCUENTO";
            this.btndesc.UseVisualStyleBackColor = true;
            this.btndesc.Click += new System.EventHandler(this.btndesc_Click);
            // 
            // libreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::programacionII_estadistica.Properties.Resources.logito;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 308);
            this.Controls.Add(this.btndesc);
            this.Controls.Add(this.btninventario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbusquedaempleados);
            this.Controls.Add(this.btnbusquedaclientes);
            this.Name = "libreria";
            this.Text = "libreria";
            this.Load += new System.EventHandler(this.libreria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbusquedaclientes;
        private System.Windows.Forms.Button btnbusquedaempleados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btninventario;
        private System.Windows.Forms.Button btndesc;
    }
}