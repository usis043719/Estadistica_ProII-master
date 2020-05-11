namespace programacionII_estadistica
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.grbdatosEmpleado = new System.Windows.Forms.GroupBox();
            this.lblejemplo = new System.Windows.Forms.Label();
            this.btnBuscarCargoEmpleados = new System.Windows.Forms.Button();
            this.cboCargoEmpleado = new System.Windows.Forms.ComboBox();
            this.lblCategoriaE = new System.Windows.Forms.Label();
            this.lblidempleado = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombreempleado = new System.Windows.Forms.TextBox();
            this.lbldescripcionproducto = new System.Windows.Forms.Label();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.lblproducto = new System.Windows.Forms.Label();
            this.grbcliente = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.grbnavegacion = new System.Windows.Forms.GroupBox();
            this.btnultimoregistro = new System.Windows.Forms.Button();
            this.btnregistroanterior = new System.Windows.Forms.Button();
            this.btnsiguienteregistro = new System.Windows.Forms.Button();
            this.registro1 = new System.Windows.Forms.Button();
            this.grbdatosEmpleado.SuspendLayout();
            this.grbcliente.SuspendLayout();
            this.grbnavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbdatosEmpleado
            // 
            this.grbdatosEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.grbdatosEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbdatosEmpleado.Controls.Add(this.lblejemplo);
            this.grbdatosEmpleado.Controls.Add(this.btnBuscarCargoEmpleados);
            this.grbdatosEmpleado.Controls.Add(this.cboCargoEmpleado);
            this.grbdatosEmpleado.Controls.Add(this.lblCategoriaE);
            this.grbdatosEmpleado.Controls.Add(this.lblidempleado);
            this.grbdatosEmpleado.Controls.Add(this.lblempleado);
            this.grbdatosEmpleado.Controls.Add(this.txttelefono);
            this.grbdatosEmpleado.Controls.Add(this.label1);
            this.grbdatosEmpleado.Controls.Add(this.txtdireccion);
            this.grbdatosEmpleado.Controls.Add(this.label2);
            this.grbdatosEmpleado.Controls.Add(this.txtnombreempleado);
            this.grbdatosEmpleado.Controls.Add(this.lbldescripcionproducto);
            this.grbdatosEmpleado.Controls.Add(this.txtidempleado);
            this.grbdatosEmpleado.Controls.Add(this.lblproducto);
            this.grbdatosEmpleado.Enabled = false;
            this.grbdatosEmpleado.Location = new System.Drawing.Point(12, 12);
            this.grbdatosEmpleado.Name = "grbdatosEmpleado";
            this.grbdatosEmpleado.Size = new System.Drawing.Size(336, 274);
            this.grbdatosEmpleado.TabIndex = 11;
            this.grbdatosEmpleado.TabStop = false;
            this.grbdatosEmpleado.Text = "Datos del empleado";
            // 
            // lblejemplo
            // 
            this.lblejemplo.AutoSize = true;
            this.lblejemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblejemplo.Location = new System.Drawing.Point(115, 173);
            this.lblejemplo.Name = "lblejemplo";
            this.lblejemplo.Size = new System.Drawing.Size(97, 15);
            this.lblejemplo.TabIndex = 21;
            this.lblejemplo.Text = "Ej. 0000-0000";
            // 
            // btnBuscarCargoEmpleados
            // 
            this.btnBuscarCargoEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarCargoEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCargoEmpleados.BackgroundImage")));
            this.btnBuscarCargoEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCargoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCargoEmpleados.Location = new System.Drawing.Point(118, 226);
            this.btnBuscarCargoEmpleados.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscarCargoEmpleados.Name = "btnBuscarCargoEmpleados";
            this.btnBuscarCargoEmpleados.Size = new System.Drawing.Size(191, 34);
            this.btnBuscarCargoEmpleados.TabIndex = 20;
            this.btnBuscarCargoEmpleados.Text = "Buscar Cargo";
            this.btnBuscarCargoEmpleados.UseVisualStyleBackColor = false;
            this.btnBuscarCargoEmpleados.Click += new System.EventHandler(this.btnBuscarCargoEmpleados_Click);
            // 
            // cboCargoEmpleado
            // 
            this.cboCargoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargoEmpleado.FormattingEnabled = true;
            this.cboCargoEmpleado.Location = new System.Drawing.Point(118, 201);
            this.cboCargoEmpleado.Margin = new System.Windows.Forms.Padding(1);
            this.cboCargoEmpleado.Name = "cboCargoEmpleado";
            this.cboCargoEmpleado.Size = new System.Drawing.Size(191, 23);
            this.cboCargoEmpleado.TabIndex = 19;
            // 
            // lblCategoriaE
            // 
            this.lblCategoriaE.AutoSize = true;
            this.lblCategoriaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaE.Location = new System.Drawing.Point(6, 203);
            this.lblCategoriaE.Name = "lblCategoriaE";
            this.lblCategoriaE.Size = new System.Drawing.Size(45, 15);
            this.lblCategoriaE.TabIndex = 18;
            this.lblCategoriaE.Text = "Cargo";
            // 
            // lblidempleado
            // 
            this.lblidempleado.AutoSize = true;
            this.lblidempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidempleado.Location = new System.Drawing.Point(241, 29);
            this.lblidempleado.Name = "lblidempleado";
            this.lblidempleado.Size = new System.Drawing.Size(21, 15);
            this.lblidempleado.TabIndex = 15;
            this.lblidempleado.Text = "ID";
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempleado.Location = new System.Drawing.Point(265, 29);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(11, 15);
            this.lblempleado.TabIndex = 14;
            this.lblempleado.Text = ":";
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(118, 149);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(191, 21);
            this.txttelefono.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Telefono:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(118, 108);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(191, 21);
            this.txtdireccion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion:";
            // 
            // txtnombreempleado
            // 
            this.txtnombreempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreempleado.Location = new System.Drawing.Point(118, 69);
            this.txtnombreempleado.Name = "txtnombreempleado";
            this.txtnombreempleado.Size = new System.Drawing.Size(191, 21);
            this.txtnombreempleado.TabIndex = 3;
            // 
            // lbldescripcionproducto
            // 
            this.lbldescripcionproducto.AutoSize = true;
            this.lbldescripcionproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcionproducto.Location = new System.Drawing.Point(6, 60);
            this.lbldescripcionproducto.Name = "lbldescripcionproducto";
            this.lbldescripcionproducto.Size = new System.Drawing.Size(82, 30);
            this.lbldescripcionproducto.TabIndex = 2;
            this.lbldescripcionproducto.Text = "Nombre de \r\nempleado";
            // 
            // txtidempleado
            // 
            this.txtidempleado.Enabled = false;
            this.txtidempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidempleado.Location = new System.Drawing.Point(118, 26);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(112, 21);
            this.txtidempleado.TabIndex = 1;
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducto.Location = new System.Drawing.Point(5, 26);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(115, 15);
            this.lblproducto.TabIndex = 0;
            this.lblproducto.Text = "Id del empleado:";
            // 
            // grbcliente
            // 
            this.grbcliente.BackColor = System.Drawing.Color.Transparent;
            this.grbcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbcliente.Controls.Add(this.btnbuscar);
            this.grbcliente.Controls.Add(this.btneliminar);
            this.grbcliente.Controls.Add(this.btnmodificar);
            this.grbcliente.Controls.Add(this.btnagregar);
            this.grbcliente.Location = new System.Drawing.Point(354, 12);
            this.grbcliente.Name = "grbcliente";
            this.grbcliente.Size = new System.Drawing.Size(207, 358);
            this.grbcliente.TabIndex = 12;
            this.grbcliente.TabStop = false;
            this.grbcliente.Text = "Edicion de empleado";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(6, 299);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(187, 53);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(6, 153);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(187, 53);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmodificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodificar.BackgroundImage")));
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(6, 96);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(187, 51);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(6, 38);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(187, 52);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Nuevo";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // grbnavegacion
            // 
            this.grbnavegacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbnavegacion.Controls.Add(this.btnultimoregistro);
            this.grbnavegacion.Controls.Add(this.btnregistroanterior);
            this.grbnavegacion.Controls.Add(this.btnsiguienteregistro);
            this.grbnavegacion.Controls.Add(this.registro1);
            this.grbnavegacion.Location = new System.Drawing.Point(12, 292);
            this.grbnavegacion.Name = "grbnavegacion";
            this.grbnavegacion.Size = new System.Drawing.Size(336, 78);
            this.grbnavegacion.TabIndex = 13;
            this.grbnavegacion.TabStop = false;
            this.grbnavegacion.Text = "Navegacion";
            // 
            // btnultimoregistro
            // 
            this.btnultimoregistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnultimoregistro.BackgroundImage")));
            this.btnultimoregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnultimoregistro.Location = new System.Drawing.Point(251, 19);
            this.btnultimoregistro.Name = "btnultimoregistro";
            this.btnultimoregistro.Size = new System.Drawing.Size(75, 53);
            this.btnultimoregistro.TabIndex = 8;
            this.btnultimoregistro.UseVisualStyleBackColor = true;
            this.btnultimoregistro.Click += new System.EventHandler(this.btnultimoregistro_Click);
            // 
            // btnregistroanterior
            // 
            this.btnregistroanterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistroanterior.BackgroundImage")));
            this.btnregistroanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistroanterior.Location = new System.Drawing.Point(170, 19);
            this.btnregistroanterior.Name = "btnregistroanterior";
            this.btnregistroanterior.Size = new System.Drawing.Size(75, 53);
            this.btnregistroanterior.TabIndex = 7;
            this.btnregistroanterior.UseVisualStyleBackColor = true;
            this.btnregistroanterior.Click += new System.EventHandler(this.btnregistroanterior_Click);
            // 
            // btnsiguienteregistro
            // 
            this.btnsiguienteregistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsiguienteregistro.BackgroundImage")));
            this.btnsiguienteregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsiguienteregistro.Location = new System.Drawing.Point(89, 19);
            this.btnsiguienteregistro.Name = "btnsiguienteregistro";
            this.btnsiguienteregistro.Size = new System.Drawing.Size(75, 53);
            this.btnsiguienteregistro.TabIndex = 6;
            this.btnsiguienteregistro.UseVisualStyleBackColor = true;
            this.btnsiguienteregistro.Click += new System.EventHandler(this.btnsiguienteregistro_Click);
            // 
            // registro1
            // 
            this.registro1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registro1.BackgroundImage")));
            this.registro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registro1.Location = new System.Drawing.Point(8, 20);
            this.registro1.Name = "registro1";
            this.registro1.Size = new System.Drawing.Size(75, 52);
            this.registro1.TabIndex = 5;
            this.registro1.UseVisualStyleBackColor = true;
            this.registro1.Click += new System.EventHandler(this.registro1_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 387);
            this.Controls.Add(this.grbnavegacion);
            this.Controls.Add(this.grbcliente);
            this.Controls.Add(this.grbdatosEmpleado);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.grbdatosEmpleado.ResumeLayout(false);
            this.grbdatosEmpleado.PerformLayout();
            this.grbcliente.ResumeLayout(false);
            this.grbnavegacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdatosEmpleado;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombreempleado;
        private System.Windows.Forms.Label lbldescripcionproducto;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.GroupBox grbcliente;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox grbnavegacion;
        private System.Windows.Forms.Button btnultimoregistro;
        private System.Windows.Forms.Button btnregistroanterior;
        private System.Windows.Forms.Button btnsiguienteregistro;
        private System.Windows.Forms.Button registro1;
        private System.Windows.Forms.Label lblidempleado;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.ComboBox cboCargoEmpleado;
        private System.Windows.Forms.Label lblCategoriaE;
        private System.Windows.Forms.Button btnBuscarCargoEmpleados;
        private System.Windows.Forms.Label lblejemplo;
    }
}