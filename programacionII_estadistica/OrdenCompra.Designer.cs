namespace programacionII_estadistica
{
    partial class OrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenCompra));
            System.Windows.Forms.Label idOrdenLabel;
            System.Windows.Forms.Label fechaCompraLabel;
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label nombreProveedorLabel;
            this.sistemaDataSet = new programacionII_estadistica.SistemaDataSet();
            this.ordenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.OrdenesTableAdapter();
            this.tableAdapterManager = new programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager();
            this.ordenesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ordenesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ordenesDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesDatosTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.OrdenesDatosTableAdapter();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.InventarioTableAdapter();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.ProveedorTableAdapter();
            this.idOrdenTextBox = new System.Windows.Forms.TextBox();
            this.fechaCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idProveedorTextBox = new System.Windows.Forms.TextBox();
            this.nombreProveedorTextBox = new System.Windows.Forms.TextBox();
            this.ventaDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaDiaTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.VentaDiaTableAdapter();
            this.ordenesDataGridView = new System.Windows.Forms.DataGridView();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.lblsuma = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idOrdenLabel = new System.Windows.Forms.Label();
            fechaCompraLabel = new System.Windows.Forms.Label();
            idProveedorLabel = new System.Windows.Forms.Label();
            nombreProveedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingNavigator)).BeginInit();
            this.ordenesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "SistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenesBindingSource
            // 
            this.ordenesBindingSource.DataMember = "Ordenes";
            this.ordenesBindingSource.DataSource = this.sistemaDataSet;
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
            this.tableAdapterManager.DetalleDeVentaTableAdapter = null;
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
            // ordenesBindingNavigator
            // 
            this.ordenesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordenesBindingNavigator.BindingSource = this.ordenesBindingSource;
            this.ordenesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordenesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordenesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ordenesBindingNavigatorSaveItem});
            this.ordenesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordenesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordenesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordenesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordenesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordenesBindingNavigator.Name = "ordenesBindingNavigator";
            this.ordenesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordenesBindingNavigator.Size = new System.Drawing.Size(625, 25);
            this.ordenesBindingNavigator.TabIndex = 0;
            this.ordenesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            // ordenesBindingNavigatorSaveItem
            // 
            this.ordenesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordenesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordenesBindingNavigatorSaveItem.Image")));
            this.ordenesBindingNavigatorSaveItem.Name = "ordenesBindingNavigatorSaveItem";
            this.ordenesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordenesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ordenesBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordenesBindingNavigatorSaveItem_Click);
            // 
            // ordenesDatosBindingSource
            // 
            this.ordenesDatosBindingSource.DataMember = "FK_Inventario_Ordenes1";
            this.ordenesDatosBindingSource.DataSource = this.ordenesBindingSource;
            // 
            // ordenesDatosTableAdapter
            // 
            this.ordenesDatosTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.sistemaDataSet;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.sistemaDataSet;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // idOrdenLabel
            // 
            idOrdenLabel.AutoSize = true;
            idOrdenLabel.Location = new System.Drawing.Point(344, 75);
            idOrdenLabel.Name = "idOrdenLabel";
            idOrdenLabel.Size = new System.Drawing.Size(51, 13);
            idOrdenLabel.TabIndex = 1;
            idOrdenLabel.Text = "Id Orden:";
            // 
            // idOrdenTextBox
            // 
            this.idOrdenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "IdOrden", true));
            this.idOrdenTextBox.Location = new System.Drawing.Point(433, 69);
            this.idOrdenTextBox.Name = "idOrdenTextBox";
            this.idOrdenTextBox.Size = new System.Drawing.Size(165, 20);
            this.idOrdenTextBox.TabIndex = 2;
            // 
            // fechaCompraLabel
            // 
            fechaCompraLabel.AutoSize = true;
            fechaCompraLabel.Location = new System.Drawing.Point(21, 72);
            fechaCompraLabel.Name = "fechaCompraLabel";
            fechaCompraLabel.Size = new System.Drawing.Size(79, 13);
            fechaCompraLabel.TabIndex = 3;
            fechaCompraLabel.Text = "Fecha Compra:";
            // 
            // fechaCompraDateTimePicker
            // 
            this.fechaCompraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordenesBindingSource, "FechaCompra", true));
            this.fechaCompraDateTimePicker.Location = new System.Drawing.Point(126, 68);
            this.fechaCompraDateTimePicker.Name = "fechaCompraDateTimePicker";
            this.fechaCompraDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaCompraDateTimePicker.TabIndex = 4;
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Location = new System.Drawing.Point(344, 45);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(71, 13);
            idProveedorLabel.TabIndex = 5;
            idProveedorLabel.Text = "Id Proveedor:";
            // 
            // idProveedorTextBox
            // 
            this.idProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "IdProveedor", true));
            this.idProveedorTextBox.Location = new System.Drawing.Point(433, 42);
            this.idProveedorTextBox.Name = "idProveedorTextBox";
            this.idProveedorTextBox.Size = new System.Drawing.Size(165, 20);
            this.idProveedorTextBox.TabIndex = 6;
            // 
            // nombreProveedorLabel
            // 
            nombreProveedorLabel.AutoSize = true;
            nombreProveedorLabel.Location = new System.Drawing.Point(21, 42);
            nombreProveedorLabel.Name = "nombreProveedorLabel";
            nombreProveedorLabel.Size = new System.Drawing.Size(99, 13);
            nombreProveedorLabel.TabIndex = 7;
            nombreProveedorLabel.Text = "Nombre Proveedor:";
            // 
            // nombreProveedorTextBox
            // 
            this.nombreProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "NombreProveedor", true));
            this.nombreProveedorTextBox.Location = new System.Drawing.Point(126, 39);
            this.nombreProveedorTextBox.Name = "nombreProveedorTextBox";
            this.nombreProveedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreProveedorTextBox.TabIndex = 8;
            // 
            // ventaDiaBindingSource
            // 
            this.ventaDiaBindingSource.DataMember = "VentaDia";
            this.ventaDiaBindingSource.DataSource = this.sistemaDataSet;
            // 
            // ventaDiaTableAdapter
            // 
            this.ventaDiaTableAdapter.ClearBeforeFill = true;
            // 
            // ordenesDataGridView
            // 
            this.ordenesDataGridView.AutoGenerateColumns = false;
            this.ordenesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordenesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.ordenesDataGridView.DataSource = this.ordenesBindingSource;
            this.ordenesDataGridView.Location = new System.Drawing.Point(24, 122);
            this.ordenesDataGridView.Name = "ordenesDataGridView";
            this.ordenesDataGridView.Size = new System.Drawing.Size(574, 201);
            this.ordenesDataGridView.TabIndex = 16;
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(149, 391);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 52;
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(205, 381);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(40, 33);
            this.btnultimo.TabIndex = 51;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(166, 381);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(40, 33);
            this.btnsiguiente.TabIndex = 50;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(107, 381);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(40, 33);
            this.btnanterior.TabIndex = 49;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.Location = new System.Drawing.Point(68, 381);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(40, 33);
            this.btnprimero.TabIndex = 48;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbliva);
            this.panel1.Controls.Add(this.lblsuma);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(398, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 47;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(32, 73);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 33;
            this.lbltotal.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "$ 0.00";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Location = new System.Drawing.Point(32, 48);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(24, 13);
            this.lbliva.TabIndex = 32;
            this.lbliva.Text = "IVA";
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.Location = new System.Drawing.Point(32, 21);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(37, 13);
            this.lblsuma.TabIndex = 31;
            this.lblsuma.Text = "Suma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "$ 0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "$ 0.00";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdOrden";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdOrden";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FechaCompra";
            this.dataGridViewTextBoxColumn8.HeaderText = "FechaCompra";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdProveedor";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdProveedor";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NombreProveedor";
            this.dataGridViewTextBoxColumn10.HeaderText = "NombreProveedor";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Empresa";
            this.dataGridViewTextBoxColumn11.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn12.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Unidades";
            this.dataGridViewTextBoxColumn13.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 593);
            this.Controls.Add(this.lblnregistros);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnprimero);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ordenesDataGridView);
            this.Controls.Add(idOrdenLabel);
            this.Controls.Add(this.idOrdenTextBox);
            this.Controls.Add(fechaCompraLabel);
            this.Controls.Add(this.fechaCompraDateTimePicker);
            this.Controls.Add(idProveedorLabel);
            this.Controls.Add(this.idProveedorTextBox);
            this.Controls.Add(nombreProveedorLabel);
            this.Controls.Add(this.nombreProveedorTextBox);
            this.Controls.Add(this.ordenesBindingNavigator);
            this.Name = "OrdenCompra";
            this.Text = "OrdenCompra";
            this.Load += new System.EventHandler(this.OrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingNavigator)).EndInit();
            this.ordenesBindingNavigator.ResumeLayout(false);
            this.ordenesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource ordenesBindingSource;
        private SistemaDataSetTableAdapters.OrdenesTableAdapter ordenesTableAdapter;
        private SistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordenesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ordenesBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource ordenesDatosBindingSource;
        private SistemaDataSetTableAdapters.OrdenesDatosTableAdapter ordenesDatosTableAdapter;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private SistemaDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private SistemaDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.TextBox idOrdenTextBox;
        private System.Windows.Forms.DateTimePicker fechaCompraDateTimePicker;
        private System.Windows.Forms.TextBox idProveedorTextBox;
        private System.Windows.Forms.TextBox nombreProveedorTextBox;
        private System.Windows.Forms.BindingSource ventaDiaBindingSource;
        private SistemaDataSetTableAdapters.VentaDiaTableAdapter ventaDiaTableAdapter;
        private System.Windows.Forms.DataGridView ordenesDataGridView;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label lblsuma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}