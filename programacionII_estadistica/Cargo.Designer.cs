namespace programacionII_estadistica
{
    partial class Cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargo));
            this.grbnavegacioncargo = new System.Windows.Forms.GroupBox();
            this.btnultimoregistroc = new System.Windows.Forms.Button();
            this.btnregistrosiguientec = new System.Windows.Forms.Button();
            this.btnregistroanterior = new System.Windows.Forms.Button();
            this.btn1registroc = new System.Windows.Forms.Button();
            this.grbedicioncargo = new System.Windows.Forms.GroupBox();
            this.btnbuscarc = new System.Windows.Forms.Button();
            this.btneliminarc = new System.Windows.Forms.Button();
            this.btnmodific = new System.Windows.Forms.Button();
            this.btnagregarc = new System.Windows.Forms.Button();
            this.grbdatosCargo = new System.Windows.Forms.GroupBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.lblncargo = new System.Windows.Forms.Label();
            this.lblidproduc = new System.Windows.Forms.Label();
            this.lblidcatego = new System.Windows.Forms.Label();
            this.txtidcargo = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.grbnavegacioncargo.SuspendLayout();
            this.grbedicioncargo.SuspendLayout();
            this.grbdatosCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbnavegacioncargo
            // 
            this.grbnavegacioncargo.Controls.Add(this.btnultimoregistroc);
            this.grbnavegacioncargo.Controls.Add(this.btnregistrosiguientec);
            this.grbnavegacioncargo.Controls.Add(this.btnregistroanterior);
            this.grbnavegacioncargo.Controls.Add(this.btn1registroc);
            this.grbnavegacioncargo.Location = new System.Drawing.Point(12, 178);
            this.grbnavegacioncargo.Name = "grbnavegacioncargo";
            this.grbnavegacioncargo.Size = new System.Drawing.Size(517, 64);
            this.grbnavegacioncargo.TabIndex = 13;
            this.grbnavegacioncargo.TabStop = false;
            this.grbnavegacioncargo.Text = "Navegacion";
            // 
            // btnultimoregistroc
            // 
            this.btnultimoregistroc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnultimoregistroc.BackgroundImage")));
            this.btnultimoregistroc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnultimoregistroc.Location = new System.Drawing.Point(270, 20);
            this.btnultimoregistroc.Name = "btnultimoregistroc";
            this.btnultimoregistroc.Size = new System.Drawing.Size(75, 35);
            this.btnultimoregistroc.TabIndex = 12;
            this.btnultimoregistroc.Text = "Ultimo registro";
            this.btnultimoregistroc.UseVisualStyleBackColor = true;
            this.btnultimoregistroc.Click += new System.EventHandler(this.btnultimoregistroc_Click);
            // 
            // btnregistrosiguientec
            // 
            this.btnregistrosiguientec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrosiguientec.BackgroundImage")));
            this.btnregistrosiguientec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrosiguientec.Location = new System.Drawing.Point(87, 20);
            this.btnregistrosiguientec.Name = "btnregistrosiguientec";
            this.btnregistrosiguientec.Size = new System.Drawing.Size(75, 35);
            this.btnregistrosiguientec.TabIndex = 11;
            this.btnregistrosiguientec.Text = "Siguiente registro";
            this.btnregistrosiguientec.UseVisualStyleBackColor = true;
            this.btnregistrosiguientec.Click += new System.EventHandler(this.btnregistrosiguientec_Click);
            // 
            // btnregistroanterior
            // 
            this.btnregistroanterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistroanterior.BackgroundImage")));
            this.btnregistroanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistroanterior.Location = new System.Drawing.Point(189, 20);
            this.btnregistroanterior.Name = "btnregistroanterior";
            this.btnregistroanterior.Size = new System.Drawing.Size(75, 35);
            this.btnregistroanterior.TabIndex = 10;
            this.btnregistroanterior.Text = "Registro anterior";
            this.btnregistroanterior.UseVisualStyleBackColor = true;
            this.btnregistroanterior.Click += new System.EventHandler(this.btnregistroanterior_Click);
            // 
            // btn1registroc
            // 
            this.btn1registroc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1registroc.BackgroundImage")));
            this.btn1registroc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1registroc.Location = new System.Drawing.Point(6, 20);
            this.btn1registroc.Name = "btn1registroc";
            this.btn1registroc.Size = new System.Drawing.Size(75, 35);
            this.btn1registroc.TabIndex = 9;
            this.btn1registroc.Text = "1° registro";
            this.btn1registroc.UseVisualStyleBackColor = true;
            this.btn1registroc.Click += new System.EventHandler(this.btn1registroc_Click);
            // 
            // grbedicioncargo
            // 
            this.grbedicioncargo.Controls.Add(this.btnbuscarc);
            this.grbedicioncargo.Controls.Add(this.btneliminarc);
            this.grbedicioncargo.Controls.Add(this.btnmodific);
            this.grbedicioncargo.Controls.Add(this.btnagregarc);
            this.grbedicioncargo.Location = new System.Drawing.Point(318, 12);
            this.grbedicioncargo.Name = "grbedicioncargo";
            this.grbedicioncargo.Size = new System.Drawing.Size(211, 160);
            this.grbedicioncargo.TabIndex = 12;
            this.grbedicioncargo.TabStop = false;
            this.grbedicioncargo.Text = "Edicion de Cargo";
            // 
            // btnbuscarc
            // 
            this.btnbuscarc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscarc.BackgroundImage")));
            this.btnbuscarc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarc.Location = new System.Drawing.Point(6, 125);
            this.btnbuscarc.Name = "btnbuscarc";
            this.btnbuscarc.Size = new System.Drawing.Size(196, 29);
            this.btnbuscarc.TabIndex = 9;
            this.btnbuscarc.Text = "Buscar";
            this.btnbuscarc.UseVisualStyleBackColor = true;
            this.btnbuscarc.Click += new System.EventHandler(this.btnbuscarc_Click);
            // 
            // btneliminarc
            // 
            this.btneliminarc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminarc.BackgroundImage")));
            this.btneliminarc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminarc.Location = new System.Drawing.Point(6, 88);
            this.btneliminarc.Name = "btneliminarc";
            this.btneliminarc.Size = new System.Drawing.Size(196, 31);
            this.btneliminarc.TabIndex = 8;
            this.btneliminarc.Text = "Eliminar";
            this.btneliminarc.UseVisualStyleBackColor = true;
            this.btneliminarc.Click += new System.EventHandler(this.btneliminarc_Click);
            // 
            // btnmodific
            // 
            this.btnmodific.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodific.BackgroundImage")));
            this.btnmodific.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodific.Location = new System.Drawing.Point(6, 55);
            this.btnmodific.Name = "btnmodific";
            this.btnmodific.Size = new System.Drawing.Size(196, 27);
            this.btnmodific.TabIndex = 7;
            this.btnmodific.Text = "Modificar";
            this.btnmodific.UseVisualStyleBackColor = true;
            this.btnmodific.Click += new System.EventHandler(this.btnmodific_Click);
            // 
            // btnagregarc
            // 
            this.btnagregarc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregarc.BackgroundImage")));
            this.btnagregarc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregarc.Location = new System.Drawing.Point(6, 19);
            this.btnagregarc.Name = "btnagregarc";
            this.btnagregarc.Size = new System.Drawing.Size(196, 30);
            this.btnagregarc.TabIndex = 6;
            this.btnagregarc.Text = "Nuevo";
            this.btnagregarc.UseVisualStyleBackColor = true;
            this.btnagregarc.Click += new System.EventHandler(this.btnagregarc_Click);
            // 
            // grbdatosCargo
            // 
            this.grbdatosCargo.Controls.Add(this.txtcargo);
            this.grbdatosCargo.Controls.Add(this.lblncargo);
            this.grbdatosCargo.Controls.Add(this.lblidproduc);
            this.grbdatosCargo.Controls.Add(this.lblidcatego);
            this.grbdatosCargo.Controls.Add(this.txtidcargo);
            this.grbdatosCargo.Controls.Add(this.lblcategoria);
            this.grbdatosCargo.Enabled = false;
            this.grbdatosCargo.Location = new System.Drawing.Point(12, 12);
            this.grbdatosCargo.Name = "grbdatosCargo";
            this.grbdatosCargo.Size = new System.Drawing.Size(300, 160);
            this.grbdatosCargo.TabIndex = 11;
            this.grbdatosCargo.TabStop = false;
            this.grbdatosCargo.Text = "Cargos de empleados";
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(102, 102);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(181, 20);
            this.txtcargo.TabIndex = 18;
            // 
            // lblncargo
            // 
            this.lblncargo.AutoSize = true;
            this.lblncargo.Location = new System.Drawing.Point(273, 58);
            this.lblncargo.Name = "lblncargo";
            this.lblncargo.Size = new System.Drawing.Size(10, 13);
            this.lblncargo.TabIndex = 13;
            this.lblncargo.Text = ":";
            // 
            // lblidproduc
            // 
            this.lblidproduc.AutoSize = true;
            this.lblidproduc.Location = new System.Drawing.Point(246, 58);
            this.lblidproduc.Name = "lblidproduc";
            this.lblidproduc.Size = new System.Drawing.Size(18, 13);
            this.lblidproduc.TabIndex = 17;
            this.lblidproduc.Text = "ID";
            // 
            // lblidcatego
            // 
            this.lblidcatego.AutoSize = true;
            this.lblidcatego.Location = new System.Drawing.Point(20, 105);
            this.lblidcatego.Name = "lblidcatego";
            this.lblidcatego.Size = new System.Drawing.Size(35, 13);
            this.lblidcatego.TabIndex = 11;
            this.lblidcatego.Text = "Cargo";
            // 
            // txtidcargo
            // 
            this.txtidcargo.Location = new System.Drawing.Point(102, 55);
            this.txtidcargo.Name = "txtidcargo";
            this.txtidcargo.Size = new System.Drawing.Size(129, 20);
            this.txtidcargo.TabIndex = 1;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(17, 55);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(64, 13);
            this.lblcategoria.TabIndex = 0;
            this.lblcategoria.Text = "Id de cargo:";
            // 
            // Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(540, 255);
            this.Controls.Add(this.grbnavegacioncargo);
            this.Controls.Add(this.grbedicioncargo);
            this.Controls.Add(this.grbdatosCargo);
            this.Name = "Cargo";
            this.Text = "Cargo";
            this.Load += new System.EventHandler(this.Cargo_Load);
            this.grbnavegacioncargo.ResumeLayout(false);
            this.grbedicioncargo.ResumeLayout(false);
            this.grbdatosCargo.ResumeLayout(false);
            this.grbdatosCargo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbnavegacioncargo;
        private System.Windows.Forms.Button btnultimoregistroc;
        private System.Windows.Forms.Button btnregistrosiguientec;
        private System.Windows.Forms.Button btnregistroanterior;
        private System.Windows.Forms.Button btn1registroc;
        private System.Windows.Forms.GroupBox grbedicioncargo;
        private System.Windows.Forms.Button btnbuscarc;
        private System.Windows.Forms.Button btneliminarc;
        private System.Windows.Forms.Button btnmodific;
        private System.Windows.Forms.Button btnagregarc;
        private System.Windows.Forms.GroupBox grbdatosCargo;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label lblncargo;
        private System.Windows.Forms.Label lblidproduc;
        private System.Windows.Forms.Label lblidcatego;
        private System.Windows.Forms.TextBox txtidcargo;
        private System.Windows.Forms.Label lblcategoria;
    }
}