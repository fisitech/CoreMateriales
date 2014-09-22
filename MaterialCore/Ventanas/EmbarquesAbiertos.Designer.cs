namespace MaterialCore.Ventanas
{
    partial class EmbarquesAbiertos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmbarquesAbiertos));
            this.dgvEmbarques = new System.Windows.Forms.DataGridView();
            this.niddeployDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nid_arrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvetranspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbox_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguide_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despachosAbiertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogos = new MaterialCore.DataSets.Catalogos();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbTransportista = new System.Windows.Forms.ComboBox();
            this.transportistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoCaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.despachosAbiertosTableAdapter = new MaterialCore.DataSets.CatalogosTableAdapters.DespachosAbiertosTableAdapter();
            this.transportistasTableAdapter = new MaterialCore.DataSets.CatalogosTableAdapters.TransportistasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmbarques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachosAbiertosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportistasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmbarques
            // 
            this.dgvEmbarques.AllowUserToAddRows = false;
            this.dgvEmbarques.AllowUserToDeleteRows = false;
            this.dgvEmbarques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmbarques.AutoGenerateColumns = false;
            this.dgvEmbarques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmbarques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.niddeployDataGridViewTextBoxColumn,
            this.nid_arrive,
            this.nombreDataGridViewTextBoxColumn,
            this.cvetranspDataGridViewTextBoxColumn,
            this.cbox_number,
            this.nguide_number});
            this.dgvEmbarques.DataSource = this.despachosAbiertosBindingSource;
            this.dgvEmbarques.Location = new System.Drawing.Point(12, 12);
            this.dgvEmbarques.Name = "dgvEmbarques";
            this.dgvEmbarques.ReadOnly = true;
            this.dgvEmbarques.RowHeadersVisible = false;
            this.dgvEmbarques.Size = new System.Drawing.Size(730, 377);
            this.dgvEmbarques.TabIndex = 0;
            this.dgvEmbarques.DoubleClick += new System.EventHandler(this.dgvEmbarques_DoubleClick);
            this.dgvEmbarques.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEmbarques_KeyDown);
            // 
            // niddeployDataGridViewTextBoxColumn
            // 
            this.niddeployDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.niddeployDataGridViewTextBoxColumn.DataPropertyName = "nid_deploy";
            this.niddeployDataGridViewTextBoxColumn.HeaderText = "No. Despacho";
            this.niddeployDataGridViewTextBoxColumn.Name = "niddeployDataGridViewTextBoxColumn";
            this.niddeployDataGridViewTextBoxColumn.ReadOnly = true;
            this.niddeployDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.niddeployDataGridViewTextBoxColumn.Width = 75;
            // 
            // nid_arrive
            // 
            this.nid_arrive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nid_arrive.DataPropertyName = "nid_arrive";
            this.nid_arrive.HeaderText = "No. Llegada";
            this.nid_arrive.Name = "nid_arrive";
            this.nid_arrive.ReadOnly = true;
            this.nid_arrive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nid_arrive.Width = 65;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre de Transportista";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombreDataGridViewTextBoxColumn.Width = 117;
            // 
            // cvetranspDataGridViewTextBoxColumn
            // 
            this.cvetranspDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cvetranspDataGridViewTextBoxColumn.DataPropertyName = "cve_transp";
            this.cvetranspDataGridViewTextBoxColumn.HeaderText = "No. Transportista";
            this.cvetranspDataGridViewTextBoxColumn.Name = "cvetranspDataGridViewTextBoxColumn";
            this.cvetranspDataGridViewTextBoxColumn.ReadOnly = true;
            this.cvetranspDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cvetranspDataGridViewTextBoxColumn.Width = 86;
            // 
            // cbox_number
            // 
            this.cbox_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cbox_number.DataPropertyName = "cbox_number";
            this.cbox_number.HeaderText = "Caja";
            this.cbox_number.Name = "cbox_number";
            this.cbox_number.ReadOnly = true;
            this.cbox_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cbox_number.Width = 35;
            // 
            // nguide_number
            // 
            this.nguide_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nguide_number.DataPropertyName = "nguide_number";
            this.nguide_number.HeaderText = "No. Guia";
            this.nguide_number.Name = "nguide_number";
            this.nguide_number.ReadOnly = true;
            this.nguide_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nguide_number.Width = 51;
            // 
            // despachosAbiertosBindingSource
            // 
            this.despachosAbiertosBindingSource.DataMember = "DespachosAbiertos";
            this.despachosAbiertosBindingSource.DataSource = this.catalogos;
            // 
            // catalogos
            // 
            this.catalogos.DataSetName = "Catalogos";
            this.catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(667, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(221, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Crear Despacho";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbTransportista
            // 
            this.cmbTransportista.DataSource = this.transportistasBindingSource;
            this.cmbTransportista.DisplayMember = "nombre";
            this.cmbTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransportista.FormattingEnabled = true;
            this.cmbTransportista.Location = new System.Drawing.Point(77, 19);
            this.cmbTransportista.Name = "cmbTransportista";
            this.cmbTransportista.Size = new System.Drawing.Size(218, 21);
            this.cmbTransportista.TabIndex = 4;
            this.cmbTransportista.ValueMember = "cve_transp";
            // 
            // transportistasBindingSource
            // 
            this.transportistasBindingSource.DataMember = "Transportistas";
            this.transportistasBindingSource.DataSource = this.catalogos;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNoCaja);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTransportista);
            this.groupBox1.Location = new System.Drawing.Point(12, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Despacho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "No. Caja:";
            // 
            // txtNoCaja
            // 
            this.txtNoCaja.Location = new System.Drawing.Point(77, 51);
            this.txtNoCaja.Name = "txtNoCaja";
            this.txtNoCaja.Size = new System.Drawing.Size(98, 20);
            this.txtNoCaja.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trasportista:";
            // 
            // despachosAbiertosTableAdapter
            // 
            this.despachosAbiertosTableAdapter.ClearBeforeFill = true;
            // 
            // transportistasTableAdapter
            // 
            this.transportistasTableAdapter.ClearBeforeFill = true;
            // 
            // EmbarquesAbiertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEmbarques);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmbarquesAbiertos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despachos Abiertos";
            this.Load += new System.EventHandler(this.EmbarquesAbiertos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmbarques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachosAbiertosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportistasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmbarques;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource despachosAbiertosBindingSource;
        private MaterialCore.DataSets.Catalogos catalogos;
        private MaterialCore.DataSets.CatalogosTableAdapters.DespachosAbiertosTableAdapter despachosAbiertosTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn niddeployDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid_arrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvetranspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbox_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguide_number;
        private System.Windows.Forms.ComboBox cmbTransportista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource transportistasBindingSource;
        private MaterialCore.DataSets.CatalogosTableAdapters.TransportistasTableAdapter transportistasTableAdapter;
    }
}