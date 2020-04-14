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
            this.grdBusquedaEmpleados = new System.Windows.Forms.DataGridView();
            this.btncancelarempleado = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.lblbusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaEmpleados
            // 
            this.grdBusquedaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaEmpleados.Location = new System.Drawing.Point(37, 90);
            this.grdBusquedaEmpleados.Name = "grdBusquedaEmpleados";
            this.grdBusquedaEmpleados.Size = new System.Drawing.Size(603, 274);
            this.grdBusquedaEmpleados.TabIndex = 23;
            // 
            // btncancelarempleado
            // 
            this.btncancelarempleado.Location = new System.Drawing.Point(537, 43);
            this.btncancelarempleado.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelarempleado.Name = "btncancelarempleado";
            this.btncancelarempleado.Size = new System.Drawing.Size(77, 31);
            this.btncancelarempleado.TabIndex = 22;
            this.btncancelarempleado.Text = "CANCELAR";
            this.btncancelarempleado.UseVisualStyleBackColor = true;
            this.btncancelarempleado.Click += new System.EventHandler(this.btncancelarempleado_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(441, 43);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionar.TabIndex = 21;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(135, 49);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(270, 20);
            this.txtbusqueda.TabIndex = 20;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.AutoSize = true;
            this.lblbusqueda.Location = new System.Drawing.Point(76, 52);
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(40, 13);
            this.lblbusqueda.TabIndex = 19;
            this.lblbusqueda.Text = "Buscar";
            // 
            // Busquedaempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 407);
            this.Controls.Add(this.grdBusquedaEmpleados);
            this.Controls.Add(this.btncancelarempleado);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.lblbusqueda);
            this.Name = "Busquedaempleado";
            this.Text = "Busquedaempleado";
            this.Load += new System.EventHandler(this.Busquedaempleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBusquedaEmpleados;
        private System.Windows.Forms.Button btncancelarempleado;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label lblbusqueda;
    }
}