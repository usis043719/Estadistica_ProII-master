namespace programacionII_estadistica
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idInventarioLabel;
            System.Windows.Forms.Label unidadesLabel;
            System.Windows.Forms.Label idproductosLabel;
            this.sistemaDataSet = new programacionII_estadistica.SistemaDataSet();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.InventarioTableAdapter();
            this.tableAdapterManager = new programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager();
            this.inventarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.inventarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.inventarioDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDatosTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.InventarioDatosTableAdapter();
            this.ventaDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaDiaTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.VentaDiaTableAdapter();
            this.ordenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.OrdenesTableAdapter();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.ProveedorTableAdapter();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.ProductosTableAdapter();
            this.devolucionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devolucionesTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.DevolucionesTableAdapter();
            this.inventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idproductosTextBox = new System.Windows.Forms.TextBox();
            this.unidadesTextBox = new System.Windows.Forms.TextBox();
            this.idInventarioTextBox = new System.Windows.Forms.TextBox();
            descripcionLabel = new System.Windows.Forms.Label();
            idInventarioLabel = new System.Windows.Forms.Label();
            unidadesLabel = new System.Windows.Forms.Label();
            idproductosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingNavigator)).BeginInit();
            this.inventarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "SistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.DescuentoTableAdapter = null;
            this.tableAdapterManager.DetalleDeVentaTableAdapter = null;
            this.tableAdapterManager.DevolucionesTableAdapter = this.devolucionesTableAdapter;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = this.inventarioTableAdapter;
            this.tableAdapterManager.OrdenesTableAdapter = this.ordenesTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ProveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.UpdateOrder = programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaDiaTableAdapter = this.ventaDiaTableAdapter;
            // 
            // inventarioBindingNavigator
            // 
            this.inventarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventarioBindingNavigator.BindingSource = this.inventarioBindingSource;
            this.inventarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.inventarioBindingNavigatorSaveItem});
            this.inventarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventarioBindingNavigator.Name = "inventarioBindingNavigator";
            this.inventarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventarioBindingNavigator.Size = new System.Drawing.Size(606, 25);
            this.inventarioBindingNavigator.TabIndex = 0;
            this.inventarioBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
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
            // inventarioBindingNavigatorSaveItem
            // 
            this.inventarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventarioBindingNavigatorSaveItem.Image")));
            this.inventarioBindingNavigatorSaveItem.Name = "inventarioBindingNavigatorSaveItem";
            this.inventarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inventarioBindingNavigatorSaveItem.Text = "Guardar datos";
            this.inventarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventarioBindingNavigatorSaveItem_Click);
            // 
            // inventarioDatosBindingSource
            // 
            this.inventarioDatosBindingSource.DataMember = "InventarioDatos";
            this.inventarioDatosBindingSource.DataSource = this.sistemaDataSet;
            // 
            // inventarioDatosTableAdapter
            // 
            this.inventarioDatosTableAdapter.ClearBeforeFill = true;
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
            // ordenesBindingSource
            // 
            this.ordenesBindingSource.DataMember = "Ordenes";
            this.ordenesBindingSource.DataSource = this.sistemaDataSet;
            // 
            // ordenesTableAdapter
            // 
            this.ordenesTableAdapter.ClearBeforeFill = true;
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
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.sistemaDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // devolucionesBindingSource
            // 
            this.devolucionesBindingSource.DataMember = "Devoluciones";
            this.devolucionesBindingSource.DataSource = this.sistemaDataSet;
            // 
            // devolucionesTableAdapter
            // 
            this.devolucionesTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioDataGridView
            // 
            this.inventarioDataGridView.AutoGenerateColumns = false;
            this.inventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.inventarioDataGridView.DataSource = this.inventarioBindingSource;
            this.inventarioDataGridView.Location = new System.Drawing.Point(32, 128);
            this.inventarioDataGridView.Name = "inventarioDataGridView";
            this.inventarioDataGridView.Size = new System.Drawing.Size(539, 182);
            this.inventarioDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdInventario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdInventario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Unidades";
            this.dataGridViewTextBoxColumn2.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Idproductos";
            this.dataGridViewTextBoxColumn3.HeaderText = "Idproductos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdOrden";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdOrden";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(118, 400);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 58;
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(174, 390);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(40, 33);
            this.btnultimo.TabIndex = 57;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(135, 390);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(40, 33);
            this.btnsiguiente.TabIndex = 56;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(76, 390);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(40, 33);
            this.btnanterior.TabIndex = 55;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnprimero
            // 
            this.btnprimero.Location = new System.Drawing.Point(37, 390);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(40, 33);
            this.btnprimero.TabIndex = 54;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbliva);
            this.panel1.Controls.Add(this.lblsuma);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(371, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 53;
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
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(315, 71);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 8;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(240, 74);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 7;
            descripcionLabel.Text = "Descripcion:";
            // 
            // idproductosTextBox
            // 
            this.idproductosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Idproductos", true));
            this.idproductosTextBox.Location = new System.Drawing.Point(315, 45);
            this.idproductosTextBox.Name = "idproductosTextBox";
            this.idproductosTextBox.Size = new System.Drawing.Size(100, 20);
            this.idproductosTextBox.TabIndex = 6;
            // 
            // idInventarioLabel
            // 
            idInventarioLabel.AutoSize = true;
            idInventarioLabel.Location = new System.Drawing.Point(29, 48);
            idInventarioLabel.Name = "idInventarioLabel";
            idInventarioLabel.Size = new System.Drawing.Size(69, 13);
            idInventarioLabel.TabIndex = 1;
            idInventarioLabel.Text = "Id Inventario:";
            // 
            // unidadesTextBox
            // 
            this.unidadesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Unidades", true));
            this.unidadesTextBox.Location = new System.Drawing.Point(104, 71);
            this.unidadesTextBox.Name = "unidadesTextBox";
            this.unidadesTextBox.Size = new System.Drawing.Size(100, 20);
            this.unidadesTextBox.TabIndex = 4;
            // 
            // unidadesLabel
            // 
            unidadesLabel.AutoSize = true;
            unidadesLabel.Location = new System.Drawing.Point(29, 74);
            unidadesLabel.Name = "unidadesLabel";
            unidadesLabel.Size = new System.Drawing.Size(55, 13);
            unidadesLabel.TabIndex = 3;
            unidadesLabel.Text = "Unidades:";
            // 
            // idInventarioTextBox
            // 
            this.idInventarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "IdInventario", true));
            this.idInventarioTextBox.Location = new System.Drawing.Point(104, 45);
            this.idInventarioTextBox.Name = "idInventarioTextBox";
            this.idInventarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.idInventarioTextBox.TabIndex = 2;
            // 
            // idproductosLabel
            // 
            idproductosLabel.AutoSize = true;
            idproductosLabel.Location = new System.Drawing.Point(240, 48);
            idproductosLabel.Name = "idproductosLabel";
            idproductosLabel.Size = new System.Drawing.Size(66, 13);
            idproductosLabel.TabIndex = 5;
            idproductosLabel.Text = "Idproductos:";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 446);
            this.Controls.Add(this.lblnregistros);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnprimero);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inventarioDataGridView);
            this.Controls.Add(idInventarioLabel);
            this.Controls.Add(this.idInventarioTextBox);
            this.Controls.Add(unidadesLabel);
            this.Controls.Add(this.unidadesTextBox);
            this.Controls.Add(idproductosLabel);
            this.Controls.Add(this.idproductosTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.inventarioBindingNavigator);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingNavigator)).EndInit();
            this.inventarioBindingNavigator.ResumeLayout(false);
            this.inventarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private SistemaDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private SistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton inventarioBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource inventarioDatosBindingSource;
        private SistemaDataSetTableAdapters.InventarioDatosTableAdapter inventarioDatosTableAdapter;
        private SistemaDataSetTableAdapters.VentaDiaTableAdapter ventaDiaTableAdapter;
        private System.Windows.Forms.BindingSource ventaDiaBindingSource;
        private SistemaDataSetTableAdapters.OrdenesTableAdapter ordenesTableAdapter;
        private System.Windows.Forms.BindingSource ordenesBindingSource;
        private SistemaDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private SistemaDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private SistemaDataSetTableAdapters.DevolucionesTableAdapter devolucionesTableAdapter;
        private System.Windows.Forms.BindingSource devolucionesBindingSource;
        private System.Windows.Forms.DataGridView inventarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
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
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idproductosTextBox;
        private System.Windows.Forms.TextBox unidadesTextBox;
        private System.Windows.Forms.TextBox idInventarioTextBox;
    }
}