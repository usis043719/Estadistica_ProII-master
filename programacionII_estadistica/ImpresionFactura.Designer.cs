namespace programacionII_estadistica
{
    partial class ImpresionFactura
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SistemaDataSet = new programacionII_estadistica.SistemaDataSet();
            this.rptFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptFacturasTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.rptFacturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptFacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DsRpFacturas";
            reportDataSource1.Value = this.rptFacturasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "programacionII_estadistica.RepFacturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(678, 475);
            this.reportViewer1.TabIndex = 1;
            // 
            // SistemaDataSet
            // 
            this.SistemaDataSet.DataSetName = "SistemaDataSet";
            this.SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptFacturasBindingSource
            // 
            this.rptFacturasBindingSource.DataMember = "rptFacturas";
            this.rptFacturasBindingSource.DataSource = this.SistemaDataSet;
            // 
            // rptFacturasTableAdapter
            // 
            this.rptFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // ImpresionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 499);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImpresionFactura";
            this.Text = "ImpresionFactura";
            this.Load += new System.EventHandler(this.ImpresionFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptFacturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptFacturasBindingSource;
        private SistemaDataSet SistemaDataSet;
        private SistemaDataSetTableAdapters.rptFacturasTableAdapter rptFacturasTableAdapter;
    }
}