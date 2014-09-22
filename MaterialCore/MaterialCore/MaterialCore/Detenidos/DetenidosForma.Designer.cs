namespace MaterialCore.Detenidos
{
    partial class DetenidosForma
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
            this.dgvConTarima = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvSinEnviar = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesOCIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renglonIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadRecibidaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroParteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detenerPartidaSinEnviarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.embarques = new MaterialCore.DataSets.Embarques();
            this.detenerPartidaConTarimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detenerPartidaConTarimaTableAdapter = new MaterialCore.DataSets.EmbarquesTableAdapters.DetenerPartidaConTarimaTableAdapter();
            this.detenerPartidaSinEnviarTableAdapter = new MaterialCore.DataSets.EmbarquesTableAdapters.DetenerPartidaSinEnviarTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialesPaletasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPaletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePaletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesOCIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renglonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadRecibidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detenerPartidaSinEnviarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detenerPartidaConTarimaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConTarima
            // 
            this.dgvConTarima.AllowUserToAddRows = false;
            this.dgvConTarima.AllowUserToDeleteRows = false;
            this.dgvConTarima.AutoGenerateColumns = false;
            this.dgvConTarima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConTarima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialesPaletasIdDataGridViewTextBoxColumn,
            this.numeroPaletaDataGridViewTextBoxColumn,
            this.nombrePaletaDataGridViewTextBoxColumn,
            this.materialesOCIdDataGridViewTextBoxColumn,
            this.renglonIdDataGridViewTextBoxColumn,
            this.cantidadRecibidaDataGridViewTextBoxColumn,
            this.plantaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dgvConTarima.DataSource = this.detenerPartidaConTarimaBindingSource;
            this.dgvConTarima.Location = new System.Drawing.Point(12, 97);
            this.dgvConTarima.Name = "dgvConTarima";
            this.dgvConTarima.ReadOnly = true;
            this.dgvConTarima.RowHeadersVisible = false;
            this.dgvConTarima.Size = new System.Drawing.Size(765, 224);
            this.dgvConTarima.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(437, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(281, 554);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvSinEnviar
            // 
            this.dgvSinEnviar.AllowUserToAddRows = false;
            this.dgvSinEnviar.AllowUserToDeleteRows = false;
            this.dgvSinEnviar.AutoGenerateColumns = false;
            this.dgvSinEnviar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinEnviar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.materialesOCIdDataGridViewTextBoxColumn1,
            this.renglonIdDataGridViewTextBoxColumn1,
            this.cantidadRecibidaDataGridViewTextBoxColumn1,
            this.plantaDataGridViewTextBoxColumn1,
            this.numeroParteDataGridViewTextBoxColumn});
            this.dgvSinEnviar.DataSource = this.detenerPartidaSinEnviarBindingSource;
            this.dgvSinEnviar.Location = new System.Drawing.Point(12, 350);
            this.dgvSinEnviar.Name = "dgvSinEnviar";
            this.dgvSinEnviar.ReadOnly = true;
            this.dgvSinEnviar.Size = new System.Drawing.Size(765, 177);
            this.dgvSinEnviar.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // materialesOCIdDataGridViewTextBoxColumn1
            // 
            this.materialesOCIdDataGridViewTextBoxColumn1.DataPropertyName = "MaterialesOCId";
            this.materialesOCIdDataGridViewTextBoxColumn1.HeaderText = "MaterialesOCId";
            this.materialesOCIdDataGridViewTextBoxColumn1.Name = "materialesOCIdDataGridViewTextBoxColumn1";
            this.materialesOCIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // renglonIdDataGridViewTextBoxColumn1
            // 
            this.renglonIdDataGridViewTextBoxColumn1.DataPropertyName = "RenglonId";
            this.renglonIdDataGridViewTextBoxColumn1.HeaderText = "RenglonId";
            this.renglonIdDataGridViewTextBoxColumn1.Name = "renglonIdDataGridViewTextBoxColumn1";
            this.renglonIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cantidadRecibidaDataGridViewTextBoxColumn1
            // 
            this.cantidadRecibidaDataGridViewTextBoxColumn1.DataPropertyName = "CantidadRecibida";
            this.cantidadRecibidaDataGridViewTextBoxColumn1.HeaderText = "CantidadRecibida";
            this.cantidadRecibidaDataGridViewTextBoxColumn1.Name = "cantidadRecibidaDataGridViewTextBoxColumn1";
            this.cantidadRecibidaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // plantaDataGridViewTextBoxColumn1
            // 
            this.plantaDataGridViewTextBoxColumn1.DataPropertyName = "Planta";
            this.plantaDataGridViewTextBoxColumn1.HeaderText = "Planta";
            this.plantaDataGridViewTextBoxColumn1.Name = "plantaDataGridViewTextBoxColumn1";
            this.plantaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numeroParteDataGridViewTextBoxColumn
            // 
            this.numeroParteDataGridViewTextBoxColumn.DataPropertyName = "NumeroParte";
            this.numeroParteDataGridViewTextBoxColumn.HeaderText = "NumeroParte";
            this.numeroParteDataGridViewTextBoxColumn.Name = "numeroParteDataGridViewTextBoxColumn";
            this.numeroParteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detenerPartidaSinEnviarBindingSource
            // 
            this.detenerPartidaSinEnviarBindingSource.DataMember = "DetenerPartidaSinEnviar";
            this.detenerPartidaSinEnviarBindingSource.DataSource = this.embarques;
            // 
            // embarques
            // 
            this.embarques.DataSetName = "Embarques";
            this.embarques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detenerPartidaConTarimaBindingSource
            // 
            this.detenerPartidaConTarimaBindingSource.DataMember = "DetenerPartidaConTarima";
            this.detenerPartidaConTarimaBindingSource.DataSource = this.embarques;
            // 
            // detenerPartidaConTarimaTableAdapter
            // 
            this.detenerPartidaConTarimaTableAdapter.ClearBeforeFill = true;
            // 
            // detenerPartidaSinEnviarTableAdapter
            // 
            this.detenerPartidaSinEnviarTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Advertencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(596, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Existen partidas con este mismo Número de guía que deben de detenerse también.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(539, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Las partidas dentro la tabla siguiente ya fueron asignadas a una tarima, a la cua" +
                "l ya se le generó un archivo PDF.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Es necesario regenerar el archivo PDF de estas partidas.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "A las partidas dentro de la siguiente tabla, se les cambiará la planta a Detenido" +
                ".";
            // 
            // materialesPaletasIdDataGridViewTextBoxColumn
            // 
            this.materialesPaletasIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialesPaletasId";
            this.materialesPaletasIdDataGridViewTextBoxColumn.HeaderText = "Id de Paleta";
            this.materialesPaletasIdDataGridViewTextBoxColumn.Name = "materialesPaletasIdDataGridViewTextBoxColumn";
            this.materialesPaletasIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroPaletaDataGridViewTextBoxColumn
            // 
            this.numeroPaletaDataGridViewTextBoxColumn.DataPropertyName = "NumeroPaleta";
            this.numeroPaletaDataGridViewTextBoxColumn.HeaderText = "Numero Paleta";
            this.numeroPaletaDataGridViewTextBoxColumn.Name = "numeroPaletaDataGridViewTextBoxColumn";
            this.numeroPaletaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePaletaDataGridViewTextBoxColumn
            // 
            this.nombrePaletaDataGridViewTextBoxColumn.DataPropertyName = "NombrePaleta";
            this.nombrePaletaDataGridViewTextBoxColumn.HeaderText = "Nombre Paleta";
            this.nombrePaletaDataGridViewTextBoxColumn.Name = "nombrePaletaDataGridViewTextBoxColumn";
            this.nombrePaletaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cantidadRecibidaDataGridViewTextBoxColumn
            // 
            this.cantidadRecibidaDataGridViewTextBoxColumn.DataPropertyName = "CantidadRecibida";
            this.cantidadRecibidaDataGridViewTextBoxColumn.HeaderText = "Cant. Recibida";
            this.cantidadRecibidaDataGridViewTextBoxColumn.Name = "cantidadRecibidaDataGridViewTextBoxColumn";
            this.cantidadRecibidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plantaDataGridViewTextBoxColumn
            // 
            this.plantaDataGridViewTextBoxColumn.DataPropertyName = "Planta";
            this.plantaDataGridViewTextBoxColumn.HeaderText = "Planta";
            this.plantaDataGridViewTextBoxColumn.Name = "plantaDataGridViewTextBoxColumn";
            this.plantaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // DetenidosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 583);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSinEnviar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvConTarima);
            this.Name = "DetenidosForma";
            this.Text = "Detenidos";
            this.Load += new System.EventHandler(this.DetenidosForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detenerPartidaSinEnviarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detenerPartidaConTarimaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConTarima;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingSource detenerPartidaConTarimaBindingSource;
        private MaterialCore.DataSets.Embarques embarques;
        private MaterialCore.DataSets.EmbarquesTableAdapters.DetenerPartidaConTarimaTableAdapter detenerPartidaConTarimaTableAdapter;
        private System.Windows.Forms.DataGridView dgvSinEnviar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialesOCIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn renglonIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadRecibidaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detenerPartidaSinEnviarBindingSource;
        private MaterialCore.DataSets.EmbarquesTableAdapters.DetenerPartidaSinEnviarTableAdapter detenerPartidaSinEnviarTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialesPaletasIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPaletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePaletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialesOCIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renglonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadRecibidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}