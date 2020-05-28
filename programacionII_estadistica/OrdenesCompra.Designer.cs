namespace programacionII_estadistica
{
    partial class OrdenesCompra
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
            System.Windows.Forms.Label idOrdenLabel;
            System.Windows.Forms.Label fechaCompraLabel;
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label nombreProveedorLabel;
            System.Windows.Forms.Label empresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenesCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label idDetalleOrdenLabel;
            this.ordenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDataSet = new programacionII_estadistica.SistemaDataSet();
            this.idOrdenComboBox = new System.Windows.Forms.ComboBox();
            this.fechaCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idProveedorTextBox = new System.Windows.Forms.TextBox();
            this.nombreProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.empresaComboBox = new System.Windows.Forms.ComboBox();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.OrdenesTableAdapter();
            this.tableAdapterManager = new programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager();
            this.dataTable2TableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.DataTable2TableAdapter();
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
            this.grbnavegacion = new System.Windows.Forms.GroupBox();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnultimo = new System.Windows.Forms.Button();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.dataTable2DataGridView = new System.Windows.Forms.DataGridView();
            this.detalleOrdenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detalleOrdenesTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.DetalleOrdenesTableAdapter();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetalleOrdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetalleOrdenTextBox = new System.Windows.Forms.TextBox();
            idOrdenLabel = new System.Windows.Forms.Label();
            fechaCompraLabel = new System.Windows.Forms.Label();
            idProveedorLabel = new System.Windows.Forms.Label();
            nombreProveedorLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            idDetalleOrdenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.grbcliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbnavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idOrdenLabel
            // 
            idOrdenLabel.AutoSize = true;
            idOrdenLabel.BackColor = System.Drawing.Color.Transparent;
            idOrdenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idOrdenLabel.Location = new System.Drawing.Point(354, 78);
            idOrdenLabel.Name = "idOrdenLabel";
            idOrdenLabel.Size = new System.Drawing.Size(57, 15);
            idOrdenLabel.TabIndex = 1;
            idOrdenLabel.Text = "Id Orden:";
            // 
            // fechaCompraLabel
            // 
            fechaCompraLabel.AutoSize = true;
            fechaCompraLabel.BackColor = System.Drawing.Color.Transparent;
            fechaCompraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaCompraLabel.Location = new System.Drawing.Point(25, 76);
            fechaCompraLabel.Name = "fechaCompraLabel";
            fechaCompraLabel.Size = new System.Drawing.Size(91, 15);
            fechaCompraLabel.TabIndex = 3;
            fechaCompraLabel.Text = "Fecha Compra:";
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.BackColor = System.Drawing.Color.Transparent;
            idProveedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProveedorLabel.Location = new System.Drawing.Point(332, 31);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(79, 15);
            idProveedorLabel.TabIndex = 5;
            idProveedorLabel.Text = "Id Proveedor:";
            // 
            // nombreProveedorLabel
            // 
            nombreProveedorLabel.AutoSize = true;
            nombreProveedorLabel.BackColor = System.Drawing.Color.Transparent;
            nombreProveedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreProveedorLabel.Location = new System.Drawing.Point(25, 30);
            nombreProveedorLabel.Name = "nombreProveedorLabel";
            nombreProveedorLabel.Size = new System.Drawing.Size(66, 15);
            nombreProveedorLabel.TabIndex = 7;
            nombreProveedorLabel.Text = "Proveedor:";
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.BackColor = System.Drawing.Color.Transparent;
            empresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empresaLabel.Location = new System.Drawing.Point(522, 30);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(60, 15);
            empresaLabel.TabIndex = 9;
            empresaLabel.Text = "Empresa:";
            // 
            // ordenesBindingSource
            // 
            this.ordenesBindingSource.DataMember = "Ordenes";
            this.ordenesBindingSource.DataSource = this.sistemaDataSet;
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "SistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idOrdenComboBox
            // 
            this.idOrdenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordenesBindingSource, "IdOrden", true));
            this.idOrdenComboBox.DataSource = this.ordenesBindingSource;
            this.idOrdenComboBox.DisplayMember = "IdOrden";
            this.idOrdenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idOrdenComboBox.Enabled = false;
            this.idOrdenComboBox.FormattingEnabled = true;
            this.idOrdenComboBox.Location = new System.Drawing.Point(417, 74);
            this.idOrdenComboBox.Name = "idOrdenComboBox";
            this.idOrdenComboBox.Size = new System.Drawing.Size(99, 21);
            this.idOrdenComboBox.TabIndex = 2;
            this.idOrdenComboBox.ValueMember = "IdOrden";
            // 
            // fechaCompraDateTimePicker
            // 
            this.fechaCompraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordenesBindingSource, "FechaCompra", true));
            this.fechaCompraDateTimePicker.Enabled = false;
            this.fechaCompraDateTimePicker.Location = new System.Drawing.Point(121, 75);
            this.fechaCompraDateTimePicker.Name = "fechaCompraDateTimePicker";
            this.fechaCompraDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaCompraDateTimePicker.TabIndex = 4;
            // 
            // idProveedorTextBox
            // 
            this.idProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "IdProveedor", true));
            this.idProveedorTextBox.Enabled = false;
            this.idProveedorTextBox.Location = new System.Drawing.Point(417, 28);
            this.idProveedorTextBox.Name = "idProveedorTextBox";
            this.idProveedorTextBox.Size = new System.Drawing.Size(99, 20);
            this.idProveedorTextBox.TabIndex = 6;
            // 
            // nombreProveedorComboBox
            // 
            this.nombreProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordenesBindingSource, "NombreProveedor", true));
            this.nombreProveedorComboBox.DataSource = this.ordenesBindingSource;
            this.nombreProveedorComboBox.DisplayMember = "NombreProveedor";
            this.nombreProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombreProveedorComboBox.Enabled = false;
            this.nombreProveedorComboBox.FormattingEnabled = true;
            this.nombreProveedorComboBox.Location = new System.Drawing.Point(121, 27);
            this.nombreProveedorComboBox.Name = "nombreProveedorComboBox";
            this.nombreProveedorComboBox.Size = new System.Drawing.Size(200, 21);
            this.nombreProveedorComboBox.TabIndex = 8;
            this.nombreProveedorComboBox.ValueMember = "NombreProveedor";
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordenesBindingSource, "Empresa", true));
            this.empresaComboBox.DataSource = this.ordenesBindingSource;
            this.empresaComboBox.DisplayMember = "Empresa";
            this.empresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaComboBox.Enabled = false;
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(590, 28);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(106, 21);
            this.empresaComboBox.TabIndex = 10;
            this.empresaComboBox.ValueMember = "Empresa";
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "FK_Inventario_Ordenes1";
            this.dataTable2BindingSource.DataSource = this.ordenesBindingSource;
            // 
            // ordenesTableAdapter
            // 
            this.ordenesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.DescuentoTableAdapter = null;
            this.tableAdapterManager.DetalleDeFacturaTableAdapter = null;
            this.tableAdapterManager.DetalleDeVentaTableAdapter = null;
            this.tableAdapterManager.DetalleOrdenesTableAdapter = null;
            this.tableAdapterManager.DevolucionesTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.OrdenesTableAdapter = this.ordenesTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaDiaTableAdapter = null;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // grbcliente
            // 
            this.grbcliente.BackColor = System.Drawing.Color.Transparent;
            this.grbcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbcliente.Controls.Add(this.btnbuscar);
            this.grbcliente.Controls.Add(this.btneliminar);
            this.grbcliente.Controls.Add(this.btnmodificar);
            this.grbcliente.Controls.Add(this.btnagregar);
            this.grbcliente.Location = new System.Drawing.Point(267, 335);
            this.grbcliente.Name = "grbcliente";
            this.grbcliente.Size = new System.Drawing.Size(269, 104);
            this.grbcliente.TabIndex = 76;
            this.grbcliente.TabStop = false;
            this.grbcliente.Text = "Edicion de Ordenes de Compra";
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
            this.panel2.Location = new System.Drawing.Point(553, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 96);
            this.panel2.TabIndex = 75;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenta.Location = new System.Drawing.Point(113, 63);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(53, 13);
            this.lblTotalVenta.TabIndex = 5;
            this.lblTotalVenta.Text = "0000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL:";
            // 
            // lblIvaVenta
            // 
            this.lblIvaVenta.AutoSize = true;
            this.lblIvaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIvaVenta.Location = new System.Drawing.Point(113, 38);
            this.lblIvaVenta.Name = "lblIvaVenta";
            this.lblIvaVenta.Size = new System.Drawing.Size(39, 13);
            this.lblIvaVenta.TabIndex = 3;
            this.lblIvaVenta.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IVA:";
            // 
            // lblSumaVenta
            // 
            this.lblSumaVenta.AutoSize = true;
            this.lblSumaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaVenta.Location = new System.Drawing.Point(113, 14);
            this.lblSumaVenta.Name = "lblSumaVenta";
            this.lblSumaVenta.Size = new System.Drawing.Size(53, 13);
            this.lblSumaVenta.TabIndex = 1;
            this.lblSumaVenta.Text = "0000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SUMA:";
            // 
            // grbnavegacion
            // 
            this.grbnavegacion.BackColor = System.Drawing.Color.Transparent;
            this.grbnavegacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbnavegacion.Controls.Add(this.btnsiguiente);
            this.grbnavegacion.Controls.Add(this.btnprimero);
            this.grbnavegacion.Controls.Add(this.btnanterior);
            this.grbnavegacion.Controls.Add(this.btnultimo);
            this.grbnavegacion.Controls.Add(this.lblnregistros);
            this.grbnavegacion.Controls.Add(this.lblregistroxden);
            this.grbnavegacion.Location = new System.Drawing.Point(18, 343);
            this.grbnavegacion.Name = "grbnavegacion";
            this.grbnavegacion.Size = new System.Drawing.Size(243, 78);
            this.grbnavegacion.TabIndex = 74;
            this.grbnavegacion.TabStop = false;
            this.grbnavegacion.Text = "Navegacion";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.White;
            this.btnsiguiente.Location = new System.Drawing.Point(149, 26);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(40, 33);
            this.btnsiguiente.TabIndex = 52;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.BackColor = System.Drawing.Color.White;
            this.btnprimero.Location = new System.Drawing.Point(17, 26);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(40, 33);
            this.btnprimero.TabIndex = 50;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = false;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.BackColor = System.Drawing.Color.White;
            this.btnanterior.Location = new System.Drawing.Point(56, 26);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(40, 33);
            this.btnanterior.TabIndex = 51;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = false;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnultimo
            // 
            this.btnultimo.BackColor = System.Drawing.Color.White;
            this.btnultimo.Location = new System.Drawing.Point(188, 26);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(40, 33);
            this.btnultimo.TabIndex = 53;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = false;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(98, 36);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 54;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistroxden.Location = new System.Drawing.Point(98, 34);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(46, 15);
            this.lblregistroxden.TabIndex = 55;
            this.lblregistroxden.Text = "x de n";
            // 
            // dataTable2DataGridView
            // 
            this.dataTable2DataGridView.AllowUserToAddRows = false;
            this.dataTable2DataGridView.AllowUserToDeleteRows = false;
            this.dataTable2DataGridView.AutoGenerateColumns = false;
            this.dataTable2DataGridView.BackgroundColor = System.Drawing.Color.Orange;
            this.dataTable2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable2DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataTable2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable2DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalleOrdenDataGridViewTextBoxColumn,
            this.idOrdenDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.idProveedorDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.Unidades,
            this.idProductosDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.PrecioUnitario,
            this.Descuento});
            this.dataTable2DataGridView.DataSource = this.detalleOrdenesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable2DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataTable2DataGridView.EnableHeadersVisualStyles = false;
            this.dataTable2DataGridView.Location = new System.Drawing.Point(18, 120);
            this.dataTable2DataGridView.Name = "dataTable2DataGridView";
            this.dataTable2DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable2DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataTable2DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTable2DataGridView.Size = new System.Drawing.Size(707, 188);
            this.dataTable2DataGridView.TabIndex = 76;
            // 
            // detalleOrdenesBindingSource
            // 
            this.detalleOrdenesBindingSource.DataMember = "Ordenes_DetalleOrdenes";
            this.detalleOrdenesBindingSource.DataSource = this.ordenesBindingSource;
            // 
            // ordenesBindingSource1
            // 
            this.ordenesBindingSource1.DataMember = "Ordenes_DataTable2";
            this.ordenesBindingSource1.DataSource = this.dataTable2BindingSource;
            // 
            // detalleOrdenesTableAdapter
            // 
            this.detalleOrdenesTableAdapter.ClearBeforeFill = true;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "Precio";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProductosDataGridViewTextBoxColumn
            // 
            this.idProductosDataGridViewTextBoxColumn.DataPropertyName = "IdProductos ";
            this.idProductosDataGridViewTextBoxColumn.HeaderText = "Codigo producto";
            this.idProductosDataGridViewTextBoxColumn.Name = "idProductosDataGridViewTextBoxColumn";
            this.idProductosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Unidades
            // 
            this.Unidades.DataPropertyName = "Unidades";
            this.Unidades.HeaderText = "Cantidad";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor ";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "NombreProveedor ";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreProveedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor ";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor ";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProveedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra ";
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "FechaCompra ";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCompraDataGridViewTextBoxColumn.Visible = false;
            // 
            // idOrdenDataGridViewTextBoxColumn
            // 
            this.idOrdenDataGridViewTextBoxColumn.DataPropertyName = "IdOrden";
            this.idOrdenDataGridViewTextBoxColumn.HeaderText = "Codigo Orden";
            this.idOrdenDataGridViewTextBoxColumn.Name = "idOrdenDataGridViewTextBoxColumn";
            this.idOrdenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDetalleOrdenDataGridViewTextBoxColumn
            // 
            this.idDetalleOrdenDataGridViewTextBoxColumn.DataPropertyName = "IdDetalleOrden";
            this.idDetalleOrdenDataGridViewTextBoxColumn.HeaderText = "IdDetalleOrden";
            this.idDetalleOrdenDataGridViewTextBoxColumn.Name = "idDetalleOrdenDataGridViewTextBoxColumn";
            this.idDetalleOrdenDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDetalleOrdenDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDetalleOrdenLabel
            // 
            idDetalleOrdenLabel.AutoSize = true;
            idDetalleOrdenLabel.BackColor = System.Drawing.Color.Transparent;
            idDetalleOrdenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idDetalleOrdenLabel.Location = new System.Drawing.Point(527, 81);
            idDetalleOrdenLabel.Name = "idDetalleOrdenLabel";
            idDetalleOrdenLabel.Size = new System.Drawing.Size(62, 15);
            idDetalleOrdenLabel.TabIndex = 90;
            idDetalleOrdenLabel.Text = "Id Detalle:";
            // 
            // idDetalleOrdenTextBox
            // 
            this.idDetalleOrdenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "IdDetalleOrden", true));
            this.idDetalleOrdenTextBox.Enabled = false;
            this.idDetalleOrdenTextBox.Location = new System.Drawing.Point(590, 77);
            this.idDetalleOrdenTextBox.Name = "idDetalleOrdenTextBox";
            this.idDetalleOrdenTextBox.Size = new System.Drawing.Size(106, 20);
            this.idDetalleOrdenTextBox.TabIndex = 91;
            // 
            // OrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 469);
            this.Controls.Add(idDetalleOrdenLabel);
            this.Controls.Add(this.idDetalleOrdenTextBox);
            this.Controls.Add(this.dataTable2DataGridView);
            this.Controls.Add(this.grbcliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grbnavegacion);
            this.Controls.Add(idOrdenLabel);
            this.Controls.Add(this.idOrdenComboBox);
            this.Controls.Add(fechaCompraLabel);
            this.Controls.Add(this.fechaCompraDateTimePicker);
            this.Controls.Add(idProveedorLabel);
            this.Controls.Add(this.idProveedorTextBox);
            this.Controls.Add(nombreProveedorLabel);
            this.Controls.Add(this.nombreProveedorComboBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaComboBox);
            this.Name = "OrdenesCompra";
            this.Text = "OrdenesCompra";
            this.Load += new System.EventHandler(this.OrdenesCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.grbcliente.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbnavegacion.ResumeLayout(false);
            this.grbnavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource ordenesBindingSource;
        private SistemaDataSetTableAdapters.OrdenesTableAdapter ordenesTableAdapter;
        private SistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox idOrdenComboBox;
        private System.Windows.Forms.DateTimePicker fechaCompraDateTimePicker;
        private System.Windows.Forms.TextBox idProveedorTextBox;
        private System.Windows.Forms.ComboBox nombreProveedorComboBox;
        private System.Windows.Forms.ComboBox empresaComboBox;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private SistemaDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
 
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
        private System.Windows.Forms.GroupBox grbnavegacion;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.DataGridView dataTable2DataGridView;
        private System.Windows.Forms.BindingSource ordenesBindingSource1;
        private System.Windows.Forms.BindingSource detalleOrdenesBindingSource;
        private SistemaDataSetTableAdapters.DetalleOrdenesTableAdapter detalleOrdenesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleOrdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.TextBox idDetalleOrdenTextBox;
    }
}