namespace MaterialCore.Incidencias
{
    partial class MaterialDetenido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialDetenido));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoGuia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoPackingList = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.txtNoParte = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaResuelto = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtResolvio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkResuelto = new System.Windows.Forms.CheckBox();
            this.pnlResuelto = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPackingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noGuiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noParteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bResueltoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaResolvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesDetenidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidencias = new MaterialCore.DataSets.Incidencias();
            this.materialesDetenidoTableAdapter = new MaterialCore.DataSets.IncidenciasTableAdapters.MaterialesDetenidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.pnlResuelto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDetenidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(105, 16);
            this.txtPO.MaxLength = 6;
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(77, 20);
            this.txtPO.TabIndex = 1;
            this.txtPO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPO_KeyPress);
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(105, 42);
            this.txtLinea.MaxLength = 3;
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(77, 20);
            this.txtLinea.TabIndex = 2;
            this.txtLinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLinea_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Linea:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNoGuia
            // 
            this.txtNoGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoGuia.Location = new System.Drawing.Point(259, 42);
            this.txtNoGuia.MaxLength = 75;
            this.txtNoGuia.Name = "txtNoGuia";
            this.txtNoGuia.Size = new System.Drawing.Size(200, 20);
            this.txtNoGuia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NoGuia:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(823, 68);
            this.txtComentario.MaxLength = 250;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(182, 50);
            this.txtComentario.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comentario:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.AllowUserToAddRows = false;
            this.dgvIncidencias.AllowUserToDeleteRows = false;
            this.dgvIncidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncidencias.AutoGenerateColumns = false;
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pODataGridViewTextBoxColumn,
            this.lineaDataGridViewTextBoxColumn,
            this.noPackingDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.noGuiaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.unidadMedidaDataGridViewTextBoxColumn,
            this.noParteDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.razonDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.bResueltoDataGridViewCheckBoxColumn,
            this.fechaResolvioDataGridViewTextBoxColumn,
            this.resolvioDataGridViewTextBoxColumn});
            this.dgvIncidencias.DataSource = this.materialesDetenidoBindingSource;
            this.dgvIncidencias.Location = new System.Drawing.Point(13, 201);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.RowHeadersWidth = 10;
            this.dgvIncidencias.Size = new System.Drawing.Size(988, 417);
            this.dgvIncidencias.TabIndex = 14;
            this.dgvIncidencias.TabStop = false;
            this.dgvIncidencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncidencias_CellDoubleClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(798, 159);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(65, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(864, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "*Incidencias del ultimo mes.";
            // 
            // txtNoPackingList
            // 
            this.txtNoPackingList.Location = new System.Drawing.Point(105, 68);
            this.txtNoPackingList.Name = "txtNoPackingList";
            this.txtNoPackingList.Size = new System.Drawing.Size(100, 20);
            this.txtNoPackingList.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(259, 69);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(53, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(368, 69);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(53, 20);
            this.txtUM.TabIndex = 7;
            // 
            // txtNoParte
            // 
            this.txtNoParte.Location = new System.Drawing.Point(527, 16);
            this.txtNoParte.Name = "txtNoParte";
            this.txtNoParte.Size = new System.Drawing.Size(162, 20);
            this.txtNoParte.TabIndex = 8;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(527, 43);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(201, 20);
            this.txtNombreProveedor.TabIndex = 9;
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(823, 16);
            this.txtRazon.Multiline = true;
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(182, 46);
            this.txtRazon.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(260, 16);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // dtpFechaResuelto
            // 
            this.dtpFechaResuelto.Location = new System.Drawing.Point(6, 21);
            this.dtpFechaResuelto.Name = "dtpFechaResuelto";
            this.dtpFechaResuelto.Size = new System.Drawing.Size(182, 20);
            this.dtpFechaResuelto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Fecha:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "No. Packing List:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Cant:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "No. Parte:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "U/M:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(767, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Razon:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(467, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 26);
            this.label14.TabIndex = 34;
            this.label14.Text = "Nombre\r\nProveedor:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Fecha que se Resolvio:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResolvio
            // 
            this.txtResolvio.Location = new System.Drawing.Point(245, 21);
            this.txtResolvio.Name = "txtResolvio";
            this.txtResolvio.Size = new System.Drawing.Size(140, 20);
            this.txtResolvio.TabIndex = 2;
            this.txtResolvio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResolvio_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(194, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Resolvio:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkResuelto
            // 
            this.chkResuelto.AutoSize = true;
            this.chkResuelto.Location = new System.Drawing.Point(470, 76);
            this.chkResuelto.Name = "chkResuelto";
            this.chkResuelto.Size = new System.Drawing.Size(68, 17);
            this.chkResuelto.TabIndex = 12;
            this.chkResuelto.Text = "Resuelto";
            this.chkResuelto.UseVisualStyleBackColor = true;
            this.chkResuelto.CheckedChanged += new System.EventHandler(this.cheResuelto_CheckedChanged);
            // 
            // pnlResuelto
            // 
            this.pnlResuelto.Controls.Add(this.label15);
            this.pnlResuelto.Controls.Add(this.label16);
            this.pnlResuelto.Controls.Add(this.txtResolvio);
            this.pnlResuelto.Controls.Add(this.dtpFechaResuelto);
            this.pnlResuelto.Location = new System.Drawing.Point(423, 101);
            this.pnlResuelto.Name = "pnlResuelto";
            this.pnlResuelto.Size = new System.Drawing.Size(394, 53);
            this.pnlResuelto.TabIndex = 13;
            this.pnlResuelto.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(869, 159);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 23);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(940, 159);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(65, 23);
            this.btnActualizar.TabIndex = 37;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "*Dar doble clic sobre el campo a Actualizar";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(63, 9);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 39;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(63, 35);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Location = new System.Drawing.Point(43, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 58);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar de:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(269, 19);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 41;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // pODataGridViewTextBoxColumn
            // 
            this.pODataGridViewTextBoxColumn.DataPropertyName = "PO";
            this.pODataGridViewTextBoxColumn.HeaderText = "PO";
            this.pODataGridViewTextBoxColumn.Name = "pODataGridViewTextBoxColumn";
            this.pODataGridViewTextBoxColumn.ReadOnly = true;
            this.pODataGridViewTextBoxColumn.Width = 60;
            // 
            // lineaDataGridViewTextBoxColumn
            // 
            this.lineaDataGridViewTextBoxColumn.DataPropertyName = "Linea";
            this.lineaDataGridViewTextBoxColumn.HeaderText = "Linea";
            this.lineaDataGridViewTextBoxColumn.Name = "lineaDataGridViewTextBoxColumn";
            this.lineaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineaDataGridViewTextBoxColumn.Width = 60;
            // 
            // noPackingDataGridViewTextBoxColumn
            // 
            this.noPackingDataGridViewTextBoxColumn.DataPropertyName = "NoPacking";
            this.noPackingDataGridViewTextBoxColumn.HeaderText = "No Packing";
            this.noPackingDataGridViewTextBoxColumn.Name = "noPackingDataGridViewTextBoxColumn";
            this.noPackingDataGridViewTextBoxColumn.ReadOnly = true;
            this.noPackingDataGridViewTextBoxColumn.Width = 60;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 120;
            // 
            // noGuiaDataGridViewTextBoxColumn
            // 
            this.noGuiaDataGridViewTextBoxColumn.DataPropertyName = "NoGuia";
            this.noGuiaDataGridViewTextBoxColumn.HeaderText = "No Guia";
            this.noGuiaDataGridViewTextBoxColumn.Name = "noGuiaDataGridViewTextBoxColumn";
            this.noGuiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.noGuiaDataGridViewTextBoxColumn.Width = 60;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 60;
            // 
            // unidadMedidaDataGridViewTextBoxColumn
            // 
            this.unidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidadMedida";
            this.unidadMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad Medida";
            this.unidadMedidaDataGridViewTextBoxColumn.Name = "unidadMedidaDataGridViewTextBoxColumn";
            this.unidadMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadMedidaDataGridViewTextBoxColumn.Width = 80;
            // 
            // noParteDataGridViewTextBoxColumn
            // 
            this.noParteDataGridViewTextBoxColumn.DataPropertyName = "NoParte";
            this.noParteDataGridViewTextBoxColumn.HeaderText = "No Parte";
            this.noParteDataGridViewTextBoxColumn.Name = "noParteDataGridViewTextBoxColumn";
            this.noParteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noParteDataGridViewTextBoxColumn.Width = 60;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razonDataGridViewTextBoxColumn
            // 
            this.razonDataGridViewTextBoxColumn.DataPropertyName = "Razon";
            this.razonDataGridViewTextBoxColumn.HeaderText = "Razón";
            this.razonDataGridViewTextBoxColumn.Name = "razonDataGridViewTextBoxColumn";
            this.razonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bResueltoDataGridViewCheckBoxColumn
            // 
            this.bResueltoDataGridViewCheckBoxColumn.DataPropertyName = "bResuelto";
            this.bResueltoDataGridViewCheckBoxColumn.HeaderText = "Resuelto";
            this.bResueltoDataGridViewCheckBoxColumn.Name = "bResueltoDataGridViewCheckBoxColumn";
            this.bResueltoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bResueltoDataGridViewCheckBoxColumn.Width = 60;
            // 
            // fechaResolvioDataGridViewTextBoxColumn
            // 
            this.fechaResolvioDataGridViewTextBoxColumn.DataPropertyName = "FechaResolvio";
            this.fechaResolvioDataGridViewTextBoxColumn.HeaderText = "Fecha Resolvio";
            this.fechaResolvioDataGridViewTextBoxColumn.Name = "fechaResolvioDataGridViewTextBoxColumn";
            this.fechaResolvioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaResolvioDataGridViewTextBoxColumn.Width = 120;
            // 
            // resolvioDataGridViewTextBoxColumn
            // 
            this.resolvioDataGridViewTextBoxColumn.DataPropertyName = "Resolvio";
            this.resolvioDataGridViewTextBoxColumn.HeaderText = "Resolvio";
            this.resolvioDataGridViewTextBoxColumn.Name = "resolvioDataGridViewTextBoxColumn";
            this.resolvioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialesDetenidoBindingSource
            // 
            this.materialesDetenidoBindingSource.DataMember = "MaterialesDetenido";
            this.materialesDetenidoBindingSource.DataSource = this.incidencias;
            // 
            // incidencias
            // 
            this.incidencias.DataSetName = "Incidencias";
            this.incidencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialesDetenidoTableAdapter
            // 
            this.materialesDetenidoTableAdapter.ClearBeforeFill = true;
            // 
            // MaterialDetenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 630);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlResuelto);
            this.Controls.Add(this.chkResuelto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.txtNoParte);
            this.Controls.Add(this.txtUM);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNoPackingList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvIncidencias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtNoGuia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPO);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaterialDetenido";
            this.Text = "Material Detenido";
            this.Load += new System.EventHandler(this.MaterialDetenido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.pnlResuelto.ResumeLayout(false);
            this.pnlResuelto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialesDetenidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoGuia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoPackingList;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.TextBox txtNoParte;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaResuelto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtResolvio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkResuelto;
        private System.Windows.Forms.Panel pnlResuelto;
        private MaterialCore.DataSets.Incidencias incidencias;
        private System.Windows.Forms.BindingSource materialesDetenidoBindingSource;
        private MaterialCore.DataSets.IncidenciasTableAdapters.MaterialesDetenidoTableAdapter materialesDetenidoTableAdapter;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPackingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noGuiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noParteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bResueltoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaResolvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltro;
    }
}