namespace MaterialCore.MaterialesMQ
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.gPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gHijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroParteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadRecibidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroGuiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaImportacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisOrigenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadBultosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoNetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoBultoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenidoTipoBultoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generarTXTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maquinaria = new MaterialCore.DataSets.Maquinaria();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToltaCon = new System.Windows.Forms.Label();
            this.lblTotalSin = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblPadres = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.generarTXTTableAdapter = new MaterialCore.DataSets.MaquinariaTableAdapters.GenerarTXTTableAdapter();
            this.lblCargando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generarTXTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.AllowUserToAddRows = false;
            this.dgvPartidas.AllowUserToDeleteRows = false;
            this.dgvPartidas.AllowUserToResizeColumns = false;
            this.dgvPartidas.AllowUserToResizeRows = false;
            this.dgvPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPartidas.AutoGenerateColumns = false;
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gPO,
            this.lineaPODataGridViewTextBoxColumn,
            this.gHijo,
            this.numeroParteDataGridViewTextBoxColumn,
            this.cantidadRecibidaDataGridViewTextBoxColumn,
            this.numeroGuiaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.facturaImportacionDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.paisOrigenDataGridViewTextBoxColumn,
            this.cantidadBultosDataGridViewTextBoxColumn,
            this.unidadMedidaDataGridViewTextBoxColumn,
            this.pesoBrutoDataGridViewTextBoxColumn,
            this.pesoNetoDataGridViewTextBoxColumn,
            this.tipoBultoDataGridViewTextBoxColumn,
            this.contenidoTipoBultoDataGridViewTextBoxColumn,
            this.transportistaDataGridViewTextBoxColumn,
            this.monedaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgvPartidas.DataSource = this.generarTXTBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPartidas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPartidas.Location = new System.Drawing.Point(12, 33);
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.ReadOnly = true;
            this.dgvPartidas.RowHeadersVisible = false;
            this.dgvPartidas.Size = new System.Drawing.Size(995, 539);
            this.dgvPartidas.TabIndex = 3;
            // 
            // gPO
            // 
            this.gPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gPO.DataPropertyName = "numPO";
            this.gPO.HeaderText = "PO";
            this.gPO.Name = "gPO";
            this.gPO.ReadOnly = true;
            this.gPO.Width = 48;
            // 
            // lineaPODataGridViewTextBoxColumn
            // 
            this.lineaPODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lineaPODataGridViewTextBoxColumn.DataPropertyName = "LineaPO";
            this.lineaPODataGridViewTextBoxColumn.HeaderText = "Linea";
            this.lineaPODataGridViewTextBoxColumn.Name = "lineaPODataGridViewTextBoxColumn";
            this.lineaPODataGridViewTextBoxColumn.ReadOnly = true;
            this.lineaPODataGridViewTextBoxColumn.Width = 59;
            // 
            // gHijo
            // 
            this.gHijo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gHijo.DataPropertyName = "hijo";
            this.gHijo.HeaderText = "Hijo";
            this.gHijo.Name = "gHijo";
            this.gHijo.ReadOnly = true;
            this.gHijo.Width = 51;
            // 
            // numeroParteDataGridViewTextBoxColumn
            // 
            this.numeroParteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numeroParteDataGridViewTextBoxColumn.DataPropertyName = "NumeroParte";
            this.numeroParteDataGridViewTextBoxColumn.HeaderText = "Numero Parte";
            this.numeroParteDataGridViewTextBoxColumn.Name = "numeroParteDataGridViewTextBoxColumn";
            this.numeroParteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroParteDataGridViewTextBoxColumn.Width = 90;
            // 
            // cantidadRecibidaDataGridViewTextBoxColumn
            // 
            this.cantidadRecibidaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cantidadRecibidaDataGridViewTextBoxColumn.DataPropertyName = "CantidadRecibida";
            this.cantidadRecibidaDataGridViewTextBoxColumn.HeaderText = "Cantidad Recibida";
            this.cantidadRecibidaDataGridViewTextBoxColumn.Name = "cantidadRecibidaDataGridViewTextBoxColumn";
            this.cantidadRecibidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadRecibidaDataGridViewTextBoxColumn.Width = 110;
            // 
            // numeroGuiaDataGridViewTextBoxColumn
            // 
            this.numeroGuiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numeroGuiaDataGridViewTextBoxColumn.DataPropertyName = "NumeroGuia";
            this.numeroGuiaDataGridViewTextBoxColumn.HeaderText = "NumeroGuia";
            this.numeroGuiaDataGridViewTextBoxColumn.Name = "numeroGuiaDataGridViewTextBoxColumn";
            this.numeroGuiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroGuiaDataGridViewTextBoxColumn.Width = 92;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.proveedorDataGridViewTextBoxColumn.Width = 82;
            // 
            // facturaImportacionDataGridViewTextBoxColumn
            // 
            this.facturaImportacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.facturaImportacionDataGridViewTextBoxColumn.DataPropertyName = "FacturaImportacion";
            this.facturaImportacionDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.facturaImportacionDataGridViewTextBoxColumn.Name = "facturaImportacionDataGridViewTextBoxColumn";
            this.facturaImportacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.facturaImportacionDataGridViewTextBoxColumn.Width = 69;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 63;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 68;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDataGridViewTextBoxColumn.Width = 57;
            // 
            // paisOrigenDataGridViewTextBoxColumn
            // 
            this.paisOrigenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.paisOrigenDataGridViewTextBoxColumn.DataPropertyName = "PaisOrigen";
            this.paisOrigenDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisOrigenDataGridViewTextBoxColumn.Name = "paisOrigenDataGridViewTextBoxColumn";
            this.paisOrigenDataGridViewTextBoxColumn.ReadOnly = true;
            this.paisOrigenDataGridViewTextBoxColumn.Width = 53;
            // 
            // cantidadBultosDataGridViewTextBoxColumn
            // 
            this.cantidadBultosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cantidadBultosDataGridViewTextBoxColumn.DataPropertyName = "CantidadBultos";
            this.cantidadBultosDataGridViewTextBoxColumn.HeaderText = "Bultos";
            this.cantidadBultosDataGridViewTextBoxColumn.Name = "cantidadBultosDataGridViewTextBoxColumn";
            this.cantidadBultosDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadBultosDataGridViewTextBoxColumn.Width = 62;
            // 
            // unidadMedidaDataGridViewTextBoxColumn
            // 
            this.unidadMedidaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.unidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidadMedida";
            this.unidadMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad Medida";
            this.unidadMedidaDataGridViewTextBoxColumn.Name = "unidadMedidaDataGridViewTextBoxColumn";
            this.unidadMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadMedidaDataGridViewTextBoxColumn.Width = 97;
            // 
            // pesoBrutoDataGridViewTextBoxColumn
            // 
            this.pesoBrutoDataGridViewTextBoxColumn.DataPropertyName = "PesoBruto";
            this.pesoBrutoDataGridViewTextBoxColumn.HeaderText = "PesoBruto";
            this.pesoBrutoDataGridViewTextBoxColumn.Name = "pesoBrutoDataGridViewTextBoxColumn";
            this.pesoBrutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoBrutoDataGridViewTextBoxColumn.Visible = false;
            // 
            // pesoNetoDataGridViewTextBoxColumn
            // 
            this.pesoNetoDataGridViewTextBoxColumn.DataPropertyName = "PesoNeto";
            this.pesoNetoDataGridViewTextBoxColumn.HeaderText = "PesoNeto";
            this.pesoNetoDataGridViewTextBoxColumn.Name = "pesoNetoDataGridViewTextBoxColumn";
            this.pesoNetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoNetoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoBultoDataGridViewTextBoxColumn
            // 
            this.tipoBultoDataGridViewTextBoxColumn.DataPropertyName = "TipoBulto";
            this.tipoBultoDataGridViewTextBoxColumn.HeaderText = "TipoBulto";
            this.tipoBultoDataGridViewTextBoxColumn.Name = "tipoBultoDataGridViewTextBoxColumn";
            this.tipoBultoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoBultoDataGridViewTextBoxColumn.Visible = false;
            // 
            // contenidoTipoBultoDataGridViewTextBoxColumn
            // 
            this.contenidoTipoBultoDataGridViewTextBoxColumn.DataPropertyName = "ContenidoTipoBulto";
            this.contenidoTipoBultoDataGridViewTextBoxColumn.HeaderText = "ContenidoTipoBulto";
            this.contenidoTipoBultoDataGridViewTextBoxColumn.Name = "contenidoTipoBultoDataGridViewTextBoxColumn";
            this.contenidoTipoBultoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contenidoTipoBultoDataGridViewTextBoxColumn.Visible = false;
            // 
            // transportistaDataGridViewTextBoxColumn
            // 
            this.transportistaDataGridViewTextBoxColumn.DataPropertyName = "Transportista";
            this.transportistaDataGridViewTextBoxColumn.HeaderText = "Transportista";
            this.transportistaDataGridViewTextBoxColumn.Name = "transportistaDataGridViewTextBoxColumn";
            this.transportistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.transportistaDataGridViewTextBoxColumn.Visible = false;
            // 
            // monedaDataGridViewTextBoxColumn
            // 
            this.monedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda";
            this.monedaDataGridViewTextBoxColumn.HeaderText = "Moneda";
            this.monedaDataGridViewTextBoxColumn.Name = "monedaDataGridViewTextBoxColumn";
            this.monedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.monedaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 42;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Visible = false;
            // 
            // generarTXTBindingSource
            // 
            this.generarTXTBindingSource.DataMember = "GenerarTXT";
            this.generarTXTBindingSource.DataSource = this.maquinaria;
            // 
            // maquinaria
            // 
            this.maquinaria.DataSetName = "Maquinaria";
            this.maquinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(88, 6);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(100, 20);
            this.txtConsecutivo.TabIndex = 1;
            this.txtConsecutivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsecutivo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consecutivo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearArchivo.Location = new System.Drawing.Point(895, 578);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(112, 26);
            this.btnCrearArchivo.TabIndex = 4;
            this.btnCrearArchivo.Text = "Generar Archivos";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total de partidas con PO:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total de partidas sin PO:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total de partidas:";
            // 
            // lblToltaCon
            // 
            this.lblToltaCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToltaCon.AutoSize = true;
            this.lblToltaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToltaCon.Location = new System.Drawing.Point(147, 575);
            this.lblToltaCon.Name = "lblToltaCon";
            this.lblToltaCon.Size = new System.Drawing.Size(41, 13);
            this.lblToltaCon.TabIndex = 9;
            this.lblToltaCon.Text = "label5";
            // 
            // lblTotalSin
            // 
            this.lblTotalSin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalSin.AutoSize = true;
            this.lblTotalSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSin.Location = new System.Drawing.Point(372, 575);
            this.lblTotalSin.Name = "lblTotalSin";
            this.lblTotalSin.Size = new System.Drawing.Size(41, 13);
            this.lblTotalSin.TabIndex = 10;
            this.lblTotalSin.Text = "label6";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(576, 575);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "label7";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(203, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblPadres
            // 
            this.lblPadres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPadres.AutoSize = true;
            this.lblPadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadres.Location = new System.Drawing.Point(780, 575);
            this.lblPadres.Name = "lblPadres";
            this.lblPadres.Size = new System.Drawing.Size(41, 13);
            this.lblPadres.TabIndex = 13;
            this.lblPadres.Text = "label7";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total de Padres con PO:";
            // 
            // generarTXTTableAdapter
            // 
            this.generarTXTTableAdapter.ClearBeforeFill = true;
            // 
            // lblCargando
            // 
            this.lblCargando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargando.AutoSize = true;
            this.lblCargando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.Location = new System.Drawing.Point(707, 486);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(289, 57);
            this.lblCargando.TabIndex = 0;
            this.lblCargando.Text = "Cargando...";
            this.lblCargando.UseWaitCursor = true;
            this.lblCargando.Visible = false;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 607);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.lblPadres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalSin);
            this.Controls.Add(this.lblToltaCon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrearArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsecutivo);
            this.Controls.Add(this.dgvPartidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeQ Archivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generarTXTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToltaCon;
        private System.Windows.Forms.Label lblTotalSin;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.BindingSource generarTXTBindingSource;
        private MaterialCore.DataSets.Maquinaria maquinaria;
        private MaterialCore.DataSets.MaquinariaTableAdapters.GenerarTXTTableAdapter generarTXTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gHijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadRecibidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroGuiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaImportacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisOrigenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadBultosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoNetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoBultoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contenidoTipoBultoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPadres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCargando;

    }
}