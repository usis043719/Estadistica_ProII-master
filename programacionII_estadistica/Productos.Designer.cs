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
            this.grbproducto = new System.Windows.Forms.GroupBox();
            this.lblidproducto = new System.Windows.Forms.Label();
            this.txtdescripcionproducto = new System.Windows.Forms.TextBox();
            this.lbldescripcionproducto = new System.Windows.Forms.Label();
            this.txtidproductoregistro = new System.Windows.Forms.TextBox();
            this.lblproducto = new System.Windows.Forms.Label();
            this.grbedicionproducto = new System.Windows.Forms.GroupBox();
            this.btnbuscarproducto = new System.Windows.Forms.Button();
            this.btneliminarproducto = new System.Windows.Forms.Button();
            this.btnmodificarproducto = new System.Windows.Forms.Button();
            this.btnagregarproducto = new System.Windows.Forms.Button();
            this.btnguardarproducto = new System.Windows.Forms.Button();
            this.grbnavegacionproducto = new System.Windows.Forms.GroupBox();
            this.btnultimoregistroproducto = new System.Windows.Forms.Button();
            this.btnregistrosiguienteproducto = new System.Windows.Forms.Button();
            this.btnregistroanteriorproducto = new System.Windows.Forms.Button();
            this.btn1registroproductos = new System.Windows.Forms.Button();
            this.grbproducto.SuspendLayout();
            this.grbedicionproducto.SuspendLayout();
            this.grbnavegacionproducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbproducto
            // 
            this.grbproducto.Controls.Add(this.lblidproducto);
            this.grbproducto.Controls.Add(this.txtdescripcionproducto);
            this.grbproducto.Controls.Add(this.lbldescripcionproducto);
            this.grbproducto.Controls.Add(this.txtidproductoregistro);
            this.grbproducto.Controls.Add(this.lblproducto);
            this.grbproducto.Enabled = false;
            this.grbproducto.Location = new System.Drawing.Point(30, 38);
            this.grbproducto.Name = "grbproducto";
            this.grbproducto.Size = new System.Drawing.Size(357, 152);
            this.grbproducto.TabIndex = 5;
            this.grbproducto.TabStop = false;
            this.grbproducto.Text = "Datos del producto";
            // 
            // lblidproducto
            // 
            this.lblidproducto.AutoSize = true;
            this.lblidproducto.Location = new System.Drawing.Point(248, 35);
            this.lblidproducto.Name = "lblidproducto";
            this.lblidproducto.Size = new System.Drawing.Size(19, 13);
            this.lblidproducto.TabIndex = 4;
            this.lblidproducto.Text = "Id:";
            // 
            // txtdescripcionproducto
            // 
            this.txtdescripcionproducto.Location = new System.Drawing.Point(119, 76);
            this.txtdescripcionproducto.Multiline = true;
            this.txtdescripcionproducto.Name = "txtdescripcionproducto";
            this.txtdescripcionproducto.Size = new System.Drawing.Size(171, 52);
            this.txtdescripcionproducto.TabIndex = 3;
            // 
            // lbldescripcionproducto
            // 
            this.lbldescripcionproducto.AutoSize = true;
            this.lbldescripcionproducto.Location = new System.Drawing.Point(35, 79);
            this.lbldescripcionproducto.Name = "lbldescripcionproducto";
            this.lbldescripcionproducto.Size = new System.Drawing.Size(66, 13);
            this.lbldescripcionproducto.TabIndex = 2;
            this.lbldescripcionproducto.Text = "Descripcion:";
            // 
            // txtidproductoregistro
            // 
            this.txtidproductoregistro.Location = new System.Drawing.Point(119, 32);
            this.txtidproductoregistro.Name = "txtidproductoregistro";
            this.txtidproductoregistro.Size = new System.Drawing.Size(112, 20);
            this.txtidproductoregistro.TabIndex = 1;
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(35, 35);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(79, 13);
            this.lblproducto.TabIndex = 0;
            this.lblproducto.Text = "Id de producto:";
            // 
            // grbedicionproducto
            // 
            this.grbedicionproducto.Controls.Add(this.btnbuscarproducto);
            this.grbedicionproducto.Controls.Add(this.btneliminarproducto);
            this.grbedicionproducto.Controls.Add(this.btnmodificarproducto);
            this.grbedicionproducto.Controls.Add(this.btnagregarproducto);
            this.grbedicionproducto.Controls.Add(this.btnguardarproducto);
            this.grbedicionproducto.Location = new System.Drawing.Point(30, 196);
            this.grbedicionproducto.Name = "grbedicionproducto";
            this.grbedicionproducto.Size = new System.Drawing.Size(357, 100);
            this.grbedicionproducto.TabIndex = 6;
            this.grbedicionproducto.TabStop = false;
            this.grbedicionproducto.Text = "Edicion de producto";
            // 
            // btnbuscarproducto
            // 
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
            this.btnagregarproducto.Location = new System.Drawing.Point(6, 19);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(75, 35);
            this.btnagregarproducto.TabIndex = 6;
            this.btnagregarproducto.Text = "Agregar";
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // btnguardarproducto
            // 
            this.btnguardarproducto.Location = new System.Drawing.Point(206, 59);
            this.btnguardarproducto.Name = "btnguardarproducto";
            this.btnguardarproducto.Size = new System.Drawing.Size(75, 35);
            this.btnguardarproducto.TabIndex = 2;
            this.btnguardarproducto.Text = "Guardar";
            this.btnguardarproducto.UseVisualStyleBackColor = true;
            this.btnguardarproducto.Click += new System.EventHandler(this.btnguardarproducto_Click);
            // 
            // grbnavegacionproducto
            // 
            this.grbnavegacionproducto.Controls.Add(this.btnultimoregistroproducto);
            this.grbnavegacionproducto.Controls.Add(this.btnregistrosiguienteproducto);
            this.grbnavegacionproducto.Controls.Add(this.btnregistroanteriorproducto);
            this.grbnavegacionproducto.Controls.Add(this.btn1registroproductos);
            this.grbnavegacionproducto.Location = new System.Drawing.Point(30, 334);
            this.grbnavegacionproducto.Name = "grbnavegacionproducto";
            this.grbnavegacionproducto.Size = new System.Drawing.Size(357, 100);
            this.grbnavegacionproducto.TabIndex = 7;
            this.grbnavegacionproducto.TabStop = false;
            this.grbnavegacionproducto.Text = "Navegacion";
            // 
            // btnultimoregistroproducto
            // 
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
            this.ClientSize = new System.Drawing.Size(437, 466);
            this.Controls.Add(this.grbnavegacionproducto);
            this.Controls.Add(this.grbedicionproducto);
            this.Controls.Add(this.grbproducto);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.grbproducto.ResumeLayout(false);
            this.grbproducto.PerformLayout();
            this.grbedicionproducto.ResumeLayout(false);
            this.grbnavegacionproducto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbproducto;
        private System.Windows.Forms.Label lblidproducto;
        private System.Windows.Forms.TextBox txtdescripcionproducto;
        private System.Windows.Forms.Label lbldescripcionproducto;
        private System.Windows.Forms.TextBox txtidproductoregistro;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.GroupBox grbedicionproducto;
        private System.Windows.Forms.Button btnbuscarproducto;
        private System.Windows.Forms.Button btneliminarproducto;
        private System.Windows.Forms.Button btnmodificarproducto;
        private System.Windows.Forms.Button btnagregarproducto;
        private System.Windows.Forms.Button btnguardarproducto;
        private System.Windows.Forms.GroupBox grbnavegacionproducto;
        private System.Windows.Forms.Button btnultimoregistroproducto;
        private System.Windows.Forms.Button btnregistrosiguienteproducto;
        private System.Windows.Forms.Button btnregistroanteriorproducto;
        private System.Windows.Forms.Button btn1registroproductos;
    }
}