namespace programacionII_estadistica
{
    partial class DetalleDeVentas
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
            System.Windows.Forms.Label idVentaLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idEmpleado_Label;
            System.Windows.Forms.Label precio_totalLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label nfacturaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleDeVentas));
            this.detalleDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDataSet = new programacionII_estadistica.SistemaDataSet();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ventaDiaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ventaDiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKFacturaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.ventaDiaTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.VentaDiaTableAdapter();
            this.tableAdapterManager = new programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.ClientesTableAdapter();
            this.detalleDeVentaTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.DetalleDeVentaTableAdapter();
            this.facturaTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.FacturaTableAdapter();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.idEmpleado_ComboBox = new System.Windows.Forms.ComboBox();
            this.precio_totalTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nfacturaTextBox = new System.Windows.Forms.TextBox();
            this.idVentaTextBox = new System.Windows.Forms.TextBox();
            this.detalleDeVentaDataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIvaVenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaVenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.IdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_comprar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbnavegacion = new System.Windows.Forms.GroupBox();
            this.grbcliente = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            idVentaLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idEmpleado_Label = new System.Windows.Forms.Label();
            precio_totalLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            nfacturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDeVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingNavigator)).BeginInit();
            this.ventaDiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFacturaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDeVentaDataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grbcliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // idVentaLabel
            // 
            idVentaLabel.AutoSize = true;
            idVentaLabel.Location = new System.Drawing.Point(549, 63);
            idVentaLabel.Name = "idVentaLabel";
            idVentaLabel.Size = new System.Drawing.Size(50, 13);
            idVentaLabel.TabIndex = 30;
            idVentaLabel.Text = "Id Venta:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(33, 65);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 40;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // idEmpleado_Label
            // 
            idEmpleado_Label.AutoSize = true;
            idEmpleado_Label.Location = new System.Drawing.Point(342, 113);
            idEmpleado_Label.Name = "idEmpleado_Label";
            idEmpleado_Label.Size = new System.Drawing.Size(72, 13);
            idEmpleado_Label.TabIndex = 38;
            idEmpleado_Label.Text = "Id Empleado :";
            // 
            // precio_totalLabel
            // 
            precio_totalLabel.AutoSize = true;
            precio_totalLabel.Location = new System.Drawing.Point(342, 64);
            precio_totalLabel.Name = "precio_totalLabel";
            precio_totalLabel.Size = new System.Drawing.Size(62, 13);
            precio_totalLabel.TabIndex = 36;
            precio_totalLabel.Text = "precio total:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(33, 111);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 34;
            fechaLabel.Text = "fecha:";
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.Location = new System.Drawing.Point(549, 111);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(49, 13);
            nfacturaLabel.TabIndex = 32;
            nfacturaLabel.Text = "nfactura:";
            // 
            // detalleDeVentaBindingSource
            // 
            this.detalleDeVentaBindingSource.DataMember = "FK_DetalledeVenta_VentaDia";
            this.detalleDeVentaBindingSource.DataSource = this.ventaDiaBindingSource;
            // 
            // ventaDiaBindingSource
            // 
            this.ventaDiaBindingSource.DataMember = "VentaDia";
            this.ventaDiaBindingSource.DataSource = this.sistemaDataSet;
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "SistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // ventaDiaBindingNavigatorSaveItem
            // 
            this.ventaDiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ventaDiaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaDiaBindingNavigatorSaveItem.Image")));
            this.ventaDiaBindingNavigatorSaveItem.Name = "ventaDiaBindingNavigatorSaveItem";
            this.ventaDiaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ventaDiaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ventaDiaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ventaDiaBindingNavigatorSaveItem_Click);
            // 
            // ventaDiaBindingNavigator
            // 
            this.ventaDiaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ventaDiaBindingNavigator.BindingSource = this.ventaDiaBindingSource;
            this.ventaDiaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ventaDiaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ventaDiaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ventaDiaBindingNavigatorSaveItem});
            this.ventaDiaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ventaDiaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ventaDiaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ventaDiaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ventaDiaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ventaDiaBindingNavigator.Name = "ventaDiaBindingNavigator";
            this.ventaDiaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ventaDiaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ventaDiaBindingNavigator.TabIndex = 0;
            this.ventaDiaBindingNavigator.Text = "bindingNavigator1";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.sistemaDataSetBindingSource;
            // 
            // sistemaDataSetBindingSource
            // 
            this.sistemaDataSetBindingSource.DataSource = this.sistemaDataSet;
            this.sistemaDataSetBindingSource.Position = 0;
            // 
            // fKFacturaClientesBindingSource
            // 
            this.fKFacturaClientesBindingSource.DataMember = "FK_Factura_Clientes";
            this.fKFacturaClientesBindingSource.DataSource = this.clientesBindingSource;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.sistemaDataSetBindingSource;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.sistemaDataSetBindingSource;
            // 
            // clientesBindingSource3
            // 
            this.clientesBindingSource3.DataMember = "Clientes";
            this.clientesBindingSource3.DataSource = this.sistemaDataSetBindingSource;
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(127, 372);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 46;
            this.lblnregistros.Click += new System.EventHandler(this.Lblnregistros_Click);
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(217, 362);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(40, 33);
            this.btnultimo.TabIndex = 45;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(178, 362);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(40, 33);
            this.btnsiguiente.TabIndex = 44;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(85, 362);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(40, 33);
            this.btnanterior.TabIndex = 43;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.Location = new System.Drawing.Point(46, 362);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(40, 33);
            this.btnprimero.TabIndex = 42;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // ventaDiaTableAdapter
            // 
            this.ventaDiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.DescuentoTableAdapter = null;
            this.tableAdapterManager.DetalleDeVentaTableAdapter = this.detalleDeVentaTableAdapter;
            this.tableAdapterManager.DevolucionesTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = this.facturaTableAdapter;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.OrdenesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaDiaTableAdapter = this.ventaDiaTableAdapter;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // detalleDeVentaTableAdapter
            // 
            this.detalleDeVentaTableAdapter.ClearBeforeFill = true;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDiaBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource;
            this.idClienteComboBox.DisplayMember = "Nombre_cliente";
            this.idClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(111, 60);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.idClienteComboBox.TabIndex = 41;
            this.idClienteComboBox.ValueMember = "IdCliente";
            // 
            // idEmpleado_ComboBox
            // 
            this.idEmpleado_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDiaBindingSource, "IdEmpleado ", true));
            this.idEmpleado_ComboBox.FormattingEnabled = true;
            this.idEmpleado_ComboBox.Location = new System.Drawing.Point(420, 106);
            this.idEmpleado_ComboBox.Name = "idEmpleado_ComboBox";
            this.idEmpleado_ComboBox.Size = new System.Drawing.Size(90, 21);
            this.idEmpleado_ComboBox.TabIndex = 39;
            // 
            // precio_totalTextBox
            // 
            this.precio_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDiaBindingSource, "precio_total", true));
            this.precio_totalTextBox.Location = new System.Drawing.Point(420, 58);
            this.precio_totalTextBox.Name = "precio_totalTextBox";
            this.precio_totalTextBox.Size = new System.Drawing.Size(90, 20);
            this.precio_totalTextBox.TabIndex = 37;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventaDiaBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(111, 107);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 35;
            // 
            // nfacturaTextBox
            // 
            this.nfacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDiaBindingSource, "nfactura", true));
            this.nfacturaTextBox.Location = new System.Drawing.Point(627, 108);
            this.nfacturaTextBox.Name = "nfacturaTextBox";
            this.nfacturaTextBox.Size = new System.Drawing.Size(90, 20);
            this.nfacturaTextBox.TabIndex = 33;
            // 
            // idVentaTextBox
            // 
            this.idVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDiaBindingSource, "IdVenta", true));
            this.idVentaTextBox.Location = new System.Drawing.Point(627, 60);
            this.idVentaTextBox.Name = "idVentaTextBox";
            this.idVentaTextBox.Size = new System.Drawing.Size(90, 20);
            this.idVentaTextBox.TabIndex = 31;
            // 
            // detalleDeVentaDataGridView1
            // 
            this.detalleDeVentaDataGridView1.AllowUserToAddRows = false;
            this.detalleDeVentaDataGridView1.AllowUserToDeleteRows = false;
            this.detalleDeVentaDataGridView1.AutoGenerateColumns = false;
            this.detalleDeVentaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleDeVentaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetalle,
            this.Descripcion,
            this.Unidades,
            this.PrecioUnitario,
            this.Fecha_de_comprar,
            this.Precio_total,
            this.IdVentas,
            this.IdProductos,
            this.Descuento,
            this.IdEmpleado});
            this.detalleDeVentaDataGridView1.DataSource = this.detalleDeVentaBindingSource;
            this.detalleDeVentaDataGridView1.Location = new System.Drawing.Point(28, 151);
            this.detalleDeVentaDataGridView1.Name = "detalleDeVentaDataGridView1";
            this.detalleDeVentaDataGridView1.ReadOnly = true;
            this.detalleDeVentaDataGridView1.Size = new System.Drawing.Size(746, 169);
            this.detalleDeVentaDataGridView1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalVenta);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblIvaVenta);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblSumaVenta);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(574, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 92);
            this.panel2.TabIndex = 47;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(142, 61);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(46, 13);
            this.lblTotalVenta.TabIndex = 5;
            this.lblTotalVenta.Text = "0000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL:";
            // 
            // lblIvaVenta
            // 
            this.lblIvaVenta.AutoSize = true;
            this.lblIvaVenta.Location = new System.Drawing.Point(154, 36);
            this.lblIvaVenta.Name = "lblIvaVenta";
            this.lblIvaVenta.Size = new System.Drawing.Size(34, 13);
            this.lblIvaVenta.TabIndex = 3;
            this.lblIvaVenta.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IVA:";
            // 
            // lblSumaVenta
            // 
            this.lblSumaVenta.AutoSize = true;
            this.lblSumaVenta.Location = new System.Drawing.Point(142, 12);
            this.lblSumaVenta.Name = "lblSumaVenta";
            this.lblSumaVenta.Size = new System.Drawing.Size(46, 13);
            this.lblSumaVenta.TabIndex = 1;
            this.lblSumaVenta.Text = "0000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SUMA:";
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Location = new System.Drawing.Point(138, 372);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(36, 13);
            this.lblregistroxden.TabIndex = 48;
            this.lblregistroxden.Text = "x de n";
            // 
            // IdDetalle
            // 
            this.IdDetalle.DataPropertyName = "IdDetalle";
            this.IdDetalle.HeaderText = "IdDetalle";
            this.IdDetalle.Name = "IdDetalle";
            this.IdDetalle.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Unidades
            // 
            this.Unidades.DataPropertyName = "Unidades";
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "PrecioUnitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Fecha_de_comprar
            // 
            this.Fecha_de_comprar.DataPropertyName = "Fecha_de_comprar";
            this.Fecha_de_comprar.HeaderText = "Fecha_de_comprar";
            this.Fecha_de_comprar.Name = "Fecha_de_comprar";
            this.Fecha_de_comprar.ReadOnly = true;
            // 
            // Precio_total
            // 
            this.Precio_total.DataPropertyName = "Precio_total";
            this.Precio_total.HeaderText = "Precio_total";
            this.Precio_total.Name = "Precio_total";
            this.Precio_total.ReadOnly = true;
            // 
            // IdVentas
            // 
            this.IdVentas.DataPropertyName = "IdVentas";
            this.IdVentas.HeaderText = "IdVentas";
            this.IdVentas.Name = "IdVentas";
            this.IdVentas.ReadOnly = true;
            this.IdVentas.Visible = false;
            // 
            // IdProductos
            // 
            this.IdProductos.DataPropertyName = "IdProductos";
            this.IdProductos.HeaderText = "IdProductos";
            this.IdProductos.Name = "IdProductos";
            this.IdProductos.ReadOnly = true;
            this.IdProductos.Visible = false;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.DataPropertyName = "IdEmpleado";
            this.IdEmpleado.HeaderText = "IdEmpleado";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            this.IdEmpleado.Visible = false;
            // 
            // grbnavegacion
            // 
            this.grbnavegacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbnavegacion.Location = new System.Drawing.Point(28, 340);
            this.grbnavegacion.Name = "grbnavegacion";
            this.grbnavegacion.Size = new System.Drawing.Size(243, 78);
            this.grbnavegacion.TabIndex = 49;
            this.grbnavegacion.TabStop = false;
            this.grbnavegacion.Text = "Navegacion";
            // 
            // grbcliente
            // 
            this.grbcliente.BackColor = System.Drawing.Color.Transparent;
            this.grbcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbcliente.Controls.Add(this.btnbuscar);
            this.grbcliente.Controls.Add(this.btneliminar);
            this.grbcliente.Controls.Add(this.btnmodificar);
            this.grbcliente.Controls.Add(this.btnagregar);
            this.grbcliente.Location = new System.Drawing.Point(277, 338);
            this.grbcliente.Name = "grbcliente";
            this.grbcliente.Size = new System.Drawing.Size(269, 104);
            this.grbcliente.TabIndex = 50;
            this.grbcliente.TabStop = false;
            this.grbcliente.Text = "Edicion de empleado";
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
            // DetalleDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.grbcliente);
            this.Controls.Add(this.lblregistroxden);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblnregistros);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnprimero);
            this.Controls.Add(idVentaLabel);
            this.Controls.Add(this.idVentaTextBox);
            this.Controls.Add(nfacturaLabel);
            this.Controls.Add(this.nfacturaTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(precio_totalLabel);
            this.Controls.Add(this.precio_totalTextBox);
            this.Controls.Add(idEmpleado_Label);
            this.Controls.Add(this.idEmpleado_ComboBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(this.detalleDeVentaDataGridView1);
            this.Controls.Add(this.ventaDiaBindingNavigator);
            this.Controls.Add(this.grbnavegacion);
            this.Name = "DetalleDeVentas";
            this.Text = "DetalleDeVentas";
            this.Load += new System.EventHandler(this.DetalleDeVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalleDeVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingNavigator)).EndInit();
            this.ventaDiaBindingNavigator.ResumeLayout(false);
            this.ventaDiaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFacturaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDeVentaDataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbcliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource ventaDiaBindingSource;
        private SistemaDataSetTableAdapters.VentaDiaTableAdapter ventaDiaTableAdapter;
        private SistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SistemaDataSetTableAdapters.DetalleDeVentaTableAdapter detalleDeVentaTableAdapter;
        private System.Windows.Forms.BindingSource detalleDeVentaBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton ventaDiaBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator ventaDiaBindingNavigator;
        private SistemaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource sistemaDataSetBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private SistemaDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.BindingSource fKFacturaClientesBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource3;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.ComboBox idEmpleado_ComboBox;
        private System.Windows.Forms.TextBox precio_totalTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox nfacturaTextBox;
        private System.Windows.Forms.TextBox idVentaTextBox;
        private System.Windows.Forms.DataGridView detalleDeVentaDataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIvaVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_comprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.GroupBox grbnavegacion;
        private System.Windows.Forms.GroupBox grbcliente;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
    }
}