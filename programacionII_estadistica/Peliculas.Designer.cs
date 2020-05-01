namespace programacionII_estadistica
{
    partial class Peliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peliculas));
            this.grbnavegacion = new System.Windows.Forms.GroupBox();
            this.lblncliente = new System.Windows.Forms.Label();
            this.btnultimoregistro = new System.Windows.Forms.Button();
            this.btnregistroanterior = new System.Windows.Forms.Button();
            this.btnsiguienteregistro = new System.Windows.Forms.Button();
            this.Registro1 = new System.Windows.Forms.Button();
            this.grbcliente = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.grbdatosPeliculas = new System.Windows.Forms.GroupBox();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.lbldura = new System.Windows.Forms.Label();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.lblidpelicula = new System.Windows.Forms.Label();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.lblTelfono = new System.Windows.Forms.Label();
            this.txtsinopsis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lblNombrepelicula = new System.Windows.Forms.Label();
            this.txtidpelicula = new System.Windows.Forms.TextBox();
            this.lblPeliculasID = new System.Windows.Forms.Label();
            this.grbnavegacion.SuspendLayout();
            this.grbcliente.SuspendLayout();
            this.grbdatosPeliculas.SuspendLayout();
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
            this.grbnavegacion.Location = new System.Drawing.Point(262, 339);
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
            // grbcliente
            // 
            this.grbcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbcliente.Controls.Add(this.btnbuscar);
            this.grbcliente.Controls.Add(this.btneliminar);
            this.grbcliente.Controls.Add(this.btnmodificar);
            this.grbcliente.Controls.Add(this.btnnuevo);
            this.grbcliente.Location = new System.Drawing.Point(33, 309);
            this.grbcliente.Name = "grbcliente";
            this.grbcliente.Size = new System.Drawing.Size(222, 194);
            this.grbcliente.TabIndex = 13;
            this.grbcliente.TabStop = false;
            this.grbcliente.Text = "Edicion de peliculas";
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
            // grbdatosPeliculas
            // 
            this.grbdatosPeliculas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbdatosPeliculas.Controls.Add(this.txtduracion);
            this.grbdatosPeliculas.Controls.Add(this.lbldura);
            this.grbdatosPeliculas.Controls.Add(this.lblidcliente);
            this.grbdatosPeliculas.Controls.Add(this.lblidpelicula);
            this.grbdatosPeliculas.Controls.Add(this.txtgenero);
            this.grbdatosPeliculas.Controls.Add(this.lblTelfono);
            this.grbdatosPeliculas.Controls.Add(this.txtsinopsis);
            this.grbdatosPeliculas.Controls.Add(this.label2);
            this.grbdatosPeliculas.Controls.Add(this.txtdescripcion);
            this.grbdatosPeliculas.Controls.Add(this.lblNombrepelicula);
            this.grbdatosPeliculas.Controls.Add(this.txtidpelicula);
            this.grbdatosPeliculas.Controls.Add(this.lblPeliculasID);
            this.grbdatosPeliculas.Enabled = false;
            this.grbdatosPeliculas.Location = new System.Drawing.Point(12, 12);
            this.grbdatosPeliculas.Name = "grbdatosPeliculas";
            this.grbdatosPeliculas.Size = new System.Drawing.Size(321, 291);
            this.grbdatosPeliculas.TabIndex = 12;
            this.grbdatosPeliculas.TabStop = false;
            this.grbdatosPeliculas.Text = "Datos del cliente";
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(119, 254);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(171, 20);
            this.txtduracion.TabIndex = 17;
            // 
            // lbldura
            // 
            this.lbldura.AutoSize = true;
            this.lbldura.Location = new System.Drawing.Point(21, 257);
            this.lbldura.Name = "lbldura";
            this.lbldura.Size = new System.Drawing.Size(53, 13);
            this.lbldura.TabIndex = 16;
            this.lbldura.Text = "Duracion:";
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
            // lblidpelicula
            // 
            this.lblidpelicula.AutoSize = true;
            this.lblidpelicula.Location = new System.Drawing.Point(271, 35);
            this.lblidpelicula.Name = "lblidpelicula";
            this.lblidpelicula.Size = new System.Drawing.Size(10, 13);
            this.lblidpelicula.TabIndex = 14;
            this.lblidpelicula.Text = ":";
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(119, 220);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(171, 20);
            this.txtgenero.TabIndex = 7;
            // 
            // lblTelfono
            // 
            this.lblTelfono.AutoSize = true;
            this.lblTelfono.Location = new System.Drawing.Point(18, 223);
            this.lblTelfono.Name = "lblTelfono";
            this.lblTelfono.Size = new System.Drawing.Size(45, 13);
            this.lblTelfono.TabIndex = 6;
            this.lblTelfono.Text = "Genero:";
            // 
            // txtsinopsis
            // 
            this.txtsinopsis.Location = new System.Drawing.Point(119, 112);
            this.txtsinopsis.Multiline = true;
            this.txtsinopsis.Name = "txtsinopsis";
            this.txtsinopsis.Size = new System.Drawing.Size(171, 102);
            this.txtsinopsis.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sinopsis:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(119, 76);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(171, 20);
            this.txtdescripcion.TabIndex = 3;
            // 
            // lblNombrepelicula
            // 
            this.lblNombrepelicula.AutoSize = true;
            this.lblNombrepelicula.Location = new System.Drawing.Point(18, 79);
            this.lblNombrepelicula.Name = "lblNombrepelicula";
            this.lblNombrepelicula.Size = new System.Drawing.Size(99, 13);
            this.lblNombrepelicula.TabIndex = 2;
            this.lblNombrepelicula.Text = "Nombre de Pelicula";
            // 
            // txtidpelicula
            // 
            this.txtidpelicula.Location = new System.Drawing.Point(119, 32);
            this.txtidpelicula.Name = "txtidpelicula";
            this.txtidpelicula.Size = new System.Drawing.Size(112, 20);
            this.txtidpelicula.TabIndex = 1;
            // 
            // lblPeliculasID
            // 
            this.lblPeliculasID.AutoSize = true;
            this.lblPeliculasID.Location = new System.Drawing.Point(18, 39);
            this.lblPeliculasID.Name = "lblPeliculasID";
            this.lblPeliculasID.Size = new System.Drawing.Size(71, 13);
            this.lblPeliculasID.TabIndex = 0;
            this.lblPeliculasID.Text = "Id de Pelicula";
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 515);
            this.Controls.Add(this.grbnavegacion);
            this.Controls.Add(this.grbcliente);
            this.Controls.Add(this.grbdatosPeliculas);
            this.Name = "Peliculas";
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.Peliculas_Load);
            this.grbnavegacion.ResumeLayout(false);
            this.grbnavegacion.PerformLayout();
            this.grbcliente.ResumeLayout(false);
            this.grbdatosPeliculas.ResumeLayout(false);
            this.grbdatosPeliculas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbnavegacion;
        private System.Windows.Forms.Label lblncliente;
        private System.Windows.Forms.Button btnultimoregistro;
        private System.Windows.Forms.Button btnregistroanterior;
        private System.Windows.Forms.Button btnsiguienteregistro;
        private System.Windows.Forms.Button Registro1;
        private System.Windows.Forms.GroupBox grbcliente;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.GroupBox grbdatosPeliculas;
        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.Label lbldura;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.Label lblidpelicula;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.Label lblTelfono;
        private System.Windows.Forms.TextBox txtsinopsis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lblNombrepelicula;
        private System.Windows.Forms.TextBox txtidpelicula;
        private System.Windows.Forms.Label lblPeliculasID;
    }
}