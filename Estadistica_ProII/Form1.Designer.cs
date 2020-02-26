namespace Estadistica_ProII
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmedia_aritmetica = new System.Windows.Forms.Button();
            this.lblrespuesta_serie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.lblserie = new System.Windows.Forms.Label();
            this.btnestandar = new System.Windows.Forms.Button();
            this.btntipica = new System.Windows.Forms.Button();
            this.btnmoda = new System.Windows.Forms.Button();
            this.lbltipica = new System.Windows.Forms.Label();
            this.lblestandar = new System.Windows.Forms.Label();
            this.lblmedia = new System.Windows.Forms.Label();
            this.lbltotales = new System.Windows.Forms.Label();
            this.lbltotalx2ixfi = new System.Windows.Forms.Label();
            this.lbltotalxixfi = new System.Windows.Forms.Label();
            this.lbltotalf1 = new System.Windows.Forms.Label();
            this.grdEstadistica = new System.Windows.Forms.DataGridView();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2ixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmedia_aritmetica
            // 
            this.btnmedia_aritmetica.Location = new System.Drawing.Point(388, 12);
            this.btnmedia_aritmetica.Name = "btnmedia_aritmetica";
            this.btnmedia_aritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnmedia_aritmetica.TabIndex = 7;
            this.btnmedia_aritmetica.Text = "carcular x";
            this.btnmedia_aritmetica.UseVisualStyleBackColor = true;
            this.btnmedia_aritmetica.Click += new System.EventHandler(this.btnmedia_aritmetica_Click);
            // 
            // lblrespuesta_serie
            // 
            this.lblrespuesta_serie.AutoSize = true;
            this.lblrespuesta_serie.Location = new System.Drawing.Point(72, 73);
            this.lblrespuesta_serie.Name = "lblrespuesta_serie";
            this.lblrespuesta_serie.Size = new System.Drawing.Size(12, 13);
            this.lblrespuesta_serie.TabIndex = 6;
            this.lblrespuesta_serie.Text = "x";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(143, 22);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(100, 20);
            this.txtserie.TabIndex = 5;
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(72, 22);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(39, 13);
            this.lblserie.TabIndex = 4;
            this.lblserie.Text = "SERIE";
            // 
            // btnestandar
            // 
            this.btnestandar.Location = new System.Drawing.Point(356, 41);
            this.btnestandar.Name = "btnestandar";
            this.btnestandar.Size = new System.Drawing.Size(107, 23);
            this.btnestandar.TabIndex = 8;
            this.btnestandar.Text = "calcular estandar";
            this.btnestandar.UseVisualStyleBackColor = true;
            this.btnestandar.Click += new System.EventHandler(this.btnestandar_Click);
            // 
            // btntipica
            // 
            this.btntipica.Location = new System.Drawing.Point(365, 73);
            this.btntipica.Name = "btntipica";
            this.btntipica.Size = new System.Drawing.Size(98, 23);
            this.btntipica.TabIndex = 9;
            this.btntipica.Text = "carcular tipica";
            this.btntipica.UseVisualStyleBackColor = true;
            this.btntipica.Click += new System.EventHandler(this.btntipica_Click);
            // 
            // btnmoda
            // 
            this.btnmoda.Location = new System.Drawing.Point(503, 12);
            this.btnmoda.Name = "btnmoda";
            this.btnmoda.Size = new System.Drawing.Size(75, 23);
            this.btnmoda.TabIndex = 11;
            this.btnmoda.Text = "moda";
            this.btnmoda.UseVisualStyleBackColor = true;
            this.btnmoda.Click += new System.EventHandler(this.btnmoda_Click);
            // 
            // lbltipica
            // 
            this.lbltipica.AutoSize = true;
            this.lbltipica.Location = new System.Drawing.Point(329, 445);
            this.lbltipica.Name = "lbltipica";
            this.lbltipica.Size = new System.Drawing.Size(36, 13);
            this.lbltipica.TabIndex = 21;
            this.lbltipica.Text = "Tipica";
            // 
            // lblestandar
            // 
            this.lblestandar.AutoSize = true;
            this.lblestandar.Location = new System.Drawing.Point(178, 445);
            this.lblestandar.Name = "lblestandar";
            this.lblestandar.Size = new System.Drawing.Size(49, 13);
            this.lblestandar.TabIndex = 20;
            this.lblestandar.Text = "Estandar";
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.Location = new System.Drawing.Point(40, 445);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(14, 13);
            this.lblmedia.TabIndex = 19;
            this.lblmedia.Text = "X";
            // 
            // lbltotales
            // 
            this.lbltotales.AutoSize = true;
            this.lbltotales.Location = new System.Drawing.Point(40, 407);
            this.lbltotales.Name = "lbltotales";
            this.lbltotales.Size = new System.Drawing.Size(59, 13);
            this.lbltotales.TabIndex = 18;
            this.lbltotales.Text = "TOTALES:";
            // 
            // lbltotalx2ixfi
            // 
            this.lbltotalx2ixfi.AutoSize = true;
            this.lbltotalx2ixfi.Location = new System.Drawing.Point(427, 407);
            this.lbltotalx2ixfi.Name = "lbltotalx2ixfi";
            this.lbltotalx2ixfi.Size = new System.Drawing.Size(64, 13);
            this.lbltotalx2ixfi.TabIndex = 17;
            this.lbltotalx2ixfi.Text = "Total x21*f1";
            // 
            // lbltotalxixfi
            // 
            this.lbltotalxixfi.AutoSize = true;
            this.lbltotalxixfi.Location = new System.Drawing.Point(320, 407);
            this.lbltotalxixfi.Name = "lbltotalxixfi";
            this.lbltotalxixfi.Size = new System.Drawing.Size(58, 13);
            this.lbltotalxixfi.TabIndex = 16;
            this.lbltotalxixfi.Text = "Total x1*f1";
            // 
            // lbltotalf1
            // 
            this.lbltotalf1.AutoSize = true;
            this.lbltotalf1.Location = new System.Drawing.Point(213, 407);
            this.lbltotalf1.Name = "lbltotalf1";
            this.lbltotalf1.Size = new System.Drawing.Size(46, 13);
            this.lbltotalf1.TabIndex = 15;
            this.lbltotalf1.Text = "Total F1";
            // 
            // grdEstadistica
            // 
            this.grdEstadistica.AllowUserToDeleteRows = false;
            this.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstadistica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1,
            this.f1,
            this.fi,
            this.xixfi,
            this.x2ixfi});
            this.grdEstadistica.Location = new System.Drawing.Point(37, 118);
            this.grdEstadistica.Margin = new System.Windows.Forms.Padding(1);
            this.grdEstadistica.Name = "grdEstadistica";
            this.grdEstadistica.RowHeadersWidth = 102;
            this.grdEstadistica.RowTemplate.Height = 40;
            this.grdEstadistica.Size = new System.Drawing.Size(510, 278);
            this.grdEstadistica.TabIndex = 14;
            this.grdEstadistica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEstadistica_KeyDow);
            // 
            // x1
            // 
            this.x1.HeaderText = "X1";
            this.x1.MinimumWidth = 12;
            this.x1.Name = "x1";
            this.x1.Width = 60;
            // 
            // f1
            // 
            this.f1.HeaderText = "F1";
            this.f1.MinimumWidth = 12;
            this.f1.Name = "f1";
            this.f1.Width = 60;
            // 
            // fi
            // 
            this.fi.HeaderText = "Fi";
            this.fi.MinimumWidth = 12;
            this.fi.Name = "fi";
            this.fi.Width = 60;
            // 
            // xixfi
            // 
            this.xixfi.HeaderText = "Xi * Fi";
            this.xixfi.MinimumWidth = 12;
            this.xixfi.Name = "xixfi";
            // 
            // x2ixfi
            // 
            this.x2ixfi.HeaderText = "X2i * Fi";
            this.x2ixfi.MinimumWidth = 12;
            this.x2ixfi.Name = "x2ixfi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 471);
            this.Controls.Add(this.lbltipica);
            this.Controls.Add(this.lblestandar);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.lbltotales);
            this.Controls.Add(this.lbltotalx2ixfi);
            this.Controls.Add(this.lbltotalxixfi);
            this.Controls.Add(this.lbltotalf1);
            this.Controls.Add(this.grdEstadistica);
            this.Controls.Add(this.btnmoda);
            this.Controls.Add(this.btntipica);
            this.Controls.Add(this.btnestandar);
            this.Controls.Add(this.btnmedia_aritmetica);
            this.Controls.Add(this.lblrespuesta_serie);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmedia_aritmetica;
        private System.Windows.Forms.Label lblrespuesta_serie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.Button btnestandar;
        private System.Windows.Forms.Button btntipica;
        private System.Windows.Forms.Button btnmoda;
        private System.Windows.Forms.Label lbltipica;
        private System.Windows.Forms.Label lblestandar;
        private System.Windows.Forms.Label lblmedia;
        private System.Windows.Forms.Label lbltotales;
        private System.Windows.Forms.Label lbltotalx2ixfi;
        private System.Windows.Forms.Label lbltotalxixfi;
        private System.Windows.Forms.Label lbltotalf1;
        private System.Windows.Forms.DataGridView grdEstadistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xixfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2ixfi;
    }
}

