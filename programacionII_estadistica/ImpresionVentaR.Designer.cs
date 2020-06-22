namespace programacionII_estadistica
{
    partial class ImpresionVentaR
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptVentaDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SistemaDataSet = new programacionII_estadistica.SistemaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptVentaDiaTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.rptVentaDiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rptVentaDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rptVentaDiaBindingSource
            // 
            this.rptVentaDiaBindingSource.DataMember = "rptVentaDia";
            this.rptVentaDiaBindingSource.DataSource = this.SistemaDataSet;
            // 
            // SistemaDataSet
            // 
            this.SistemaDataSet.DataSetName = "SistemaDataSet";
            this.SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DsRpVentas";
            reportDataSource1.Value = this.rptVentaDiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "programacionII_estadistica.RepVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(678, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // rptVentaDiaTableAdapter
            // 
            this.rptVentaDiaTableAdapter.ClearBeforeFill = true;
            // 
            // ImpresionVentaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 452);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImpresionVentaR";
            this.Text = "Factura de Ventas Webara";
            this.Load += new System.EventHandler(this.ImpresionVentaR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rptVentaDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptVentaDiaBindingSource;
        private SistemaDataSet SistemaDataSet;
        private SistemaDataSetTableAdapters.rptVentaDiaTableAdapter rptVentaDiaTableAdapter;
    }
}