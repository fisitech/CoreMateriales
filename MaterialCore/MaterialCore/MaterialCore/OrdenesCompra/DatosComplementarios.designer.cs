namespace MaterialCore.Embarques
{
    partial class DatosComplementarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosComplementarios));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gNid_deploy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTransportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTarimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosComplementariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.embarques = new MaterialCore.DataSets.Embarques();
            this.datosComplementariosTableAdapter = new MaterialCore.DataSets.EmbarquesTableAdapters.DatosComplementariosTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCrearDocumento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosComplementariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gNid_deploy,
            this.gTransportista,
            this.gCaja,
            this.gBultos,
            this.gPeso,
            this.gTarimas});
            this.dgvDatos.DataSource = this.datosComplementariosBindingSource;
            this.dgvDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(923, 461);
            this.dgvDatos.TabIndex = 0;
            // 
            // gNid_deploy
            // 
            this.gNid_deploy.DataPropertyName = "nid_deploy";
            this.gNid_deploy.HeaderText = "Despacho";
            this.gNid_deploy.Name = "gNid_deploy";
            // 
            // gTransportista
            // 
            this.gTransportista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gTransportista.DataPropertyName = "nombre";
            this.gTransportista.HeaderText = "Transportista";
            this.gTransportista.Name = "gTransportista";
            this.gTransportista.Width = 94;
            // 
            // gCaja
            // 
            this.gCaja.DataPropertyName = "cbox_number";
            this.gCaja.HeaderText = "Caja";
            this.gCaja.Name = "gCaja";
            // 
            // gBultos
            // 
            this.gBultos.DataPropertyName = "bultos";
            this.gBultos.HeaderText = "Bultos";
            this.gBultos.Name = "gBultos";
            this.gBultos.ReadOnly = true;
            // 
            // gPeso
            // 
            this.gPeso.DataPropertyName = "pesobruto";
            dataGridViewCellStyle1.Format = "N2";
            this.gPeso.DefaultCellStyle = dataGridViewCellStyle1;
            this.gPeso.HeaderText = "Peso Bruto";
            this.gPeso.Name = "gPeso";
            this.gPeso.ReadOnly = true;
            // 
            // gTarimas
            // 
            this.gTarimas.DataPropertyName = "Tarimas";
            this.gTarimas.HeaderText = "Tarimas";
            this.gTarimas.Name = "gTarimas";
            this.gTarimas.ReadOnly = true;
            // 
            // datosComplementariosBindingSource
            // 
            this.datosComplementariosBindingSource.DataMember = "DatosComplementarios";
            this.datosComplementariosBindingSource.DataSource = this.embarques;
            // 
            // embarques
            // 
            this.embarques.DataSetName = "Embarques";
            this.embarques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosComplementariosTableAdapter
            // 
            this.datosComplementariosTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(860, 479);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnCrearDocumento
            // 
            this.btnCrearDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearDocumento.Location = new System.Drawing.Point(657, 479);
            this.btnCrearDocumento.Name = "btnCrearDocumento";
            this.btnCrearDocumento.Size = new System.Drawing.Size(149, 23);
            this.btnCrearDocumento.TabIndex = 2;
            this.btnCrearDocumento.Text = "Crear documento";
            this.btnCrearDocumento.UseVisualStyleBackColor = true;
            this.btnCrearDocumento.Click += new System.EventHandler(this.btnCrearDocumento_Click);
            // 
            // DatosComplementarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 514);
            this.Controls.Add(this.btnCrearDocumento);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosComplementarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Complementarios";
            this.Load += new System.EventHandler(this.DatosComplementarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosComplementariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private MaterialCore.DataSets.Embarques embarques;
        private System.Windows.Forms.BindingSource datosComplementariosBindingSource;
        private MaterialCore.DataSets.EmbarquesTableAdapters.DatosComplementariosTableAdapter datosComplementariosTableAdapter;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCrearDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNid_deploy;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn gBultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTarimas;
    }
}