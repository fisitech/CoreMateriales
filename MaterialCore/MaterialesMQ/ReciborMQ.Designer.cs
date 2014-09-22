namespace MaterialCore.MaterialesMQ
{
    partial class ReciborMQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciborMQ));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCantPiezas = new System.Windows.Forms.TextBox();
            this.txtNoGuia = new System.Windows.Forms.TextBox();
            this.txtTransportista = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtRenglon = new System.Windows.Forms.TextBox();
            this.txtOCId = new System.Windows.Forms.TextBox();
            this.lblMQID = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogos = new MaterialCore.DataSets.Catalogos();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtPaisOrigen = new System.Windows.Forms.TextBox();
            this.txtPesoBruto = new System.Windows.Forms.TextBox();
            this.txtCantBultos = new System.Windows.Forms.TextBox();
            this.txtFacturaImportacion = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtTipoBulto = new System.Windows.Forms.TextBox();
            this.txtFechaRecibido = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.dgbMQ = new System.Windows.Forms.DataGridView();
            this.gConsecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNoParte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCantidadRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNoGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFacturaProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCantBultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPesoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFechaRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPesoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTipoBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gContenidoTipoBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enviadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gTransportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReciboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPqOrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPqRec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCantidadPriezas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preparado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialesMaquinariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maquinaria = new MaterialCore.DataSets.Maquinaria();
            this.materialesMaquinariaTableAdapter = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter();
            this.txtFechaImportacion = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new MaterialCore.DataSets.CatalogosTableAdapters.ClientesTableAdapter();
            this.txtNoParte = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.txtCantRecibida = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtContenidoTipoBulto = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPesoNeto = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopiarPartida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHijo = new System.Windows.Forms.Button();
            this.btnPegar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtBuscarPO = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtConsecutivo1 = new System.Windows.Forms.TextBox();
            this.txtConsecutivo2 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblGuardada = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tmlblGuardado = new System.Windows.Forms.Timer(this.components);
            this.chkProcesados = new System.Windows.Forms.CheckBox();
            this.mtxtFecha1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFecha2 = new System.Windows.Forms.MaskedTextBox();
            this.btnProcesados = new System.Windows.Forms.Button();
            this.lblfinicio = new System.Windows.Forms.Label();
            this.lblffinal = new System.Windows.Forms.Label();
            this.pnlFiltroPRocesados = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesMaquinariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFiltroPRocesados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 43);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(841, 258);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCantPiezas
            // 
            this.txtCantPiezas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCantPiezas.Location = new System.Drawing.Point(841, 140);
            this.txtCantPiezas.Name = "txtCantPiezas";
            this.txtCantPiezas.Size = new System.Drawing.Size(61, 20);
            this.txtCantPiezas.TabIndex = 49;
            this.txtCantPiezas.Visible = false;
            // 
            // txtNoGuia
            // 
            this.txtNoGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoGuia.Location = new System.Drawing.Point(455, 34);
            this.txtNoGuia.MaxLength = 75;
            this.txtNoGuia.Name = "txtNoGuia";
            this.txtNoGuia.Size = new System.Drawing.Size(166, 20);
            this.txtNoGuia.TabIndex = 20;
            this.txtNoGuia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoGuia_KeyDown);
            this.txtNoGuia.Leave += new System.EventHandler(this.txtNoGuia_Leave);
            // 
            // txtTransportista
            // 
            this.txtTransportista.Location = new System.Drawing.Point(138, 137);
            this.txtTransportista.Name = "txtTransportista";
            this.txtTransportista.Size = new System.Drawing.Size(212, 20);
            this.txtTransportista.TabIndex = 16;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(138, 59);
            this.txtProveedor.MaxLength = 5;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(79, 20);
            this.txtProveedor.TabIndex = 7;
            this.txtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProveedor_KeyDown);
            // 
            // txtRenglon
            // 
            this.txtRenglon.Location = new System.Drawing.Point(138, 34);
            this.txtRenglon.MaxLength = 3;
            this.txtRenglon.Name = "txtRenglon";
            this.txtRenglon.Size = new System.Drawing.Size(47, 20);
            this.txtRenglon.TabIndex = 3;
            this.txtRenglon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRenglon_KeyDown);
            // 
            // txtOCId
            // 
            this.txtOCId.Location = new System.Drawing.Point(138, 8);
            this.txtOCId.MaxLength = 6;
            this.txtOCId.Name = "txtOCId";
            this.txtOCId.Size = new System.Drawing.Size(128, 20);
            this.txtOCId.TabIndex = 1;
            this.txtOCId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOCId_KeyDown);
            // 
            // lblMQID
            // 
            this.lblMQID.AutoSize = true;
            this.lblMQID.Location = new System.Drawing.Point(67, 11);
            this.lblMQID.Name = "lblMQID";
            this.lblMQID.Size = new System.Drawing.Size(65, 13);
            this.lblMQID.TabIndex = 0;
            this.lblMQID.Text = "Numero PO:";
            this.lblMQID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCliente.DataSource = this.clientesBindingSource;
            this.cmbCliente.DisplayMember = "NombreCliente";
            this.cmbCliente.Enabled = false;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(439, -37);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 13;
            this.cmbCliente.ValueMember = "IdCliente";
            this.cmbCliente.Visible = false;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.catalogos;
            // 
            // catalogos
            // 
            this.catalogos.DataSetName = "Catalogos";
            this.catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, -36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "No. Proveedor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Transportista:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Guia:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(749, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cantidad Piezas:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Numero Linea:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unidad Medida:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Descripcion Num Parte:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(713, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Marca:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(708, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Modelo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(719, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Serie:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Pais:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(636, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Comentario:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(377, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Fecha Recibo:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(177, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Tipo de bulto:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(368, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Cantidad Bultos:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(691, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Peso Bruto:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(359, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Fatura Proveedor:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(798, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "Status:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label19.Visible = false;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadMedida.Location = new System.Drawing.Point(138, 111);
            this.txtUnidadMedida.MaxLength = 2;
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(61, 20);
            this.txtUnidadMedida.TabIndex = 14;
            this.txtUnidadMedida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnidadMedida_KeyDown);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(660, 56);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(196, 20);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(756, 134);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 40;
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarca_KeyDown);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(756, 82);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 36;
            this.txtModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtModelo_KeyDown);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(756, 108);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 38;
            this.txtSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie_KeyDown);
            // 
            // txtPaisOrigen
            // 
            this.txtPaisOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaisOrigen.Location = new System.Drawing.Point(455, 85);
            this.txtPaisOrigen.MaxLength = 2;
            this.txtPaisOrigen.Name = "txtPaisOrigen";
            this.txtPaisOrigen.Size = new System.Drawing.Size(57, 20);
            this.txtPaisOrigen.TabIndex = 24;
            this.txtPaisOrigen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaisOrigen_KeyDown);
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.Location = new System.Drawing.Point(756, 4);
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.Size = new System.Drawing.Size(100, 20);
            this.txtPesoBruto.TabIndex = 32;
            this.txtPesoBruto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesoBruto_KeyDown);
            // 
            // txtCantBultos
            // 
            this.txtCantBultos.Location = new System.Drawing.Point(455, 162);
            this.txtCantBultos.Name = "txtCantBultos";
            this.txtCantBultos.Size = new System.Drawing.Size(100, 20);
            this.txtCantBultos.TabIndex = 30;
            this.txtCantBultos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantBultos_KeyDown);
            // 
            // txtFacturaImportacion
            // 
            this.txtFacturaImportacion.Location = new System.Drawing.Point(455, 110);
            this.txtFacturaImportacion.Name = "txtFacturaImportacion";
            this.txtFacturaImportacion.Size = new System.Drawing.Size(112, 20);
            this.txtFacturaImportacion.TabIndex = 26;
            this.txtFacturaImportacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFacturaImportacion_KeyDown);
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStatus.Location = new System.Drawing.Point(841, 166);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 55;
            this.txtStatus.Visible = false;
            // 
            // txtTipoBulto
            // 
            this.txtTipoBulto.Location = new System.Drawing.Point(252, 85);
            this.txtTipoBulto.MaxLength = 2;
            this.txtTipoBulto.Name = "txtTipoBulto";
            this.txtTipoBulto.Size = new System.Drawing.Size(29, 20);
            this.txtTipoBulto.TabIndex = 12;
            this.txtTipoBulto.Text = "BU";
            // 
            // txtFechaRecibido
            // 
            this.txtFechaRecibido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFechaRecibido.Location = new System.Drawing.Point(455, 136);
            this.txtFechaRecibido.Name = "txtFechaRecibido";
            this.txtFechaRecibido.ReadOnly = true;
            this.txtFechaRecibido.Size = new System.Drawing.Size(144, 20);
            this.txtFechaRecibido.TabIndex = 28;
            this.txtFechaRecibido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaRecibido_KeyDown);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(705, 160);
            this.txtComentario.MaxLength = 200;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(151, 20);
            this.txtComentario.TabIndex = 42;
            this.txtComentario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            this.txtComentario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComentario_KeyPress);
            // 
            // dgbMQ
            // 
            this.dgbMQ.AllowUserToAddRows = false;
            this.dgbMQ.AllowUserToDeleteRows = false;
            this.dgbMQ.AllowUserToResizeRows = false;
            this.dgbMQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbMQ.AutoGenerateColumns = false;
            this.dgbMQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbMQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gConsecutivo,
            this.gPO,
            this.gLinea,
            this.gIdentificador,
            this.gNoParte,
            this.gCantidadRecibida,
            this.gNoGuia,
            this.gProveedor,
            this.gFacturaProveedor,
            this.gMarca,
            this.gModelo,
            this.gMoneda,
            this.gSerie,
            this.gDescripcion,
            this.gPais,
            this.gCantBultos,
            this.gComentario,
            this.gClienteId,
            this.gPesoNeto,
            this.gFechaRecibo,
            this.gPesoBruto,
            this.gTipoBulto,
            this.gContenidoTipoBulto,
            this.enviadoDataGridViewCheckBoxColumn,
            this.gTransportista,
            this.fechaReciboDataGridViewTextBoxColumn,
            this.gPqOrd,
            this.gPqRec,
            this.gNombreProveedor,
            this.gid,
            this.gUnidadMedida,
            this.gCantidadPriezas,
            this.Preparado});
            this.dgbMQ.DataSource = this.materialesMaquinariaBindingSource;
            this.dgbMQ.Location = new System.Drawing.Point(4, 40);
            this.dgbMQ.MultiSelect = false;
            this.dgbMQ.Name = "dgbMQ";
            this.dgbMQ.ReadOnly = true;
            this.dgbMQ.RowHeadersVisible = false;
            this.dgbMQ.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dgbMQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbMQ.Size = new System.Drawing.Size(970, 329);
            this.dgbMQ.TabIndex = 60;
            this.dgbMQ.Sorted += new System.EventHandler(this.dgbMQ_Sorted);
            this.dgbMQ.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbMQ_CellContentClick);
            this.dgbMQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgbMQ_KeyDown);
            this.dgbMQ.SelectionChanged += new System.EventHandler(this.dgbMQ_SelectionChanged);
            // 
            // gConsecutivo
            // 
            this.gConsecutivo.DataPropertyName = "Consecutivo";
            this.gConsecutivo.FillWeight = 21F;
            this.gConsecutivo.HeaderText = "Consecutivo";
            this.gConsecutivo.Name = "gConsecutivo";
            this.gConsecutivo.ReadOnly = true;
            this.gConsecutivo.Width = 40;
            // 
            // gPO
            // 
            this.gPO.DataPropertyName = "MaterialesOCId";
            this.gPO.FillWeight = 49F;
            this.gPO.HeaderText = "PO";
            this.gPO.Name = "gPO";
            this.gPO.ReadOnly = true;
            this.gPO.Width = 49;
            // 
            // gLinea
            // 
            this.gLinea.DataPropertyName = "RenglonId";
            this.gLinea.FillWeight = 21F;
            this.gLinea.HeaderText = "Linea";
            this.gLinea.Name = "gLinea";
            this.gLinea.ReadOnly = true;
            this.gLinea.Width = 37;
            // 
            // gIdentificador
            // 
            this.gIdentificador.DataPropertyName = "Identificador";
            this.gIdentificador.FillWeight = 21F;
            this.gIdentificador.HeaderText = "Hijo";
            this.gIdentificador.Name = "gIdentificador";
            this.gIdentificador.ReadOnly = true;
            this.gIdentificador.Width = 28;
            // 
            // gNoParte
            // 
            this.gNoParte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gNoParte.DataPropertyName = "NumeroParte";
            this.gNoParte.HeaderText = "No. Parte";
            this.gNoParte.Name = "gNoParte";
            this.gNoParte.ReadOnly = true;
            this.gNoParte.Width = 71;
            // 
            // gCantidadRecibida
            // 
            this.gCantidadRecibida.DataPropertyName = "CantidadRecibida";
            dataGridViewCellStyle1.Format = "N2";
            this.gCantidadRecibida.DefaultCellStyle = dataGridViewCellStyle1;
            this.gCantidadRecibida.FillWeight = 21F;
            this.gCantidadRecibida.HeaderText = "Cant. Recibida";
            this.gCantidadRecibida.Name = "gCantidadRecibida";
            this.gCantidadRecibida.ReadOnly = true;
            this.gCantidadRecibida.Width = 53;
            // 
            // gNoGuia
            // 
            this.gNoGuia.DataPropertyName = "NumeroGuia";
            this.gNoGuia.HeaderText = "NumeroGuia";
            this.gNoGuia.Name = "gNoGuia";
            this.gNoGuia.ReadOnly = true;
            // 
            // gProveedor
            // 
            this.gProveedor.DataPropertyName = "Proveedor";
            this.gProveedor.HeaderText = "Proveedor";
            this.gProveedor.Name = "gProveedor";
            this.gProveedor.ReadOnly = true;
            this.gProveedor.Width = 60;
            // 
            // gFacturaProveedor
            // 
            this.gFacturaProveedor.DataPropertyName = "FacturaProveedor";
            this.gFacturaProveedor.FillWeight = 70F;
            this.gFacturaProveedor.HeaderText = "Factura Proveedor";
            this.gFacturaProveedor.Name = "gFacturaProveedor";
            this.gFacturaProveedor.ReadOnly = true;
            this.gFacturaProveedor.Width = 60;
            // 
            // gMarca
            // 
            this.gMarca.DataPropertyName = "Marca";
            this.gMarca.HeaderText = "Marca";
            this.gMarca.Name = "gMarca";
            this.gMarca.ReadOnly = true;
            // 
            // gModelo
            // 
            this.gModelo.DataPropertyName = "Modelo";
            this.gModelo.HeaderText = "Modelo";
            this.gModelo.Name = "gModelo";
            this.gModelo.ReadOnly = true;
            // 
            // gMoneda
            // 
            this.gMoneda.DataPropertyName = "Moneda";
            this.gMoneda.HeaderText = "Moneda";
            this.gMoneda.Name = "gMoneda";
            this.gMoneda.ReadOnly = true;
            this.gMoneda.Visible = false;
            // 
            // gSerie
            // 
            this.gSerie.DataPropertyName = "Serie";
            this.gSerie.HeaderText = "Serie";
            this.gSerie.Name = "gSerie";
            this.gSerie.ReadOnly = true;
            // 
            // gDescripcion
            // 
            this.gDescripcion.DataPropertyName = "Descripcion";
            this.gDescripcion.HeaderText = "Descripcion";
            this.gDescripcion.Name = "gDescripcion";
            this.gDescripcion.ReadOnly = true;
            // 
            // gPais
            // 
            this.gPais.DataPropertyName = "PaisOrigen";
            this.gPais.HeaderText = "Pais";
            this.gPais.Name = "gPais";
            this.gPais.ReadOnly = true;
            this.gPais.Width = 40;
            // 
            // gCantBultos
            // 
            this.gCantBultos.DataPropertyName = "CantidadBultos";
            dataGridViewCellStyle2.Format = "N0";
            this.gCantBultos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gCantBultos.FillWeight = 21F;
            this.gCantBultos.HeaderText = "Bultos";
            this.gCantBultos.Name = "gCantBultos";
            this.gCantBultos.ReadOnly = true;
            this.gCantBultos.Width = 28;
            // 
            // gComentario
            // 
            this.gComentario.DataPropertyName = "Comentarios";
            this.gComentario.HeaderText = "Comentarios";
            this.gComentario.Name = "gComentario";
            this.gComentario.ReadOnly = true;
            // 
            // gClienteId
            // 
            this.gClienteId.DataPropertyName = "ClienteId";
            this.gClienteId.HeaderText = "ClienteId";
            this.gClienteId.Name = "gClienteId";
            this.gClienteId.ReadOnly = true;
            this.gClienteId.Visible = false;
            // 
            // gPesoNeto
            // 
            this.gPesoNeto.DataPropertyName = "PesoNeto";
            this.gPesoNeto.HeaderText = "PesoNeto";
            this.gPesoNeto.Name = "gPesoNeto";
            this.gPesoNeto.ReadOnly = true;
            this.gPesoNeto.Visible = false;
            // 
            // gFechaRecibo
            // 
            this.gFechaRecibo.DataPropertyName = "FechaRecibo";
            this.gFechaRecibo.HeaderText = "FechaRecibo";
            this.gFechaRecibo.Name = "gFechaRecibo";
            this.gFechaRecibo.ReadOnly = true;
            // 
            // gPesoBruto
            // 
            this.gPesoBruto.DataPropertyName = "PesoBruto";
            this.gPesoBruto.HeaderText = "PesoBruto";
            this.gPesoBruto.Name = "gPesoBruto";
            this.gPesoBruto.ReadOnly = true;
            this.gPesoBruto.Visible = false;
            // 
            // gTipoBulto
            // 
            this.gTipoBulto.DataPropertyName = "TipoBulto";
            this.gTipoBulto.HeaderText = "TipoBulto";
            this.gTipoBulto.Name = "gTipoBulto";
            this.gTipoBulto.ReadOnly = true;
            this.gTipoBulto.Visible = false;
            // 
            // gContenidoTipoBulto
            // 
            this.gContenidoTipoBulto.DataPropertyName = "ContenidoTipoBulto";
            this.gContenidoTipoBulto.HeaderText = "ContenidoTipoBulto";
            this.gContenidoTipoBulto.Name = "gContenidoTipoBulto";
            this.gContenidoTipoBulto.ReadOnly = true;
            this.gContenidoTipoBulto.Visible = false;
            // 
            // enviadoDataGridViewCheckBoxColumn
            // 
            this.enviadoDataGridViewCheckBoxColumn.DataPropertyName = "enviado";
            this.enviadoDataGridViewCheckBoxColumn.HeaderText = "enviado";
            this.enviadoDataGridViewCheckBoxColumn.Name = "enviadoDataGridViewCheckBoxColumn";
            this.enviadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.enviadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // gTransportista
            // 
            this.gTransportista.DataPropertyName = "Transportista";
            this.gTransportista.HeaderText = "Transportista";
            this.gTransportista.Name = "gTransportista";
            this.gTransportista.ReadOnly = true;
            // 
            // fechaReciboDataGridViewTextBoxColumn
            // 
            this.fechaReciboDataGridViewTextBoxColumn.DataPropertyName = "FechaRecibo";
            this.fechaReciboDataGridViewTextBoxColumn.HeaderText = "FechaRecibo";
            this.fechaReciboDataGridViewTextBoxColumn.Name = "fechaReciboDataGridViewTextBoxColumn";
            this.fechaReciboDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaReciboDataGridViewTextBoxColumn.Visible = false;
            // 
            // gPqOrd
            // 
            this.gPqOrd.DataPropertyName = "PqOrd";
            this.gPqOrd.HeaderText = "PqOrd";
            this.gPqOrd.Name = "gPqOrd";
            this.gPqOrd.ReadOnly = true;
            // 
            // gPqRec
            // 
            this.gPqRec.DataPropertyName = "PqRec";
            this.gPqRec.HeaderText = "PqRec";
            this.gPqRec.Name = "gPqRec";
            this.gPqRec.ReadOnly = true;
            // 
            // gNombreProveedor
            // 
            this.gNombreProveedor.DataPropertyName = "NombreProveedor";
            this.gNombreProveedor.HeaderText = "NombreProveedor";
            this.gNombreProveedor.Name = "gNombreProveedor";
            this.gNombreProveedor.ReadOnly = true;
            // 
            // gid
            // 
            this.gid.DataPropertyName = "Id";
            this.gid.HeaderText = "Id";
            this.gid.Name = "gid";
            this.gid.ReadOnly = true;
            this.gid.Visible = false;
            // 
            // gUnidadMedida
            // 
            this.gUnidadMedida.DataPropertyName = "UnidadMedida";
            this.gUnidadMedida.HeaderText = "UnidadMedida";
            this.gUnidadMedida.Name = "gUnidadMedida";
            this.gUnidadMedida.ReadOnly = true;
            this.gUnidadMedida.Visible = false;
            // 
            // gCantidadPriezas
            // 
            this.gCantidadPriezas.DataPropertyName = "CantidadPiezas";
            this.gCantidadPriezas.HeaderText = "CantidadPiezas";
            this.gCantidadPriezas.Name = "gCantidadPriezas";
            this.gCantidadPriezas.ReadOnly = true;
            this.gCantidadPriezas.Visible = false;
            // 
            // Preparado
            // 
            this.Preparado.DataPropertyName = "Preparado";
            this.Preparado.HeaderText = "Preparado";
            this.Preparado.Name = "Preparado";
            this.Preparado.ReadOnly = true;
            this.Preparado.Visible = false;
            // 
            // materialesMaquinariaBindingSource
            // 
            this.materialesMaquinariaBindingSource.DataMember = "MaterialesMaquinaria";
            this.materialesMaquinariaBindingSource.DataSource = this.maquinaria;
            // 
            // maquinaria
            // 
            this.maquinaria.DataSetName = "Maquinaria";
            this.maquinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialesMaquinariaTableAdapter
            // 
            this.materialesMaquinariaTableAdapter.ClearBeforeFill = true;
            // 
            // txtFechaImportacion
            // 
            this.txtFechaImportacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFechaImportacion.Location = new System.Drawing.Point(841, 192);
            this.txtFechaImportacion.Name = "txtFechaImportacion";
            this.txtFechaImportacion.Size = new System.Drawing.Size(100, 20);
            this.txtFechaImportacion.TabIndex = 33;
            this.txtFechaImportacion.Visible = false;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(706, 195);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "&E.- Fecha de Importacion:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label20.Visible = false;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // txtNoParte
            // 
            this.txtNoParte.Location = new System.Drawing.Point(756, 30);
            this.txtNoParte.Name = "txtNoParte";
            this.txtNoParte.Size = new System.Drawing.Size(100, 20);
            this.txtNoParte.TabIndex = 34;
            this.txtNoParte.TextChanged += new System.EventHandler(this.txtNoParte_TextChanged);
            this.txtNoParte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoParte_KeyDown);
            this.txtNoParte.Leave += new System.EventHandler(this.txtNoParte_Leave);
            this.txtNoParte.Enter += new System.EventHandler(this.txtNoParte_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(675, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Numero Parte:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.Location = new System.Drawing.Point(841, 229);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(86, 23);
            this.btnPDF.TabIndex = 58;
            this.btnPDF.Text = "Crear PDF MeQ";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Visible = false;
            // 
            // txtCantRecibida
            // 
            this.txtCantRecibida.Location = new System.Drawing.Point(455, 60);
            this.txtCantRecibida.Name = "txtCantRecibida";
            this.txtCantRecibida.Size = new System.Drawing.Size(57, 20);
            this.txtCantRecibida.TabIndex = 22;
            this.txtCantRecibida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantRecibida_KeyDown);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(372, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "Cant. Recibida:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMoneda
            // 
            this.txtMoneda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMoneda.Location = new System.Drawing.Point(841, 88);
            this.txtMoneda.MaxLength = 3;
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(52, 20);
            this.txtMoneda.TabIndex = 37;
            this.txtMoneda.Visible = false;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(778, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 36;
            this.label25.Text = "&M.-Moneda:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label25.Visible = false;
            // 
            // txtContenidoTipoBulto
            // 
            this.txtContenidoTipoBulto.Location = new System.Drawing.Point(138, 85);
            this.txtContenidoTipoBulto.MaxLength = 2;
            this.txtContenidoTipoBulto.Name = "txtContenidoTipoBulto";
            this.txtContenidoTipoBulto.Size = new System.Drawing.Size(29, 20);
            this.txtContenidoTipoBulto.TabIndex = 10;
            this.txtContenidoTipoBulto.Text = "BU";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 85);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 13);
            this.label26.TabIndex = 9;
            this.label26.Text = "Contenido tipo de bulto:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPesoNeto
            // 
            this.txtPesoNeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPesoNeto.Location = new System.Drawing.Point(841, 114);
            this.txtPesoNeto.Name = "txtPesoNeto";
            this.txtPesoNeto.Size = new System.Drawing.Size(100, 20);
            this.txtPesoNeto.TabIndex = 45;
            this.txtPesoNeto.Visible = false;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(775, 121);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 13);
            this.label27.TabIndex = 44;
            this.label27.Text = "Peso Neto:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label27.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCopiarPartida);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnHijo);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Location = new System.Drawing.Point(862, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 174);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros";
            // 
            // btnCopiarPartida
            // 
            this.btnCopiarPartida.Location = new System.Drawing.Point(6, 93);
            this.btnCopiarPartida.Name = "btnCopiarPartida";
            this.btnCopiarPartida.Size = new System.Drawing.Size(75, 36);
            this.btnCopiarPartida.TabIndex = 70;
            this.btnCopiarPartida.Text = "Copiar Partida";
            this.btnCopiarPartida.UseVisualStyleBackColor = true;
            this.btnCopiarPartida.Click += new System.EventHandler(this.btnCopiarPartida_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 69;
            this.button1.Text = "Crear Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHijo
            // 
            this.btnHijo.Location = new System.Drawing.Point(6, 68);
            this.btnHijo.Name = "btnHijo";
            this.btnHijo.Size = new System.Drawing.Size(75, 23);
            this.btnHijo.TabIndex = 3;
            this.btnHijo.Text = "Hijo";
            this.btnHijo.UseVisualStyleBackColor = true;
            this.btnHijo.Click += new System.EventHandler(this.btnHijo_Click);
            // 
            // btnPegar
            // 
            this.btnPegar.Location = new System.Drawing.Point(752, 287);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(75, 23);
            this.btnPegar.TabIndex = 67;
            this.btnPegar.Text = "Pegar info partida";
            this.btnPegar.UseVisualStyleBackColor = true;
            this.btnPegar.Visible = false;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(833, 287);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 66;
            this.btnCopiar.Text = "Copiar info partida";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Visible = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtBuscarPO
            // 
            this.txtBuscarPO.Location = new System.Drawing.Point(32, 15);
            this.txtBuscarPO.MaxLength = 6;
            this.txtBuscarPO.Name = "txtBuscarPO";
            this.txtBuscarPO.Size = new System.Drawing.Size(48, 20);
            this.txtBuscarPO.TabIndex = 1;
            this.txtBuscarPO.TextChanged += new System.EventHandler(this.txtBuscarPO_TextChanged);
            this.txtBuscarPO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarPO_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(91, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(52, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Añadir";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "PO:";
            // 
            // txtConsecutivo1
            // 
            this.txtConsecutivo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsecutivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo1.Location = new System.Drawing.Point(866, 5);
            this.txtConsecutivo1.Name = "txtConsecutivo1";
            this.txtConsecutivo1.Size = new System.Drawing.Size(108, 29);
            this.txtConsecutivo1.TabIndex = 61;
            this.txtConsecutivo1.TextChanged += new System.EventHandler(this.txtConsecutivo1_TextChanged);
            this.txtConsecutivo1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsecutivo1_KeyDown);
            this.txtConsecutivo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsecutivo1_KeyPress);
            // 
            // txtConsecutivo2
            // 
            this.txtConsecutivo2.Location = new System.Drawing.Point(455, 8);
            this.txtConsecutivo2.Name = "txtConsecutivo2";
            this.txtConsecutivo2.Size = new System.Drawing.Size(57, 20);
            this.txtConsecutivo2.TabIndex = 18;
            this.txtConsecutivo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsecutivo2_KeyDown);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(382, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "Consecutivo: ";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(788, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 13);
            this.label28.TabIndex = 64;
            this.label28.Text = "Consecutivo: ";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(223, 59);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(127, 20);
            this.txtNombreProveedor.TabIndex = 8;
            this.txtNombreProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProveedor_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.txtNoGuia);
            this.panel1.Controls.Add(this.lblGuardada);
            this.panel1.Controls.Add(this.txtTransportista);
            this.panel1.Controls.Add(this.txtProveedor);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txtNombreProveedor);
            this.panel1.Controls.Add(this.txtConsecutivo2);
            this.panel1.Controls.Add(this.txtRenglon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtOCId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblMQID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtPesoBruto);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtCantBultos);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPaisOrigen);
            this.panel1.Controls.Add(this.txtFechaRecibido);
            this.panel1.Controls.Add(this.txtContenidoTipoBulto);
            this.panel1.Controls.Add(this.txtComentario);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtSerie);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.txtNoParte);
            this.panel1.Controls.Add(this.txtFacturaImportacion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCantRecibida);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtUnidadMedida);
            this.panel1.Controls.Add(this.txtTipoBulto);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(4, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 241);
            this.panel1.TabIndex = 0;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label32.Location = new System.Drawing.Point(3, 190);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(122, 16);
            this.label32.TabIndex = 63;
            this.label32.Text = "Guardar: Ctrl + G";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label31.Location = new System.Drawing.Point(3, 222);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(136, 16);
            this.label31.TabIndex = 62;
            this.label31.Text = "Crear Hijo: Ctrl + H";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label29.Location = new System.Drawing.Point(3, 206);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(166, 16);
            this.label29.TabIndex = 60;
            this.label29.Text = "Copiar Partida: Ctrl + D";
            // 
            // lblGuardada
            // 
            this.lblGuardada.AutoSize = true;
            this.lblGuardada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardada.ForeColor = System.Drawing.Color.Green;
            this.lblGuardada.Location = new System.Drawing.Point(724, 207);
            this.lblGuardada.Name = "lblGuardada";
            this.lblGuardada.Size = new System.Drawing.Size(243, 31);
            this.lblGuardada.TabIndex = 59;
            this.lblGuardada.Text = "Partida Guardada";
            this.lblGuardada.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label30.Location = new System.Drawing.Point(699, 261);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(136, 16);
            this.label30.TabIndex = 61;
            this.label30.Text = "Pegar info: Ctrl + P";
            this.label30.Visible = false;
            // 
            // tmlblGuardado
            // 
            this.tmlblGuardado.Interval = 1500;
            this.tmlblGuardado.Tick += new System.EventHandler(this.tmlblGuardado_Tick);
            // 
            // chkProcesados
            // 
            this.chkProcesados.AutoSize = true;
            this.chkProcesados.Location = new System.Drawing.Point(234, 13);
            this.chkProcesados.Name = "chkProcesados";
            this.chkProcesados.Size = new System.Drawing.Size(120, 17);
            this.chkProcesados.TabIndex = 69;
            this.chkProcesados.Text = "Mostrar Procesados";
            this.chkProcesados.UseVisualStyleBackColor = true;
            this.chkProcesados.CheckedChanged += new System.EventHandler(this.chkProcesados_CheckedChanged);
            // 
            // mtxtFecha1
            // 
            this.mtxtFecha1.Location = new System.Drawing.Point(5, 16);
            this.mtxtFecha1.Mask = "00/00/0000";
            this.mtxtFecha1.Name = "mtxtFecha1";
            this.mtxtFecha1.Size = new System.Drawing.Size(67, 20);
            this.mtxtFecha1.TabIndex = 70;
            this.mtxtFecha1.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtFecha2
            // 
            this.mtxtFecha2.Location = new System.Drawing.Point(78, 16);
            this.mtxtFecha2.Mask = "00/00/0000";
            this.mtxtFecha2.Name = "mtxtFecha2";
            this.mtxtFecha2.Size = new System.Drawing.Size(67, 20);
            this.mtxtFecha2.TabIndex = 71;
            this.mtxtFecha2.ValidatingType = typeof(System.DateTime);
            // 
            // btnProcesados
            // 
            this.btnProcesados.Location = new System.Drawing.Point(151, 14);
            this.btnProcesados.Name = "btnProcesados";
            this.btnProcesados.Size = new System.Drawing.Size(75, 23);
            this.btnProcesados.TabIndex = 72;
            this.btnProcesados.Text = "Mostrar";
            this.btnProcesados.UseVisualStyleBackColor = true;
            this.btnProcesados.Click += new System.EventHandler(this.btnProcesados_Click);
            // 
            // lblfinicio
            // 
            this.lblfinicio.AutoSize = true;
            this.lblfinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinicio.Location = new System.Drawing.Point(2, 2);
            this.lblfinicio.Name = "lblfinicio";
            this.lblfinicio.Size = new System.Drawing.Size(59, 12);
            this.lblfinicio.TabIndex = 73;
            this.lblfinicio.Text = "Fecha inicial:";
            // 
            // lblffinal
            // 
            this.lblffinal.AutoSize = true;
            this.lblffinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblffinal.Location = new System.Drawing.Point(76, 2);
            this.lblffinal.Name = "lblffinal";
            this.lblffinal.Size = new System.Drawing.Size(53, 12);
            this.lblffinal.TabIndex = 74;
            this.lblffinal.Text = "Fecha final:";
            // 
            // pnlFiltroPRocesados
            // 
            this.pnlFiltroPRocesados.Controls.Add(this.btnProcesados);
            this.pnlFiltroPRocesados.Controls.Add(this.lblffinal);
            this.pnlFiltroPRocesados.Controls.Add(this.mtxtFecha1);
            this.pnlFiltroPRocesados.Controls.Add(this.lblfinicio);
            this.pnlFiltroPRocesados.Controls.Add(this.mtxtFecha2);
            this.pnlFiltroPRocesados.Location = new System.Drawing.Point(360, -3);
            this.pnlFiltroPRocesados.Name = "pnlFiltroPRocesados";
            this.pnlFiltroPRocesados.Size = new System.Drawing.Size(232, 42);
            this.pnlFiltroPRocesados.TabIndex = 75;
            this.pnlFiltroPRocesados.Visible = false;
            // 
            // ReciborMQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 617);
            this.Controls.Add(this.pnlFiltroPRocesados);
            this.Controls.Add(this.chkProcesados);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.btnPegar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtConsecutivo1);
            this.Controls.Add(this.txtPesoNeto);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtFechaImportacion);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantPiezas);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarPO);
            this.Controls.Add(this.dgbMQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReciborMQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar maquinaria y equipo";
            this.Load += new System.EventHandler(this.ReciborMQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesMaquinariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFiltroPRocesados.ResumeLayout(false);
            this.pnlFiltroPRocesados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCantPiezas;
        private System.Windows.Forms.TextBox txtNoGuia;
        private System.Windows.Forms.TextBox txtTransportista;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtRenglon;
        private System.Windows.Forms.TextBox txtOCId;
        private System.Windows.Forms.Label lblMQID;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtPaisOrigen;
        private System.Windows.Forms.TextBox txtPesoBruto;
        private System.Windows.Forms.TextBox txtCantBultos;
        private System.Windows.Forms.TextBox txtFacturaImportacion;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtTipoBulto;
        private System.Windows.Forms.TextBox txtFechaRecibido;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.DataGridView dgbMQ;
        private MaterialCore.DataSets.Maquinaria maquinaria;
        private System.Windows.Forms.BindingSource materialesMaquinariaBindingSource;
        private MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter materialesMaquinariaTableAdapter;
        private System.Windows.Forms.TextBox txtFechaImportacion;
        private System.Windows.Forms.Label label20;
        private MaterialCore.DataSets.Catalogos catalogos;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private MaterialCore.DataSets.CatalogosTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.TextBox txtNoParte;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.TextBox txtCantRecibida;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtContenidoTipoBulto;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtPesoNeto;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarPO;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnHijo;
        private System.Windows.Forms.TextBox txtConsecutivo1;
        private System.Windows.Forms.TextBox txtConsecutivo2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFacturaImp;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaImportacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnPegar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGuardada;
        private System.Windows.Forms.Timer tmlblGuardado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox chkProcesados;
        private System.Windows.Forms.MaskedTextBox mtxtFecha1;
        private System.Windows.Forms.MaskedTextBox mtxtFecha2;
        private System.Windows.Forms.Button btnProcesados;
        private System.Windows.Forms.Label lblfinicio;
        private System.Windows.Forms.Label lblffinal;
        private System.Windows.Forms.Panel pnlFiltroPRocesados;
        private System.Windows.Forms.Button btnCopiarPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn gConsecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNoParte;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCantidadRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNoGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFacturaProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn gModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCantBultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn gComentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn gClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPesoNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFechaRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPesoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTipoBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gContenidoTipoBulto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enviadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReciboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPqOrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPqRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCantidadPriezas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Preparado;
    }
}