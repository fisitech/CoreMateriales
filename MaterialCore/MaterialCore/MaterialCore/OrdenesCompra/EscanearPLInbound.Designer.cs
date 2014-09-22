namespace MaterialCore.OrdenesCompra
{
    partial class EscanearPLInbound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscanearPLInbound));
            this.lblMensaje = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnCargaArchivo = new System.Windows.Forms.Button();
            this.btnBuscaArchivo = new System.Windows.Forms.Button();
            this.btnAsosiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarsku = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEscanear = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscanear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.SystemColors.Control;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblMensaje.Location = new System.Drawing.Point(325, 100);
            this.lblMensaje.Multiline = true;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblMensaje.Size = new System.Drawing.Size(286, 112);
            this.lblMensaje.TabIndex = 21;
            this.lblMensaje.Text = "Etiqueta se asocio exitosamente";
            this.lblMensaje.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArchivo);
            this.groupBox1.Controls.Add(this.btnCargaArchivo);
            this.groupBox1.Controls.Add(this.btnBuscaArchivo);
            this.groupBox1.Location = new System.Drawing.Point(325, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 107);
            this.groupBox1.TabIndex = 19;
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
            this.btnCargaArchivo.Text = "Carga archivo y asociar";
            this.btnCargaArchivo.UseVisualStyleBackColor = true;
            this.btnCargaArchivo.Click += new System.EventHandler(this.btnCargaArchivo_Click);
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
            // btnAsosiar
            // 
            this.btnAsosiar.Enabled = false;
            this.btnAsosiar.Location = new System.Drawing.Point(407, 266);
            this.btnAsosiar.Name = "btnAsosiar";
            this.btnAsosiar.Size = new System.Drawing.Size(126, 42);
            this.btnAsosiar.TabIndex = 18;
            this.btnAsosiar.Text = "Asociar Guias a PL";
            this.btnAsosiar.UseVisualStyleBackColor = true;
            this.btnAsosiar.Visible = false;
            this.btnAsosiar.Click += new System.EventHandler(this.btnAsosiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(195, 451);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Agregar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "No. Guia:";
            // 
            // txtBuscarsku
            // 
            this.txtBuscarsku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarsku.Location = new System.Drawing.Point(322, 30);
            this.txtBuscarsku.Name = "txtBuscarsku";
            this.txtBuscarsku.Size = new System.Drawing.Size(262, 20);
            this.txtBuscarsku.TabIndex = 14;
            this.txtBuscarsku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarsku_KeyPress_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 13;
            this.button1.TabStop = false;
            this.button1.Text = "&Digitalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEscanear
            // 
            this.dgvEscanear.AllowUserToAddRows = false;
            this.dgvEscanear.AllowUserToDeleteRows = false;
            this.dgvEscanear.AllowUserToResizeRows = false;
            this.dgvEscanear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvEscanear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscanear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvEscanear.Location = new System.Drawing.Point(12, 12);
            this.dgvEscanear.Name = "dgvEscanear";
            this.dgvEscanear.RowHeadersVisible = false;
            this.dgvEscanear.RowHeadersWidth = 24;
            this.dgvEscanear.Size = new System.Drawing.Size(280, 479);
            this.dgvEscanear.TabIndex = 16;
            this.dgvEscanear.TabStop = false;
            this.dgvEscanear.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEscanear_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Guia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // btnAgrega
            // 
            this.btnAgrega.Location = new System.Drawing.Point(509, 56);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(75, 23);
            this.btnAgrega.TabIndex = 22;
            this.btnAgrega.Text = "Agregar";
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // EscanearPLInbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 503);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAsosiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarsku);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEscanear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EscanearPLInbound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitalizar INBOUND";
            this.Load += new System.EventHandler(this.EscanearPL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscanear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblMensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnCargaArchivo;
        private System.Windows.Forms.Button btnBuscaArchivo;
        private System.Windows.Forms.Button btnAsosiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarsku;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEscanear;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}