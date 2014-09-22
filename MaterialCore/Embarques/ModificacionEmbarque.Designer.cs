namespace MaterialCore.Embarques
{
    partial class ModificacionEmbarque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionEmbarque));
            this.materialesPaltetasDataGridView = new System.Windows.Forms.DataGridView();
            this.Consecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesEnviarDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitarTodos = new System.Windows.Forms.Button();
            this.btnRegresarTodos = new System.Windows.Forms.Button();
            this.pnlGuia = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoNoGuia = new System.Windows.Forms.TextBox();
            this.materialesEnviarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.embarques = new MaterialCore.DataSets.Embarques();
            this.FechaRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsecutivoEmbarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePaleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPaleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadBultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nid_sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmbarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEmbarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContenidoTipoBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesPaltetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialesPaltetasTableAdapter = new MaterialCore.DataSets.EmbarquesTableAdapters.MaterialesPaltetasTableAdapter();
            this.materialesEnviarTableAdapter = new MaterialCore.DataSets.EmbarquesTableAdapters.MaterialesEnviarTableAdapter();
            this.g2PO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g2Renglon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroParte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g2Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escaneado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materialesPaltetasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesEnviarDataGridView)).BeginInit();
            this.pnlGuia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesEnviarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesPaltetasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialesPaltetasDataGridView
            // 
            this.materialesPaltetasDataGridView.AllowUserToAddRows = false;
            this.materialesPaltetasDataGridView.AllowUserToDeleteRows = false;
            this.materialesPaltetasDataGridView.AllowUserToResizeRows = false;
            this.materialesPaltetasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.materialesPaltetasDataGridView.AutoGenerateColumns = false;
            this.materialesPaltetasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRecibo,
            this.ConsecutivoEmbarque,
            this.Consecutivo,
            this.NombrePaleta,
            this.NumeroPaleta,
            this.Planta,
            this.PesoBruto,
            this.CantidadBultos,
            this.nid_sku,
            this.FechaEmbarque,
            this.TipoEmbarque,
            this.ContenidoTipoBulto,
            this.Id});
            this.materialesPaltetasDataGridView.DataSource = this.materialesPaltetasBindingSource;
            this.materialesPaltetasDataGridView.Location = new System.Drawing.Point(12, 12);
            this.materialesPaltetasDataGridView.Name = "materialesPaltetasDataGridView";
            this.materialesPaltetasDataGridView.ReadOnly = true;
            this.materialesPaltetasDataGridView.RowHeadersVisible = false;
            this.materialesPaltetasDataGridView.RowHeadersWidth = 25;
            this.materialesPaltetasDataGridView.Size = new System.Drawing.Size(968, 258);
            this.materialesPaltetasDataGridView.TabIndex = 1;
            this.materialesPaltetasDataGridView.SelectionChanged += new System.EventHandler(this.materialesPaltetasDataGridView_SelectionChanged);
            // 
            // Consecutivo
            // 
            this.Consecutivo.DataPropertyName = "Consecutivo";
            this.Consecutivo.HeaderText = "Consecutivo";
            this.Consecutivo.Name = "Consecutivo";
            this.Consecutivo.ReadOnly = true;
            // 
            // materialesEnviarDataGridView
            // 
            this.materialesEnviarDataGridView.AllowUserToAddRows = false;
            this.materialesEnviarDataGridView.AllowUserToDeleteRows = false;
            this.materialesEnviarDataGridView.AllowUserToResizeRows = false;
            this.materialesEnviarDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.materialesEnviarDataGridView.AutoGenerateColumns = false;
            this.materialesEnviarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g2PO,
            this.g2Renglon,
            this.NumeroParte,
            this.g2Cantidad,
            this.UnidadMedida,
            this.NoGuia,
            this.FacturaProveedor,
            this.Pais,
            this.Moneda,
            this.escaneado,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.Id2,
            this.Comentario});
            this.materialesEnviarDataGridView.DataSource = this.materialesEnviarBindingSource;
            this.materialesEnviarDataGridView.Location = new System.Drawing.Point(12, 276);
            this.materialesEnviarDataGridView.Name = "materialesEnviarDataGridView";
            this.materialesEnviarDataGridView.RowHeadersVisible = false;
            this.materialesEnviarDataGridView.RowHeadersWidth = 25;
            this.materialesEnviarDataGridView.Size = new System.Drawing.Size(968, 247);
            this.materialesEnviarDataGridView.TabIndex = 2;
            this.materialesEnviarDataGridView.DoubleClick += new System.EventHandler(this.materialesEnviarDataGridView_DoubleClick);
            this.materialesEnviarDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialesEnviarDataGridView_CellEndEdit);
            this.materialesEnviarDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialesEnviarDataGridView_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(640, 529);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.Location = new System.Drawing.Point(744, 529);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(825, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar a no enviados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(132, 534);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblRegistros.TabIndex = 6;
            this.lblRegistros.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuitarTodos.Location = new System.Drawing.Point(203, 529);
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Size = new System.Drawing.Size(86, 23);
            this.btnQuitarTodos.TabIndex = 8;
            this.btnQuitarTodos.Text = "Quitar Todos";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            this.btnQuitarTodos.Click += new System.EventHandler(this.btnQuitarTodos_Click);
            // 
            // btnRegresarTodos
            // 
            this.btnRegresarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegresarTodos.Location = new System.Drawing.Point(306, 529);
            this.btnRegresarTodos.Name = "btnRegresarTodos";
            this.btnRegresarTodos.Size = new System.Drawing.Size(163, 23);
            this.btnRegresarTodos.TabIndex = 9;
            this.btnRegresarTodos.Text = "Regresar Todos a no enviados";
            this.btnRegresarTodos.UseVisualStyleBackColor = true;
            this.btnRegresarTodos.Click += new System.EventHandler(this.btnRegresarTodos_Click);
            // 
            // pnlGuia
            // 
            this.pnlGuia.Controls.Add(this.btnCancelar);
            this.pnlGuia.Controls.Add(this.btnAceptar);
            this.pnlGuia.Controls.Add(this.label2);
            this.pnlGuia.Controls.Add(this.txtNuevoNoGuia);
            this.pnlGuia.Location = new System.Drawing.Point(203, 160);
            this.pnlGuia.Name = "pnlGuia";
            this.pnlGuia.Size = new System.Drawing.Size(322, 77);
            this.pnlGuia.TabIndex = 89;
            this.pnlGuia.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 36);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(151, 36);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Favor de ingresar el nuevo número de guía:";
            // 
            // txtNuevoNoGuia
            // 
            this.txtNuevoNoGuia.Location = new System.Drawing.Point(7, 36);
            this.txtNuevoNoGuia.Name = "txtNuevoNoGuia";
            this.txtNuevoNoGuia.Size = new System.Drawing.Size(138, 20);
            this.txtNuevoNoGuia.TabIndex = 0;
            // 
            // materialesEnviarBindingSource
            // 
            this.materialesEnviarBindingSource.DataMember = "MaterialesEnviar";
            this.materialesEnviarBindingSource.DataSource = this.embarques;
            // 
            // embarques
            // 
            this.embarques.DataSetName = "Embarques";
            this.embarques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FechaRecibo
            // 
            this.FechaRecibo.DataPropertyName = "FechaRecibo";
            this.FechaRecibo.HeaderText = "Fecha de Creacion";
            this.FechaRecibo.Name = "FechaRecibo";
            this.FechaRecibo.ReadOnly = true;
            // 
            // ConsecutivoEmbarque
            // 
            this.ConsecutivoEmbarque.DataPropertyName = "ConsecutivoEmbarque";
            this.ConsecutivoEmbarque.HeaderText = "Embarque";
            this.ConsecutivoEmbarque.Name = "ConsecutivoEmbarque";
            this.ConsecutivoEmbarque.ReadOnly = true;
            // 
            // NombrePaleta
            // 
            this.NombrePaleta.DataPropertyName = "NombrePaleta";
            this.NombrePaleta.HeaderText = "Nombre de Paleta";
            this.NombrePaleta.Name = "NombrePaleta";
            this.NombrePaleta.ReadOnly = true;
            // 
            // NumeroPaleta
            // 
            this.NumeroPaleta.DataPropertyName = "NumeroPaleta";
            this.NumeroPaleta.HeaderText = "Numero de Paleta";
            this.NumeroPaleta.Name = "NumeroPaleta";
            this.NumeroPaleta.ReadOnly = true;
            // 
            // Planta
            // 
            this.Planta.DataPropertyName = "Planta";
            this.Planta.HeaderText = "Planta";
            this.Planta.Name = "Planta";
            this.Planta.ReadOnly = true;
            // 
            // PesoBruto
            // 
            this.PesoBruto.DataPropertyName = "PesoBruto";
            dataGridViewCellStyle1.Format = "N2";
            this.PesoBruto.DefaultCellStyle = dataGridViewCellStyle1;
            this.PesoBruto.HeaderText = "Peso Bruto";
            this.PesoBruto.Name = "PesoBruto";
            this.PesoBruto.ReadOnly = true;
            // 
            // CantidadBultos
            // 
            this.CantidadBultos.DataPropertyName = "CantidadBultos";
            dataGridViewCellStyle2.Format = "N2";
            this.CantidadBultos.DefaultCellStyle = dataGridViewCellStyle2;
            this.CantidadBultos.HeaderText = "Cant. Bultos";
            this.CantidadBultos.Name = "CantidadBultos";
            this.CantidadBultos.ReadOnly = true;
            // 
            // nid_sku
            // 
            this.nid_sku.DataPropertyName = "nid_sku";
            this.nid_sku.HeaderText = "Etiqueta Azul";
            this.nid_sku.Name = "nid_sku";
            this.nid_sku.ReadOnly = true;
            // 
            // FechaEmbarque
            // 
            this.FechaEmbarque.DataPropertyName = "FechaEmbarque";
            this.FechaEmbarque.HeaderText = "Fecha de Embarque";
            this.FechaEmbarque.Name = "FechaEmbarque";
            this.FechaEmbarque.ReadOnly = true;
            this.FechaEmbarque.Visible = false;
            // 
            // TipoEmbarque
            // 
            this.TipoEmbarque.DataPropertyName = "TipoEmbarque";
            this.TipoEmbarque.HeaderText = "Tipo Embarque";
            this.TipoEmbarque.Name = "TipoEmbarque";
            this.TipoEmbarque.ReadOnly = true;
            this.TipoEmbarque.Visible = false;
            // 
            // ContenidoTipoBulto
            // 
            this.ContenidoTipoBulto.DataPropertyName = "ContenidoTipoBulto";
            this.ContenidoTipoBulto.HeaderText = "ContenidoTipoBulto";
            this.ContenidoTipoBulto.Name = "ContenidoTipoBulto";
            this.ContenidoTipoBulto.ReadOnly = true;
            this.ContenidoTipoBulto.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id Tarima";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // materialesPaltetasBindingSource
            // 
            this.materialesPaltetasBindingSource.DataMember = "MaterialesPaltetas";
            this.materialesPaltetasBindingSource.DataSource = this.embarques;
            // 
            // materialesPaltetasTableAdapter
            // 
            this.materialesPaltetasTableAdapter.ClearBeforeFill = true;
            // 
            // materialesEnviarTableAdapter
            // 
            this.materialesEnviarTableAdapter.ClearBeforeFill = true;
            // 
            // g2PO
            // 
            this.g2PO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.g2PO.DataPropertyName = "MaterialesOCId";
            this.g2PO.HeaderText = "PO";
            this.g2PO.Name = "g2PO";
            this.g2PO.ReadOnly = true;
            this.g2PO.Width = 48;
            // 
            // g2Renglon
            // 
            this.g2Renglon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.g2Renglon.DataPropertyName = "RenglonId";
            this.g2Renglon.HeaderText = "Linea";
            this.g2Renglon.Name = "g2Renglon";
            this.g2Renglon.ReadOnly = true;
            this.g2Renglon.Width = 59;
            // 
            // NumeroParte
            // 
            this.NumeroParte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NumeroParte.DataPropertyName = "NumeroParte";
            this.NumeroParte.HeaderText = "Numero de Parte";
            this.NumeroParte.Name = "NumeroParte";
            this.NumeroParte.ReadOnly = true;
            this.NumeroParte.Width = 113;
            // 
            // g2Cantidad
            // 
            this.g2Cantidad.DataPropertyName = "CantidadRecibida";
            dataGridViewCellStyle3.Format = "N2";
            this.g2Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.g2Cantidad.HeaderText = "Cant. Recibida";
            this.g2Cantidad.Name = "g2Cantidad";
            this.g2Cantidad.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.DataPropertyName = "UnidadMedida";
            this.UnidadMedida.HeaderText = "Unidad Medida";
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            this.UnidadMedida.Width = 50;
            // 
            // NoGuia
            // 
            this.NoGuia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NoGuia.DataPropertyName = "NoGuia";
            this.NoGuia.HeaderText = "NoGuia";
            this.NoGuia.Name = "NoGuia";
            this.NoGuia.ReadOnly = true;
            this.NoGuia.Width = 69;
            // 
            // FacturaProveedor
            // 
            this.FacturaProveedor.DataPropertyName = "FacturaProveedor";
            this.FacturaProveedor.HeaderText = "Factura Proveedor";
            this.FacturaProveedor.Name = "FacturaProveedor";
            this.FacturaProveedor.ReadOnly = true;
            // 
            // Pais
            // 
            this.Pais.DataPropertyName = "Pais";
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            this.Pais.Width = 50;
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "Moneda";
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            this.Moneda.Width = 50;
            // 
            // escaneado
            // 
            this.escaneado.DataPropertyName = "escaneado";
            this.escaneado.HeaderText = "Digitalizado";
            this.escaneado.Name = "escaneado";
            this.escaneado.ReadOnly = true;
            this.escaneado.Width = 75;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ClienteID";
            this.dataGridViewTextBoxColumn16.HeaderText = "ClienteID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn19.HeaderText = "Fecha Creacion";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Preparado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Preparado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Enviado";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Enviado";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Visible = false;
            // 
            // Id2
            // 
            this.Id2.DataPropertyName = "Id";
            this.Id2.HeaderText = "Id";
            this.Id2.Name = "Id2";
            this.Id2.ReadOnly = true;
            this.Id2.Visible = false;
            // 
            // Comentario
            // 
            this.Comentario.DataPropertyName = "Comentario";
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            // 
            // ModificacionEmbarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 561);
            this.Controls.Add(this.pnlGuia);
            this.Controls.Add(this.btnRegresarTodos);
            this.Controls.Add(this.btnQuitarTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.materialesEnviarDataGridView);
            this.Controls.Add(this.materialesPaltetasDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificacionEmbarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Tarima";
            this.Load += new System.EventHandler(this.ModificacionEmbarque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialesPaltetasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesEnviarDataGridView)).EndInit();
            this.pnlGuia.ResumeLayout(false);
            this.pnlGuia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesEnviarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesPaltetasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialCore.DataSets.Embarques embarques;
        private System.Windows.Forms.BindingSource materialesPaltetasBindingSource;
        private MaterialCore.DataSets.EmbarquesTableAdapters.MaterialesPaltetasTableAdapter materialesPaltetasTableAdapter;
        private System.Windows.Forms.DataGridView materialesPaltetasDataGridView;
        private System.Windows.Forms.BindingSource materialesEnviarBindingSource;
        private MaterialCore.DataSets.EmbarquesTableAdapters.MaterialesEnviarTableAdapter materialesEnviarTableAdapter;
        private System.Windows.Forms.DataGridView materialesEnviarDataGridView;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitarTodos;
        private System.Windows.Forms.Button btnRegresarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsecutivoEmbarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePaleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPaleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadBultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid_sku;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmbarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmbarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContenidoTipoBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Panel pnlGuia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevoNoGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn g2PO;
        private System.Windows.Forms.DataGridViewTextBoxColumn g2Renglon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroParte;
        private System.Windows.Forms.DataGridViewTextBoxColumn g2Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn escaneado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;

    }
}