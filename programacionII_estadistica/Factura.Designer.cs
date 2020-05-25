namespace programacionII_estadistica
{
    partial class Factura
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
            System.Windows.Forms.Label idProductosDvLabel;
            System.Windows.Forms.Label fecha_de_ventaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombre_del_clienteLabel;
            System.Windows.Forms.Label unidadesLabel;
            System.Windows.Forms.Label precioUnitarioLabel;
            System.Windows.Forms.Label idDetalleFacturaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.sistemaDataSet = new programacionII_estadistica.SistemaDataSet();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new programacionII_estadistica.SistemaDataSetTableAdapters.FacturaTableAdapter();
            this.tableAdapterManager = new programacionII_estadistica.SistemaDataSetTableAdapters.TableAdapterManager();
            this.facturaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nfacturaComboBox = new System.Windows.Forms.ComboBox();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.idProductosDvTextBox = new System.Windows.Forms.TextBox();
            this.fecha_de_ventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombre_del_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.unidadesTextBox = new System.Windows.Forms.TextBox();
            this.precioUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.idDetalleFacturaTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.facturaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            nfacturaLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idProductosDvLabel = new System.Windows.Forms.Label();
            fecha_de_ventaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombre_del_clienteLabel = new System.Windows.Forms.Label();
            unidadesLabel = new System.Windows.Forms.Label();
            precioUnitarioLabel = new System.Windows.Forms.Label();
            idDetalleFacturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingNavigator)).BeginInit();
            this.facturaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // facturaBindingNavigator
            // 
            this.facturaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.facturaBindingNavigator.BindingSource = this.facturaBindingSource;
            this.facturaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facturaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.facturaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.facturaBindingNavigatorSaveItem});
            this.facturaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.facturaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facturaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facturaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facturaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facturaBindingNavigator.Name = "facturaBindingNavigator";
            this.facturaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facturaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.facturaBindingNavigator.TabIndex = 0;
            this.facturaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.Location = new System.Drawing.Point(23, 38);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(49, 13);
            nfacturaLabel.TabIndex = 1;
            nfacturaLabel.Text = "nfactura:";
            // 
            // nfacturaComboBox
            // 
            this.nfacturaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "nfactura", true));
            this.nfacturaComboBox.FormattingEnabled = true;
            this.nfacturaComboBox.Location = new System.Drawing.Point(125, 35);
            this.nfacturaComboBox.Name = "nfacturaComboBox";
            this.nfacturaComboBox.Size = new System.Drawing.Size(200, 21);
            this.nfacturaComboBox.TabIndex = 2;
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(23, 65);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 3;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "IdCliente", true));
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(125, 62);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.idClienteComboBox.TabIndex = 4;
            // 
            // idProductosDvLabel
            // 
            idProductosDvLabel.AutoSize = true;
            idProductosDvLabel.Location = new System.Drawing.Point(23, 92);
            idProductosDvLabel.Name = "idProductosDvLabel";
            idProductosDvLabel.Size = new System.Drawing.Size(87, 13);
            idProductosDvLabel.TabIndex = 5;
            idProductosDvLabel.Text = "Id Productos Dv:";
            // 
            // idProductosDvTextBox
            // 
            this.idProductosDvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "IdProductosDv", true));
            this.idProductosDvTextBox.Location = new System.Drawing.Point(125, 89);
            this.idProductosDvTextBox.Name = "idProductosDvTextBox";
            this.idProductosDvTextBox.Size = new System.Drawing.Size(200, 20);
            this.idProductosDvTextBox.TabIndex = 6;
            // 
            // fecha_de_ventaLabel
            // 
            fecha_de_ventaLabel.AutoSize = true;
            fecha_de_ventaLabel.Location = new System.Drawing.Point(23, 119);
            fecha_de_ventaLabel.Name = "fecha_de_ventaLabel";
            fecha_de_ventaLabel.Size = new System.Drawing.Size(82, 13);
            fecha_de_ventaLabel.TabIndex = 7;
            fecha_de_ventaLabel.Text = "fecha de venta:";
            // 
            // fecha_de_ventaDateTimePicker
            // 
            this.fecha_de_ventaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facturaBindingSource, "fecha_de_venta", true));
            this.fecha_de_ventaDateTimePicker.Location = new System.Drawing.Point(125, 115);
            this.fecha_de_ventaDateTimePicker.Name = "fecha_de_ventaDateTimePicker";
            this.fecha_de_ventaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_de_ventaDateTimePicker.TabIndex = 8;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(23, 144);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 9;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(125, 141);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcionTextBox.TabIndex = 10;
            // 
            // nombre_del_clienteLabel
            // 
            nombre_del_clienteLabel.AutoSize = true;
            nombre_del_clienteLabel.Location = new System.Drawing.Point(23, 170);
            nombre_del_clienteLabel.Name = "nombre_del_clienteLabel";
            nombre_del_clienteLabel.Size = new System.Drawing.Size(96, 13);
            nombre_del_clienteLabel.TabIndex = 11;
            nombre_del_clienteLabel.Text = "nombre del cliente:";
            // 
            // nombre_del_clienteComboBox
            // 
            this.nombre_del_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "nombre_del_cliente", true));
            this.nombre_del_clienteComboBox.FormattingEnabled = true;
            this.nombre_del_clienteComboBox.Location = new System.Drawing.Point(125, 167);
            this.nombre_del_clienteComboBox.Name = "nombre_del_clienteComboBox";
            this.nombre_del_clienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.nombre_del_clienteComboBox.TabIndex = 12;
            // 
            // unidadesLabel
            // 
            unidadesLabel.AutoSize = true;
            unidadesLabel.Location = new System.Drawing.Point(23, 197);
            unidadesLabel.Name = "unidadesLabel";
            unidadesLabel.Size = new System.Drawing.Size(55, 13);
            unidadesLabel.TabIndex = 13;
            unidadesLabel.Text = "Unidades:";
            // 
            // unidadesTextBox
            // 
            this.unidadesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Unidades", true));
            this.unidadesTextBox.Location = new System.Drawing.Point(125, 194);
            this.unidadesTextBox.Name = "unidadesTextBox";
            this.unidadesTextBox.Size = new System.Drawing.Size(200, 20);
            this.unidadesTextBox.TabIndex = 14;
            // 
            // precioUnitarioLabel
            // 
            precioUnitarioLabel.AutoSize = true;
            precioUnitarioLabel.Location = new System.Drawing.Point(23, 223);
            precioUnitarioLabel.Name = "precioUnitarioLabel";
            precioUnitarioLabel.Size = new System.Drawing.Size(78, 13);
            precioUnitarioLabel.TabIndex = 15;
            precioUnitarioLabel.Text = "precio Unitario:";
            // 
            // precioUnitarioTextBox
            // 
            this.precioUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "precioUnitario", true));
            this.precioUnitarioTextBox.Location = new System.Drawing.Point(125, 220);
            this.precioUnitarioTextBox.Name = "precioUnitarioTextBox";
            this.precioUnitarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioUnitarioTextBox.TabIndex = 16;
            // 
            // idDetalleFacturaLabel
            // 
            idDetalleFacturaLabel.AutoSize = true;
            idDetalleFacturaLabel.Location = new System.Drawing.Point(23, 249);
            idDetalleFacturaLabel.Name = "idDetalleFacturaLabel";
            idDetalleFacturaLabel.Size = new System.Drawing.Size(94, 13);
            idDetalleFacturaLabel.TabIndex = 17;
            idDetalleFacturaLabel.Text = "Id Detalle Factura:";
            // 
            // idDetalleFacturaTextBox
            // 
            this.idDetalleFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "IdDetalleFactura", true));
            this.idDetalleFacturaTextBox.Location = new System.Drawing.Point(125, 246);
            this.idDetalleFacturaTextBox.Name = "idDetalleFacturaTextBox";
            this.idDetalleFacturaTextBox.Size = new System.Drawing.Size(200, 20);
            this.idDetalleFacturaTextBox.TabIndex = 18;
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
            // facturaBindingNavigatorSaveItem
            // 
            this.facturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facturaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facturaBindingNavigatorSaveItem.Image")));
            this.facturaBindingNavigatorSaveItem.Name = "facturaBindingNavigatorSaveItem";
            this.facturaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.facturaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.facturaBindingNavigatorSaveItem.Click += new System.EventHandler(this.facturaBindingNavigatorSaveItem_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(nfacturaLabel);
            this.Controls.Add(this.nfacturaComboBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(idProductosDvLabel);
            this.Controls.Add(this.idProductosDvTextBox);
            this.Controls.Add(fecha_de_ventaLabel);
            this.Controls.Add(this.fecha_de_ventaDateTimePicker);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(nombre_del_clienteLabel);
            this.Controls.Add(this.nombre_del_clienteComboBox);
            this.Controls.Add(unidadesLabel);
            this.Controls.Add(this.unidadesTextBox);
            this.Controls.Add(precioUnitarioLabel);
            this.Controls.Add(this.precioUnitarioTextBox);
            this.Controls.Add(idDetalleFacturaLabel);
            this.Controls.Add(this.idDetalleFacturaTextBox);
            this.Controls.Add(this.facturaBindingNavigator);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingNavigator)).EndInit();
            this.facturaBindingNavigator.ResumeLayout(false);
            this.facturaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private SistemaDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private SistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator facturaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton facturaBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox nfacturaComboBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.TextBox idProductosDvTextBox;
        private System.Windows.Forms.DateTimePicker fecha_de_ventaDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox nombre_del_clienteComboBox;
        private System.Windows.Forms.TextBox unidadesTextBox;
        private System.Windows.Forms.TextBox precioUnitarioTextBox;
        private System.Windows.Forms.TextBox idDetalleFacturaTextBox;
    }
}