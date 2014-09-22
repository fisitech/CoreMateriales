namespace MaterialCore
{
    partial class POActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POActivos));
            this.materialesOCPODataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesOCPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quimicos = new MaterialCore.DataSets.Quimicos();
            this.materialesOCPOTableAdapter = new MaterialCore.DataSets.QuimicosTableAdapters.MaterialesOCPOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.materialesOCPODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesOCPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quimicos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialesOCPODataGridView
            // 
            this.materialesOCPODataGridView.AllowUserToAddRows = false;
            this.materialesOCPODataGridView.AllowUserToDeleteRows = false;
            this.materialesOCPODataGridView.AllowUserToResizeColumns = false;
            this.materialesOCPODataGridView.AutoGenerateColumns = false;
            this.materialesOCPODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn});
            this.materialesOCPODataGridView.DataSource = this.materialesOCPOBindingSource;
            this.materialesOCPODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialesOCPODataGridView.Location = new System.Drawing.Point(0, 0);
            this.materialesOCPODataGridView.Name = "materialesOCPODataGridView";
            this.materialesOCPODataGridView.ReadOnly = true;
            this.materialesOCPODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialesOCPODataGridView.Size = new System.Drawing.Size(371, 421);
            this.materialesOCPODataGridView.TabIndex = 0;
            this.materialesOCPODataGridView.DoubleClick += new System.EventHandler(this.materialesOCPODataGridView_DoubleClick);
            this.materialesOCPODataGridView.SelectionChanged += new System.EventHandler(this.materialesOCDataGridView_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Orden de Compra";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 300;
            // 
            // materialesOCPOBindingSource
            // 
            this.materialesOCPOBindingSource.DataMember = "MaterialesOCPO";
            this.materialesOCPOBindingSource.DataSource = this.quimicos;
            // 
            // quimicos
            // 
            this.quimicos.DataSetName = "Quimicos";
            this.quimicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialesOCPOTableAdapter
            // 
            this.materialesOCPOTableAdapter.ClearBeforeFill = true;
            // 
            // POActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 421);
            this.Controls.Add(this.materialesOCPODataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POActivos";
            this.Text = "POs";
            this.Load += new System.EventHandler(this.POActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialesOCPODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesOCPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quimicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView materialesOCPODataGridView;
        private MaterialCore.DataSets.Quimicos quimicos;
        private System.Windows.Forms.BindingSource materialesOCPOBindingSource;
        private MaterialCore.DataSets.QuimicosTableAdapters.MaterialesOCPOTableAdapter materialesOCPOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

    }
}