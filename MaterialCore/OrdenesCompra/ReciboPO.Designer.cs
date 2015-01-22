namespace MaterialCore
{
    partial class ReciboPO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciboPO));
            this.dgvPos = new System.Windows.Forms.DataGridView();
            this.Corto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.escaneado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renglonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNumeroParte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDrawingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadAbierta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadOriginalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSkipLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gQuimico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gITAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gConsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quimicos = new MaterialCore.DataSets.Quimicos();
            this.txtNumeroProveedor = new System.Windows.Forms.TextBox();
            this.txtNumeroPo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroParte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadRecibida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFacturaProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaisOC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.txtPlanta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoGuia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBultos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkMaster = new System.Windows.Forms.CheckBox();
            this.txtPlantaOriginal = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRenglonID = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtUOM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoneda1 = new System.Windows.Forms.TextBox();
            this.txtFechaRecibo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBuscarPO = new System.Windows.Forms.TextBox();
            this.btnMas = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtProgramaID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblQuimico = new System.Windows.Forms.Label();
            this.lblSkip = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblITAR = new System.Windows.Forms.Label();
            this.materialesOCTableAdapter = new MaterialCore.DataSets.QuimicosTableAdapters.MaterialesOCTableAdapter();
            this.chkCerradas = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblInbound = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quimicos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPos
            // 
            this.dgvPos.AllowUserToAddRows = false;
            this.dgvPos.AllowUserToDeleteRows = false;
            this.dgvPos.AllowUserToResizeRows = false;
            this.dgvPos.AutoGenerateColumns = false;
            this.dgvPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Corto,
            this.escaneado,
            this.idDataGridViewTextBoxColumn,
            this.gPlanta,
            this.renglonIdDataGridViewTextBoxColumn,
            this.gNumeroParte,
            this.gDrawingId,
            this.CantidadAbierta,
            this.cantidadOriginalDataGridViewTextBoxColumn,
            this.CantidadRecibida,
            this.precioDataGridViewTextBoxColumn,
            this.NoGuia,
            this.gSkipLot,
            this.gQuimico,
            this.gITAR,
            this.gConsignacion});
            this.dgvPos.DataSource = this.materialesOCBindingSource;
            this.dgvPos.Location = new System.Drawing.Point(12, 34);
            this.dgvPos.MultiSelect = false;
            this.dgvPos.Name = "dgvPos";
            this.dgvPos.ReadOnly = true;
            this.dgvPos.RowHeadersVisible = false;
            this.dgvPos.RowHeadersWidth = 24;
            this.dgvPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPos.Size = new System.Drawing.Size(988, 285);
            this.dgvPos.TabIndex = 2;
            this.dgvPos.Sorted += new System.EventHandler(this.dgvPos_Sorted);
            this.dgvPos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPos_CellDoubleClick);
            this.dgvPos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPos_KeyDown);
            this.dgvPos.SelectionChanged += new System.EventHandler(this.dgvPos_SelectionChanged);
            // 
            // Corto
            // 
            this.Corto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Corto.HeaderText = "Corto";
            this.Corto.Name = "Corto";
            this.Corto.ReadOnly = true;
            this.Corto.Visible = false;
            // 
            // escaneado
            // 
            this.escaneado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.escaneado.DataPropertyName = "escaneado";
            this.escaneado.HeaderText = "Digitalizado";
            this.escaneado.Name = "escaneado";
            this.escaneado.ReadOnly = true;
            this.escaneado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.escaneado.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "PO Num";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Width = 53;
            // 
            // gPlanta
            // 
            this.gPlanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gPlanta.DataPropertyName = "Planta";
            this.gPlanta.HeaderText = "Planta";
            this.gPlanta.Name = "gPlanta";
            this.gPlanta.ReadOnly = true;
            this.gPlanta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gPlanta.Width = 43;
            // 
            // renglonIdDataGridViewTextBoxColumn
            // 
            this.renglonIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.renglonIdDataGridViewTextBoxColumn.DataPropertyName = "RenglonId";
            this.renglonIdDataGridViewTextBoxColumn.HeaderText = "PO Linea";
            this.renglonIdDataGridViewTextBoxColumn.Name = "renglonIdDataGridViewTextBoxColumn";
            this.renglonIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.renglonIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.renglonIdDataGridViewTextBoxColumn.Width = 57;
            // 
            // gNumeroParte
            // 
            this.gNumeroParte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gNumeroParte.DataPropertyName = "NumeroParte";
            this.gNumeroParte.HeaderText = "Numero Parte";
            this.gNumeroParte.Name = "gNumeroParte";
            this.gNumeroParte.ReadOnly = true;
            this.gNumeroParte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gNumeroParte.Width = 78;
            // 
            // gDrawingId
            // 
            this.gDrawingId.DataPropertyName = "DrawingId";
            this.gDrawingId.HeaderText = "DrawingId";
            this.gDrawingId.Name = "gDrawingId";
            this.gDrawingId.ReadOnly = true;
            this.gDrawingId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gDrawingId.Width = 130;
            // 
            // CantidadAbierta
            // 
            this.CantidadAbierta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CantidadAbierta.DataPropertyName = "CantidadAbierta";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.CantidadAbierta.DefaultCellStyle = dataGridViewCellStyle1;
            this.CantidadAbierta.HeaderText = "Cant. Abierta";
            this.CantidadAbierta.Name = "CantidadAbierta";
            this.CantidadAbierta.ReadOnly = true;
            this.CantidadAbierta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CantidadAbierta.Width = 74;
            // 
            // cantidadOriginalDataGridViewTextBoxColumn
            // 
            this.cantidadOriginalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cantidadOriginalDataGridViewTextBoxColumn.DataPropertyName = "CantidadOriginal";
            dataGridViewCellStyle2.Format = "N0";
            this.cantidadOriginalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cantidadOriginalDataGridViewTextBoxColumn.HeaderText = "Cant. Original";
            this.cantidadOriginalDataGridViewTextBoxColumn.Name = "cantidadOriginalDataGridViewTextBoxColumn";
            this.cantidadOriginalDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadOriginalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidadOriginalDataGridViewTextBoxColumn.Width = 76;
            // 
            // CantidadRecibida
            // 
            this.CantidadRecibida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CantidadRecibida.DataPropertyName = "CantidadRecibida";
            dataGridViewCellStyle3.Format = "N0";
            this.CantidadRecibida.DefaultCellStyle = dataGridViewCellStyle3;
            this.CantidadRecibida.HeaderText = "Cant. Recibida";
            this.CantidadRecibida.Name = "CantidadRecibida";
            this.CantidadRecibida.ReadOnly = true;
            this.CantidadRecibida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CantidadRecibida.Width = 83;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            dataGridViewCellStyle4.Format = "N2";
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioDataGridViewTextBoxColumn.Width = 43;
            // 
            // NoGuia
            // 
            this.NoGuia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NoGuia.DataPropertyName = "NoGuia";
            this.NoGuia.HeaderText = "NoGuia";
            this.NoGuia.Name = "NoGuia";
            this.NoGuia.ReadOnly = true;
            this.NoGuia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NoGuia.Width = 49;
            // 
            // gSkipLot
            // 
            this.gSkipLot.DataPropertyName = "Text1";
            this.gSkipLot.HeaderText = "";
            this.gSkipLot.Name = "gSkipLot";
            this.gSkipLot.ReadOnly = true;
            this.gSkipLot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gQuimico
            // 
            this.gQuimico.DataPropertyName = "Quimico";
            this.gQuimico.HeaderText = "Quimico";
            this.gQuimico.Name = "gQuimico";
            this.gQuimico.ReadOnly = true;
            this.gQuimico.Visible = false;
            // 
            // gITAR
            // 
            this.gITAR.DataPropertyName = "ITAR";
            this.gITAR.HeaderText = "ITAR";
            this.gITAR.Name = "gITAR";
            this.gITAR.ReadOnly = true;
            this.gITAR.Visible = false;
            // 
            // gConsignacion
            // 
            this.gConsignacion.DataPropertyName = "Consignacion";
            this.gConsignacion.HeaderText = "Consignacion";
            this.gConsignacion.Name = "gConsignacion";
            this.gConsignacion.ReadOnly = true;
            this.gConsignacion.Visible = false;
            // 
            // materialesOCBindingSource
            // 
            this.materialesOCBindingSource.DataMember = "MaterialesOC";
            this.materialesOCBindingSource.DataSource = this.quimicos;
            // 
            // quimicos
            // 
            this.quimicos.DataSetName = "Quimicos";
            this.quimicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumeroProveedor
            // 
            this.txtNumeroProveedor.Location = new System.Drawing.Point(79, 348);
            this.txtNumeroProveedor.Name = "txtNumeroProveedor";
            this.txtNumeroProveedor.ReadOnly = true;
            this.txtNumeroProveedor.Size = new System.Drawing.Size(84, 20);
            this.txtNumeroProveedor.TabIndex = 7;
            // 
            // txtNumeroPo
            // 
            this.txtNumeroPo.Location = new System.Drawing.Point(105, 31);
            this.txtNumeroPo.MaxLength = 10;
            this.txtNumeroPo.Name = "txtNumeroPo";
            this.txtNumeroPo.ReadOnly = true;
            this.txtNumeroPo.Size = new System.Drawing.Size(146, 20);
            this.txtNumeroPo.TabIndex = 3;
            this.txtNumeroPo.Click += new System.EventHandler(this.txtNumeroPo_Click);
            this.txtNumeroPo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPo_KeyPress);
            this.txtNumeroPo.Enter += new System.EventHandler(this.txtNumeroPo_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&2.- Numero PO:";
            // 
            // txtNumeroParte
            // 
            this.txtNumeroParte.Location = new System.Drawing.Point(365, 6);
            this.txtNumeroParte.Name = "txtNumeroParte";
            this.txtNumeroParte.ReadOnly = true;
            this.txtNumeroParte.Size = new System.Drawing.Size(119, 20);
            this.txtNumeroParte.TabIndex = 7;
            this.txtNumeroParte.Click += new System.EventHandler(this.txtNumeroParte_Click);
            this.txtNumeroParte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroParte_KeyPress);
            this.txtNumeroParte.Enter += new System.EventHandler(this.txtNumeroParte_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&4.- Numero Parte:";
            // 
            // txtCantidadRecibida
            // 
            this.txtCantidadRecibida.Location = new System.Drawing.Point(630, 31);
            this.txtCantidadRecibida.Name = "txtCantidadRecibida";
            this.txtCantidadRecibida.Size = new System.Drawing.Size(119, 20);
            this.txtCantidadRecibida.TabIndex = 17;
            this.txtCantidadRecibida.Click += new System.EventHandler(this.txtCantidadRecibida_Click);
            this.txtCantidadRecibida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidadRecibida_KeyDown);
            this.txtCantidadRecibida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadRecibida_KeyPress);
            this.txtCantidadRecibida.Enter += new System.EventHandler(this.txtCantidadRecibida_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "&C.- Cant. Recibida:";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(670, 324);
            this.txtUnidadMedida.MaxLength = 2;
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.ReadOnly = true;
            this.txtUnidadMedida.Size = new System.Drawing.Size(35, 20);
            this.txtUnidadMedida.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Unidad de medida:";
            // 
            // txtFacturaProveedor
            // 
            this.txtFacturaProveedor.Location = new System.Drawing.Point(630, 56);
            this.txtFacturaProveedor.MaxLength = 15;
            this.txtFacturaProveedor.Name = "txtFacturaProveedor";
            this.txtFacturaProveedor.Size = new System.Drawing.Size(119, 20);
            this.txtFacturaProveedor.TabIndex = 19;
            this.txtFacturaProveedor.Click += new System.EventHandler(this.txtFacturaProveedor_Click);
            this.txtFacturaProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFacturaProveedor_KeyDown);
            this.txtFacturaProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFacturaProveedor_KeyPress);
            this.txtFacturaProveedor.Enter += new System.EventHandler(this.txtFacturaProveedor_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "&F.- Factura proveedor:";
            // 
            // txtPaisOC
            // 
            this.txtPaisOC.Location = new System.Drawing.Point(740, 348);
            this.txtPaisOC.MaxLength = 2;
            this.txtPaisOC.Name = "txtPaisOC";
            this.txtPaisOC.ReadOnly = true;
            this.txtPaisOC.Size = new System.Drawing.Size(86, 20);
            this.txtPaisOC.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "&1.- Fecha Recibo:";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(624, 348);
            this.txtMoneda.MaxLength = 3;
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.ReadOnly = true;
            this.txtMoneda.Size = new System.Drawing.Size(56, 20);
            this.txtMoneda.TabIndex = 12;
            // 
            // txtPlanta
            // 
            this.txtPlanta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlanta.Location = new System.Drawing.Point(330, 83);
            this.txtPlanta.Name = "txtPlanta";
            this.txtPlanta.Size = new System.Drawing.Size(56, 20);
            this.txtPlanta.TabIndex = 21;
            this.txtPlanta.Click += new System.EventHandler(this.txtPlanta_Click);
            this.txtPlanta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlanta_KeyDown);
            this.txtPlanta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlanta_KeyPress);
            this.txtPlanta.Enter += new System.EventHandler(this.txtPlanta_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "&P.- Planta:";
            // 
            // txtNoGuia
            // 
            this.txtNoGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoGuia.Location = new System.Drawing.Point(630, 82);
            this.txtNoGuia.Name = "txtNoGuia";
            this.txtNoGuia.Size = new System.Drawing.Size(220, 20);
            this.txtNoGuia.TabIndex = 23;
            this.txtNoGuia.TextChanged += new System.EventHandler(this.txtNoGuia_TextChanged);
            this.txtNoGuia.Click += new System.EventHandler(this.txtNoGuia_Click);
            this.txtNoGuia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoGuia_KeyDown);
            this.txtNoGuia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoGuia_KeyPress);
            this.txtNoGuia.Enter += new System.EventHandler(this.txtNoGuia_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(575, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "&G.- Guia:";
            // 
            // txtBultos
            // 
            this.txtBultos.Location = new System.Drawing.Point(630, 108);
            this.txtBultos.Name = "txtBultos";
            this.txtBultos.Size = new System.Drawing.Size(83, 20);
            this.txtBultos.TabIndex = 25;
            this.txtBultos.Click += new System.EventHandler(this.txtBultos_Click);
            this.txtBultos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBultos_KeyDown);
            this.txtBultos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBultos_KeyPress);
            this.txtBultos.Enter += new System.EventHandler(this.txtBultos_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "&B.- Bultos:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(629, 134);
            this.txtComentario.MaxLength = 200;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(352, 20);
            this.txtComentario.TabIndex = 27;
            this.txtComentario.Click += new System.EventHandler(this.txtComentario_Click);
            this.txtComentario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            this.txtComentario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComentario_KeyPress);
            this.txtComentario.Enter += new System.EventHandler(this.txtComentario_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(545, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "&O.- Comentario:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 328);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Descripcion Num Parte:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 352);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Proveedor:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(613, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(571, 381);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Programa ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkMaster);
            this.panel2.Controls.Add(this.txtPlantaOriginal);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.txtRenglonID);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPais);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNumeroPo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNumeroParte);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtUOM);
            this.panel2.Controls.Add(this.txtCantidadRecibida);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtFacturaProveedor);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMoneda1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtFechaRecibo);
            this.panel2.Controls.Add(this.txtPlanta);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtNoGuia);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtComentario);
            this.panel2.Controls.Add(this.txtBultos);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(12, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 201);
            this.panel2.TabIndex = 3;
            // 
            // chkMaster
            // 
            this.chkMaster.AutoSize = true;
            this.chkMaster.Location = new System.Drawing.Point(856, 83);
            this.chkMaster.Name = "chkMaster";
            this.chkMaster.Size = new System.Drawing.Size(58, 17);
            this.chkMaster.TabIndex = 56;
            this.chkMaster.Text = "Master";
            this.chkMaster.UseVisualStyleBackColor = true;
            // 
            // txtPlantaOriginal
            // 
            this.txtPlantaOriginal.Location = new System.Drawing.Point(392, 83);
            this.txtPlantaOriginal.Name = "txtPlantaOriginal";
            this.txtPlantaOriginal.ReadOnly = true;
            this.txtPlantaOriginal.Size = new System.Drawing.Size(56, 20);
            this.txtPlantaOriginal.TabIndex = 55;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(13, 94);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 23);
            this.btnActualizar.TabIndex = 28;
            this.btnActualizar.Text = "Actualizar info";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(906, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "&3.- Numero Linea:";
            // 
            // txtRenglonID
            // 
            this.txtRenglonID.Location = new System.Drawing.Point(105, 57);
            this.txtRenglonID.MaxLength = 3;
            this.txtRenglonID.Name = "txtRenglonID";
            this.txtRenglonID.ReadOnly = true;
            this.txtRenglonID.Size = new System.Drawing.Size(146, 20);
            this.txtRenglonID.TabIndex = 5;
            this.txtRenglonID.Click += new System.EventHandler(this.txtRenglonID_Click);
            this.txtRenglonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRenglonID_KeyPress);
            this.txtRenglonID.Enter += new System.EventHandler(this.txtRenglonID_Enter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(825, 164);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(13, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 61);
            this.panel1.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Location = new System.Drawing.Point(3, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Cancelar:  Esc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Guardar:  Ctrl + G";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Location = new System.Drawing.Point(3, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Digitalizar:  Ctrl + S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "&6.- Pais:";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(330, 57);
            this.txtPais.MaxLength = 2;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(75, 20);
            this.txtPais.TabIndex = 11;
            this.txtPais.Click += new System.EventHandler(this.txtPais_Click);
            this.txtPais.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPais_KeyDown);
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPais_KeyPress);
            this.txtPais.Enter += new System.EventHandler(this.txtPais_Enter);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(516, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "&7.- Unidad de medida:";
            // 
            // txtUOM
            // 
            this.txtUOM.Location = new System.Drawing.Point(630, 6);
            this.txtUOM.MaxLength = 2;
            this.txtUOM.Name = "txtUOM";
            this.txtUOM.Size = new System.Drawing.Size(38, 20);
            this.txtUOM.TabIndex = 15;
            this.txtUOM.Click += new System.EventHandler(this.txtUOM_Click);
            this.txtUOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUOM_KeyPress);
            this.txtUOM.Enter += new System.EventHandler(this.txtUOM_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "&5.- Moneda:";
            // 
            // txtMoneda1
            // 
            this.txtMoneda1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMoneda1.Location = new System.Drawing.Point(365, 31);
            this.txtMoneda1.MaxLength = 3;
            this.txtMoneda1.Name = "txtMoneda1";
            this.txtMoneda1.Size = new System.Drawing.Size(56, 20);
            this.txtMoneda1.TabIndex = 9;
            this.txtMoneda1.Click += new System.EventHandler(this.txtMoneda1_Click);
            this.txtMoneda1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneda1_KeyPress);
            this.txtMoneda1.Enter += new System.EventHandler(this.txtMoneda1_Enter);
            // 
            // txtFechaRecibo
            // 
            this.txtFechaRecibo.Location = new System.Drawing.Point(105, 6);
            this.txtFechaRecibo.Name = "txtFechaRecibo";
            this.txtFechaRecibo.ReadOnly = true;
            this.txtFechaRecibo.Size = new System.Drawing.Size(146, 20);
            this.txtFechaRecibo.TabIndex = 1;
            this.txtFechaRecibo.Click += new System.EventHandler(this.txtFechaRecibo_Click);
            this.txtFechaRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaRecibo_KeyPress);
            this.txtFechaRecibo.Enter += new System.EventHandler(this.txtFechaRecibo_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Numero de PO:";
            // 
            // txtBuscarPO
            // 
            this.txtBuscarPO.Location = new System.Drawing.Point(95, 7);
            this.txtBuscarPO.MaxLength = 10;
            this.txtBuscarPO.Name = "txtBuscarPO";
            this.txtBuscarPO.Size = new System.Drawing.Size(98, 20);
            this.txtBuscarPO.TabIndex = 1;
            this.txtBuscarPO.TextChanged += new System.EventHandler(this.txtBuscarPO_TextChanged);
            this.txtBuscarPO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPO_KeyPress);
            this.txtBuscarPO.Enter += new System.EventHandler(this.txtBuscarPO_Enter);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(280, 7);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(27, 23);
            this.btnMas.TabIndex = 2;
            this.btnMas.TabStop = false;
            this.btnMas.Text = "...";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(139, 324);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(419, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(172, 348);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(386, 20);
            this.txtProveedor.TabIndex = 8;
            // 
            // txtProgramaID
            // 
            this.txtProgramaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramaID.Location = new System.Drawing.Point(646, 373);
            this.txtProgramaID.Name = "txtProgramaID";
            this.txtProgramaID.ReadOnly = true;
            this.txtProgramaID.Size = new System.Drawing.Size(180, 26);
            this.txtProgramaID.TabIndex = 16;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(571, 352);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "Moneda:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(686, 352);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Pais OC:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(199, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblQuimico
            // 
            this.lblQuimico.AutoSize = true;
            this.lblQuimico.BackColor = System.Drawing.Color.Peru;
            this.lblQuimico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuimico.Location = new System.Drawing.Point(903, 322);
            this.lblQuimico.Name = "lblQuimico";
            this.lblQuimico.Size = new System.Drawing.Size(97, 24);
            this.lblQuimico.TabIndex = 56;
            this.lblQuimico.Text = "QUÍMICO";
            this.lblQuimico.Visible = false;
            // 
            // lblSkip
            // 
            this.lblSkip.AutoSize = true;
            this.lblSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.lblSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkip.ForeColor = System.Drawing.Color.Black;
            this.lblSkip.Location = new System.Drawing.Point(899, 349);
            this.lblSkip.Name = "lblSkip";
            this.lblSkip.Size = new System.Drawing.Size(101, 24);
            this.lblSkip.TabIndex = 57;
            this.lblSkip.Text = "SKIP-LOT";
            this.lblSkip.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Numero Parte Quimico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(199, 394);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(98, 20);
            this.dtpHora.TabIndex = 59;
            this.dtpHora.Value = new System.DateTime(2012, 9, 22, 0, 0, 0, 0);
            this.dtpHora.Visible = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(95, 394);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(98, 20);
            this.dtpFecha.TabIndex = 60;
            this.dtpFecha.Value = new System.DateTime(2012, 9, 22, 0, 0, 0, 0);
            this.dtpFecha.Visible = false;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.Transparent;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCon.Location = new System.Drawing.Point(835, 369);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(172, 29);
            this.lblCon.TabIndex = 62;
            this.lblCon.Text = "Consignacion";
            this.lblCon.Visible = false;
            // 
            // lblITAR
            // 
            this.lblITAR.AutoSize = true;
            this.lblITAR.BackColor = System.Drawing.Color.Red;
            this.lblITAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITAR.ForeColor = System.Drawing.Color.White;
            this.lblITAR.Location = new System.Drawing.Point(845, 322);
            this.lblITAR.Name = "lblITAR";
            this.lblITAR.Size = new System.Drawing.Size(52, 24);
            this.lblITAR.TabIndex = 63;
            this.lblITAR.Text = "ITAR";
            this.lblITAR.Visible = false;
            // 
            // materialesOCTableAdapter
            // 
            this.materialesOCTableAdapter.ClearBeforeFill = true;
            // 
            // chkCerradas
            // 
            this.chkCerradas.AutoSize = true;
            this.chkCerradas.Checked = true;
            this.chkCerradas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCerradas.Location = new System.Drawing.Point(329, 13);
            this.chkCerradas.Name = "chkCerradas";
            this.chkCerradas.Size = new System.Drawing.Size(108, 17);
            this.chkCerradas.TabIndex = 64;
            this.chkCerradas.Text = "Partidas cerradas";
            this.chkCerradas.UseVisualStyleBackColor = true;
            this.chkCerradas.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(783, 325);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(43, 20);
            this.txtPrecio.TabIndex = 65;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(737, 328);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 66;
            this.label16.Text = "Precio:";
            // 
            // lblInbound
            // 
            this.lblInbound.BackColor = System.Drawing.SystemColors.Control;
            this.lblInbound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblInbound.ForeColor = System.Drawing.Color.DimGray;
            this.lblInbound.Location = new System.Drawing.Point(602, 5);
            this.lblInbound.Name = "lblInbound";
            this.lblInbound.Size = new System.Drawing.Size(398, 22);
            this.lblInbound.TabIndex = 67;
            this.lblInbound.Text = "INBOUND";
            this.lblInbound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReciboPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 632);
            this.Controls.Add(this.lblInbound);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.chkCerradas);
            this.Controls.Add(this.lblITAR);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSkip);
            this.Controls.Add(this.lblQuimico);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtProgramaID);
            this.Controls.Add(this.txtNumeroProveedor);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.txtBuscarPO);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtPaisOC);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgvPos);
            this.Controls.Add(this.lblCon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReciboPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibos de PO\'s";
            this.Load += new System.EventHandler(this.ReciboPO_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReciboPO_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quimicos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPos;
        private System.Windows.Forms.TextBox txtNumeroProveedor;
        private System.Windows.Forms.TextBox txtNumeroPo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroParte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadRecibida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFacturaProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaisOC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.TextBox txtPlanta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNoGuia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBultos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBuscarPO;
        private System.Windows.Forms.Button btnMas;
        private MaterialCore.DataSets.Quimicos quimicos;
        private System.Windows.Forms.BindingSource materialesOCBindingSource;
        private MaterialCore.DataSets.QuimicosTableAdapters.MaterialesOCTableAdapter materialesOCTableAdapter;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtProgramaID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtFechaRecibo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtUOM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoneda1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRenglonID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblQuimico;
        private System.Windows.Forms.Label lblSkip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pqOrdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblITAR;
        private System.Windows.Forms.TextBox txtPlantaOriginal;
        private System.Windows.Forms.CheckBox chkCerradas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox lblInbound;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Corto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn escaneado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn renglonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNumeroParte;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDrawingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadAbierta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadOriginalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSkipLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn gQuimico;
        private System.Windows.Forms.DataGridViewTextBoxColumn gITAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn gConsignacion;
        private System.Windows.Forms.CheckBox chkMaster;
    }
}