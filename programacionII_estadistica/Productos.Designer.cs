namespace programacionII_estadistica
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.grbdatosProducto = new System.Windows.Forms.GroupBox();
            this.cboCategoriaProductos = new System.Windows.Forms.ComboBox();
            this.lblnpruduto = new System.Windows.Forms.Label();
            this.lblidproduc = new System.Windows.Forms.Label();
            this.txtmarcaproducto = new System.Windows.Forms.TextBox();
            this.lblmarcaproducto = new System.Windows.Forms.Label();
            this.lblidcatego = new System.Windows.Forms.Label();
            this.txtidnumordenproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtiddescuentoproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcionproducto = new System.Windows.Forms.TextBox();
            this.lbldescripcionproducto = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.lblproducto = new System.Windows.Forms.Label();
            this.grbedicionproducto = new System.Windows.Forms.GroupBox();
            this.btnbuscarproducto = new System.Windows.Forms.Button();
            this.btneliminarproducto = new System.Windows.Forms.Button();
            this.btnmodificarproducto = new System.Windows.Forms.Button();
            this.btnagregarproducto = new System.Windows.Forms.Button();
            this.grbnavegacionproducto = new System.Windows.Forms.GroupBox();
            this.btnultimoregistroproducto = new System.Windows.Forms.Button();
            this.btnregistrosiguienteproducto = new System.Windows.Forms.Button();
            this.btnregistroanteriorproducto = new System.Windows.Forms.Button();
            this.btn1registroproductos = new System.Windows.Forms.Button();
            this.grbdatosProducto.SuspendLayout();
            this.grbedicionproducto.SuspendLayout();
            this.grbnavegacionproducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbdatosProducto
            // 
            this.grbdatosProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbdatosProducto.BackgroundImage")));
            this.grbdatosProducto.Controls.Add(this.cboCategoriaProductos);
            this.grbdatosProducto.Controls.Add(this.lblnpruduto);
            this.grbdatosProducto.Controls.Add(this.lblidproduc);
            this.grbdatosProducto.Controls.Add(this.txtmarcaproducto);
            this.grbdatosProducto.Controls.Add(this.lblmarcaproducto);
            this.grbdatosProducto.Controls.Add(this.lblidcatego);
            this.grbdatosProducto.Controls.Add(this.txtidnumordenproducto);
            this.grbdatosProducto.Controls.Add(this.label2);
            this.grbdatosProducto.Controls.Add(this.txtiddescuentoproducto);
            this.grbdatosProducto.Controls.Add(this.label1);
            this.grbdatosProducto.Controls.Add(this.txtdescripcionproducto);
            this.grbdatosProducto.Controls.Add(this.lbldescripcionproducto);
            this.grbdatosProducto.Controls.Add(this.txtidproducto);
            this.grbdatosProducto.Controls.Add(this.lblproducto);
            this.grbdatosProducto.Enabled = false;
            this.grbdatosProducto.Location = new System.Drawing.Point(30, 12);
            this.grbdatosProducto.Name = "grbdatosProducto";
            this.grbdatosProducto.Size = new System.Drawing.Size(357, 302);
            this.grbdatosProducto.TabIndex = 5;
            this.grbdatosProducto.TabStop = false;
            this.grbdatosProducto.Text = "Datos del producto";
            // 
            // cboCategoriaProductos
            // 
            this.cboCategoriaProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaProductos.FormattingEnabled = true;
            this.cboCategoriaProductos.Location = new System.Drawing.Point(124, 214);
            this.cboCategoriaProductos.Margin = new System.Windows.Forms.Padding(1);
            this.cboCategoriaProductos.Name = "cboCategoriaProductos";
            this.cboCategoriaProductos.Size = new System.Drawing.Size(171, 21);
            this.cboCategoriaProductos.TabIndex = 15;
            this.cboCategoriaProductos.SelectedIndexChanged += new System.EventHandler(this.cboCategoriaProductos_SelectedIndexChanged);
            // 
            // lblnpruduto
            // 
            this.lblnpruduto.AutoSize = true;
            this.lblnpruduto.Location = new System.Drawing.Point(290, 35);
            this.lblnpruduto.Name = "lblnpruduto";
            this.lblnpruduto.Size = new System.Drawing.Size(10, 13);
            this.lblnpruduto.TabIndex = 13;
            this.lblnpruduto.Text = ":";
            // 
            // lblidproduc
            // 
            this.lblidproduc.AutoSize = true;
            this.lblidproduc.Location = new System.Drawing.Point(263, 35);
            this.lblidproduc.Name = "lblidproduc";
            this.lblidproduc.Size = new System.Drawing.Size(18, 13);
            this.lblidproduc.TabIndex = 17;
            this.lblidproduc.Text = "ID";
            // 
            // txtmarcaproducto
            // 
            this.txtmarcaproducto.Location = new System.Drawing.Point(124, 258);
            this.txtmarcaproducto.Name = "txtmarcaproducto";
            this.txtmarcaproducto.Size = new System.Drawing.Size(171, 20);
            this.txtmarcaproducto.TabIndex = 14;
            this.txtmarcaproducto.TextChanged += new System.EventHandler(this.txtmarcaproducto_TextChanged);
            // 
            // lblmarcaproducto
            // 
            this.lblmarcaproducto.AutoSize = true;
            this.lblmarcaproducto.Location = new System.Drawing.Point(42, 261);
            this.lblmarcaproducto.Name = "lblmarcaproducto";
            this.lblmarcaproducto.Size = new System.Drawing.Size(37, 13);
            this.lblmarcaproducto.TabIndex = 12;
            this.lblmarcaproducto.Text = "Marca";
            // 
            // lblidcatego
            // 
            this.lblidcatego.AutoSize = true;
            this.lblidcatego.Location = new System.Drawing.Point(42, 217);
            this.lblidcatego.Name = "lblidcatego";
            this.lblidcatego.Size = new System.Drawing.Size(52, 13);
            this.lblidcatego.TabIndex = 11;
            this.lblidcatego.Text = "Categoria";
            this.lblidcatego.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtidnumordenproducto
            // 
            this.txtidnumordenproducto.Location = new System.Drawing.Point(124, 180);
            this.txtidnumordenproducto.Name = "txtidnumordenproducto";
            this.txtidnumordenproducto.Size = new System.Drawing.Size(171, 20);
            this.txtidnumordenproducto.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id Num Orden:";
            // 
            // txtiddescuentoproducto
            // 
            this.txtiddescuentoproducto.Location = new System.Drawing.Point(167, 134);
            this.txtiddescuentoproducto.Name = "txtiddescuentoproducto";
            this.txtiddescuentoproducto.Size = new System.Drawing.Size(123, 20);
            this.txtiddescuentoproducto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id Descuento del producto:";
            // 
            // txtdescripcionproducto
            // 
            this.txtdescripcionproducto.Location = new System.Drawing.Point(119, 72);
            this.txtdescripcionproducto.Multiline = true;
            this.txtdescripcionproducto.Name = "txtdescripcionproducto";
            this.txtdescripcionproducto.Size = new System.Drawing.Size(171, 49);
            this.txtdescripcionproducto.TabIndex = 3;
            // 
            // lbldescripcionproducto
            // 
            this.lbldescripcionproducto.AutoSize = true;
            this.lbldescripcionproducto.Location = new System.Drawing.Point(34, 75);
            this.lbldescripcionproducto.Name = "lbldescripcionproducto";
            this.lbldescripcionproducto.Size = new System.Drawing.Size(66, 13);
            this.lbldescripcionproducto.TabIndex = 2;
            this.lbldescripcionproducto.Text = "Descripcion:";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(119, 32);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(129, 20);
            this.txtidproducto.TabIndex = 1;
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(34, 32);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(79, 13);
            this.lblproducto.TabIndex = 0;
            this.lblproducto.Text = "Id de producto:";
            // 
            // grbedicionproducto
            // 
            this.grbedicionproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbedicionproducto.BackgroundImage")));
            this.grbedicionproducto.Controls.Add(this.btnbuscarproducto);
            this.grbedicionproducto.Controls.Add(this.btneliminarproducto);
            this.grbedicionproducto.Controls.Add(this.btnmodificarproducto);
            this.grbedicionproducto.Controls.Add(this.btnagregarproducto);
            this.grbedicionproducto.Location = new System.Drawing.Point(30, 320);
            this.grbedicionproducto.Name = "grbedicionproducto";
            this.grbedicionproducto.Size = new System.Drawing.Size(357, 100);
            this.grbedicionproducto.TabIndex = 6;
            this.grbedicionproducto.TabStop = false;
            this.grbedicionproducto.Text = "Edicion de producto";
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscarproducto.BackgroundImage")));
            this.btnbuscarproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarproducto.Location = new System.Drawing.Point(276, 18);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(75, 35);
            this.btnbuscarproducto.TabIndex = 9;
            this.btnbuscarproducto.Text = "Buscar";
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // btneliminarproducto
            // 
            this.btneliminarproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminarproducto.BackgroundImage")));
            this.btneliminarproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminarproducto.Location = new System.Drawing.Point(141, 18);
            this.btneliminarproducto.Name = "btneliminarproducto";
            this.btneliminarproducto.Size = new System.Drawing.Size(75, 35);
            this.btneliminarproducto.TabIndex = 8;
            this.btneliminarproducto.Text = "Eliminar";
            this.btneliminarproducto.UseVisualStyleBackColor = true;
            this.btneliminarproducto.Click += new System.EventHandler(this.btneliminarproducto_Click);
            // 
            // btnmodificarproducto
            // 
            this.btnmodificarproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodificarproducto.BackgroundImage")));
            this.btnmodificarproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificarproducto.Location = new System.Drawing.Point(76, 59);
            this.btnmodificarproducto.Name = "btnmodificarproducto";
            this.btnmodificarproducto.Size = new System.Drawing.Size(75, 35);
            this.btnmodificarproducto.TabIndex = 7;
            this.btnmodificarproducto.Text = "Modificar";
            this.btnmodificarproducto.UseVisualStyleBackColor = true;
            this.btnmodificarproducto.Click += new System.EventHandler(this.btnmodificarproducto_Click);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregarproducto.BackgroundImage")));
            this.btnagregarproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregarproducto.Location = new System.Drawing.Point(6, 19);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(75, 35);
            this.btnagregarproducto.TabIndex = 6;
            this.btnagregarproducto.Text = "Nuevo";
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // grbnavegacionproducto
            // 
            this.grbnavegacionproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbnavegacionproducto.BackgroundImage")));
            this.grbnavegacionproducto.Controls.Add(this.btnultimoregistroproducto);
            this.grbnavegacionproducto.Controls.Add(this.btnregistrosiguienteproducto);
            this.grbnavegacionproducto.Controls.Add(this.btnregistroanteriorproducto);
            this.grbnavegacionproducto.Controls.Add(this.btn1registroproductos);
            this.grbnavegacionproducto.Location = new System.Drawing.Point(30, 426);
            this.grbnavegacionproducto.Name = "grbnavegacionproducto";
            this.grbnavegacionproducto.Size = new System.Drawing.Size(357, 100);
            this.grbnavegacionproducto.TabIndex = 7;
            this.grbnavegacionproducto.TabStop = false;
            this.grbnavegacionproducto.Text = "Navegacion";
            // 
            // btnultimoregistroproducto
            // 
            this.btnultimoregistroproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnultimoregistroproducto.BackgroundImage")));
            this.btnultimoregistroproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnultimoregistroproducto.Location = new System.Drawing.Point(156, 18);
            this.btnultimoregistroproducto.Name = "btnultimoregistroproducto";
            this.btnultimoregistroproducto.Size = new System.Drawing.Size(75, 35);
            this.btnultimoregistroproducto.TabIndex = 12;
            this.btnultimoregistroproducto.Text = "Ultimo registro";
            this.btnultimoregistroproducto.UseVisualStyleBackColor = true;
            this.btnultimoregistroproducto.Click += new System.EventHandler(this.btnultimoregistroproducto_Click);
            // 
            // btnregistrosiguienteproducto
            // 
            this.btnregistrosiguienteproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrosiguienteproducto.BackgroundImage")));
            this.btnregistrosiguienteproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrosiguienteproducto.Location = new System.Drawing.Point(225, 59);
            this.btnregistrosiguienteproducto.Name = "btnregistrosiguienteproducto";
            this.btnregistrosiguienteproducto.Size = new System.Drawing.Size(75, 35);
            this.btnregistrosiguienteproducto.TabIndex = 11;
            this.btnregistrosiguienteproducto.Text = "Siguiente registro";
            this.btnregistrosiguienteproducto.UseVisualStyleBackColor = true;
            this.btnregistrosiguienteproducto.Click += new System.EventHandler(this.btnregistrosiguienteproducto_Click);
            // 
            // btnregistroanteriorproducto
            // 
            this.btnregistroanteriorproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistroanteriorproducto.BackgroundImage")));
            this.btnregistroanteriorproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistroanteriorproducto.Location = new System.Drawing.Point(76, 61);
            this.btnregistroanteriorproducto.Name = "btnregistroanteriorproducto";
            this.btnregistroanteriorproducto.Size = new System.Drawing.Size(75, 35);
            this.btnregistroanteriorproducto.TabIndex = 10;
            this.btnregistroanteriorproducto.Text = "Registro anterior";
            this.btnregistroanteriorproducto.UseVisualStyleBackColor = true;
            this.btnregistroanteriorproducto.Click += new System.EventHandler(this.btnregistroanteriorproducto_Click);
            // 
            // btn1registroproductos
            // 
            this.btn1registroproductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1registroproductos.BackgroundImage")));
            this.btn1registroproductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1registroproductos.Location = new System.Drawing.Point(6, 20);
            this.btn1registroproductos.Name = "btn1registroproductos";
            this.btn1registroproductos.Size = new System.Drawing.Size(75, 35);
            this.btn1registroproductos.TabIndex = 9;
            this.btn1registroproductos.Text = "1° registro";
            this.btn1registroproductos.UseVisualStyleBackColor = true;
            this.btn1registroproductos.Click += new System.EventHandler(this.btn1registroproductos_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programacionII_estadistica.Properties.Resources.degrado;
            this.ClientSize = new System.Drawing.Size(437, 541);
            this.Controls.Add(this.grbnavegacionproducto);
            this.Controls.Add(this.grbedicionproducto);
            this.Controls.Add(this.grbdatosProducto);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.grbdatosProducto.ResumeLayout(false);
            this.grbdatosProducto.PerformLayout();
            this.grbedicionproducto.ResumeLayout(false);
            this.grbnavegacionproducto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdatosProducto;
        private System.Windows.Forms.TextBox txtdescripcionproducto;
        private System.Windows.Forms.Label lbldescripcionproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.GroupBox grbedicionproducto;
        private System.Windows.Forms.Button btnbuscarproducto;
        private System.Windows.Forms.Button btneliminarproducto;
        private System.Windows.Forms.Button btnmodificarproducto;
        private System.Windows.Forms.Button btnagregarproducto;
        private System.Windows.Forms.GroupBox grbnavegacionproducto;
        private System.Windows.Forms.Button btnultimoregistroproducto;
        private System.Windows.Forms.Button btnregistrosiguienteproducto;
        private System.Windows.Forms.Button btnregistroanteriorproducto;
        private System.Windows.Forms.Button btn1registroproductos;
        private System.Windows.Forms.TextBox txtiddescuentoproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnpruduto;
        private System.Windows.Forms.TextBox txtidnumordenproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmarcaproducto;
        private System.Windows.Forms.Label lblidcatego;
        private System.Windows.Forms.TextBox txtmarcaproducto;
        private System.Windows.Forms.Label lblidproduc;
        private System.Windows.Forms.ComboBox cboCategoriaProductos;
    }
}