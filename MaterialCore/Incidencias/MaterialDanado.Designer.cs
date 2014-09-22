namespace MaterialCore.Incidencias
{
    partial class MaterialDanado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.lstFotos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoGuia = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillTrasnp = new System.Windows.Forms.TextBox();
            this.btnBillTransp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noGuiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirPDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCapturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesDanadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maquinaria = new MaterialCore.DataSets.Maquinaria();
            this.materialesDanadoTableAdapter = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesDanadoTableAdapter();
            this.valida_nidskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valida_nid_skuTableAdapter = new MaterialCore.DataSets.MaquinariaTableAdapters.valida_nid_skuTableAdapter();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDanadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valida_nidskuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.Location = new System.Drawing.Point(157, 121);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarFoto.TabIndex = 0;
            this.btnAgregarFoto.Text = "Buscar";
            this.btnAgregarFoto.UseVisualStyleBackColor = true;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // lstFotos
            // 
            this.lstFotos.FormattingEnabled = true;
            this.lstFotos.HorizontalScrollbar = true;
            this.lstFotos.Location = new System.Drawing.Point(11, 23);
            this.lstFotos.Name = "lstFotos";
            this.lstFotos.Size = new System.Drawing.Size(142, 121);
            this.lstFotos.TabIndex = 1;
            this.lstFotos.DoubleClick += new System.EventHandler(this.lstFotos_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guia:";
            // 
            // txtNoGuia
            // 
            this.txtNoGuia.Location = new System.Drawing.Point(12, 31);
            this.txtNoGuia.Name = "txtNoGuia";
            this.txtNoGuia.Size = new System.Drawing.Size(194, 20);
            this.txtNoGuia.TabIndex = 3;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(12, 80);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(231, 67);
            this.txtComentarios.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comentario:";
            // 
            // txtBillTrasnp
            // 
            this.txtBillTrasnp.Location = new System.Drawing.Point(6, 19);
            this.txtBillTrasnp.Name = "txtBillTrasnp";
            this.txtBillTrasnp.ReadOnly = true;
            this.txtBillTrasnp.Size = new System.Drawing.Size(142, 20);
            this.txtBillTrasnp.TabIndex = 6;
            // 
            // btnBillTransp
            // 
            this.btnBillTransp.Location = new System.Drawing.Point(164, 16);
            this.btnBillTransp.Name = "btnBillTransp";
            this.btnBillTransp.Size = new System.Drawing.Size(75, 23);
            this.btnBillTransp.TabIndex = 8;
            this.btnBillTransp.Text = "Buscar";
            this.btnBillTransp.UseVisualStyleBackColor = true;
            this.btnBillTransp.Click += new System.EventHandler(this.btnBillTransp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.noGuiaDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.dirPDFDataGridViewTextBoxColumn,
            this.fechaCapturaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialesDanadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(282, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 391);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstFotos);
            this.groupBox1.Controls.Add(this.btnAgregarFoto);
            this.groupBox1.Location = new System.Drawing.Point(4, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 150);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fotos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBillTransp);
            this.groupBox2.Controls.Add(this.txtBillTrasnp);
            this.groupBox2.Location = new System.Drawing.Point(4, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 54);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill de Transportista";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // noGuiaDataGridViewTextBoxColumn
            // 
            this.noGuiaDataGridViewTextBoxColumn.DataPropertyName = "noGuia";
            this.noGuiaDataGridViewTextBoxColumn.HeaderText = "noGuia";
            this.noGuiaDataGridViewTextBoxColumn.Name = "noGuiaDataGridViewTextBoxColumn";
            this.noGuiaDataGridViewTextBoxColumn.Width = 80;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.Width = 250;
            // 
            // dirPDFDataGridViewTextBoxColumn
            // 
            this.dirPDFDataGridViewTextBoxColumn.DataPropertyName = "dirPDF";
            this.dirPDFDataGridViewTextBoxColumn.HeaderText = "dirPDF";
            this.dirPDFDataGridViewTextBoxColumn.Name = "dirPDFDataGridViewTextBoxColumn";
            this.dirPDFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCapturaDataGridViewTextBoxColumn
            // 
            this.fechaCapturaDataGridViewTextBoxColumn.DataPropertyName = "fechaCaptura";
            this.fechaCapturaDataGridViewTextBoxColumn.HeaderText = "fechaCaptura";
            this.fechaCapturaDataGridViewTextBoxColumn.Name = "fechaCapturaDataGridViewTextBoxColumn";
            this.fechaCapturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialesDanadoBindingSource
            // 
            this.materialesDanadoBindingSource.DataMember = "MaterialesDanado";
            this.materialesDanadoBindingSource.DataSource = this.maquinaria;
            // 
            // maquinaria
            // 
            this.maquinaria.DataSetName = "Maquinaria";
            this.maquinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialesDanadoTableAdapter
            // 
            this.materialesDanadoTableAdapter.ClearBeforeFill = true;
            // 
            // valida_nidskuBindingSource
            // 
            this.valida_nidskuBindingSource.DataMember = "valida_nid_sku";
            this.valida_nidskuBindingSource.DataSource = this.maquinaria;
            // 
            // valida_nid_skuTableAdapter
            // 
            this.valida_nid_skuTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(113, 379);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 34);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(194, 378);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 34);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // MaterialDanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 447);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoGuia);
            this.Controls.Add(this.label1);
            this.Name = "MaterialDanado";
            this.Text = "MaterialDanado";
            this.Load += new System.EventHandler(this.MaterialDanado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDanadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valida_nidskuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarFoto;
        private System.Windows.Forms.ListBox lstFotos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoGuia;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillTrasnp;
        private System.Windows.Forms.Button btnBillTransp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialCore.DataSets.Maquinaria maquinaria;
        private System.Windows.Forms.BindingSource materialesDanadoBindingSource;
        private MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesDanadoTableAdapter materialesDanadoTableAdapter;
        private System.Windows.Forms.BindingSource valida_nidskuBindingSource;
        private MaterialCore.DataSets.MaquinariaTableAdapters.valida_nid_skuTableAdapter valida_nid_skuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noGuiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirPDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCapturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}