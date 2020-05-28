namespace programacionII_estadistica
{
    partial class Devoluciones
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
            System.Windows.Forms.Label idProductosDvLabel;
            System.Windows.Forms.Label nombre_ClienteLabel;
            System.Windows.Forms.Label idDcProductosLabel;
            System.Windows.Forms.Label idOrdenLabel;
            System.Windows.Forms.Label idDetalleDevolucionLabel;
            System.Windows.Forms.Label fecha_DevolucionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devoluciones));
            this.devolucionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDataSet = new programacionII_estadistica.SistemaDataSet();
            this.devolucionesTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.DevolucionesTableAdapter();
            this.tableAdapterManager = new programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager();
            this.dataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable4TableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.DataTable4TableAdapter();
            this.dataTable4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idProductosDvComboBox = new System.Windows.Forms.ComboBox();
            this.nombre_ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.idDcProductosComboBox = new System.Windows.Forms.ComboBox();
            this.idOrdenTextBox = new System.Windows.Forms.TextBox();
            this.idDetalleDevolucionTextBox = new System.Windows.Forms.TextBox();
            this.fecha_DevolucionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataTable4DataGridView = new System.Windows.Forms.DataGridView();
            this.grbcliente = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIvaVenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaVenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.grbnavegacion = new System.Windows.Forms.GroupBox();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idProductosDvLabel = new System.Windows.Forms.Label();
            nombre_ClienteLabel = new System.Windows.Forms.Label();
            idDcProductosLabel = new System.Windows.Forms.Label();
            idOrdenLabel = new System.Windows.Forms.Label();
            idDetalleDevolucionLabel = new System.Windows.Forms.Label();
            fecha_DevolucionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4DataGridView)).BeginInit();
            this.grbcliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbnavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // idProductosDvLabel
            // 
            idProductosDvLabel.AutoSize = true;
            idProductosDvLabel.Location = new System.Drawing.Point(351, 34);
            idProductosDvLabel.Name = "idProductosDvLabel";
            idProductosDvLabel.Size = new System.Drawing.Size(87, 13);
            idProductosDvLabel.TabIndex = 1;
            idProductosDvLabel.Text = "Id Productos Dv:";
            // 
            // nombre_ClienteLabel
            // 
            nombre_ClienteLabel.AutoSize = true;
            nombre_ClienteLabel.Location = new System.Drawing.Point(21, 34);
            nombre_ClienteLabel.Name = "nombre_ClienteLabel";
            nombre_ClienteLabel.Size = new System.Drawing.Size(82, 13);
            nombre_ClienteLabel.TabIndex = 11;
            nombre_ClienteLabel.Text = "Nombre Cliente:";
            // 
            // idDcProductosLabel
            // 
            idDcProductosLabel.AutoSize = true;
            idDcProductosLabel.Location = new System.Drawing.Point(351, 87);
            idDcProductosLabel.Name = "idDcProductosLabel";
            idDcProductosLabel.Size = new System.Drawing.Size(87, 13);
            idDcProductosLabel.TabIndex = 13;
            idDcProductosLabel.Text = "Id Dc Productos:";
            // 
            // idOrdenLabel
            // 
            idOrdenLabel.AutoSize = true;
            idOrdenLabel.Location = new System.Drawing.Point(588, 33);
            idOrdenLabel.Name = "idOrdenLabel";
            idOrdenLabel.Size = new System.Drawing.Size(51, 13);
            idOrdenLabel.TabIndex = 15;
            idOrdenLabel.Text = "Id Orden:";
            // 
            // idDetalleDevolucionLabel
            // 
            idDetalleDevolucionLabel.AutoSize = true;
            idDetalleDevolucionLabel.Location = new System.Drawing.Point(588, 89);
            idDetalleDevolucionLabel.Name = "idDetalleDevolucionLabel";
            idDetalleDevolucionLabel.Size = new System.Drawing.Size(112, 13);
            idDetalleDevolucionLabel.TabIndex = 17;
            idDetalleDevolucionLabel.Text = "Id Detalle Devolucion:";
            // 
            // fecha_DevolucionLabel
            // 
            fecha_DevolucionLabel.AutoSize = true;
            fecha_DevolucionLabel.Location = new System.Drawing.Point(21, 87);
            fecha_DevolucionLabel.Name = "fecha_DevolucionLabel";
            fecha_DevolucionLabel.Size = new System.Drawing.Size(97, 13);
            fecha_DevolucionLabel.TabIndex = 19;
            fecha_DevolucionLabel.Text = "Fecha Devolucion:";
            // 
            // devolucionesBindingSource
            // 
            this.devolucionesBindingSource.DataMember = "Devoluciones";
            this.devolucionesBindingSource.DataSource = this.sistemaDataSet;
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "SistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devolucionesTableAdapter
            // 
            this.devolucionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.DescuentoTableAdapter = null;
            this.tableAdapterManager.DetalleDeDevolucionesTableAdapter = null;
            this.tableAdapterManager.DetalleDeFactura1TableAdapter = null;
            this.tableAdapterManager.DetalleDeFacturaTableAdapter = null;
            this.tableAdapterManager.DetalleDeVentaTableAdapter = null;
            this.tableAdapterManager.DetalleOrdenesTableAdapter = null;
            this.tableAdapterManager.DevolucionesTableAdapter = this.devolucionesTableAdapter;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.OrdenesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaDiaTableAdapter = null;
            // 
            // dataTable4BindingSource
            // 
            this.dataTable4BindingSource.DataMember = "DataTable4";
            this.dataTable4BindingSource.DataSource = this.sistemaDataSet;
            // 
            // dataTable4TableAdapter
            // 
            this.dataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable4BindingSource1
            // 
            this.dataTable4BindingSource1.DataMember = "Devoluciones_DataTable4";
            this.dataTable4BindingSource1.DataSource = this.devolucionesBindingSource;
            // 
            // idProductosDvComboBox
            // 
            this.idProductosDvComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.devolucionesBindingSource, "IdProductosDv", true));
            this.idProductosDvComboBox.DataSource = this.devolucionesBindingSource;
            this.idProductosDvComboBox.DisplayMember = "IdProductosDv";
            this.idProductosDvComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProductosDvComboBox.Enabled = false;
            this.idProductosDvComboBox.FormattingEnabled = true;
            this.idProductosDvComboBox.Location = new System.Drawing.Point(444, 31);
            this.idProductosDvComboBox.Name = "idProductosDvComboBox";
            this.idProductosDvComboBox.Size = new System.Drawing.Size(133, 21);
            this.idProductosDvComboBox.TabIndex = 2;
            this.idProductosDvComboBox.ValueMember = "IdProductosDv";
            // 
            // nombre_ClienteComboBox
            // 
            this.nombre_ClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.devolucionesBindingSource, "Nombre_Cliente", true));
            this.nombre_ClienteComboBox.DataSource = this.devolucionesBindingSource;
            this.nombre_ClienteComboBox.DisplayMember = "Nombre_Cliente";
            this.nombre_ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombre_ClienteComboBox.Enabled = false;
            this.nombre_ClienteComboBox.FormattingEnabled = true;
            this.nombre_ClienteComboBox.Location = new System.Drawing.Point(120, 31);
            this.nombre_ClienteComboBox.Name = "nombre_ClienteComboBox";
            this.nombre_ClienteComboBox.Size = new System.Drawing.Size(215, 21);
            this.nombre_ClienteComboBox.TabIndex = 12;
            this.nombre_ClienteComboBox.ValueMember = "Nombre_Cliente";
            // 
            // idDcProductosComboBox
            // 
            this.idDcProductosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.devolucionesBindingSource, "IdDcProductos", true));
            this.idDcProductosComboBox.DataSource = this.devolucionesBindingSource;
            this.idDcProductosComboBox.DisplayMember = "IdDcProductos";
            this.idDcProductosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idDcProductosComboBox.Enabled = false;
            this.idDcProductosComboBox.FormattingEnabled = true;
            this.idDcProductosComboBox.Location = new System.Drawing.Point(444, 82);
            this.idDcProductosComboBox.Name = "idDcProductosComboBox";
            this.idDcProductosComboBox.Size = new System.Drawing.Size(133, 21);
            this.idDcProductosComboBox.TabIndex = 14;
            this.idDcProductosComboBox.ValueMember = "IdDcProductos";
            // 
            // idOrdenTextBox
            // 
            this.idOrdenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionesBindingSource, "IdOrden", true));
            this.idOrdenTextBox.Enabled = false;
            this.idOrdenTextBox.Location = new System.Drawing.Point(653, 28);
            this.idOrdenTextBox.Name = "idOrdenTextBox";
            this.idOrdenTextBox.Size = new System.Drawing.Size(145, 20);
            this.idOrdenTextBox.TabIndex = 16;
            // 
            // idDetalleDevolucionTextBox
            // 
            this.idDetalleDevolucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionesBindingSource, "IdDetalleDevolucion", true));
            this.idDetalleDevolucionTextBox.Enabled = false;
            this.idDetalleDevolucionTextBox.Location = new System.Drawing.Point(706, 86);
            this.idDetalleDevolucionTextBox.Name = "idDetalleDevolucionTextBox";
            this.idDetalleDevolucionTextBox.Size = new System.Drawing.Size(92, 20);
            this.idDetalleDevolucionTextBox.TabIndex = 18;
            // 
            // fecha_DevolucionDateTimePicker
            // 
            this.fecha_DevolucionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.devolucionesBindingSource, "Fecha_Devolucion", true));
            this.fecha_DevolucionDateTimePicker.Location = new System.Drawing.Point(120, 83);
            this.fecha_DevolucionDateTimePicker.Name = "fecha_DevolucionDateTimePicker";
            this.fecha_DevolucionDateTimePicker.Size = new System.Drawing.Size(215, 20);
            this.fecha_DevolucionDateTimePicker.TabIndex = 20;
            // 
            // dataTable4DataGridView
            // 
            this.dataTable4DataGridView.AllowUserToAddRows = false;
            this.dataTable4DataGridView.AllowUserToDeleteRows = false;
            this.dataTable4DataGridView.AutoGenerateColumns = false;
            this.dataTable4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable4DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Unidades,
            this.PrecioUnitario,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Descuento,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.dataTable4DataGridView.DataSource = this.dataTable4BindingSource1;
            this.dataTable4DataGridView.Location = new System.Drawing.Point(16, 137);
            this.dataTable4DataGridView.Name = "dataTable4DataGridView";
            this.dataTable4DataGridView.ReadOnly = true;
            this.dataTable4DataGridView.Size = new System.Drawing.Size(819, 202);
            this.dataTable4DataGridView.TabIndex = 20;
            // 
            // grbcliente
            // 
            this.grbcliente.BackColor = System.Drawing.Color.Transparent;
            this.grbcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbcliente.Controls.Add(this.btnbuscar);
            this.grbcliente.Controls.Add(this.btneliminar);
            this.grbcliente.Controls.Add(this.btnmodificar);
            this.grbcliente.Controls.Add(this.btnagregar);
            this.grbcliente.Location = new System.Drawing.Point(317, 356);
            this.grbcliente.Name = "grbcliente";
            this.grbcliente.Size = new System.Drawing.Size(269, 104);
            this.grbcliente.TabIndex = 58;
            this.grbcliente.TabStop = false;
            this.grbcliente.Text = "Edicion Devoluciones";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(143, 57);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(105, 39);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(141, 20);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(107, 39);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmodificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodificar.BackgroundImage")));
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(11, 57);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(103, 39);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(11, 20);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 39);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Nuevo";
            this.btnagregar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotalVenta);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblIvaVenta);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblSumaVenta);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(611, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 56;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenta.Location = new System.Drawing.Point(135, 73);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(53, 13);
            this.lblTotalVenta.TabIndex = 5;
            this.lblTotalVenta.Text = "0000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL:";
            // 
            // lblIvaVenta
            // 
            this.lblIvaVenta.AutoSize = true;
            this.lblIvaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIvaVenta.Location = new System.Drawing.Point(135, 48);
            this.lblIvaVenta.Name = "lblIvaVenta";
            this.lblIvaVenta.Size = new System.Drawing.Size(39, 13);
            this.lblIvaVenta.TabIndex = 3;
            this.lblIvaVenta.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IVA:";
            // 
            // lblSumaVenta
            // 
            this.lblSumaVenta.AutoSize = true;
            this.lblSumaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaVenta.Location = new System.Drawing.Point(135, 24);
            this.lblSumaVenta.Name = "lblSumaVenta";
            this.lblSumaVenta.Size = new System.Drawing.Size(53, 13);
            this.lblSumaVenta.TabIndex = 1;
            this.lblSumaVenta.Text = "0000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SUMA:";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(126, 398);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 55;
            // 
            // btnultimo
            // 
            this.btnultimo.BackColor = System.Drawing.Color.White;
            this.btnultimo.Location = new System.Drawing.Point(216, 388);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(40, 33);
            this.btnultimo.TabIndex = 54;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = false;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.White;
            this.btnsiguiente.Location = new System.Drawing.Point(177, 388);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(40, 33);
            this.btnsiguiente.TabIndex = 53;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.BackColor = System.Drawing.Color.White;
            this.btnanterior.Location = new System.Drawing.Point(84, 388);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(40, 33);
            this.btnanterior.TabIndex = 52;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = false;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.BackColor = System.Drawing.Color.White;
            this.btnprimero.Location = new System.Drawing.Point(45, 388);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(40, 33);
            this.btnprimero.TabIndex = 51;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = false;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // grbnavegacion
            // 
            this.grbnavegacion.BackColor = System.Drawing.Color.Transparent;
            this.grbnavegacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbnavegacion.Controls.Add(this.lblregistroxden);
            this.grbnavegacion.Location = new System.Drawing.Point(36, 368);
            this.grbnavegacion.Name = "grbnavegacion";
            this.grbnavegacion.Size = new System.Drawing.Size(243, 78);
            this.grbnavegacion.TabIndex = 57;
            this.grbnavegacion.TabStop = false;
            this.grbnavegacion.Text = "Navegacion";
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.BackColor = System.Drawing.Color.Transparent;
            this.lblregistroxden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistroxden.Location = new System.Drawing.Point(91, 32);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(46, 15);
            this.lblregistroxden.TabIndex = 48;
            this.lblregistroxden.Text = "x de n";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDetalleDevolucion";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDetalleDevolucion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdProductosDv";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigoProducto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Unidades
            // 
            this.Unidades.DataPropertyName = "Unidades";
            this.Unidades.HeaderText = "Cantidad";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "Precio";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Reembolso ";
            this.dataGridViewTextBoxColumn6.HeaderText = "Reembolso ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nombre_Cliente";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre_Cliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdDcProductos";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdDcProductos";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdOrden";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdOrden";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Precio_total";
            this.dataGridViewTextBoxColumn10.HeaderText = "Precio_total";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "IdProductos";
            this.dataGridViewTextBoxColumn12.HeaderText = "IdProductos";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Expr3";
            this.dataGridViewTextBoxColumn13.HeaderText = "Expr3";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Expr4";
            this.dataGridViewTextBoxColumn14.HeaderText = "Expr4";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Expr5";
            this.dataGridViewTextBoxColumn15.HeaderText = "Expr5";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn16.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Expr7";
            this.dataGridViewTextBoxColumn17.HeaderText = "Expr7";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Expr8";
            this.dataGridViewTextBoxColumn18.HeaderText = "Expr8";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Expr9";
            this.dataGridViewTextBoxColumn19.HeaderText = "Expr9";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "nfactura";
            this.dataGridViewTextBoxColumn20.HeaderText = "nfactura";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 481);
            this.Controls.Add(this.grbcliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblnregistros);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnprimero);
            this.Controls.Add(this.grbnavegacion);
            this.Controls.Add(this.dataTable4DataGridView);
            this.Controls.Add(idProductosDvLabel);
            this.Controls.Add(this.idProductosDvComboBox);
            this.Controls.Add(nombre_ClienteLabel);
            this.Controls.Add(this.nombre_ClienteComboBox);
            this.Controls.Add(idDcProductosLabel);
            this.Controls.Add(this.idDcProductosComboBox);
            this.Controls.Add(idOrdenLabel);
            this.Controls.Add(this.idOrdenTextBox);
            this.Controls.Add(idDetalleDevolucionLabel);
            this.Controls.Add(this.idDetalleDevolucionTextBox);
            this.Controls.Add(fecha_DevolucionLabel);
            this.Controls.Add(this.fecha_DevolucionDateTimePicker);
            this.Name = "Devoluciones";
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.Devoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4DataGridView)).EndInit();
            this.grbcliente.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbnavegacion.ResumeLayout(false);
            this.grbnavegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource devolucionesBindingSource;
        private SistemaDataSetTableAdapters.DevolucionesTableAdapter devolucionesTableAdapter;
        private SistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dataTable4BindingSource;
        private SistemaDataSetTableAdapters.DataTable4TableAdapter dataTable4TableAdapter;
        private System.Windows.Forms.BindingSource dataTable4BindingSource1;
        private System.Windows.Forms.ComboBox idProductosDvComboBox;
        private System.Windows.Forms.ComboBox nombre_ClienteComboBox;
        private System.Windows.Forms.ComboBox idDcProductosComboBox;
        private System.Windows.Forms.TextBox idOrdenTextBox;
        private System.Windows.Forms.TextBox idDetalleDevolucionTextBox;
        private System.Windows.Forms.DateTimePicker fecha_DevolucionDateTimePicker;
        private System.Windows.Forms.DataGridView dataTable4DataGridView;
        private System.Windows.Forms.GroupBox grbcliente;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIvaVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.GroupBox grbnavegacion;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}