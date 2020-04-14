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
            this.SuspendLayout();
            // 
            // btnbusquedaclientes
            // 
            this.btnbusquedaclientes.Location = new System.Drawing.Point(82, 51);
            this.btnbusquedaclientes.Name = "btnbusquedaclientes";
            this.btnbusquedaclientes.Size = new System.Drawing.Size(133, 44);
            this.btnbusquedaclientes.TabIndex = 1;
            this.btnbusquedaclientes.Text = "busqueda de clientes";
            this.btnbusquedaclientes.UseVisualStyleBackColor = true;
            this.btnbusquedaclientes.Click += new System.EventHandler(this.btnbusquedaclientes_Click);
            // 
            // btnbusquedaempleados
            // 
            this.btnbusquedaempleados.Location = new System.Drawing.Point(82, 110);
            this.btnbusquedaempleados.Name = "btnbusquedaempleados";
            this.btnbusquedaempleados.Size = new System.Drawing.Size(133, 42);
            this.btnbusquedaempleados.TabIndex = 2;
            this.btnbusquedaempleados.Text = "busqueda de Productos";
            this.btnbusquedaempleados.UseVisualStyleBackColor = true;
            this.btnbusquedaempleados.Click += new System.EventHandler(this.btnbusquedaempleados_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "busqueda empleados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // libreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(310, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbusquedaempleados);
            this.Controls.Add(this.btnbusquedaclientes);
            this.Name = "libreria";
            this.Text = "libreria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbusquedaclientes;
        private System.Windows.Forms.Button btnbusquedaempleados;
        private System.Windows.Forms.Button button1;
    }
}