namespace MaterialCore.MaterialesMQ
{
    partial class LineasPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineasPO));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvLineas = new System.Windows.Forms.DataGridView();
            this.gPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNoParte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDescripcionParte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadAbiertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPqOrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPqRec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadRecibidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bultosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noGuiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesMaquinariaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesOCMeQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maquinaria = new MaterialCore.DataSets.Maquinaria();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDev = new System.Windows.Forms.Button();
            this.txtDevPO = new System.Windows.Forms.TextBox();
            this.txtDevLinea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDevolucion = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProveedorDes = new System.Windows.Forms.TextBox();
            this.txtProveedorID = new System.Windows.Forms.TextBox();
            this.materialesOCMeQTableAdapter = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesOCMeQTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesOCMeQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).BeginInit();
            this.pnlDevolucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(780, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(699, 425);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvLineas
            // 
            this.dgvLineas.AllowUserToAddRows = false;
            this.dgvLineas.AllowUserToDeleteRows = false;
            this.dgvLineas.AutoGenerateColumns = false;
            this.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gPO,
            this.gClienteId,
            this.gLinea,
            this.gNoParte,
            this.gDescripcionParte,
            this.cantidadAbiertaDataGridViewTextBoxColumn,
            this.gPqOrd,
            this.gPqRec,
            this.precioDataGridViewTextBoxColumn,
            this.gProveedorID,
            this.gNombreProveedor,
            this.cantidadRecibidaDataGridViewTextBoxColumn,
            this.gUnidadMedida,
            this.facturaProveedorDataGridViewTextBoxColumn,
            this.bultosDataGridViewTextBoxColumn,
            this.noGuiaDataGridViewTextBoxColumn,
            this.gMoneda,
            this.plantaDataGridViewTextBoxColumn,
            this.materialesMaquinariaIDDataGridViewTextBoxColumn});
            this.dgvLineas.DataSource = this.materialesOCMeQBindingSource;
            this.dgvLineas.Location = new System.Drawing.Point(12, 36);
            this.dgvLineas.Name = "dgvLineas";
            this.dgvLineas.ReadOnly = true;
            this.dgvLineas.RowHeadersVisible = false;
            this.dgvLineas.Size = new System.Drawing.Size(843, 369);
            this.dgvLineas.TabIndex = 0;
            this.dgvLineas.DoubleClick += new System.EventHandler(this.dgvLineas_DoubleClick);
            this.dgvLineas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvLineas_KeyDown);
            // 
            // gPO
            // 
            this.gPO.DataPropertyName = "Id";
            this.gPO.HeaderText = "Id";
            this.gPO.Name = "gPO";
            this.gPO.ReadOnly = true;
            // 
            // gClienteId
            // 
            this.gClienteId.DataPropertyName = "ClienteId";
            this.gClienteId.HeaderText = "ClienteId";
            this.gClienteId.Name = "gClienteId";
            this.gClienteId.ReadOnly = true;
            // 
            // gLinea
            // 
            this.gLinea.DataPropertyName = "RenglonId";
            this.gLinea.HeaderText = "RenglonId";
            this.gLinea.Name = "gLinea";
            this.gLinea.ReadOnly = true;
            // 
            // gNoParte
            // 
            this.gNoParte.DataPropertyName = "NumeroParte";
            this.gNoParte.HeaderText = "NumeroParte";
            this.gNoParte.Name = "gNoParte";
            this.gNoParte.ReadOnly = true;
            // 
            // gDescripcionParte
            // 
            this.gDescripcionParte.DataPropertyName = "Descripcion";
            this.gDescripcionParte.HeaderText = "Descripcion";
            this.gDescripcionParte.Name = "gDescripcionParte";
            this.gDescripcionParte.ReadOnly = true;
            // 
            // cantidadAbiertaDataGridViewTextBoxColumn
            // 
            this.cantidadAbiertaDataGridViewTextBoxColumn.DataPropertyName = "CantidadAbierta";
            this.cantidadAbiertaDataGridViewTextBoxColumn.HeaderText = "CantidadAbierta";
            this.cantidadAbiertaDataGridViewTextBoxColumn.Name = "cantidadAbiertaDataGridViewTextBoxColumn";
            this.cantidadAbiertaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gProveedorID
            // 
            this.gProveedorID.DataPropertyName = "ProveedorID";
            this.gProveedorID.HeaderText = "ProveedorID";
            this.gProveedorID.Name = "gProveedorID";
            this.gProveedorID.ReadOnly = true;
            // 
            // gNombreProveedor
            // 
            this.gNombreProveedor.DataPropertyName = "NombreProveedor";
            this.gNombreProveedor.HeaderText = "NombreProveedor";
            this.gNombreProveedor.Name = "gNombreProveedor";
            this.gNombreProveedor.ReadOnly = true;
            // 
            // cantidadRecibidaDataGridViewTextBoxColumn
            // 
            this.cantidadRecibidaDataGridViewTextBoxColumn.DataPropertyName = "CantidadRecibida";
            this.cantidadRecibidaDataGridViewTextBoxColumn.HeaderText = "CantidadRecibida";
            this.cantidadRecibidaDataGridViewTextBoxColumn.Name = "cantidadRecibidaDataGridViewTextBoxColumn";
            this.cantidadRecibidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gUnidadMedida
            // 
            this.gUnidadMedida.DataPropertyName = "UnidadMedida";
            this.gUnidadMedida.HeaderText = "UnidadMedida";
            this.gUnidadMedida.Name = "gUnidadMedida";
            this.gUnidadMedida.ReadOnly = true;
            // 
            // facturaProveedorDataGridViewTextBoxColumn
            // 
            this.facturaProveedorDataGridViewTextBoxColumn.DataPropertyName = "FacturaProveedor";
            this.facturaProveedorDataGridViewTextBoxColumn.HeaderText = "FacturaProveedor";
            this.facturaProveedorDataGridViewTextBoxColumn.Name = "facturaProveedorDataGridViewTextBoxColumn";
            this.facturaProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bultosDataGridViewTextBoxColumn
            // 
            this.bultosDataGridViewTextBoxColumn.DataPropertyName = "Bultos";
            this.bultosDataGridViewTextBoxColumn.HeaderText = "Bultos";
            this.bultosDataGridViewTextBoxColumn.Name = "bultosDataGridViewTextBoxColumn";
            this.bultosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noGuiaDataGridViewTextBoxColumn
            // 
            this.noGuiaDataGridViewTextBoxColumn.DataPropertyName = "NoGuia";
            this.noGuiaDataGridViewTextBoxColumn.HeaderText = "NoGuia";
            this.noGuiaDataGridViewTextBoxColumn.Name = "noGuiaDataGridViewTextBoxColumn";
            this.noGuiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gMoneda
            // 
            this.gMoneda.DataPropertyName = "Moneda";
            this.gMoneda.HeaderText = "Moneda";
            this.gMoneda.Name = "gMoneda";
            this.gMoneda.ReadOnly = true;
            // 
            // plantaDataGridViewTextBoxColumn
            // 
            this.plantaDataGridViewTextBoxColumn.DataPropertyName = "Planta";
            this.plantaDataGridViewTextBoxColumn.HeaderText = "Planta";
            this.plantaDataGridViewTextBoxColumn.Name = "plantaDataGridViewTextBoxColumn";
            this.plantaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialesMaquinariaIDDataGridViewTextBoxColumn
            // 
            this.materialesMaquinariaIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialesMaquinariaID";
            this.materialesMaquinariaIDDataGridViewTextBoxColumn.HeaderText = "MaterialesMaquinariaID";
            this.materialesMaquinariaIDDataGridViewTextBoxColumn.Name = "materialesMaquinariaIDDataGridViewTextBoxColumn";
            this.materialesMaquinariaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialesOCMeQBindingSource
            // 
            this.materialesOCMeQBindingSource.DataMember = "MaterialesOCMeQ";
            this.materialesOCMeQBindingSource.DataSource = this.maquinaria;
            // 
            // maquinaria
            // 
            this.maquinaria.DataSetName = "Maquinaria";
            this.maquinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(96, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(43, 9);
            this.txtPO.MaxLength = 6;
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(47, 20);
            this.txtPO.TabIndex = 4;
            this.txtPO.Text = "000000";
            this.txtPO.TextChanged += new System.EventHandler(this.txtPO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PO:";
            // 
            // btnDev
            // 
            this.btnDev.Location = new System.Drawing.Point(392, 32);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(75, 23);
            this.btnDev.TabIndex = 8;
            this.btnDev.Text = "Aceptar";
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // txtDevPO
            // 
            this.txtDevPO.Location = new System.Drawing.Point(9, 35);
            this.txtDevPO.MaxLength = 6;
            this.txtDevPO.Name = "txtDevPO";
            this.txtDevPO.Size = new System.Drawing.Size(47, 20);
            this.txtDevPO.TabIndex = 1;
            // 
            // txtDevLinea
            // 
            this.txtDevLinea.Location = new System.Drawing.Point(62, 35);
            this.txtDevLinea.MaxLength = 3;
            this.txtDevLinea.Name = "txtDevLinea";
            this.txtDevLinea.Size = new System.Drawing.Size(37, 20);
            this.txtDevLinea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PO:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Linea:";
            // 
            // pnlDevolucion
            // 
            this.pnlDevolucion.Controls.Add(this.label5);
            this.pnlDevolucion.Controls.Add(this.label4);
            this.pnlDevolucion.Controls.Add(this.txtProveedorDes);
            this.pnlDevolucion.Controls.Add(this.txtProveedorID);
            this.pnlDevolucion.Controls.Add(this.label2);
            this.pnlDevolucion.Controls.Add(this.btnDev);
            this.pnlDevolucion.Controls.Add(this.label3);
            this.pnlDevolucion.Controls.Add(this.txtDevPO);
            this.pnlDevolucion.Controls.Add(this.txtDevLinea);
            this.pnlDevolucion.Location = new System.Drawing.Point(12, 411);
            this.pnlDevolucion.Name = "pnlDevolucion";
            this.pnlDevolucion.Size = new System.Drawing.Size(476, 67);
            this.pnlDevolucion.TabIndex = 3;
            this.pnlDevolucion.TabStop = false;
            this.pnlDevolucion.Text = "Garantia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripcion Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id Proveedor:";
            // 
            // txtProveedorDes
            // 
            this.txtProveedorDes.Location = new System.Drawing.Point(187, 35);
            this.txtProveedorDes.Name = "txtProveedorDes";
            this.txtProveedorDes.Size = new System.Drawing.Size(185, 20);
            this.txtProveedorDes.TabIndex = 7;
            // 
            // txtProveedorID
            // 
            this.txtProveedorID.Location = new System.Drawing.Point(105, 35);
            this.txtProveedorID.Name = "txtProveedorID";
            this.txtProveedorID.Size = new System.Drawing.Size(76, 20);
            this.txtProveedorID.TabIndex = 5;
            // 
            // materialesOCMeQTableAdapter
            // 
            this.materialesOCMeQTableAdapter.ClearBeforeFill = true;
            // 
            // LineasPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 484);
            this.Controls.Add(this.pnlDevolucion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPO);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvLineas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LineasPO";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lineas disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesOCMeQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).EndInit();
            this.pnlDevolucion.ResumeLayout(false);
            this.pnlDevolucion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvLineas;
        private System.Windows.Forms.BindingSource materialesOCMeQBindingSource;
        private MaterialCore.DataSets.Maquinaria maquinaria;
        private MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesOCMeQTableAdapter materialesOCMeQTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNoParte;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDescripcionParte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadAbiertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPqOrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPqRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadRecibidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bultosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noGuiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialesMaquinariaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.TextBox txtDevPO;
        private System.Windows.Forms.TextBox txtDevLinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox pnlDevolucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProveedorDes;
        private System.Windows.Forms.TextBox txtProveedorID;
    }
}