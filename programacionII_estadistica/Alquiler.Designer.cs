namespace programacionII_estadistica
{
    partial class Alquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alquiler));
            this.grbnavegacion = new System.Windows.Forms.GroupBox();
            this.lblncliente = new System.Windows.Forms.Label();
            this.btnultimoregistro = new System.Windows.Forms.Button();
            this.btnregistroanterior = new System.Windows.Forms.Button();
            this.btnsiguienteregistro = new System.Windows.Forms.Button();
            this.Registro1 = new System.Windows.Forms.Button();
            this.grbalquiler = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.grbdatosAlquiler = new System.Windows.Forms.GroupBox();
            this.btnBuscarpeliculaalquiler = new System.Windows.Forms.Button();
            this.btbbuscarcliente = new System.Windows.Forms.Button();
            this.cboclientesalquiler = new System.Windows.Forms.ComboBox();
            this.cbopeliculasalquiler = new System.Windows.Forms.ComboBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfechadevolucion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.lblidalquiler = new System.Windows.Forms.Label();
            this.txtfechaprestamo = new System.Windows.Forms.TextBox();
            this.lblTelfono = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtidalquiler = new System.Windows.Forms.TextBox();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.grbnavegacion.SuspendLayout();
            this.grbalquiler.SuspendLayout();
            this.grbdatosAlquiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbnavegacion
            // 
            this.grbnavegacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbnavegacion.Controls.Add(this.lblncliente);
            this.grbnavegacion.Controls.Add(this.btnultimoregistro);
            this.grbnavegacion.Controls.Add(this.btnregistroanterior);
            this.grbnavegacion.Controls.Add(this.btnsiguienteregistro);
            this.grbnavegacion.Controls.Add(this.Registro1);
            this.grbnavegacion.Location = new System.Drawing.Point(250, 367);
            this.grbnavegacion.Name = "grbnavegacion";
            this.grbnavegacion.Size = new System.Drawing.Size(173, 153);
            this.grbnavegacion.TabIndex = 14;
            this.grbnavegacion.TabStop = false;
            this.grbnavegacion.Text = "Navegacion";
            // 
            // lblncliente
            // 
            this.lblncliente.AutoSize = true;
            this.lblncliente.Location = new System.Drawing.Point(360, 30);
            this.lblncliente.Name = "lblncliente";
            this.lblncliente.Size = new System.Drawing.Size(10, 13);
            this.lblncliente.TabIndex = 9;
            this.lblncliente.Text = ":";
            // 
            // btnultimoregistro
            // 
            this.btnultimoregistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnultimoregistro.BackgroundImage")));
            this.btnultimoregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnultimoregistro.Location = new System.Drawing.Point(89, 85);
            this.btnultimoregistro.Name = "btnultimoregistro";
            this.btnultimoregistro.Size = new System.Drawing.Size(75, 35);
            this.btnultimoregistro.TabIndex = 8;
            this.btnultimoregistro.Text = "Ultimo registro";
            this.btnultimoregistro.UseVisualStyleBackColor = true;
            this.btnultimoregistro.Click += new System.EventHandler(this.btnultimoregistro_Click);
            // 
            // btnregistroanterior
            // 
            this.btnregistroanterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistroanterior.BackgroundImage")));
            this.btnregistroanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistroanterior.Location = new System.Drawing.Point(8, 85);
            this.btnregistroanterior.Name = "btnregistroanterior";
            this.btnregistroanterior.Size = new System.Drawing.Size(75, 35);
            this.btnregistroanterior.TabIndex = 7;
            this.btnregistroanterior.Text = "Registro anterior";
            this.btnregistroanterior.UseVisualStyleBackColor = true;
            this.btnregistroanterior.Click += new System.EventHandler(this.btnregistroanterior_Click);
            // 
            // btnsiguienteregistro
            // 
            this.btnsiguienteregistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsiguienteregistro.BackgroundImage")));
            this.btnsiguienteregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsiguienteregistro.Location = new System.Drawing.Point(89, 19);
            this.btnsiguienteregistro.Name = "btnsiguienteregistro";
            this.btnsiguienteregistro.Size = new System.Drawing.Size(75, 35);
            this.btnsiguienteregistro.TabIndex = 6;
            this.btnsiguienteregistro.Text = "Siguiente registro";
            this.btnsiguienteregistro.UseVisualStyleBackColor = true;
            this.btnsiguienteregistro.Click += new System.EventHandler(this.btnsiguienteregistro_Click);
            // 
            // Registro1
            // 
            this.Registro1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Registro1.BackgroundImage")));
            this.Registro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Registro1.Location = new System.Drawing.Point(8, 20);
            this.Registro1.Name = "Registro1";
            this.Registro1.Size = new System.Drawing.Size(75, 35);
            this.Registro1.TabIndex = 5;
            this.Registro1.Text = "1° registro";
            this.Registro1.UseVisualStyleBackColor = true;
            this.Registro1.Click += new System.EventHandler(this.Registro1_Click);
            // 
            // grbalquiler
            // 
            this.grbalquiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbalquiler.Controls.Add(this.btnbuscar);
            this.grbalquiler.Controls.Add(this.btneliminar);
            this.grbalquiler.Controls.Add(this.btnmodificar);
            this.grbalquiler.Controls.Add(this.btnnuevo);
            this.grbalquiler.Location = new System.Drawing.Point(21, 337);
            this.grbalquiler.Name = "grbalquiler";
            this.grbalquiler.Size = new System.Drawing.Size(222, 194);
            this.grbalquiler.TabIndex = 13;
            this.grbalquiler.TabStop = false;
            this.grbalquiler.Text = "Edicion de cliente";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Location = new System.Drawing.Point(6, 148);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(204, 35);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Location = new System.Drawing.Point(6, 107);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(204, 35);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodificar.BackgroundImage")));
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Location = new System.Drawing.Point(6, 60);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(204, 35);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Location = new System.Drawing.Point(6, 19);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(204, 35);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // grbdatosAlquiler
            // 
            this.grbdatosAlquiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbdatosAlquiler.Controls.Add(this.btnBuscarpeliculaalquiler);
            this.grbdatosAlquiler.Controls.Add(this.btbbuscarcliente);
            this.grbdatosAlquiler.Controls.Add(this.cboclientesalquiler);
            this.grbdatosAlquiler.Controls.Add(this.cbopeliculasalquiler);
            this.grbdatosAlquiler.Controls.Add(this.txtvalor);
            this.grbdatosAlquiler.Controls.Add(this.label3);
            this.grbdatosAlquiler.Controls.Add(this.txtfechadevolucion);
            this.grbdatosAlquiler.Controls.Add(this.label1);
            this.grbdatosAlquiler.Controls.Add(this.lblidcliente);
            this.grbdatosAlquiler.Controls.Add(this.lblidalquiler);
            this.grbdatosAlquiler.Controls.Add(this.txtfechaprestamo);
            this.grbdatosAlquiler.Controls.Add(this.lblTelfono);
            this.grbdatosAlquiler.Controls.Add(this.label2);
            this.grbdatosAlquiler.Controls.Add(this.lblNombreCliente);
            this.grbdatosAlquiler.Controls.Add(this.txtidalquiler);
            this.grbdatosAlquiler.Controls.Add(this.lblClienteID);
            this.grbdatosAlquiler.Enabled = false;
            this.grbdatosAlquiler.Location = new System.Drawing.Point(12, 21);
            this.grbdatosAlquiler.Name = "grbdatosAlquiler";
            this.grbdatosAlquiler.Size = new System.Drawing.Size(402, 310);
            this.grbdatosAlquiler.TabIndex = 12;
            this.grbdatosAlquiler.TabStop = false;
            this.grbdatosAlquiler.Text = "Datos de Alquiler";
            // 
            // btnBuscarpeliculaalquiler
            // 
            this.btnBuscarpeliculaalquiler.Location = new System.Drawing.Point(292, 160);
            this.btnBuscarpeliculaalquiler.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscarpeliculaalquiler.Name = "btnBuscarpeliculaalquiler";
            this.btnBuscarpeliculaalquiler.Size = new System.Drawing.Size(91, 21);
            this.btnBuscarpeliculaalquiler.TabIndex = 22;
            this.btnBuscarpeliculaalquiler.Text = "Buscar Pelicula";
            this.btnBuscarpeliculaalquiler.UseVisualStyleBackColor = true;
            this.btnBuscarpeliculaalquiler.Click += new System.EventHandler(this.btnBuscarpeliculaalquiler_Click);
            // 
            // btbbuscarcliente
            // 
            this.btbbuscarcliente.Location = new System.Drawing.Point(292, 91);
            this.btbbuscarcliente.Margin = new System.Windows.Forms.Padding(1);
            this.btbbuscarcliente.Name = "btbbuscarcliente";
            this.btbbuscarcliente.Size = new System.Drawing.Size(91, 21);
            this.btbbuscarcliente.TabIndex = 22;
            this.btbbuscarcliente.Text = "Buscar Cliente";
            this.btbbuscarcliente.UseVisualStyleBackColor = true;
            this.btbbuscarcliente.Click += new System.EventHandler(this.btbbuscarcliente_Click);
            // 
            // cboclientesalquiler
            // 
            this.cboclientesalquiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboclientesalquiler.FormattingEnabled = true;
            this.cboclientesalquiler.Location = new System.Drawing.Point(119, 91);
            this.cboclientesalquiler.Margin = new System.Windows.Forms.Padding(1);
            this.cboclientesalquiler.Name = "cboclientesalquiler";
            this.cboclientesalquiler.Size = new System.Drawing.Size(171, 21);
            this.cboclientesalquiler.TabIndex = 21;
            // 
            // cbopeliculasalquiler
            // 
            this.cbopeliculasalquiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopeliculasalquiler.FormattingEnabled = true;
            this.cbopeliculasalquiler.Location = new System.Drawing.Point(119, 160);
            this.cbopeliculasalquiler.Margin = new System.Windows.Forms.Padding(1);
            this.cbopeliculasalquiler.Name = "cbopeliculasalquiler";
            this.cbopeliculasalquiler.Size = new System.Drawing.Size(171, 21);
            this.cbopeliculasalquiler.TabIndex = 20;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(122, 280);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(171, 20);
            this.txtvalor.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor:";
            // 
            // txtfechadevolucion
            // 
            this.txtfechadevolucion.Location = new System.Drawing.Point(122, 234);
            this.txtfechadevolucion.Name = "txtfechadevolucion";
            this.txtfechadevolucion.Size = new System.Drawing.Size(171, 20);
            this.txtfechadevolucion.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha de devolucion:";
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Location = new System.Drawing.Point(247, 35);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(18, 13);
            this.lblidcliente.TabIndex = 15;
            this.lblidcliente.Text = "ID";
            // 
            // lblidalquiler
            // 
            this.lblidalquiler.AutoSize = true;
            this.lblidalquiler.Location = new System.Drawing.Point(271, 35);
            this.lblidalquiler.Name = "lblidalquiler";
            this.lblidalquiler.Size = new System.Drawing.Size(10, 13);
            this.lblidalquiler.TabIndex = 14;
            this.lblidalquiler.Text = ":";
            // 
            // txtfechaprestamo
            // 
            this.txtfechaprestamo.Location = new System.Drawing.Point(119, 200);
            this.txtfechaprestamo.Name = "txtfechaprestamo";
            this.txtfechaprestamo.Size = new System.Drawing.Size(171, 20);
            this.txtfechaprestamo.TabIndex = 7;
            // 
            // lblTelfono
            // 
            this.lblTelfono.AutoSize = true;
            this.lblTelfono.Location = new System.Drawing.Point(18, 203);
            this.lblTelfono.Name = "lblTelfono";
            this.lblTelfono.Size = new System.Drawing.Size(101, 13);
            this.lblTelfono.TabIndex = 6;
            this.lblTelfono.Text = "Fecha de prestamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Pelicula:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(18, 91);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(82, 13);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre Cliente:";
            // 
            // txtidalquiler
            // 
            this.txtidalquiler.Location = new System.Drawing.Point(119, 32);
            this.txtidalquiler.Name = "txtidalquiler";
            this.txtidalquiler.Size = new System.Drawing.Size(112, 20);
            this.txtidalquiler.TabIndex = 1;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(18, 39);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(71, 13);
            this.lblClienteID.TabIndex = 0;
            this.lblClienteID.Text = "Id de Alquiler:";
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 534);
            this.Controls.Add(this.grbnavegacion);
            this.Controls.Add(this.grbalquiler);
            this.Controls.Add(this.grbdatosAlquiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alquiler";
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.Alquiler_Load);
            this.grbnavegacion.ResumeLayout(false);
            this.grbnavegacion.PerformLayout();
            this.grbalquiler.ResumeLayout(false);
            this.grbdatosAlquiler.ResumeLayout(false);
            this.grbdatosAlquiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbnavegacion;
        private System.Windows.Forms.Label lblncliente;
        private System.Windows.Forms.Button btnultimoregistro;
        private System.Windows.Forms.Button btnregistroanterior;
        private System.Windows.Forms.Button btnsiguienteregistro;
        private System.Windows.Forms.Button Registro1;
        private System.Windows.Forms.GroupBox grbalquiler;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.GroupBox grbdatosAlquiler;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfechadevolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.Label lblidalquiler;
        private System.Windows.Forms.TextBox txtfechaprestamo;
        private System.Windows.Forms.Label lblTelfono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtidalquiler;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.ComboBox cbopeliculasalquiler;
        private System.Windows.Forms.ComboBox cboclientesalquiler;
        private System.Windows.Forms.Button btbbuscarcliente;
        private System.Windows.Forms.Button btnBuscarpeliculaalquiler;
    }
}