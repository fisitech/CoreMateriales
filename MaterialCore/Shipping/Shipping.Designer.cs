namespace MaterialCore.Shipping
{
    partial class Shipping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShipping = new System.Windows.Forms.DataGridView();
            this.gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPackSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gfechaRBI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTransportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gConsignee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDomestic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gfechaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gfechaDespacho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnoGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gComentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gfechaCapura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesShippingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maquinaria = new MaterialCore.DataSets.Maquinaria();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.materialesShippingTableAdapter = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesShippingTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoCamion = new System.Windows.Forms.TextBox();
            this.gpbFiltroFechas = new System.Windows.Forms.GroupBox();
            this.btnNoFiltro = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.mtxtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtFechaDespacho = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaLlegada = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaRBI = new System.Windows.Forms.MaskedTextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.txtNoGuia = new System.Windows.Forms.TextBox();
            this.txtDomestic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConsignee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransportista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPackSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesShippingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpbFiltroFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShipping
            // 
            this.dgvShipping.AllowUserToAddRows = false;
            this.dgvShipping.AllowUserToDeleteRows = false;
            this.dgvShipping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShipping.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShipping.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gid,
            this.NoCamion,
            this.gPackSum,
            this.gfechaRBI,
            this.gTransportista,
            this.gConsignee,
            this.gDomestic,
            this.gfechaLlegada,
            this.gfechaDespacho,
            this.gnoGuia,
            this.gComentarios,
            this.gfechaCapura});
            this.dgvShipping.DataSource = this.materialesShippingBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShipping.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShipping.Location = new System.Drawing.Point(0, 171);
            this.dgvShipping.Margin = new System.Windows.Forms.Padding(0);
            this.dgvShipping.Name = "dgvShipping";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShipping.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvShipping.RowHeadersWidth = 20;
            this.dgvShipping.Size = new System.Drawing.Size(977, 363);
            this.dgvShipping.TabIndex = 0;
            this.dgvShipping.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dgvShipping.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvShipping_EditingControlShowing);
            this.dgvShipping.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShipping_CellEnter);
            // 
            // gid
            // 
            this.gid.DataPropertyName = "id";
            this.gid.HeaderText = "id";
            this.gid.Name = "gid";
            this.gid.ReadOnly = true;
            this.gid.Visible = false;
            // 
            // NoCamion
            // 
            this.NoCamion.DataPropertyName = "NoCamion";
            this.NoCamion.HeaderText = "#Trailer";
            this.NoCamion.Name = "NoCamion";
            this.NoCamion.Width = 80;
            // 
            // gPackSum
            // 
            this.gPackSum.DataPropertyName = "PackSum";
            this.gPackSum.HeaderText = "PACKSUM";
            this.gPackSum.Name = "gPackSum";
            this.gPackSum.Width = 80;
            // 
            // gfechaRBI
            // 
            this.gfechaRBI.DataPropertyName = "fechaRBI";
            dataGridViewCellStyle2.Format = "dd/MM/yy";
            this.gfechaRBI.DefaultCellStyle = dataGridViewCellStyle2;
            this.gfechaRBI.HeaderText = "Date & time receeived in RBI";
            this.gfechaRBI.Name = "gfechaRBI";
            // 
            // gTransportista
            // 
            this.gTransportista.DataPropertyName = "Transportista";
            this.gTransportista.HeaderText = "Carrier";
            this.gTransportista.Name = "gTransportista";
            // 
            // gConsignee
            // 
            this.gConsignee.DataPropertyName = "Consignee";
            this.gConsignee.HeaderText = "Consignee";
            this.gConsignee.Name = "gConsignee";
            // 
            // gDomestic
            // 
            this.gDomestic.DataPropertyName = "Domestic";
            this.gDomestic.HeaderText = "DOMESTIC/ INT´L";
            this.gDomestic.Name = "gDomestic";
            // 
            // gfechaLlegada
            // 
            this.gfechaLlegada.DataPropertyName = "fechaLlegada";
            dataGridViewCellStyle3.Format = "dd/MM/yy";
            this.gfechaLlegada.DefaultCellStyle = dataGridViewCellStyle3;
            this.gfechaLlegada.HeaderText = "Date shipped from Labinal de Mexico";
            this.gfechaLlegada.Name = "gfechaLlegada";
            // 
            // gfechaDespacho
            // 
            this.gfechaDespacho.DataPropertyName = "fechaDespacho";
            dataGridViewCellStyle4.Format = "dd/MM/yy";
            this.gfechaDespacho.DefaultCellStyle = dataGridViewCellStyle4;
            this.gfechaDespacho.HeaderText = "Date shipped from RBI";
            this.gfechaDespacho.Name = "gfechaDespacho";
            // 
            // gnoGuia
            // 
            this.gnoGuia.DataPropertyName = "noGuia";
            this.gnoGuia.HeaderText = "Tracking number or airbill number";
            this.gnoGuia.Name = "gnoGuia";
            // 
            // gComentarios
            // 
            this.gComentarios.DataPropertyName = "Comentarios";
            this.gComentarios.HeaderText = "Comments";
            this.gComentarios.Name = "gComentarios";
            // 
            // gfechaCapura
            // 
            this.gfechaCapura.DataPropertyName = "fechaCapura";
            dataGridViewCellStyle5.Format = "dd/MM/yy";
            this.gfechaCapura.DefaultCellStyle = dataGridViewCellStyle5;
            this.gfechaCapura.HeaderText = "fechaCapura";
            this.gfechaCapura.Name = "gfechaCapura";
            this.gfechaCapura.Visible = false;
            // 
            // materialesShippingBindingSource
            // 
            this.materialesShippingBindingSource.DataMember = "MaterialesShipping";
            this.materialesShippingBindingSource.DataSource = this.maquinaria;
            
            // 
            // maquinaria
            // 
            this.maquinaria.DataSetName = "Maquinaria";
            this.maquinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialesShippingTableAdapter
            // 
            this.materialesShippingTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNoCamion);
            this.panel1.Controls.Add(this.gpbFiltroFechas);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.BtnActualizar);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Controls.Add(this.txtFechaDespacho);
            this.panel1.Controls.Add(this.txtFechaLlegada);
            this.panel1.Controls.Add(this.txtFechaRBI);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.txtComentarios);
            this.panel1.Controls.Add(this.txtNoGuia);
            this.panel1.Controls.Add(this.txtDomestic);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtConsignee);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTransportista);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPackSum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 159);
            this.panel1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(796, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Comments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "#Trailer";
            // 
            // txtNoCamion
            // 
            this.txtNoCamion.Location = new System.Drawing.Point(6, 76);
            this.txtNoCamion.Name = "txtNoCamion";
            this.txtNoCamion.Size = new System.Drawing.Size(44, 20);
            this.txtNoCamion.TabIndex = 21;
            // 
            // gpbFiltroFechas
            // 
            this.gpbFiltroFechas.Controls.Add(this.btnNoFiltro);
            this.gpbFiltroFechas.Controls.Add(this.btnFiltrar);
            this.gpbFiltroFechas.Controls.Add(this.mtxtFechaFin);
            this.gpbFiltroFechas.Controls.Add(this.label8);
            this.gpbFiltroFechas.Controls.Add(this.mtxtFechaInicio);
            this.gpbFiltroFechas.Controls.Add(this.label7);
            this.gpbFiltroFechas.Location = new System.Drawing.Point(6, 109);
            this.gpbFiltroFechas.Name = "gpbFiltroFechas";
            this.gpbFiltroFechas.Size = new System.Drawing.Size(544, 44);
            this.gpbFiltroFechas.TabIndex = 34;
            this.gpbFiltroFechas.TabStop = false;
            this.gpbFiltroFechas.Text = "Filtrar por Fechas:";
            // 
            // btnNoFiltro
            // 
            this.btnNoFiltro.Location = new System.Drawing.Point(411, 15);
            this.btnNoFiltro.Name = "btnNoFiltro";
            this.btnNoFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnNoFiltro.TabIndex = 4;
            this.btnNoFiltro.Text = "Quitar filtro";
            this.btnNoFiltro.UseVisualStyleBackColor = true;
            this.btnNoFiltro.Click += new System.EventHandler(this.btnNoFiltro_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(329, 15);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // mtxtFechaFin
            // 
            this.mtxtFechaFin.Location = new System.Drawing.Point(238, 15);
            this.mtxtFechaFin.Mask = "00/00/0000";
            this.mtxtFechaFin.Name = "mtxtFechaFin";
            this.mtxtFechaFin.Size = new System.Drawing.Size(83, 20);
            this.mtxtFechaFin.TabIndex = 2;
            this.mtxtFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fecha Fin:";
            // 
            // mtxtFechaInicio
            // 
            this.mtxtFechaInicio.Location = new System.Drawing.Point(85, 15);
            this.mtxtFechaInicio.Mask = "00/00/0000";
            this.mtxtFechaInicio.Name = "mtxtFechaInicio";
            this.mtxtFechaInicio.Size = new System.Drawing.Size(83, 20);
            this.mtxtFechaInicio.TabIndex = 1;
            this.mtxtFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha Inicio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(718, 109);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(637, 109);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 32;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click_1);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(556, 109);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 31;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // txtFechaDespacho
            // 
            this.txtFechaDespacho.Location = new System.Drawing.Point(597, 76);
            this.txtFechaDespacho.Mask = "00/00/0000";
            this.txtFechaDespacho.Name = "txtFechaDespacho";
            this.txtFechaDespacho.Size = new System.Drawing.Size(73, 20);
            this.txtFechaDespacho.TabIndex = 28;
            this.txtFechaDespacho.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaLlegada
            // 
            this.txtFechaLlegada.Location = new System.Drawing.Point(517, 76);
            this.txtFechaLlegada.Mask = "00/00/0000";
            this.txtFechaLlegada.Name = "txtFechaLlegada";
            this.txtFechaLlegada.Size = new System.Drawing.Size(74, 20);
            this.txtFechaLlegada.TabIndex = 27;
            this.txtFechaLlegada.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaRBI
            // 
            this.txtFechaRBI.Location = new System.Drawing.Point(128, 76);
            this.txtFechaRBI.Mask = "00/00/0000";
            this.txtFechaRBI.Name = "txtFechaRBI";
            this.txtFechaRBI.Size = new System.Drawing.Size(70, 20);
            this.txtFechaRBI.TabIndex = 23;
            this.txtFechaRBI.ValidatingType = typeof(System.DateTime);
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(676, 45);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 28);
            this.textBox13.TabIndex = 39;
            this.textBox13.TabStop = false;
            this.textBox13.Text = "Tracking number or airbill number";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(581, 45);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 28);
            this.textBox12.TabIndex = 38;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "Date shipped from RBI";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(504, 36);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(90, 40);
            this.textBox11.TabIndex = 40;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "Date shipped\r\nfrom Labinal\r\nde Mexico";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(118, 32);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(87, 44);
            this.textBox10.TabIndex = 42;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Date & time receeived\r\nin RBI";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(799, 63);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComentarios.Size = new System.Drawing.Size(161, 63);
            this.txtComentarios.TabIndex = 30;
            // 
            // txtNoGuia
            // 
            this.txtNoGuia.Location = new System.Drawing.Point(676, 76);
            this.txtNoGuia.Name = "txtNoGuia";
            this.txtNoGuia.Size = new System.Drawing.Size(100, 20);
            this.txtNoGuia.TabIndex = 29;
            // 
            // txtDomestic
            // 
            this.txtDomestic.Location = new System.Drawing.Point(416, 76);
            this.txtDomestic.Name = "txtDomestic";
            this.txtDomestic.Size = new System.Drawing.Size(95, 20);
            this.txtDomestic.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "DOMESTIC/ INT´L";
            // 
            // txtConsignee
            // 
            this.txtConsignee.Location = new System.Drawing.Point(310, 76);
            this.txtConsignee.Name = "txtConsignee";
            this.txtConsignee.Size = new System.Drawing.Size(100, 20);
            this.txtConsignee.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Consignee";
            // 
            // txtTransportista
            // 
            this.txtTransportista.Location = new System.Drawing.Point(204, 76);
            this.txtTransportista.Name = "txtTransportista";
            this.txtTransportista.Size = new System.Drawing.Size(100, 20);
            this.txtTransportista.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Carrier";
            // 
            // txtPackSum
            // 
            this.txtPackSum.Location = new System.Drawing.Point(56, 76);
            this.txtPackSum.Name = "txtPackSum";
            this.txtPackSum.Size = new System.Drawing.Size(66, 20);
            this.txtPackSum.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "PACKSUM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Labinal de Mexico today\'s shipments USA-Worldwide";
            // 
            // Shipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvShipping);
            this.Name = "Shipping";
            this.Text = "Shipping";
            this.Load += new System.EventHandler(this.Shipping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesShippingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbFiltroFechas.ResumeLayout(false);
            this.gpbFiltroFechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShipping;
        private MaterialCore.DataSets.Maquinaria maquinaria;
        private System.Windows.Forms.BindingSource materialesShippingBindingSource;
        private MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesShippingTableAdapter materialesShippingTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPackSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gfechaRBI;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn gConsignee;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDomestic;
        private System.Windows.Forms.DataGridViewTextBoxColumn gfechaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn gfechaDespacho;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnoGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gComentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn gfechaCapura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoCamion;
        private System.Windows.Forms.GroupBox gpbFiltroFechas;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.MaskedTextBox mtxtFechaFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtFechaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.MaskedTextBox txtFechaDespacho;
        private System.Windows.Forms.MaskedTextBox txtFechaLlegada;
        private System.Windows.Forms.MaskedTextBox txtFechaRBI;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.TextBox txtNoGuia;
        private System.Windows.Forms.TextBox txtDomestic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConsignee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransportista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPackSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoFiltro;
    }
}