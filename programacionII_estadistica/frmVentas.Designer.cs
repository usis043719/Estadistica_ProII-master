namespace programacionII_estadistica
{
    partial class frmVentas
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
            System.Windows.Forms.Label nfacturaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label precio_totalLabel;
            System.Windows.Forms.Label idEmpleado_Label;
            System.Windows.Forms.Label idClienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.sistemaDataSet = new programacionII_estadistica.SistemaDataSet();
            this.ventaDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaDiaTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.VentaDiaTableAdapter();
            this.tableAdapterManager = new programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager();
            this.ventaDiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ventaDiaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idVentaTextBox = new System.Windows.Forms.TextBox();
            this.nfacturaTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.precio_totalTextBox = new System.Windows.Forms.TextBox();
            this.idEmpleado_TextBox = new System.Windows.Forms.TextBox();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.ventaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idVentaLabel = new System.Windows.Forms.Label();
            nfacturaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            precio_totalLabel = new System.Windows.Forms.Label();
            idEmpleado_Label = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingNavigator)).BeginInit();
            this.ventaDiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idVentaLabel
            // 
            idVentaLabel.AutoSize = true;
            idVentaLabel.Location = new System.Drawing.Point(306, 55);
            idVentaLabel.Name = "idVentaLabel";
            idVentaLabel.Size = new System.Drawing.Size(50, 13);
            idVentaLabel.TabIndex = 1;
            idVentaLabel.Text = "Id Venta:";
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.Location = new System.Drawing.Point(477, 56);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(49, 13);
            nfacturaLabel.TabIndex = 3;
            nfacturaLabel.Text = "nfactura:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(22, 104);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "fecha:";
            // 
            // precio_totalLabel
            // 
            precio_totalLabel.AutoSize = true;
            precio_totalLabel.Location = new System.Drawing.Point(529, 100);
            precio_totalLabel.Name = "precio_totalLabel";
            precio_totalLabel.Size = new System.Drawing.Size(62, 13);
            precio_totalLabel.TabIndex = 7;
            precio_totalLabel.Text = "precio total:";
            // 
            // idEmpleado_Label
            // 
            idEmpleado_Label.AutoSize = true;
            idEmpleado_Label.Location = new System.Drawing.Point(331, 107);
            idEmpleado_Label.Name = "idEmpleado_Label";
            idEmpleado_Label.Size = new System.Drawing.Size(72, 13);
            idEmpleado_Label.TabIndex = 9;
            idEmpleado_Label.Text = "Id Empleado :";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(22, 55);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 11;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "SistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.OrdenesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaDiaTableAdapter = this.ventaDiaTableAdapter;
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
            this.ventaDiaBindingNavigator.Size = new System.Drawing.Size(949, 25);
            this.ventaDiaBindingNavigator.TabIndex = 0;
            this.ventaDiaBindingNavigator.Text = "bindingNavigator1";
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
            // ventaDiaBindingNavigatorSaveItem
            // 
            this.ventaDiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ventaDiaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaDiaBindingNavigatorSaveItem.Image")));
            this.ventaDiaBindingNavigatorSaveItem.Name = "ventaDiaBindingNavigatorSaveItem";
            this.ventaDiaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ventaDiaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ventaDiaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ventaDiaBindingNavigatorSaveItem_Click_1);
            // 
            // idVentaTextBox
            // 
            this.idVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDiaBindingSource, "IdVenta", true));
            this.idVentaTextBox.Location = new System.Drawing.Point(362, 53);
            this.idVentaTextBox.Name = "idVentaTextBox";
            this.idVentaTextBox.Size = new System.Drawing.Size(64, 20);
            this.idVentaTextBox.TabIndex = 2;
            // 
            // nfacturaTextBox
            // 
            this.nfacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDiaBindingSource, "nfactura", true));
            this.nfacturaTextBox.Location = new System.Drawing.Point(532, 52);
            this.nfacturaTextBox.Name = "nfacturaTextBox";
            this.nfacturaTextBox.Size = new System.Drawing.Size(147, 20);
            this.nfacturaTextBox.TabIndex = 4;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventaDiaBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(100, 100);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 6;
            // 
            // precio_totalTextBox
            // 
            this.precio_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDiaBindingSource, "precio_total", true));
            this.precio_totalTextBox.Location = new System.Drawing.Point(607, 97);
            this.precio_totalTextBox.Name = "precio_totalTextBox";
            this.precio_totalTextBox.Size = new System.Drawing.Size(91, 20);
            this.precio_totalTextBox.TabIndex = 8;
            // 
            // idEmpleado_TextBox
            // 
            this.idEmpleado_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDiaBindingSource, "IdEmpleado ", true));
            this.idEmpleado_TextBox.Location = new System.Drawing.Point(409, 100);
            this.idEmpleado_TextBox.Name = "idEmpleado_TextBox";
            this.idEmpleado_TextBox.Size = new System.Drawing.Size(73, 20);
            this.idEmpleado_TextBox.TabIndex = 10;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDiaBindingSource, "IdCliente", true));
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(100, 52);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.idClienteComboBox.TabIndex = 12;
            // 
            // ventaDetalleBindingSource
            // 
            this.ventaDetalleBindingSource.DataMember = "FK_DetalledeVenta_VentaDia1";
            this.ventaDetalleBindingSource.DataSource = this.ventaDiaBindingSource;
            // 
            // ventaDetalleDataGridView
            // 
            this.ventaDetalleDataGridView.AutoGenerateColumns = false;
            this.ventaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventaDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.ventaDetalleDataGridView.DataSource = this.ventaDetalleBindingSource;
            this.ventaDetalleDataGridView.Location = new System.Drawing.Point(12, 157);
            this.ventaDetalleDataGridView.Name = "ventaDetalleDataGridView";
            this.ventaDetalleDataGridView.Size = new System.Drawing.Size(915, 253);
            this.ventaDetalleDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDetalle";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDetalle";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrecioUnitario";
            this.dataGridViewTextBoxColumn3.HeaderText = "PrecioUnitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha_de_comprar";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha_de_comprar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio_total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio_total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descuento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdProductos";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdProductos";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdVentas";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdVentas";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdProDetalle";
            this.dataGridViewTextBoxColumn10.HeaderText = "IdProDetalle";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DescripcionDetalle";
            this.dataGridViewTextBoxColumn11.HeaderText = "DescripcionDetalle";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 493);
            this.Controls.Add(this.ventaDetalleDataGridView);
            this.Controls.Add(idVentaLabel);
            this.Controls.Add(this.idVentaTextBox);
            this.Controls.Add(nfacturaLabel);
            this.Controls.Add(this.nfacturaTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(precio_totalLabel);
            this.Controls.Add(this.precio_totalTextBox);
            this.Controls.Add(idEmpleado_Label);
            this.Controls.Add(this.idEmpleado_TextBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(this.ventaDiaBindingNavigator);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDiaBindingNavigator)).EndInit();
            this.ventaDiaBindingNavigator.ResumeLayout(false);
            this.ventaDiaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource ventaDiaBindingSource;
        private SistemaDataSetTableAdapters.VentaDiaTableAdapter ventaDiaTableAdapter;
        private SistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ventaDiaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ventaDiaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idVentaTextBox;
        private System.Windows.Forms.TextBox nfacturaTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox precio_totalTextBox;
        private System.Windows.Forms.TextBox idEmpleado_TextBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.BindingSource ventaDetalleBindingSource;
        private System.Windows.Forms.DataGridView ventaDetalleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}