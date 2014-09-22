namespace MaterialCore.Embarques
{
    partial class Embarques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Embarques));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPlantas = new System.Windows.Forms.DataGridView();
            this.fechaEmbarqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesSinEnviarPlantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.embarques1 = new MaterialCore.DataSets.Embarques();
            this.dgvDetalleEmbarque = new System.Windows.Forms.DataGridView();
            this.materialesSinEnviarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NoTarima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProgramaID = new System.Windows.Forms.TextBox();
            this.txtNumeroProveedor = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtCantidadBultos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFacturaProveedor = new System.Windows.Forms.TextBox();
            this.btnPaleta = new System.Windows.Forms.Button();
            this.txtFiltroPO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.materialesSinEnviarTableAdapter = new MaterialCore.DataSets.EmbarquesTableAdapters.MaterialesSinEnviarTableAdapter();
            this.materialesSinEnviarPlantaTableAdapter = new MaterialCore.DataSets.EmbarquesTableAdapters.MaterialesSinEnviarPlantaTableAdapter();
            this.pnlGuia = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoNoGuia = new System.Windows.Forms.TextBox();
            this.FechaRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlantaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineaPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroParte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gescaneado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NoGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesSinEnviarPlantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEmbarque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesSinEnviarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlGuia.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlantas
            // 
            this.dgvPlantas.AllowUserToAddRows = false;
            this.dgvPlantas.AllowUserToDeleteRows = false;
            this.dgvPlantas.AllowUserToResizeColumns = false;
            this.dgvPlantas.AllowUserToResizeRows = false;
            this.dgvPlantas.AutoGenerateColumns = false;
            this.dgvPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaEmbarqueDataGridViewTextBoxColumn,
            this.gPlanta});
            this.dgvPlantas.DataSource = this.materialesSinEnviarPlantaBindingSource;
            this.dgvPlantas.Location = new System.Drawing.Point(13, 13);
            this.dgvPlantas.MultiSelect = false;
            this.dgvPlantas.Name = "dgvPlantas";
            this.dgvPlantas.ReadOnly = true;
            this.dgvPlantas.RowHeadersVisible = false;
            this.dgvPlantas.RowHeadersWidth = 24;
            this.dgvPlantas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlantas.Size = new System.Drawing.Size(114, 488);
            this.dgvPlantas.TabIndex = 0;
            this.dgvPlantas.SelectionChanged += new System.EventHandler(this.dgvPlantas_SelectionChanged);
            // 
            // fechaEmbarqueDataGridViewTextBoxColumn
            // 
            this.fechaEmbarqueDataGridViewTextBoxColumn.DataPropertyName = "FechaEmbarque";
            this.fechaEmbarqueDataGridViewTextBoxColumn.HeaderText = "Fecha Embarque";
            this.fechaEmbarqueDataGridViewTextBoxColumn.Name = "fechaEmbarqueDataGridViewTextBoxColumn";
            this.fechaEmbarqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaEmbarqueDataGridViewTextBoxColumn.Visible = false;
            this.fechaEmbarqueDataGridViewTextBoxColumn.Width = 200;
            // 
            // gPlanta
            // 
            this.gPlanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gPlanta.DataPropertyName = "Planta";
            this.gPlanta.HeaderText = "Planta";
            this.gPlanta.Name = "gPlanta";
            this.gPlanta.ReadOnly = true;
            this.gPlanta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // materialesSinEnviarPlantaBindingSource
            // 
            this.materialesSinEnviarPlantaBindingSource.DataMember = "MaterialesSinEnviarPlanta";
            this.materialesSinEnviarPlantaBindingSource.DataSource = this.embarques1;
            // 
            // embarques1
            // 
            this.embarques1.DataSetName = "Embarques";
            this.embarques1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDetalleEmbarque
            // 
            this.dgvDetalleEmbarque.AllowUserToAddRows = false;
            this.dgvDetalleEmbarque.AllowUserToDeleteRows = false;
            this.dgvDetalleEmbarque.AllowUserToResizeRows = false;
            this.dgvDetalleEmbarque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalleEmbarque.AutoGenerateColumns = false;
            this.dgvDetalleEmbarque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleEmbarque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRecibo,
            this.PlantaID,
            this.NumeroPO,
            this.LineaPO,
            this.NumeroParte,
            this.facturaProveedorDataGridViewTextBoxColumn,
            this.CantidadRecibida,
            this.Comentario,
            this.gescaneado,
            this.NoGuia,
            this.Quitar,
            this.gId});
            this.dgvDetalleEmbarque.DataSource = this.materialesSinEnviarBindingSource;
            this.dgvDetalleEmbarque.Location = new System.Drawing.Point(136, 36);
            this.dgvDetalleEmbarque.MultiSelect = false;
            this.dgvDetalleEmbarque.Name = "dgvDetalleEmbarque";
            this.dgvDetalleEmbarque.RowHeadersVisible = false;
            this.dgvDetalleEmbarque.RowHeadersWidth = 24;
            this.dgvDetalleEmbarque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleEmbarque.Size = new System.Drawing.Size(844, 465);
            this.dgvDetalleEmbarque.TabIndex = 1;
            this.dgvDetalleEmbarque.DoubleClick += new System.EventHandler(this.dgvDetalleEmbarque_DoubleClick);
            this.dgvDetalleEmbarque.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleEmbarque_CellEndEdit);
            this.dgvDetalleEmbarque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleEmbarque_CellClick);
            // 
            // materialesSinEnviarBindingSource
            // 
            this.materialesSinEnviarBindingSource.DataMember = "MaterialesSinEnviar";
            this.materialesSinEnviarBindingSource.DataSource = this.embarques1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoTarima});
            this.dataGridView1.Location = new System.Drawing.Point(793, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(174, 97);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // NoTarima
            // 
            this.NoTarima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoTarima.HeaderText = "Numero Tarima";
            this.NoTarima.Name = "NoTarima";
            this.NoTarima.ReadOnly = true;
            // 
            // txtProgramaID
            // 
            this.txtProgramaID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesSinEnviarBindingSource, "ProgramaId", true));
            this.txtProgramaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtProgramaID.Location = new System.Drawing.Point(854, 558);
            this.txtProgramaID.Name = "txtProgramaID";
            this.txtProgramaID.Size = new System.Drawing.Size(130, 20);
            this.txtProgramaID.TabIndex = 77;
            // 
            // txtNumeroProveedor
            // 
            this.txtNumeroProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesSinEnviarBindingSource, "ProveedorID", true));
            this.txtNumeroProveedor.Location = new System.Drawing.Point(71, 532);
            this.txtNumeroProveedor.Name = "txtNumeroProveedor";
            this.txtNumeroProveedor.Size = new System.Drawing.Size(84, 20);
            this.txtNumeroProveedor.TabIndex = 65;
            // 
            // txtProveedor
            // 
            this.txtProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesSinEnviarBindingSource, "NombreProveedor", true));
            this.txtProveedor.Location = new System.Drawing.Point(164, 532);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(350, 20);
            this.txtProveedor.TabIndex = 76;
            // 
            // txtCantidadBultos
            // 
            this.txtCantidadBultos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesSinEnviarBindingSource, "Bultos", true));
            this.txtCantidadBultos.Location = new System.Drawing.Point(109, 558);
            this.txtCantidadBultos.Name = "txtCantidadBultos";
            this.txtCantidadBultos.Size = new System.Drawing.Size(42, 20);
            this.txtCantidadBultos.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Unidad de medida:";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesSinEnviarBindingSource, "UnidadMedida", true));
            this.txtUnidadMedida.Location = new System.Drawing.Point(717, 558);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(56, 20);
            this.txtUnidadMedida.TabIndex = 67;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(520, 562);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 13);
            this.label24.TabIndex = 73;
            this.label24.Text = "Pais:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(405, 562);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 74;
            this.label23.Text = "Moneda:";
            // 
            // txtPais
            // 
            this.txtPais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesSinEnviarBindingSource, "Pais", true));
            this.txtPais.Location = new System.Drawing.Point(554, 558);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(56, 20);
            this.txtPais.TabIndex = 68;
            // 
            // txtMoneda
            // 
            this.txtMoneda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesSinEnviarBindingSource, "Moneda", true));
            this.txtMoneda.Location = new System.Drawing.Point(458, 558);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(56, 20);
            this.txtMoneda.TabIndex = 69;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(779, 562);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 72;
            this.label20.Text = "Programa ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 536);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 71;
            this.label18.Text = "Proveedor:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 562);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 70;
            this.label17.Text = "Cantidad de Bultos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Factura Proveedor";
            // 
            // txtFacturaProveedor
            // 
            this.txtFacturaProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesSinEnviarBindingSource, "FacturaProveedor", true));
            this.txtFacturaProveedor.Location = new System.Drawing.Point(272, 558);
            this.txtFacturaProveedor.Name = "txtFacturaProveedor";
            this.txtFacturaProveedor.Size = new System.Drawing.Size(87, 20);
            this.txtFacturaProveedor.TabIndex = 75;
            // 
            // btnPaleta
            // 
            this.btnPaleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaleta.Location = new System.Drawing.Point(905, 507);
            this.btnPaleta.Name = "btnPaleta";
            this.btnPaleta.Size = new System.Drawing.Size(75, 23);
            this.btnPaleta.TabIndex = 80;
            this.btnPaleta.Text = "Crear Paleta";
            this.btnPaleta.UseVisualStyleBackColor = true;
            this.btnPaleta.Click += new System.EventHandler(this.btnPaleta_Click);
            // 
            // txtFiltroPO
            // 
            this.txtFiltroPO.Location = new System.Drawing.Point(207, 10);
            this.txtFiltroPO.MaxLength = 6;
            this.txtFiltroPO.Name = "txtFiltroPO";
            this.txtFiltroPO.Size = new System.Drawing.Size(106, 20);
            this.txtFiltroPO.TabIndex = 81;
            this.txtFiltroPO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroPO_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Filtro por PO:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(317, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 83;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Cantidad de registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(178, 507);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(14, 13);
            this.lblRegistros.TabIndex = 85;
            this.lblRegistros.Text = "0";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(88, 463);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(35, 35);
            this.btnActualizar.TabIndex = 86;
            this.btnActualizar.Text = " ";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(612, 507);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(134, 23);
            this.btnBorrarTodo.TabIndex = 87;
            this.btnBorrarTodo.Text = "Quitar todas las partidas";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // materialesSinEnviarTableAdapter
            // 
            this.materialesSinEnviarTableAdapter.ClearBeforeFill = true;
            // 
            // materialesSinEnviarPlantaTableAdapter
            // 
            this.materialesSinEnviarPlantaTableAdapter.ClearBeforeFill = true;
            // 
            // pnlGuia
            // 
            this.pnlGuia.Controls.Add(this.btnCancelar);
            this.pnlGuia.Controls.Add(this.btnAceptar);
            this.pnlGuia.Controls.Add(this.label1);
            this.pnlGuia.Controls.Add(this.txtNuevoNoGuia);
            this.pnlGuia.Location = new System.Drawing.Point(228, 182);
            this.pnlGuia.Name = "pnlGuia";
            this.pnlGuia.Size = new System.Drawing.Size(322, 77);
            this.pnlGuia.TabIndex = 88;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Favor de ingresar el nuevo número de guía:";
            // 
            // txtNuevoNoGuia
            // 
            this.txtNuevoNoGuia.Location = new System.Drawing.Point(7, 36);
            this.txtNuevoNoGuia.Name = "txtNuevoNoGuia";
            this.txtNuevoNoGuia.Size = new System.Drawing.Size(138, 20);
            this.txtNuevoNoGuia.TabIndex = 0;
            // 
            // FechaRecibo
            // 
            this.FechaRecibo.DataPropertyName = "Fecha";
            this.FechaRecibo.HeaderText = "Fecha de Recibo";
            this.FechaRecibo.Name = "FechaRecibo";
            this.FechaRecibo.ReadOnly = true;
            this.FechaRecibo.Width = 120;
            // 
            // PlantaID
            // 
            this.PlantaID.DataPropertyName = "Planta";
            this.PlantaID.HeaderText = "Planta";
            this.PlantaID.Name = "PlantaID";
            this.PlantaID.Width = 45;
            // 
            // NumeroPO
            // 
            this.NumeroPO.DataPropertyName = "MaterialesOCId";
            this.NumeroPO.HeaderText = "Num. PO";
            this.NumeroPO.Name = "NumeroPO";
            this.NumeroPO.ReadOnly = true;
            this.NumeroPO.Width = 50;
            // 
            // LineaPO
            // 
            this.LineaPO.DataPropertyName = "RenglonId";
            this.LineaPO.HeaderText = "Linea PO";
            this.LineaPO.Name = "LineaPO";
            this.LineaPO.ReadOnly = true;
            this.LineaPO.Width = 45;
            // 
            // NumeroParte
            // 
            this.NumeroParte.DataPropertyName = "NumeroParte";
            this.NumeroParte.HeaderText = "Numero Parte";
            this.NumeroParte.Name = "NumeroParte";
            this.NumeroParte.ReadOnly = true;
            this.NumeroParte.Width = 80;
            // 
            // facturaProveedorDataGridViewTextBoxColumn
            // 
            this.facturaProveedorDataGridViewTextBoxColumn.DataPropertyName = "FacturaProveedor";
            this.facturaProveedorDataGridViewTextBoxColumn.HeaderText = "Factura Proveedor";
            this.facturaProveedorDataGridViewTextBoxColumn.Name = "facturaProveedorDataGridViewTextBoxColumn";
            this.facturaProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.facturaProveedorDataGridViewTextBoxColumn.Width = 75;
            // 
            // CantidadRecibida
            // 
            this.CantidadRecibida.DataPropertyName = "CantidadRecibida";
            dataGridViewCellStyle3.Format = "N2";
            this.CantidadRecibida.DefaultCellStyle = dataGridViewCellStyle3;
            this.CantidadRecibida.HeaderText = "Cantidad Recibida";
            this.CantidadRecibida.Name = "CantidadRecibida";
            this.CantidadRecibida.ReadOnly = true;
            this.CantidadRecibida.Width = 60;
            // 
            // Comentario
            // 
            this.Comentario.DataPropertyName = "Comentario";
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            // 
            // gescaneado
            // 
            this.gescaneado.DataPropertyName = "escaneado";
            this.gescaneado.HeaderText = "Digitalizado";
            this.gescaneado.Name = "gescaneado";
            this.gescaneado.ReadOnly = true;
            this.gescaneado.Width = 50;
            // 
            // NoGuia
            // 
            this.NoGuia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NoGuia.DataPropertyName = "NoGuia";
            this.NoGuia.HeaderText = "Guia";
            this.NoGuia.Name = "NoGuia";
            this.NoGuia.ReadOnly = true;
            this.NoGuia.Width = 55;
            // 
            // Quitar
            // 
            this.Quitar.HeaderText = "";
            this.Quitar.Name = "Quitar";
            this.Quitar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Quitar.Text = "Quitar";
            this.Quitar.UseColumnTextForButtonValue = true;
            // 
            // gId
            // 
            this.gId.DataPropertyName = "Id";
            this.gId.HeaderText = "Id";
            this.gId.Name = "gId";
            this.gId.Visible = false;
            // 
            // Embarques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 587);
            this.Controls.Add(this.pnlGuia);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFiltroPO);
            this.Controls.Add(this.btnPaleta);
            this.Controls.Add(this.txtProgramaID);
            this.Controls.Add(this.txtNumeroProveedor);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtFacturaProveedor);
            this.Controls.Add(this.txtCantidadBultos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvDetalleEmbarque);
            this.Controls.Add(this.dgvPlantas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Embarques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partidas Sin Enviar";
            this.Load += new System.EventHandler(this.Embarques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesSinEnviarPlantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEmbarque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesSinEnviarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlGuia.ResumeLayout(false);
            this.pnlGuia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlantas;
        private System.Windows.Forms.DataGridView dgvDetalleEmbarque;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialCore.DataSets.Embarques embarques1;
        private System.Windows.Forms.BindingSource materialesSinEnviarBindingSource;
        private MaterialCore.DataSets.EmbarquesTableAdapters.MaterialesSinEnviarTableAdapter materialesSinEnviarTableAdapter;
        private System.Windows.Forms.BindingSource materialesSinEnviarPlantaBindingSource;
        private MaterialCore.DataSets.EmbarquesTableAdapters.MaterialesSinEnviarPlantaTableAdapter materialesSinEnviarPlantaTableAdapter;
        private System.Windows.Forms.TextBox txtProgramaID;
        private System.Windows.Forms.TextBox txtNumeroProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtCantidadBultos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFacturaProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTarima;
        private System.Windows.Forms.Button btnPaleta;
        private System.Windows.Forms.TextBox txtFiltroPO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmbarqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPlanta;
        private System.Windows.Forms.Panel pnlGuia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoNoGuia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlantaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineaPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroParte;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gescaneado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoGuia;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn gId;
    }
}