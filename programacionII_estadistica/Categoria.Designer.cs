namespace programacionII_estadistica
{
    partial class Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria));
            this.grbnavegacion = new System.Windows.Forms.GroupBox();
            this.btnultimoregistro = new System.Windows.Forms.Button();
            this.btnregistrosiguiente = new System.Windows.Forms.Button();
            this.btnregistroanterior = new System.Windows.Forms.Button();
            this.btn1registro = new System.Windows.Forms.Button();
            this.grbedicioncargo = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.grbdatos = new System.Windows.Forms.GroupBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.lblncategoria = new System.Windows.Forms.Label();
            this.lblidproduc = new System.Windows.Forms.Label();
            this.lblidcatego = new System.Windows.Forms.Label();
            this.txtidcategoria = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.grbnavegacion.SuspendLayout();
            this.grbedicioncargo.SuspendLayout();
            this.grbdatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbnavegacion
            // 
            this.grbnavegacion.Controls.Add(this.btnultimoregistro);
            this.grbnavegacion.Controls.Add(this.btnregistrosiguiente);
            this.grbnavegacion.Controls.Add(this.btnregistroanterior);
            this.grbnavegacion.Controls.Add(this.btn1registro);
            this.grbnavegacion.Location = new System.Drawing.Point(24, 187);
            this.grbnavegacion.Name = "grbnavegacion";
            this.grbnavegacion.Size = new System.Drawing.Size(525, 66);
            this.grbnavegacion.TabIndex = 10;
            this.grbnavegacion.TabStop = false;
            this.grbnavegacion.Text = "Navegacion";
            // 
            // btnultimoregistro
            // 
            this.btnultimoregistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnultimoregistro.BackgroundImage")));
            this.btnultimoregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnultimoregistro.Location = new System.Drawing.Point(270, 19);
            this.btnultimoregistro.Name = "btnultimoregistro";
            this.btnultimoregistro.Size = new System.Drawing.Size(75, 35);
            this.btnultimoregistro.TabIndex = 12;
            this.btnultimoregistro.Text = "Ultimo registro";
            this.btnultimoregistro.UseVisualStyleBackColor = true;
            this.btnultimoregistro.Click += new System.EventHandler(this.btnultimoregistro_Click);
            // 
            // btnregistrosiguiente
            // 
            this.btnregistrosiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrosiguiente.BackgroundImage")));
            this.btnregistrosiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrosiguiente.Location = new System.Drawing.Point(87, 19);
            this.btnregistrosiguiente.Name = "btnregistrosiguiente";
            this.btnregistrosiguiente.Size = new System.Drawing.Size(75, 35);
            this.btnregistrosiguiente.TabIndex = 11;
            this.btnregistrosiguiente.Text = "Siguiente registro";
            this.btnregistrosiguiente.UseVisualStyleBackColor = true;
            this.btnregistrosiguiente.Click += new System.EventHandler(this.btnregistrosiguiente_Click);
            // 
            // btnregistroanterior
            // 
            this.btnregistroanterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistroanterior.BackgroundImage")));
            this.btnregistroanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistroanterior.Location = new System.Drawing.Point(189, 19);
            this.btnregistroanterior.Name = "btnregistroanterior";
            this.btnregistroanterior.Size = new System.Drawing.Size(75, 35);
            this.btnregistroanterior.TabIndex = 10;
            this.btnregistroanterior.Text = "Registro anterior";
            this.btnregistroanterior.UseVisualStyleBackColor = true;
            this.btnregistroanterior.Click += new System.EventHandler(this.btnregistroanterior_Click);
            // 
            // btn1registro
            // 
            this.btn1registro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1registro.BackgroundImage")));
            this.btn1registro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1registro.Location = new System.Drawing.Point(6, 20);
            this.btn1registro.Name = "btn1registro";
            this.btn1registro.Size = new System.Drawing.Size(75, 35);
            this.btn1registro.TabIndex = 9;
            this.btn1registro.Text = "1° registro";
            this.btn1registro.UseVisualStyleBackColor = true;
            this.btn1registro.Click += new System.EventHandler(this.btn1registro_Click);
            // 
            // grbedicioncargo
            // 
            this.grbedicioncargo.Controls.Add(this.btneliminar);
            this.grbedicioncargo.Controls.Add(this.btnmodificar);
            this.grbedicioncargo.Controls.Add(this.btnagregar);
            this.grbedicioncargo.Location = new System.Drawing.Point(333, 12);
            this.grbedicioncargo.Name = "grbedicioncargo";
            this.grbedicioncargo.Size = new System.Drawing.Size(216, 169);
            this.grbedicioncargo.TabIndex = 9;
            this.grbedicioncargo.TabStop = false;
            this.grbedicioncargo.Text = "Edicion de categoria";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Location = new System.Drawing.Point(339, 140);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(199, 31);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Location = new System.Drawing.Point(6, 94);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(199, 28);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodificar.BackgroundImage")));
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Location = new System.Drawing.Point(6, 53);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(199, 35);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.Location = new System.Drawing.Point(6, 19);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(199, 28);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Nuevo";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // grbdatos
            // 
            this.grbdatos.Controls.Add(this.txtcategoria);
            this.grbdatos.Controls.Add(this.lblncategoria);
            this.grbdatos.Controls.Add(this.lblidproduc);
            this.grbdatos.Controls.Add(this.lblidcatego);
            this.grbdatos.Controls.Add(this.txtidcategoria);
            this.grbdatos.Controls.Add(this.lblcategoria);
            this.grbdatos.Enabled = false;
            this.grbdatos.Location = new System.Drawing.Point(24, 12);
            this.grbdatos.Name = "grbdatos";
            this.grbdatos.Size = new System.Drawing.Size(300, 169);
            this.grbdatos.TabIndex = 8;
            this.grbdatos.TabStop = false;
            this.grbdatos.Text = "Categorias de Productos";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(102, 86);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(181, 20);
            this.txtcategoria.TabIndex = 18;
            // 
            // lblncategoria
            // 
            this.lblncategoria.AutoSize = true;
            this.lblncategoria.Location = new System.Drawing.Point(273, 42);
            this.lblncategoria.Name = "lblncategoria";
            this.lblncategoria.Size = new System.Drawing.Size(10, 13);
            this.lblncategoria.TabIndex = 13;
            this.lblncategoria.Text = ":";
            // 
            // lblidproduc
            // 
            this.lblidproduc.AutoSize = true;
            this.lblidproduc.Location = new System.Drawing.Point(246, 42);
            this.lblidproduc.Name = "lblidproduc";
            this.lblidproduc.Size = new System.Drawing.Size(18, 13);
            this.lblidproduc.TabIndex = 17;
            this.lblidproduc.Text = "ID";
            // 
            // lblidcatego
            // 
            this.lblidcatego.AutoSize = true;
            this.lblidcatego.Location = new System.Drawing.Point(20, 89);
            this.lblidcatego.Name = "lblidcatego";
            this.lblidcatego.Size = new System.Drawing.Size(52, 13);
            this.lblidcatego.TabIndex = 11;
            this.lblidcatego.Text = "Categoria";
            // 
            // txtidcategoria
            // 
            this.txtidcategoria.Location = new System.Drawing.Point(102, 39);
            this.txtidcategoria.Name = "txtidcategoria";
            this.txtidcategoria.Size = new System.Drawing.Size(129, 20);
            this.txtidcategoria.TabIndex = 1;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(17, 39);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(81, 13);
            this.lblcategoria.TabIndex = 0;
            this.lblcategoria.Text = "Id de categoria:";
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(562, 273);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.grbnavegacion);
            this.Controls.Add(this.grbedicioncargo);
            this.Controls.Add(this.grbdatos);
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.grbnavegacion.ResumeLayout(false);
            this.grbedicioncargo.ResumeLayout(false);
            this.grbdatos.ResumeLayout(false);
            this.grbdatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbnavegacion;
        private System.Windows.Forms.Button btnultimoregistro;
        private System.Windows.Forms.Button btnregistrosiguiente;
        private System.Windows.Forms.Button btnregistroanterior;
        private System.Windows.Forms.Button btn1registro;
        private System.Windows.Forms.GroupBox grbedicioncargo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox grbdatos;
        private System.Windows.Forms.Label lblncategoria;
        private System.Windows.Forms.Label lblidproduc;
        private System.Windows.Forms.Label lblidcatego;
        private System.Windows.Forms.TextBox txtidcategoria;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.TextBox txtcategoria;
    }
}