namespace programacionII_estadistica
{
    partial class Facturas
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
            System.Windows.Forms.Label nfacturaLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label fecha_de_ventaLabel;
            System.Windows.Forms.Label nombre_del_clienteLabel;
            System.Windows.Forms.Label idProductosDvLabel;
            System.Windows.Forms.Label idDetalleFacturaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            this.sistemaDataSet = new programacionII_estadistica.SistemaDataSet();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.FacturaTableAdapter();
            this.tableAdapterManager = new programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager();
            this.nfacturaComboBox = new System.Windows.Forms.ComboBox();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.fecha_de_ventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombre_del_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable3TableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.DataTable3TableAdapter();
            this.dataTable3DataGridView = new System.Windows.Forms.DataGridView();
            this.grbcliente = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblregistroxden = new System.Windows.Forms.Label();
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
            this.idProductosDvTextBox = new System.Windows.Forms.TextBox();
            this.idDetalleFacturaTextBox = new System.Windows.Forms.TextBox();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetalleFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadeventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductosDvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredelclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nfacturaLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            fecha_de_ventaLabel = new System.Windows.Forms.Label();
            nombre_del_clienteLabel = new System.Windows.Forms.Label();
            idProductosDvLabel = new System.Windows.Forms.Label();
            idDetalleFacturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3DataGridView)).BeginInit();
            this.grbcliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbnavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.BackColor = System.Drawing.Color.Transparent;
            nfacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nfacturaLabel.Location = new System.Drawing.Point(346, 91);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(61, 16);
            nfacturaLabel.TabIndex = 1;
            nfacturaLabel.Text = "# factura:";
            nfacturaLabel.Click += new System.EventHandler(this.nfacturaLabel_Click);
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.BackColor = System.Drawing.Color.Transparent;
            idClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idClienteLabel.Location = new System.Drawing.Point(345, 34);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(66, 16);
            idClienteLabel.TabIndex = 3;
            idClienteLabel.Text = "Id Cliente:";
            idClienteLabel.Click += new System.EventHandler(this.idClienteLabel_Click);
            // 
            // fecha_de_ventaLabel
            // 
            fecha_de_ventaLabel.AutoSize = true;
            fecha_de_ventaLabel.BackColor = System.Drawing.Color.Transparent;
            fecha_de_ventaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_de_ventaLabel.ForeColor = System.Drawing.Color.Black;
            fecha_de_ventaLabel.Location = new System.Drawing.Point(32, 93);
            fecha_de_ventaLabel.Name = "fecha_de_ventaLabel";
            fecha_de_ventaLabel.Size = new System.Drawing.Size(99, 16);
            fecha_de_ventaLabel.TabIndex = 7;
            fecha_de_ventaLabel.Text = "fecha de venta:";
            fecha_de_ventaLabel.Click += new System.EventHandler(this.fecha_de_ventaLabel_Click);
            // 
            // nombre_del_clienteLabel
            // 
            nombre_del_clienteLabel.AutoSize = true;
            nombre_del_clienteLabel.BackColor = System.Drawing.Color.Transparent;
            nombre_del_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_del_clienteLabel.ForeColor = System.Drawing.Color.Black;
            nombre_del_clienteLabel.Location = new System.Drawing.Point(66, 34);
            nombre_del_clienteLabel.Name = "nombre_del_clienteLabel";
            nombre_del_clienteLabel.Size = new System.Drawing.Size(52, 16);
            nombre_del_clienteLabel.TabIndex = 11;
            nombre_del_clienteLabel.Text = "Cliente:";
            nombre_del_clienteLabel.Click += new System.EventHandler(this.nombre_del_clienteLabel_Click);
            // 
            // idProductosDvLabel
            // 
            idProductosDvLabel.AutoSize = true;
            idProductosDvLabel.BackColor = System.Drawing.Color.Transparent;
            idProductosDvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProductosDvLabel.Location = new System.Drawing.Point(532, 33);
            idProductosDvLabel.Name = "idProductosDvLabel";
            idProductosDvLabel.Size = new System.Drawing.Size(95, 15);
            idProductosDvLabel.TabIndex = 63;
            idProductosDvLabel.Text = "Id Productos Dv:";
            // 
            // idDetalleFacturaLabel
            // 
            idDetalleFacturaLabel.AutoSize = true;
            idDetalleFacturaLabel.BackColor = System.Drawing.Color.Transparent;
            idDetalleFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idDetalleFacturaLabel.Location = new System.Drawing.Point(525, 91);
            idDetalleFacturaLabel.Name = "idDetalleFacturaLabel";
            idDetalleFacturaLabel.Size = new System.Drawing.Size(62, 15);
            idDetalleFacturaLabel.TabIndex = 75;
            idDetalleFacturaLabel.Text = "Id Detalle:";
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "SistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.sistemaDataSet;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DevolucionesTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = this.facturaTableAdapter;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.OrdenesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaDiaTableAdapter = null;
            // 
            // nfacturaComboBox
            // 
            this.nfacturaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturaBindingSource, "nfactura", true));
            this.nfacturaComboBox.DataSource = this.facturaBindingSource;
            this.nfacturaComboBox.DisplayMember = "nfactura";
            this.nfacturaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nfacturaComboBox.Enabled = false;
            this.nfacturaComboBox.FormattingEnabled = true;
            this.nfacturaComboBox.Location = new System.Drawing.Point(413, 86);
            this.nfacturaComboBox.Name = "nfacturaComboBox";
            this.nfacturaComboBox.Size = new System.Drawing.Size(106, 21);
            this.nfacturaComboBox.TabIndex = 2;
            this.nfacturaComboBox.ValueMember = "nfactura";
            this.nfacturaComboBox.SelectedIndexChanged += new System.EventHandler(this.nfacturaComboBox_SelectedIndexChanged);
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturaBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.facturaBindingSource;
            this.idClienteComboBox.DisplayMember = "IdCliente";
            this.idClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idClienteComboBox.Enabled = false;
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(413, 28);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(106, 21);
            this.idClienteComboBox.TabIndex = 4;
            this.idClienteComboBox.ValueMember = "IdCliente";
            this.idClienteComboBox.SelectedIndexChanged += new System.EventHandler(this.idClienteComboBox_SelectedIndexChanged);
            // 
            // fecha_de_ventaDateTimePicker
            // 
            this.fecha_de_ventaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facturaBindingSource, "fecha_de_venta", true));
            this.fecha_de_ventaDateTimePicker.Enabled = false;
            this.fecha_de_ventaDateTimePicker.Location = new System.Drawing.Point(134, 89);
            this.fecha_de_ventaDateTimePicker.Name = "fecha_de_ventaDateTimePicker";
            this.fecha_de_ventaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_de_ventaDateTimePicker.TabIndex = 8;
            this.fecha_de_ventaDateTimePicker.ValueChanged += new System.EventHandler(this.fecha_de_ventaDateTimePicker_ValueChanged);
            // 
            // nombre_del_clienteComboBox
            // 
            this.nombre_del_clienteComboBox.BackColor = System.Drawing.Color.White;
            this.nombre_del_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturaBindingSource, "nombre_del_cliente", true));
            this.nombre_del_clienteComboBox.DataSource = this.facturaBindingSource;
            this.nombre_del_clienteComboBox.DisplayMember = "nombre_del_cliente";
            this.nombre_del_clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombre_del_clienteComboBox.Enabled = false;
            this.nombre_del_clienteComboBox.FormattingEnabled = true;
            this.nombre_del_clienteComboBox.Location = new System.Drawing.Point(134, 28);
            this.nombre_del_clienteComboBox.Name = "nombre_del_clienteComboBox";
            this.nombre_del_clienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.nombre_del_clienteComboBox.TabIndex = 12;
            this.nombre_del_clienteComboBox.ValueMember = "nombre_del_cliente";
            this.nombre_del_clienteComboBox.SelectedIndexChanged += new System.EventHandler(this.nombre_del_clienteComboBox_SelectedIndexChanged);
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "FK_DetalleDeFactura_Factura";
            this.dataTable3BindingSource.DataSource = this.facturaBindingSource;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable3DataGridView
            // 
            this.dataTable3DataGridView.AllowUserToAddRows = false;
            this.dataTable3DataGridView.AllowUserToDeleteRows = false;
            this.dataTable3DataGridView.AutoGenerateColumns = false;
            this.dataTable3DataGridView.BackgroundColor = System.Drawing.Color.Orange;
            this.dataTable3DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable3DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataTable3DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable3DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaDataGridViewTextBoxColumn,
            this.nfacturaDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.Unidades,
            this.idDetalleFacturaDataGridViewTextBoxColumn,
            this.expr3DataGridViewTextBoxColumn,
            this.fechadeventaDataGridViewTextBoxColumn,
            this.PrecioUnitario,
            this.preciototalDataGridViewTextBoxColumn,
            this.idProductosDataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.Descuento,
            this.expr4DataGridViewTextBoxColumn,
            this.expr5DataGridViewTextBoxColumn,
            this.idProductosDvDataGridViewTextBoxColumn,
            this.expr6DataGridViewTextBoxColumn,
            this.expr7DataGridViewTextBoxColumn,
            this.nombredelclienteDataGridViewTextBoxColumn,
            this.expr8DataGridViewTextBoxColumn});
            this.dataTable3DataGridView.DataSource = this.dataTable3BindingSource;
            this.dataTable3DataGridView.EnableHeadersVisualStyles = false;
            this.dataTable3DataGridView.Location = new System.Drawing.Point(22, 146);
            this.dataTable3DataGridView.Name = "dataTable3DataGridView";
            this.dataTable3DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable3DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataTable3DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTable3DataGridView.Size = new System.Drawing.Size(731, 149);
            this.dataTable3DataGridView.TabIndex = 19;
            this.dataTable3DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable3DataGridView_CellContentClick);
            // 
            // grbcliente
            // 
            this.grbcliente.BackColor = System.Drawing.Color.Transparent;
            this.grbcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbcliente.Controls.Add(this.btnbuscar);
            this.grbcliente.Controls.Add(this.btneliminar);
            this.grbcliente.Controls.Add(this.btnmodificar);
            this.grbcliente.Controls.Add(this.btnagregar);
            this.grbcliente.Location = new System.Drawing.Point(268, 326);
            this.grbcliente.Name = "grbcliente";
            this.grbcliente.Size = new System.Drawing.Size(269, 104);
            this.grbcliente.TabIndex = 59;
            this.grbcliente.TabStop = false;
            this.grbcliente.Text = "Edicion de Factura";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(146, 57);
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
            this.btneliminar.Location = new System.Drawing.Point(144, 20);
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
            this.btnmodificar.Location = new System.Drawing.Point(14, 57);
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
            this.btnagregar.Location = new System.Drawing.Point(14, 20);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 39);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Nuevo";
            this.btnagregar.UseVisualStyleBackColor = false;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistroxden.Location = new System.Drawing.Point(101, 32);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(46, 15);
            this.lblregistroxden.TabIndex = 57;
            this.lblregistroxden.Text = "x de n";
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
            this.panel2.Location = new System.Drawing.Point(553, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 92);
            this.panel2.TabIndex = 56;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenta.Location = new System.Drawing.Point(130, 61);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(59, 15);
            this.lblTotalVenta.TabIndex = 5;
            this.lblTotalVenta.Text = "0000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL:";
            // 
            // lblIvaVenta
            // 
            this.lblIvaVenta.AutoSize = true;
            this.lblIvaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIvaVenta.Location = new System.Drawing.Point(130, 36);
            this.lblIvaVenta.Name = "lblIvaVenta";
            this.lblIvaVenta.Size = new System.Drawing.Size(43, 15);
            this.lblIvaVenta.TabIndex = 3;
            this.lblIvaVenta.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "IVA:";
            // 
            // lblSumaVenta
            // 
            this.lblSumaVenta.AutoSize = true;
            this.lblSumaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaVenta.Location = new System.Drawing.Point(130, 12);
            this.lblSumaVenta.Name = "lblSumaVenta";
            this.lblSumaVenta.Size = new System.Drawing.Size(59, 15);
            this.lblSumaVenta.TabIndex = 1;
            this.lblSumaVenta.Text = "0000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "SUMA:";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(118, 360);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 55;
            // 
            // btnultimo
            // 
            this.btnultimo.BackColor = System.Drawing.Color.White;
            this.btnultimo.Location = new System.Drawing.Point(208, 350);
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
            this.btnsiguiente.Location = new System.Drawing.Point(169, 350);
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
            this.btnanterior.Location = new System.Drawing.Point(76, 350);
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
            this.btnprimero.Location = new System.Drawing.Point(37, 350);
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
            this.grbnavegacion.Location = new System.Drawing.Point(19, 328);
            this.grbnavegacion.Name = "grbnavegacion";
            this.grbnavegacion.Size = new System.Drawing.Size(243, 78);
            this.grbnavegacion.TabIndex = 58;
            this.grbnavegacion.TabStop = false;
            this.grbnavegacion.Text = "Navegacion";
            // 
            // idProductosDvTextBox
            // 
            this.idProductosDvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "IdProductosDv", true));
            this.idProductosDvTextBox.Enabled = false;
            this.idProductosDvTextBox.Location = new System.Drawing.Point(633, 28);
            this.idProductosDvTextBox.Name = "idProductosDvTextBox";
            this.idProductosDvTextBox.Size = new System.Drawing.Size(102, 20);
            this.idProductosDvTextBox.TabIndex = 64;
            // 
            // idDetalleFacturaTextBox
            // 
            this.idDetalleFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "IdDetalleFactura", true));
            this.idDetalleFacturaTextBox.Enabled = false;
            this.idDetalleFacturaTextBox.Location = new System.Drawing.Point(633, 89);
            this.idDetalleFacturaTextBox.Name = "idDetalleFacturaTextBox";
            this.idDetalleFacturaTextBox.Size = new System.Drawing.Size(102, 20);
            this.idDetalleFacturaTextBox.TabIndex = 76;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nfacturaDataGridViewTextBoxColumn
            // 
            this.nfacturaDataGridViewTextBoxColumn.DataPropertyName = "nfactura";
            this.nfacturaDataGridViewTextBoxColumn.HeaderText = "nfactura";
            this.nfacturaDataGridViewTextBoxColumn.Name = "nfacturaDataGridViewTextBoxColumn";
            this.nfacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nfacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Unidades
            // 
            this.Unidades.DataPropertyName = "Unidades";
            this.Unidades.HeaderText = "Cantidad";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            // 
            // idDetalleFacturaDataGridViewTextBoxColumn
            // 
            this.idDetalleFacturaDataGridViewTextBoxColumn.DataPropertyName = "IdDetalleFactura";
            this.idDetalleFacturaDataGridViewTextBoxColumn.HeaderText = "IdDetalleFactura";
            this.idDetalleFacturaDataGridViewTextBoxColumn.Name = "idDetalleFacturaDataGridViewTextBoxColumn";
            this.idDetalleFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDetalleFacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // expr3DataGridViewTextBoxColumn
            // 
            this.expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3";
            this.expr3DataGridViewTextBoxColumn.HeaderText = "Expr3";
            this.expr3DataGridViewTextBoxColumn.Name = "expr3DataGridViewTextBoxColumn";
            this.expr3DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr3DataGridViewTextBoxColumn.Visible = false;
            // 
            // fechadeventaDataGridViewTextBoxColumn
            // 
            this.fechadeventaDataGridViewTextBoxColumn.DataPropertyName = "fecha_de_venta";
            this.fechadeventaDataGridViewTextBoxColumn.HeaderText = "fecha_de_venta";
            this.fechadeventaDataGridViewTextBoxColumn.Name = "fechadeventaDataGridViewTextBoxColumn";
            this.fechadeventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechadeventaDataGridViewTextBoxColumn.Visible = false;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "Precio";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // preciototalDataGridViewTextBoxColumn
            // 
            this.preciototalDataGridViewTextBoxColumn.DataPropertyName = "Precio_total";
            this.preciototalDataGridViewTextBoxColumn.HeaderText = "Precio_total";
            this.preciototalDataGridViewTextBoxColumn.Name = "preciototalDataGridViewTextBoxColumn";
            this.preciototalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProductosDataGridViewTextBoxColumn
            // 
            this.idProductosDataGridViewTextBoxColumn.DataPropertyName = "IdProductos";
            this.idProductosDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.idProductosDataGridViewTextBoxColumn.Name = "idProductosDataGridViewTextBoxColumn";
            this.idProductosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr2DataGridViewTextBoxColumn
            // 
            this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
            this.expr2DataGridViewTextBoxColumn.HeaderText = "Expr2";
            this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
            this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr2DataGridViewTextBoxColumn.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreclienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // expr4DataGridViewTextBoxColumn
            // 
            this.expr4DataGridViewTextBoxColumn.DataPropertyName = "Expr4";
            this.expr4DataGridViewTextBoxColumn.HeaderText = "Expr4";
            this.expr4DataGridViewTextBoxColumn.Name = "expr4DataGridViewTextBoxColumn";
            this.expr4DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr4DataGridViewTextBoxColumn.Visible = false;
            // 
            // expr5DataGridViewTextBoxColumn
            // 
            this.expr5DataGridViewTextBoxColumn.DataPropertyName = "Expr5";
            this.expr5DataGridViewTextBoxColumn.HeaderText = "Expr5";
            this.expr5DataGridViewTextBoxColumn.Name = "expr5DataGridViewTextBoxColumn";
            this.expr5DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr5DataGridViewTextBoxColumn.Visible = false;
            // 
            // idProductosDvDataGridViewTextBoxColumn
            // 
            this.idProductosDvDataGridViewTextBoxColumn.DataPropertyName = "IdProductosDv";
            this.idProductosDvDataGridViewTextBoxColumn.HeaderText = "IdProductosDv";
            this.idProductosDvDataGridViewTextBoxColumn.Name = "idProductosDvDataGridViewTextBoxColumn";
            this.idProductosDvDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductosDvDataGridViewTextBoxColumn.Visible = false;
            // 
            // expr6DataGridViewTextBoxColumn
            // 
            this.expr6DataGridViewTextBoxColumn.DataPropertyName = "Expr6";
            this.expr6DataGridViewTextBoxColumn.HeaderText = "Expr6";
            this.expr6DataGridViewTextBoxColumn.Name = "expr6DataGridViewTextBoxColumn";
            this.expr6DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr6DataGridViewTextBoxColumn.Visible = false;
            // 
            // expr7DataGridViewTextBoxColumn
            // 
            this.expr7DataGridViewTextBoxColumn.DataPropertyName = "Expr7";
            this.expr7DataGridViewTextBoxColumn.HeaderText = "Expr7";
            this.expr7DataGridViewTextBoxColumn.Name = "expr7DataGridViewTextBoxColumn";
            this.expr7DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr7DataGridViewTextBoxColumn.Visible = false;
            // 
            // nombredelclienteDataGridViewTextBoxColumn
            // 
            this.nombredelclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_del_cliente";
            this.nombredelclienteDataGridViewTextBoxColumn.HeaderText = "nombre_del_cliente";
            this.nombredelclienteDataGridViewTextBoxColumn.Name = "nombredelclienteDataGridViewTextBoxColumn";
            this.nombredelclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombredelclienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // expr8DataGridViewTextBoxColumn
            // 
            this.expr8DataGridViewTextBoxColumn.DataPropertyName = "Expr8";
            this.expr8DataGridViewTextBoxColumn.HeaderText = "Expr8";
            this.expr8DataGridViewTextBoxColumn.Name = "expr8DataGridViewTextBoxColumn";
            this.expr8DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr8DataGridViewTextBoxColumn.Visible = false;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 453);
            this.Controls.Add(idProductosDvLabel);
            this.Controls.Add(this.idProductosDvTextBox);
            this.Controls.Add(idDetalleFacturaLabel);
            this.Controls.Add(this.idDetalleFacturaTextBox);
            this.Controls.Add(this.grbcliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblnregistros);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnprimero);
            this.Controls.Add(this.grbnavegacion);
            this.Controls.Add(this.dataTable3DataGridView);
            this.Controls.Add(nfacturaLabel);
            this.Controls.Add(this.nfacturaComboBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(fecha_de_ventaLabel);
            this.Controls.Add(this.fecha_de_ventaDateTimePicker);
            this.Controls.Add(nombre_del_clienteLabel);
            this.Controls.Add(this.nombre_del_clienteComboBox);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3DataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private SistemaDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private SistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nfacturaComboBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.DateTimePicker fecha_de_ventaDateTimePicker;
        private System.Windows.Forms.ComboBox nombre_del_clienteComboBox;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private SistemaDataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.DataGridView dataTable3DataGridView;
        private System.Windows.Forms.GroupBox grbcliente;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblregistroxden;
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
        private System.Windows.Forms.TextBox idProductosDvTextBox;
        private System.Windows.Forms.TextBox idDetalleFacturaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nfacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadeventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciototalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductosDvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredelclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr8DataGridViewTextBoxColumn;
    }
}