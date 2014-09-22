namespace MaterialCore.OrdenesCompra
{
    partial class EscanearPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscanearPL));
            this.dgvEscanear = new System.Windows.Forms.DataGridView();
            this.gId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNid_sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gEscanear = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.escaneadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.skuescanearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.embarques = new MaterialCore.DataSets.Embarques();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscarsku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAsosiar = new System.Windows.Forms.Button();
            this.btnBuscaArchivo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnCargaArchivo = new System.Windows.Forms.Button();
            this.pLSinEscanearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLSinEscanearTableAdapter = new MaterialCore.DataSets.EmbarquesTableAdapters.PLSinEscanearTableAdapter();
            this.sku_escanearTableAdapter = new MaterialCore.DataSets.EmbarquesTableAdapters.sku_escanearTableAdapter();
            this.chkEscaneados = new System.Windows.Forms.CheckBox();
            this.lblMensaje = new System.Windows.Forms.TextBox();
            this.txtMaster = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscanear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuescanearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLSinEscanearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEscanear
            // 
            this.dgvEscanear.AllowUserToAddRows = false;
            this.dgvEscanear.AllowUserToDeleteRows = false;
            this.dgvEscanear.AllowUserToResizeRows = false;
            this.dgvEscanear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvEscanear.AutoGenerateColumns = false;
            this.dgvEscanear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscanear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gId,
            this.gNid_sku,
            this.fechaDataGridViewTextBoxColumn,
            this.gEscanear,
            this.escaneadoDataGridViewCheckBoxColumn});
            this.dgvEscanear.DataSource = this.skuescanearBindingSource;
            this.dgvEscanear.Location = new System.Drawing.Point(12, 12);
            this.dgvEscanear.Name = "dgvEscanear";
            this.dgvEscanear.RowHeadersVisible = false;
            this.dgvEscanear.RowHeadersWidth = 24;
            this.dgvEscanear.Size = new System.Drawing.Size(474, 468);
            this.dgvEscanear.TabIndex = 4;
            this.dgvEscanear.TabStop = false;
            // 
            // gId
            // 
            this.gId.DataPropertyName = "id";
            this.gId.HeaderText = "id";
            this.gId.Name = "gId";
            this.gId.ReadOnly = true;
            this.gId.Visible = false;
            this.gId.Width = 80;
            // 
            // gNid_sku
            // 
            this.gNid_sku.DataPropertyName = "nid_sku";
            this.gNid_sku.HeaderText = "Número de Guia";
            this.gNid_sku.Name = "gNid_sku";
            this.gNid_sku.ReadOnly = true;
            this.gNid_sku.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gNid_sku.Width = 200;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gEscanear
            // 
            this.gEscanear.FillWeight = 30F;
            this.gEscanear.HeaderText = "Digitalizar";
            this.gEscanear.Name = "gEscanear";
            this.gEscanear.Width = 80;
            // 
            // escaneadoDataGridViewCheckBoxColumn
            // 
            this.escaneadoDataGridViewCheckBoxColumn.DataPropertyName = "escaneado";
            this.escaneadoDataGridViewCheckBoxColumn.HeaderText = "escaneado";
            this.escaneadoDataGridViewCheckBoxColumn.Name = "escaneadoDataGridViewCheckBoxColumn";
            this.escaneadoDataGridViewCheckBoxColumn.Visible = false;
            this.escaneadoDataGridViewCheckBoxColumn.Width = 80;
            // 
            // skuescanearBindingSource
            // 
            this.skuescanearBindingSource.DataMember = "sku_escanear";
            this.skuescanearBindingSource.DataSource = this.embarques;
            // 
            // embarques
            // 
            this.embarques.DataSetName = "Embarques";
            this.embarques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "&Digitalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscarsku
            // 
            this.txtBuscarsku.Location = new System.Drawing.Point(492, 82);
            this.txtBuscarsku.Name = "txtBuscarsku";
            this.txtBuscarsku.Size = new System.Drawing.Size(262, 20);
            this.txtBuscarsku.TabIndex = 1;
            this.txtBuscarsku.TextChanged += new System.EventHandler(this.txtBuscarsku_TextChanged);
            this.txtBuscarsku.Click += new System.EventHandler(this.txtBuscarsku_Click);
            this.txtBuscarsku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarsku_KeyPress);
            this.txtBuscarsku.Enter += new System.EventHandler(this.txtBuscarsku_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Buscar No. Guia:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(679, 108);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(397, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Probar digitalizador";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAsosiar
            // 
            this.btnAsosiar.Enabled = false;
            this.btnAsosiar.Location = new System.Drawing.Point(577, 318);
            this.btnAsosiar.Name = "btnAsosiar";
            this.btnAsosiar.Size = new System.Drawing.Size(126, 42);
            this.btnAsosiar.TabIndex = 7;
            this.btnAsosiar.Text = "Asociar Guias a PL";
            this.btnAsosiar.UseVisualStyleBackColor = true;
            this.btnAsosiar.Visible = false;
            this.btnAsosiar.Click += new System.EventHandler(this.btnAsosiar_Click);
            // 
            // btnBuscaArchivo
            // 
            this.btnBuscaArchivo.Location = new System.Drawing.Point(42, 78);
            this.btnBuscaArchivo.Name = "btnBuscaArchivo";
            this.btnBuscaArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaArchivo.TabIndex = 8;
            this.btnBuscaArchivo.Text = "Buscar";
            this.btnBuscaArchivo.UseVisualStyleBackColor = true;
            this.btnBuscaArchivo.Click += new System.EventHandler(this.btnBuscaArchivo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArchivo);
            this.groupBox1.Controls.Add(this.btnCargaArchivo);
            this.groupBox1.Controls.Add(this.btnBuscaArchivo);
            this.groupBox1.Location = new System.Drawing.Point(495, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 107);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga Manual";
            // 
            // txtArchivo
            // 
            this.txtArchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArchivo.Location = new System.Drawing.Point(6, 19);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(274, 53);
            this.txtArchivo.TabIndex = 10;
            // 
            // btnCargaArchivo
            // 
            this.btnCargaArchivo.Location = new System.Drawing.Point(123, 78);
            this.btnCargaArchivo.Name = "btnCargaArchivo";
            this.btnCargaArchivo.Size = new System.Drawing.Size(157, 23);
            this.btnCargaArchivo.TabIndex = 9;
            this.btnCargaArchivo.Text = "Cargar archivo y asociar";
            this.btnCargaArchivo.UseVisualStyleBackColor = true;
            this.btnCargaArchivo.Click += new System.EventHandler(this.btnCargaArchivo_Click);
            // 
            // pLSinEscanearBindingSource
            // 
            this.pLSinEscanearBindingSource.DataMember = "PLSinEscanear";
            this.pLSinEscanearBindingSource.DataSource = this.embarques;
            // 
            // pLSinEscanearTableAdapter
            // 
            this.pLSinEscanearTableAdapter.ClearBeforeFill = true;
            // 
            // sku_escanearTableAdapter
            // 
            this.sku_escanearTableAdapter.ClearBeforeFill = true;
            // 
            // chkEscaneados
            // 
            this.chkEscaneados.AutoSize = true;
            this.chkEscaneados.Location = new System.Drawing.Point(492, 109);
            this.chkEscaneados.Name = "chkEscaneados";
            this.chkEscaneados.Size = new System.Drawing.Size(123, 17);
            this.chkEscaneados.TabIndex = 10;
            this.chkEscaneados.Text = "Mostrar Digitalizados";
            this.chkEscaneados.UseVisualStyleBackColor = true;
            this.chkEscaneados.CheckedChanged += new System.EventHandler(this.chkEscaneados_CheckedChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.SystemColors.Control;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblMensaje.Location = new System.Drawing.Point(495, 152);
            this.lblMensaje.Multiline = true;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblMensaje.Size = new System.Drawing.Size(286, 112);
            this.lblMensaje.TabIndex = 11;
            this.lblMensaje.Text = "Etiqueta se asocio exitosamente";
            this.lblMensaje.Visible = false;
            // 
            // txtMaster
            // 
            this.txtMaster.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaster.Location = new System.Drawing.Point(584, 9);
            this.txtMaster.Name = "txtMaster";
            this.txtMaster.Size = new System.Drawing.Size(177, 20);
            this.txtMaster.TabIndex = 13;
            this.txtMaster.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(492, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Guia Master:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // EscanearPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 492);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtMaster);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.chkEscaneados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAsosiar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarsku);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEscanear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EscanearPL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitalizador de documentos";
            this.Load += new System.EventHandler(this.EscanearPL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscanear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuescanearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLSinEscanearBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEscanear;
        private System.Windows.Forms.Button button1;
        private MaterialCore.DataSets.Embarques embarques;
        private System.Windows.Forms.BindingSource pLSinEscanearBindingSource;
        private MaterialCore.DataSets.EmbarquesTableAdapters.PLSinEscanearTableAdapter pLSinEscanearTableAdapter;
        private System.Windows.Forms.BindingSource skuescanearBindingSource;
        private MaterialCore.DataSets.EmbarquesTableAdapters.sku_escanearTableAdapter sku_escanearTableAdapter;
        private System.Windows.Forms.TextBox txtBuscarsku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAsosiar;
        private System.Windows.Forms.Button btnBuscaArchivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCargaArchivo;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.CheckBox chkEscaneados;
        private System.Windows.Forms.TextBox lblMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn gId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNid_sku;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gEscanear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn escaneadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txtMaster;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}