namespace MaterialCore.Embarques
{
    partial class EmbarquesEmbiados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmbarquesEmbiados));
            this.dgbPartidas = new System.Windows.Forms.DataGridView();
            this.txtNoGuia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoParte = new System.Windows.Forms.TextBox();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtNoCaja = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.partidasDespachadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.embarques = new MaterialCore.DataSets.Embarques();
            this.partidasDespachadasTableAdapter = new MaterialCore.DataSets.EmbarquesTableAdapters.PartidasDespachadasTableAdapter();
            this.txtEmbarque = new System.Windows.Forms.TextBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fechallegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutivoEmbarqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePaletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPaletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadBultosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nidskuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEndSelectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesOCIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renglonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroParteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvetranspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escaneadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPartidas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partidasDespachadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbPartidas
            // 
            this.dgbPartidas.AllowUserToAddRows = false;
            this.dgbPartidas.AllowUserToDeleteRows = false;
            this.dgbPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbPartidas.AutoGenerateColumns = false;
            this.dgbPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechallegadaDataGridViewTextBoxColumn,
            this.consecutivoEmbarqueDataGridViewTextBoxColumn,
            this.consecutivoDataGridViewTextBoxColumn,
            this.nombrePaletaDataGridViewTextBoxColumn,
            this.numeroPaletaDataGridViewTextBoxColumn,
            this.plantaDataGridViewTextBoxColumn,
            this.pesoBrutoDataGridViewTextBoxColumn,
            this.cantidadBultosDataGridViewTextBoxColumn,
            this.nidskuDataGridViewTextBoxColumn,
            this.dEndSelectionDataGridViewTextBoxColumn,
            this.materialesOCIdDataGridViewTextBoxColumn,
            this.renglonIdDataGridViewTextBoxColumn,
            this.facturaProveedorDataGridViewTextBoxColumn,
            this.numeroParteDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.proveedorIdDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.cboxnumberDataGridViewTextBoxColumn,
            this.cvetranspDataGridViewTextBoxColumn,
            this.escaneadoDataGridViewCheckBoxColumn});
            this.dgbPartidas.DataSource = this.partidasDespachadasBindingSource;
            this.dgbPartidas.Location = new System.Drawing.Point(12, 104);
            this.dgbPartidas.Name = "dgbPartidas";
            this.dgbPartidas.ReadOnly = true;
            this.dgbPartidas.Size = new System.Drawing.Size(1228, 605);
            this.dgbPartidas.TabIndex = 1;
            // 
            // txtNoGuia
            // 
            this.txtNoGuia.Location = new System.Drawing.Point(378, 21);
            this.txtNoGuia.Name = "txtNoGuia";
            this.txtNoGuia.Size = new System.Drawing.Size(140, 20);
            this.txtNoGuia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "No. Guia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. Parte:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PO:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Linea:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "No. Caja:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNoParte
            // 
            this.txtNoParte.Location = new System.Drawing.Point(599, 21);
            this.txtNoParte.Name = "txtNoParte";
            this.txtNoParte.Size = new System.Drawing.Size(114, 20);
            this.txtNoParte.TabIndex = 6;
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(378, 47);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(48, 20);
            this.txtPO.TabIndex = 4;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(488, 47);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(30, 20);
            this.txtLinea.TabIndex = 5;
            // 
            // txtNoCaja
            // 
            this.txtNoCaja.Location = new System.Drawing.Point(244, 21);
            this.txtNoCaja.Name = "txtNoCaja";
            this.txtNoCaja.Size = new System.Drawing.Size(54, 20);
            this.txtNoCaja.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNoCaja);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNoGuia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConsecutivo);
            this.groupBox1.Controls.Add(this.txtLinea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmbarque);
            this.groupBox1.Controls.Add(this.txtPO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNoParte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1228, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fitros de busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1124, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 36);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // partidasDespachadasBindingSource
            // 
            this.partidasDespachadasBindingSource.DataMember = "PartidasDespachadas";
            this.partidasDespachadasBindingSource.DataSource = this.embarques;
            // 
            // embarques
            // 
            this.embarques.DataSetName = "Embarques";
            this.embarques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partidasDespachadasTableAdapter
            // 
            this.partidasDespachadasTableAdapter.ClearBeforeFill = true;
            // 
            // txtEmbarque
            // 
            this.txtEmbarque.Location = new System.Drawing.Point(79, 21);
            this.txtEmbarque.Name = "txtEmbarque";
            this.txtEmbarque.Size = new System.Drawing.Size(100, 20);
            this.txtEmbarque.TabIndex = 0;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(79, 47);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(100, 20);
            this.txtConsecutivo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Embarque:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Consecutivo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar Filtros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechallegadaDataGridViewTextBoxColumn
            // 
            this.fechallegadaDataGridViewTextBoxColumn.DataPropertyName = "Fechallegada";
            this.fechallegadaDataGridViewTextBoxColumn.HeaderText = "FechaLlegada";
            this.fechallegadaDataGridViewTextBoxColumn.Name = "fechallegadaDataGridViewTextBoxColumn";
            this.fechallegadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consecutivoEmbarqueDataGridViewTextBoxColumn
            // 
            this.consecutivoEmbarqueDataGridViewTextBoxColumn.DataPropertyName = "ConsecutivoEmbarque";
            this.consecutivoEmbarqueDataGridViewTextBoxColumn.HeaderText = "Embarque";
            this.consecutivoEmbarqueDataGridViewTextBoxColumn.Name = "consecutivoEmbarqueDataGridViewTextBoxColumn";
            this.consecutivoEmbarqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consecutivoDataGridViewTextBoxColumn
            // 
            this.consecutivoDataGridViewTextBoxColumn.DataPropertyName = "Consecutivo";
            this.consecutivoDataGridViewTextBoxColumn.HeaderText = "Consecutivo";
            this.consecutivoDataGridViewTextBoxColumn.Name = "consecutivoDataGridViewTextBoxColumn";
            this.consecutivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePaletaDataGridViewTextBoxColumn
            // 
            this.nombrePaletaDataGridViewTextBoxColumn.DataPropertyName = "NombrePaleta";
            this.nombrePaletaDataGridViewTextBoxColumn.HeaderText = "NombrePaleta";
            this.nombrePaletaDataGridViewTextBoxColumn.Name = "nombrePaletaDataGridViewTextBoxColumn";
            this.nombrePaletaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroPaletaDataGridViewTextBoxColumn
            // 
            this.numeroPaletaDataGridViewTextBoxColumn.DataPropertyName = "NumeroPaleta";
            this.numeroPaletaDataGridViewTextBoxColumn.HeaderText = "NumeroPaleta";
            this.numeroPaletaDataGridViewTextBoxColumn.Name = "numeroPaletaDataGridViewTextBoxColumn";
            this.numeroPaletaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plantaDataGridViewTextBoxColumn
            // 
            this.plantaDataGridViewTextBoxColumn.DataPropertyName = "Planta";
            this.plantaDataGridViewTextBoxColumn.HeaderText = "Planta";
            this.plantaDataGridViewTextBoxColumn.Name = "plantaDataGridViewTextBoxColumn";
            this.plantaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoBrutoDataGridViewTextBoxColumn
            // 
            this.pesoBrutoDataGridViewTextBoxColumn.DataPropertyName = "PesoBruto";
            this.pesoBrutoDataGridViewTextBoxColumn.HeaderText = "PesoBruto";
            this.pesoBrutoDataGridViewTextBoxColumn.Name = "pesoBrutoDataGridViewTextBoxColumn";
            this.pesoBrutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadBultosDataGridViewTextBoxColumn
            // 
            this.cantidadBultosDataGridViewTextBoxColumn.DataPropertyName = "CantidadBultos";
            this.cantidadBultosDataGridViewTextBoxColumn.HeaderText = "CantidadBultos";
            this.cantidadBultosDataGridViewTextBoxColumn.Name = "cantidadBultosDataGridViewTextBoxColumn";
            this.cantidadBultosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nidskuDataGridViewTextBoxColumn
            // 
            this.nidskuDataGridViewTextBoxColumn.DataPropertyName = "nid_sku";
            this.nidskuDataGridViewTextBoxColumn.HeaderText = "Eti. Azul";
            this.nidskuDataGridViewTextBoxColumn.Name = "nidskuDataGridViewTextBoxColumn";
            this.nidskuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dEndSelectionDataGridViewTextBoxColumn
            // 
            this.dEndSelectionDataGridViewTextBoxColumn.DataPropertyName = "dEndSelection";
            this.dEndSelectionDataGridViewTextBoxColumn.HeaderText = "FechaDespacho";
            this.dEndSelectionDataGridViewTextBoxColumn.Name = "dEndSelectionDataGridViewTextBoxColumn";
            this.dEndSelectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialesOCIdDataGridViewTextBoxColumn
            // 
            this.materialesOCIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialesOCId";
            this.materialesOCIdDataGridViewTextBoxColumn.HeaderText = "PO";
            this.materialesOCIdDataGridViewTextBoxColumn.Name = "materialesOCIdDataGridViewTextBoxColumn";
            this.materialesOCIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // renglonIdDataGridViewTextBoxColumn
            // 
            this.renglonIdDataGridViewTextBoxColumn.DataPropertyName = "RenglonId";
            this.renglonIdDataGridViewTextBoxColumn.HeaderText = "Linea";
            this.renglonIdDataGridViewTextBoxColumn.Name = "renglonIdDataGridViewTextBoxColumn";
            this.renglonIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaProveedorDataGridViewTextBoxColumn
            // 
            this.facturaProveedorDataGridViewTextBoxColumn.DataPropertyName = "FacturaProveedor";
            this.facturaProveedorDataGridViewTextBoxColumn.HeaderText = "FacturaProveedor";
            this.facturaProveedorDataGridViewTextBoxColumn.Name = "facturaProveedorDataGridViewTextBoxColumn";
            this.facturaProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroParteDataGridViewTextBoxColumn
            // 
            this.numeroParteDataGridViewTextBoxColumn.DataPropertyName = "NumeroParte";
            this.numeroParteDataGridViewTextBoxColumn.HeaderText = "NumeroParte";
            this.numeroParteDataGridViewTextBoxColumn.Name = "numeroParteDataGridViewTextBoxColumn";
            this.numeroParteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorIdDataGridViewTextBoxColumn
            // 
            this.proveedorIdDataGridViewTextBoxColumn.DataPropertyName = "ProveedorId";
            this.proveedorIdDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorIdDataGridViewTextBoxColumn.Name = "proveedorIdDataGridViewTextBoxColumn";
            this.proveedorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cboxnumberDataGridViewTextBoxColumn
            // 
            this.cboxnumberDataGridViewTextBoxColumn.DataPropertyName = "cbox_number";
            this.cboxnumberDataGridViewTextBoxColumn.HeaderText = "Caja";
            this.cboxnumberDataGridViewTextBoxColumn.Name = "cboxnumberDataGridViewTextBoxColumn";
            this.cboxnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cvetranspDataGridViewTextBoxColumn
            // 
            this.cvetranspDataGridViewTextBoxColumn.DataPropertyName = "cve_transp";
            this.cvetranspDataGridViewTextBoxColumn.HeaderText = "Transportista";
            this.cvetranspDataGridViewTextBoxColumn.Name = "cvetranspDataGridViewTextBoxColumn";
            this.cvetranspDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // escaneadoDataGridViewCheckBoxColumn
            // 
            this.escaneadoDataGridViewCheckBoxColumn.DataPropertyName = "escaneado";
            this.escaneadoDataGridViewCheckBoxColumn.HeaderText = "escaneado";
            this.escaneadoDataGridViewCheckBoxColumn.Name = "escaneadoDataGridViewCheckBoxColumn";
            this.escaneadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // EmbarquesEmbiados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 721);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgbPartidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmbarquesEmbiados";
            this.Text = "Embarques enviados";
            this.Load += new System.EventHandler(this.EmbarquesEmbiados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbPartidas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partidasDespachadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbPartidas;
        private System.Windows.Forms.TextBox txtNoGuia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoParte;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtNoCaja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource partidasDespachadasBindingSource;
        private MaterialCore.DataSets.Embarques embarques;
        private MaterialCore.DataSets.EmbarquesTableAdapters.PartidasDespachadasTableAdapter partidasDespachadasTableAdapter;
        private System.Windows.Forms.TextBox txtEmbarque;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechallegadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutivoEmbarqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePaletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPaletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadBultosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nidskuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEndSelectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialesOCIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renglonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboxnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvetranspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn escaneadoDataGridViewCheckBoxColumn;
    }
}