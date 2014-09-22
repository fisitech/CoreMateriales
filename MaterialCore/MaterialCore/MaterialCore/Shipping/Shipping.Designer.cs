namespace MaterialCore.Shipping
{
    partial class Shipping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShipping = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.mtxtFecha1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.materialesShippingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maquinaria = new MaterialCore.DataSets.Maquinaria();
            this.materialesShippingTableAdapter = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesShippingTableAdapter();
            this.gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPackSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gfechaRBI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTransportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gConsignee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDomestic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gfechaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gfechaDespacho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnoGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gComentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gfechaCapura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesShippingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShipping
            // 
            this.dgvShipping.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShipping.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gid,
            this.gPackSum,
            this.gfechaRBI,
            this.gTransportista,
            this.gConsignee,
            this.gDomestic,
            this.gfechaLlegada,
            this.gfechaDespacho,
            this.gnoGuia,
            this.gComentarios,
            this.gfechaCapura});
            this.dgvShipping.DataSource = this.materialesShippingBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShipping.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvShipping.Location = new System.Drawing.Point(12, 39);
            this.dgvShipping.Name = "dgvShipping";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShipping.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvShipping.RowHeadersWidth = 20;
            this.dgvShipping.Size = new System.Drawing.Size(968, 455);
            this.dgvShipping.TabIndex = 0;
            this.dgvShipping.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Labinal de Mexico today\'s shipments USA-Worldwide";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PACKSUM";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 578);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 578);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carrier";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(333, 578);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Consignee";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(439, 578);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "DOMESTIC/ INT´L";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(757, 578);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(862, 578);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(867, 565);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Comments";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(100, 544);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 28);
            this.textBox10.TabIndex = 21;
            this.textBox10.Text = "Date & time receeived in RBI";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(545, 547);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 28);
            this.textBox11.TabIndex = 22;
            this.textBox11.Text = "Date shipped from Labinal de Mexico";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(651, 544);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 28);
            this.textBox12.TabIndex = 23;
            this.textBox12.Text = "Date shipped from RBI";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(757, 547);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 28);
            this.textBox13.TabIndex = 24;
            this.textBox13.Text = "Tracking number or airbill number";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtFecha1
            // 
            this.mtxtFecha1.Location = new System.Drawing.Point(117, 578);
            this.mtxtFecha1.Mask = "00/00/0000";
            this.mtxtFecha1.Name = "mtxtFecha1";
            this.mtxtFecha1.Size = new System.Drawing.Size(83, 20);
            this.mtxtFecha1.TabIndex = 71;
            this.mtxtFecha1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(562, 578);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBox1.TabIndex = 72;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(663, 578);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBox2.TabIndex = 73;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // materialesShippingBindingSource
            // 
            this.materialesShippingBindingSource.DataMember = "MaterialesShipping";
            this.materialesShippingBindingSource.DataSource = this.maquinaria;
            // 
            // maquinaria
            // 
            this.maquinaria.DataSetName = "Maquinaria";
            this.maquinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialesShippingTableAdapter
            // 
            this.materialesShippingTableAdapter.ClearBeforeFill = true;
            // 
            // gid
            // 
            this.gid.DataPropertyName = "id";
            this.gid.HeaderText = "id";
            this.gid.Name = "gid";
            this.gid.ReadOnly = true;
            this.gid.Visible = false;
            // 
            // gPackSum
            // 
            this.gPackSum.DataPropertyName = "PackSum";
            this.gPackSum.HeaderText = "PACKSUM";
            this.gPackSum.Name = "gPackSum";
            // 
            // gfechaRBI
            // 
            this.gfechaRBI.DataPropertyName = "fechaRBI";
            dataGridViewCellStyle8.Format = "dd/MM/yy";
            this.gfechaRBI.DefaultCellStyle = dataGridViewCellStyle8;
            this.gfechaRBI.HeaderText = "Date & time receeived in RBI";
            this.gfechaRBI.Name = "gfechaRBI";
            // 
            // gTransportista
            // 
            this.gTransportista.DataPropertyName = "Transportista";
            this.gTransportista.HeaderText = "Carrier";
            this.gTransportista.Name = "gTransportista";
            // 
            // gConsignee
            // 
            this.gConsignee.DataPropertyName = "Consignee";
            this.gConsignee.HeaderText = "Consignee";
            this.gConsignee.Name = "gConsignee";
            // 
            // gDomestic
            // 
            this.gDomestic.DataPropertyName = "Domestic";
            this.gDomestic.HeaderText = "DOMESTIC/ INT´L";
            this.gDomestic.Name = "gDomestic";
            // 
            // gfechaLlegada
            // 
            this.gfechaLlegada.DataPropertyName = "fechaLlegada";
            dataGridViewCellStyle9.Format = "dd/MM/yy";
            this.gfechaLlegada.DefaultCellStyle = dataGridViewCellStyle9;
            this.gfechaLlegada.HeaderText = "Date shipped from Labinal de Mexico";
            this.gfechaLlegada.Name = "gfechaLlegada";
            // 
            // gfechaDespacho
            // 
            this.gfechaDespacho.DataPropertyName = "fechaDespacho";
            dataGridViewCellStyle10.Format = "dd/MM/yy";
            this.gfechaDespacho.DefaultCellStyle = dataGridViewCellStyle10;
            this.gfechaDespacho.HeaderText = "Date shipped from RBI";
            this.gfechaDespacho.Name = "gfechaDespacho";
            // 
            // gnoGuia
            // 
            this.gnoGuia.DataPropertyName = "noGuia";
            this.gnoGuia.HeaderText = "Tracking number or airbill number";
            this.gnoGuia.Name = "gnoGuia";
            // 
            // gComentarios
            // 
            this.gComentarios.DataPropertyName = "Comentarios";
            this.gComentarios.HeaderText = "Comments";
            this.gComentarios.Name = "gComentarios";
            // 
            // gfechaCapura
            // 
            this.gfechaCapura.DataPropertyName = "fechaCapura";
            this.gfechaCapura.HeaderText = "fechaCapura";
            this.gfechaCapura.Name = "gfechaCapura";
            this.gfechaCapura.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 646);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 74;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Shipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 698);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.mtxtFecha1);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShipping);
            this.Name = "Shipping";
            this.Text = "Shipping";
            this.Load += new System.EventHandler(this.Shipping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesShippingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShipping;
        private MaterialCore.DataSets.Maquinaria maquinaria;
        private System.Windows.Forms.BindingSource materialesShippingBindingSource;
        private MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesShippingTableAdapter materialesShippingTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.MaskedTextBox mtxtFecha1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPackSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gfechaRBI;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn gConsignee;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDomestic;
        private System.Windows.Forms.DataGridViewTextBoxColumn gfechaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn gfechaDespacho;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnoGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gComentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn gfechaCapura;
        private System.Windows.Forms.Button button2;
    }
}