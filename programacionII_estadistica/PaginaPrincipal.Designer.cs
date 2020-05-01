namespace programacionII_estadistica
{
    partial class PaginaPrincipal
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
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnpelis = new System.Windows.Forms.Button();
            this.btnalquiler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclientes
            // 
            this.btnclientes.Location = new System.Drawing.Point(35, 38);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(129, 69);
            this.btnclientes.TabIndex = 0;
            this.btnclientes.Text = "CLIENTES";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnpelis
            // 
            this.btnpelis.Location = new System.Drawing.Point(144, 113);
            this.btnpelis.Name = "btnpelis";
            this.btnpelis.Size = new System.Drawing.Size(121, 59);
            this.btnpelis.TabIndex = 1;
            this.btnpelis.Text = "PELICULAS";
            this.btnpelis.UseVisualStyleBackColor = true;
            this.btnpelis.Click += new System.EventHandler(this.btnpelis_Click);
            // 
            // btnalquiler
            // 
            this.btnalquiler.Location = new System.Drawing.Point(247, 178);
            this.btnalquiler.Name = "btnalquiler";
            this.btnalquiler.Size = new System.Drawing.Size(133, 60);
            this.btnalquiler.TabIndex = 2;
            this.btnalquiler.Text = "ALQUILER";
            this.btnalquiler.UseVisualStyleBackColor = true;
            this.btnalquiler.Click += new System.EventHandler(this.btnalquiler_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 301);
            this.Controls.Add(this.btnalquiler);
            this.Controls.Add(this.btnpelis);
            this.Controls.Add(this.btnclientes);
            this.Name = "PaginaPrincipal";
            this.Text = "PaginaPrincipal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnpelis;
        private System.Windows.Forms.Button btnalquiler;
    }
}