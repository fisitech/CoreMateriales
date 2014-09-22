namespace MaterialCore.MaterialesEmbarques
{
    partial class MaterialesEmbarques
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTipoEmbarque = new System.Windows.Forms.ComboBox();
            this.materialesEmbarquesTipoEmbarqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.embarques = new MaterialCore.core_v2DataSet();
            this.comboTransportista = new System.Windows.Forms.ComboBox();
            this.materialesEmbarquesTransportistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.textComentarios = new System.Windows.Forms.TextBox();
            this.labelComentarios = new System.Windows.Forms.Label();
            this.labelTipoEmbarque = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateCaptura = new System.Windows.Forms.DateTimePicker();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.labelCosto = new System.Windows.Forms.Label();
            this.textPackingList = new System.Windows.Forms.TextBox();
            this.labelPackingList = new System.Windows.Forms.Label();
            this.textNoFactura = new System.Windows.Forms.TextBox();
            this.labelNoFactura = new System.Windows.Forms.Label();
            this.textNoPaletas = new System.Windows.Forms.TextBox();
            this.labelNoPaletas = new System.Windows.Forms.Label();
            this.labelTransportista = new System.Windows.Forms.Label();
            this.labelNoTrailer = new System.Windows.Forms.Label();
            this.textNoTrailer = new System.Windows.Forms.TextBox();
            this.materialesEmbarquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMaterialesEmbarques = new System.Windows.Forms.DataGridView();
            this.noTrailerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPaletasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingListDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCapturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEmbarqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesEmbarquesTableAdapter = new MaterialCore.core_v2DataSetTableAdapters.MaterialesEmbarquesTableAdapter();
            this.materialesEmbarquesTransportistaTableAdapter = new MaterialCore.core_v2DataSetTableAdapters.MaterialesEmbarquesTransportistaTableAdapter();
            this.materialesEmbarquesTipoEmbarqueTableAdapter = new MaterialCore.core_v2DataSetTableAdapters.MaterialesEmbarquesTipoEmbarqueTableAdapter();
            this.labelTipoCosto = new System.Windows.Forms.Label();
            this.textTipoCosto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesEmbarquesTipoEmbarqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesEmbarquesTransportistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesEmbarquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesEmbarques)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 149);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTipoCosto);
            this.groupBox1.Controls.Add(this.labelTipoCosto);
            this.groupBox1.Controls.Add(this.comboTipoEmbarque);
            this.groupBox1.Controls.Add(this.comboTransportista);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonInsertar);
            this.groupBox1.Controls.Add(this.textComentarios);
            this.groupBox1.Controls.Add(this.labelComentarios);
            this.groupBox1.Controls.Add(this.labelTipoEmbarque);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.dateCaptura);
            this.groupBox1.Controls.Add(this.textCosto);
            this.groupBox1.Controls.Add(this.labelCosto);
            this.groupBox1.Controls.Add(this.textPackingList);
            this.groupBox1.Controls.Add(this.labelPackingList);
            this.groupBox1.Controls.Add(this.textNoFactura);
            this.groupBox1.Controls.Add(this.labelNoFactura);
            this.groupBox1.Controls.Add(this.textNoPaletas);
            this.groupBox1.Controls.Add(this.labelNoPaletas);
            this.groupBox1.Controls.Add(this.labelTransportista);
            this.groupBox1.Controls.Add(this.labelNoTrailer);
            this.groupBox1.Controls.Add(this.textNoTrailer);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura";
            // 
            // comboTipoEmbarque
            // 
            this.comboTipoEmbarque.DataSource = this.materialesEmbarquesTipoEmbarqueBindingSource;
            this.comboTipoEmbarque.DisplayMember = "tipoEmbarque";
            this.comboTipoEmbarque.FormattingEnabled = true;
            this.comboTipoEmbarque.Location = new System.Drawing.Point(542, 41);
            this.comboTipoEmbarque.Name = "comboTipoEmbarque";
            this.comboTipoEmbarque.Size = new System.Drawing.Size(130, 21);
            this.comboTipoEmbarque.TabIndex = 17;
            this.comboTipoEmbarque.ValueMember = "tipoEmbarque";
            // 
            // materialesEmbarquesTipoEmbarqueBindingSource
            // 
            this.materialesEmbarquesTipoEmbarqueBindingSource.DataMember = "MaterialesEmbarquesTipoEmbarque";
            this.materialesEmbarquesTipoEmbarqueBindingSource.DataSource = this.embarques;
            // 
            // embarques
            // 
            this.embarques.DataSetName = "core_v2DataSet";
            this.embarques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboTransportista
            // 
            this.comboTransportista.DataSource = this.materialesEmbarquesTransportistaBindingSource;
            this.comboTransportista.DisplayMember = "transportista";
            this.comboTransportista.FormattingEnabled = true;
            this.comboTransportista.Location = new System.Drawing.Point(116, 41);
            this.comboTransportista.Name = "comboTransportista";
            this.comboTransportista.Size = new System.Drawing.Size(99, 21);
            this.comboTransportista.TabIndex = 2;
            this.comboTransportista.ValueMember = "transportista";
            // 
            // materialesEmbarquesTransportistaBindingSource
            // 
            this.materialesEmbarquesTransportistaBindingSource.DataMember = "MaterialesEmbarquesTransportista";
            this.materialesEmbarquesTransportistaBindingSource.DataSource = this.embarques;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.Location = new System.Drawing.Point(703, 87);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 12;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(623, 87);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(542, 87);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertar.TabIndex = 10;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // textComentarios
            // 
            this.textComentarios.Location = new System.Drawing.Point(222, 67);
            this.textComentarios.Multiline = true;
            this.textComentarios.Name = "textComentarios";
            this.textComentarios.Size = new System.Drawing.Size(314, 43);
            this.textComentarios.TabIndex = 9;
            // 
            // labelComentarios
            // 
            this.labelComentarios.AutoSize = true;
            this.labelComentarios.Location = new System.Drawing.Point(151, 67);
            this.labelComentarios.Name = "labelComentarios";
            this.labelComentarios.Size = new System.Drawing.Size(65, 13);
            this.labelComentarios.TabIndex = 16;
            this.labelComentarios.Text = "Comentarios";
            // 
            // labelTipoEmbarque
            // 
            this.labelTipoEmbarque.AutoSize = true;
            this.labelTipoEmbarque.Location = new System.Drawing.Point(539, 25);
            this.labelTipoEmbarque.Name = "labelTipoEmbarque";
            this.labelTipoEmbarque.Size = new System.Drawing.Size(93, 13);
            this.labelTipoEmbarque.TabIndex = 15;
            this.labelTipoEmbarque.Text = "Tipo de embarque";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(7, 74);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 13;
            this.labelFecha.Text = "Fecha";
            // 
            // dateCaptura
            // 
            this.dateCaptura.Location = new System.Drawing.Point(10, 90);
            this.dateCaptura.Name = "dateCaptura";
            this.dateCaptura.Size = new System.Drawing.Size(206, 20);
            this.dateCaptura.TabIndex = 8;
            // 
            // textCosto
            // 
            this.textCosto.Location = new System.Drawing.Point(678, 40);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(100, 20);
            this.textCosto.TabIndex = 6;
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Location = new System.Drawing.Point(675, 24);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(34, 13);
            this.labelCosto.TabIndex = 10;
            this.labelCosto.Text = "Costo";
            // 
            // textPackingList
            // 
            this.textPackingList.Location = new System.Drawing.Point(436, 41);
            this.textPackingList.Name = "textPackingList";
            this.textPackingList.Size = new System.Drawing.Size(100, 20);
            this.textPackingList.TabIndex = 5;
            // 
            // labelPackingList
            // 
            this.labelPackingList.AutoSize = true;
            this.labelPackingList.Location = new System.Drawing.Point(433, 25);
            this.labelPackingList.Name = "labelPackingList";
            this.labelPackingList.Size = new System.Drawing.Size(65, 13);
            this.labelPackingList.TabIndex = 8;
            this.labelPackingList.Text = "Packing List";
            // 
            // textNoFactura
            // 
            this.textNoFactura.Location = new System.Drawing.Point(327, 41);
            this.textNoFactura.Name = "textNoFactura";
            this.textNoFactura.Size = new System.Drawing.Size(100, 20);
            this.textNoFactura.TabIndex = 4;
            // 
            // labelNoFactura
            // 
            this.labelNoFactura.AutoSize = true;
            this.labelNoFactura.Location = new System.Drawing.Point(324, 25);
            this.labelNoFactura.Name = "labelNoFactura";
            this.labelNoFactura.Size = new System.Drawing.Size(73, 13);
            this.labelNoFactura.TabIndex = 6;
            this.labelNoFactura.Text = "N° de Factura";
            // 
            // textNoPaletas
            // 
            this.textNoPaletas.Location = new System.Drawing.Point(221, 41);
            this.textNoPaletas.Name = "textNoPaletas";
            this.textNoPaletas.Size = new System.Drawing.Size(100, 20);
            this.textNoPaletas.TabIndex = 3;
            // 
            // labelNoPaletas
            // 
            this.labelNoPaletas.AutoSize = true;
            this.labelNoPaletas.Location = new System.Drawing.Point(218, 25);
            this.labelNoPaletas.Name = "labelNoPaletas";
            this.labelNoPaletas.Size = new System.Drawing.Size(72, 13);
            this.labelNoPaletas.TabIndex = 4;
            this.labelNoPaletas.Text = "N° de Paletas";
            // 
            // labelTransportista
            // 
            this.labelTransportista.AutoSize = true;
            this.labelTransportista.Location = new System.Drawing.Point(113, 25);
            this.labelTransportista.Name = "labelTransportista";
            this.labelTransportista.Size = new System.Drawing.Size(68, 13);
            this.labelTransportista.TabIndex = 2;
            this.labelTransportista.Text = "Transportista";
            // 
            // labelNoTrailer
            // 
            this.labelNoTrailer.AutoSize = true;
            this.labelNoTrailer.Location = new System.Drawing.Point(7, 25);
            this.labelNoTrailer.Name = "labelNoTrailer";
            this.labelNoTrailer.Size = new System.Drawing.Size(66, 13);
            this.labelNoTrailer.TabIndex = 1;
            this.labelNoTrailer.Text = "N° de Trailer";
            // 
            // textNoTrailer
            // 
            this.textNoTrailer.Location = new System.Drawing.Point(10, 41);
            this.textNoTrailer.Name = "textNoTrailer";
            this.textNoTrailer.Size = new System.Drawing.Size(100, 20);
            this.textNoTrailer.TabIndex = 1;
            // 
            // materialesEmbarquesBindingSource
            // 
            this.materialesEmbarquesBindingSource.DataMember = "MaterialesEmbarques";
            this.materialesEmbarquesBindingSource.DataSource = this.embarques;
            // 
            // dgvMaterialesEmbarques
            // 
            this.dgvMaterialesEmbarques.AllowUserToAddRows = false;
            this.dgvMaterialesEmbarques.AllowUserToDeleteRows = false;
            this.dgvMaterialesEmbarques.AllowUserToOrderColumns = true;
            this.dgvMaterialesEmbarques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterialesEmbarques.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterialesEmbarques.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMaterialesEmbarques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialesEmbarques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noTrailerDataGridViewTextBoxColumn,
            this.transportistaDataGridViewTextBoxColumn,
            this.noPaletasDataGridViewTextBoxColumn,
            this.noFacturaDataGridViewTextBoxColumn,
            this.packingListDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.fechaCapturaDataGridViewTextBoxColumn,
            this.comentariosDataGridViewTextBoxColumn,
            this.tipoEmbarqueDataGridViewTextBoxColumn,
            this.id});
            this.dgvMaterialesEmbarques.DataSource = this.materialesEmbarquesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterialesEmbarques.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMaterialesEmbarques.Location = new System.Drawing.Point(12, 161);
            this.dgvMaterialesEmbarques.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMaterialesEmbarques.Name = "dgvMaterialesEmbarques";
            this.dgvMaterialesEmbarques.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterialesEmbarques.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMaterialesEmbarques.Size = new System.Drawing.Size(945, 256);
            this.dgvMaterialesEmbarques.TabIndex = 1;
            this.dgvMaterialesEmbarques.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialesEmbarques_CellContentClick);
            // 
            // noTrailerDataGridViewTextBoxColumn
            // 
            this.noTrailerDataGridViewTextBoxColumn.DataPropertyName = "noTrailer";
            this.noTrailerDataGridViewTextBoxColumn.HeaderText = "N° de Trailer";
            this.noTrailerDataGridViewTextBoxColumn.Name = "noTrailerDataGridViewTextBoxColumn";
            this.noTrailerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transportistaDataGridViewTextBoxColumn
            // 
            this.transportistaDataGridViewTextBoxColumn.DataPropertyName = "transportista";
            this.transportistaDataGridViewTextBoxColumn.HeaderText = "Transportista";
            this.transportistaDataGridViewTextBoxColumn.Name = "transportistaDataGridViewTextBoxColumn";
            this.transportistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noPaletasDataGridViewTextBoxColumn
            // 
            this.noPaletasDataGridViewTextBoxColumn.DataPropertyName = "noPaletas";
            this.noPaletasDataGridViewTextBoxColumn.HeaderText = "N° de Paletas";
            this.noPaletasDataGridViewTextBoxColumn.Name = "noPaletasDataGridViewTextBoxColumn";
            this.noPaletasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noFacturaDataGridViewTextBoxColumn
            // 
            this.noFacturaDataGridViewTextBoxColumn.DataPropertyName = "noFactura";
            this.noFacturaDataGridViewTextBoxColumn.HeaderText = "N° de Factura";
            this.noFacturaDataGridViewTextBoxColumn.Name = "noFacturaDataGridViewTextBoxColumn";
            this.noFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packingListDataGridViewTextBoxColumn
            // 
            this.packingListDataGridViewTextBoxColumn.DataPropertyName = "packingList";
            this.packingListDataGridViewTextBoxColumn.HeaderText = "Packing List";
            this.packingListDataGridViewTextBoxColumn.Name = "packingListDataGridViewTextBoxColumn";
            this.packingListDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCapturaDataGridViewTextBoxColumn
            // 
            this.fechaCapturaDataGridViewTextBoxColumn.DataPropertyName = "fechaCaptura";
            this.fechaCapturaDataGridViewTextBoxColumn.HeaderText = "Captura";
            this.fechaCapturaDataGridViewTextBoxColumn.Name = "fechaCapturaDataGridViewTextBoxColumn";
            this.fechaCapturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentariosDataGridViewTextBoxColumn
            // 
            this.comentariosDataGridViewTextBoxColumn.DataPropertyName = "comentarios";
            this.comentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.Name = "comentariosDataGridViewTextBoxColumn";
            this.comentariosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoEmbarqueDataGridViewTextBoxColumn
            // 
            this.tipoEmbarqueDataGridViewTextBoxColumn.DataPropertyName = "tipoEmbarque";
            this.tipoEmbarqueDataGridViewTextBoxColumn.HeaderText = "Tipo de Embarque";
            this.tipoEmbarqueDataGridViewTextBoxColumn.Name = "tipoEmbarqueDataGridViewTextBoxColumn";
            this.tipoEmbarqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // materialesEmbarquesTableAdapter
            // 
            this.materialesEmbarquesTableAdapter.ClearBeforeFill = true;
            // 
            // materialesEmbarquesTransportistaTableAdapter
            // 
            this.materialesEmbarquesTransportistaTableAdapter.ClearBeforeFill = true;
            // 
            // materialesEmbarquesTipoEmbarqueTableAdapter
            // 
            this.materialesEmbarquesTipoEmbarqueTableAdapter.ClearBeforeFill = true;
            // 
            // labelTipoCosto
            // 
            this.labelTipoCosto.AutoSize = true;
            this.labelTipoCosto.Location = new System.Drawing.Point(781, 20);
            this.labelTipoCosto.Name = "labelTipoCosto";
            this.labelTipoCosto.Size = new System.Drawing.Size(73, 13);
            this.labelTipoCosto.TabIndex = 18;
            this.labelTipoCosto.Text = "Tipo de Costo";
            // 
            // textTipoCosto
            // 
            this.textTipoCosto.Location = new System.Drawing.Point(784, 39);
            this.textTipoCosto.Name = "textTipoCosto";
            this.textTipoCosto.Size = new System.Drawing.Size(100, 20);
            this.textTipoCosto.TabIndex = 19;
            // 
            // MaterialesEmbarques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 426);
            this.Controls.Add(this.dgvMaterialesEmbarques);
            this.Controls.Add(this.panel1);
            this.Name = "MaterialesEmbarques";
            this.Text = "MaterialesEmbarques";
            this.Load += new System.EventHandler(this.MaterialesEmbarques_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesEmbarquesTipoEmbarqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesEmbarquesTransportistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesEmbarquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesEmbarques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNoTrailer;
        private System.Windows.Forms.TextBox textNoTrailer;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.TextBox textPackingList;
        private System.Windows.Forms.Label labelPackingList;
        private System.Windows.Forms.TextBox textNoFactura;
        private System.Windows.Forms.Label labelNoFactura;
        private System.Windows.Forms.TextBox textNoPaletas;
        private System.Windows.Forms.Label labelNoPaletas;
        private System.Windows.Forms.Label labelTransportista;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateCaptura;
        private System.Windows.Forms.TextBox textComentarios;
        private System.Windows.Forms.Label labelComentarios;
        private System.Windows.Forms.Label labelTipoEmbarque;
        private System.Windows.Forms.DataGridView dgvMaterialesEmbarques;
        private System.Windows.Forms.BindingSource materialesEmbarquesBindingSource;
        private MaterialCore.core_v2DataSetTableAdapters.MaterialesEmbarquesTableAdapter materialesEmbarquesTableAdapter;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonInsertar;
        private core_v2DataSet embarques;
        private System.Windows.Forms.ComboBox comboTransportista;
        private System.Windows.Forms.BindingSource materialesEmbarquesTransportistaBindingSource;
        private MaterialCore.core_v2DataSetTableAdapters.MaterialesEmbarquesTransportistaTableAdapter materialesEmbarquesTransportistaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTrailerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPaletasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCapturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEmbarqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.ComboBox comboTipoEmbarque;
        private System.Windows.Forms.BindingSource materialesEmbarquesTipoEmbarqueBindingSource;
        private MaterialCore.core_v2DataSetTableAdapters.MaterialesEmbarquesTipoEmbarqueTableAdapter materialesEmbarquesTipoEmbarqueTableAdapter;
        private System.Windows.Forms.TextBox textTipoCosto;
        private System.Windows.Forms.Label labelTipoCosto;
    }
}