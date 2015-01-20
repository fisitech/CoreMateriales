namespace MaterialCore
{
    partial class ImpCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpCSV));
            this.rbtManual = new System.Windows.Forms.RadioButton();
            this.rbtAutomatico = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCortos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDirCSV = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Barra = new System.Windows.Forms.ProgressBar();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkMat = new System.Windows.Forms.CheckBox();
            this.chkMeQ = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarMeQ = new System.Windows.Forms.Button();
            this.lblMeQ = new System.Windows.Forms.Label();
            this.btnNuevoFormato = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtManual
            // 
            this.rbtManual.AutoSize = true;
            this.rbtManual.Checked = true;
            this.rbtManual.Location = new System.Drawing.Point(6, 55);
            this.rbtManual.Name = "rbtManual";
            this.rbtManual.Size = new System.Drawing.Size(60, 17);
            this.rbtManual.TabIndex = 2;
            this.rbtManual.TabStop = true;
            this.rbtManual.Text = "&Manual";
            this.rbtManual.UseVisualStyleBackColor = true;
            this.rbtManual.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // rbtAutomatico
            // 
            this.rbtAutomatico.AutoSize = true;
            this.rbtAutomatico.Location = new System.Drawing.Point(6, 19);
            this.rbtAutomatico.Name = "rbtAutomatico";
            this.rbtAutomatico.Size = new System.Drawing.Size(78, 17);
            this.rbtAutomatico.TabIndex = 3;
            this.rbtAutomatico.Text = "&Automatica";
            this.rbtAutomatico.UseVisualStyleBackColor = true;
            this.rbtAutomatico.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtAutomatico);
            this.groupBox1.Controls.Add(this.rbtManual);
            this.groupBox1.Controls.Add(this.chkCortos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicacion de archivo";
            // 
            // chkCortos
            // 
            this.chkCortos.AutoSize = true;
            this.chkCortos.Location = new System.Drawing.Point(68, 70);
            this.chkCortos.Name = "chkCortos";
            this.chkCortos.Size = new System.Drawing.Size(56, 17);
            this.chkCortos.TabIndex = 14;
            this.chkCortos.Text = "Cortos";
            this.chkCortos.UseVisualStyleBackColor = true;
            this.chkCortos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dirección del archivo Excel:";
            // 
            // lblDirCSV
            // 
            this.lblDirCSV.Location = new System.Drawing.Point(6, 16);
            this.lblDirCSV.Name = "lblDirCSV";
            this.lblDirCSV.Size = new System.Drawing.Size(336, 49);
            this.lblDirCSV.TabIndex = 6;
            this.lblDirCSV.Text = "C:\\la que esta en el archivo de config\\mas bnombre.ext";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(267, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Barra
            // 
            this.Barra.Location = new System.Drawing.Point(12, 268);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(334, 28);
            this.Barra.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(352, 268);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 28);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "&Cargar BPCS";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(14, 163);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(14, 20);
            this.lblmensaje.TabIndex = 12;
            this.lblmensaje.Text = ".";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 310);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(532, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblEstado
            // 
            this.tslblEstado.Name = "tslblEstado";
            this.tslblEstado.Size = new System.Drawing.Size(127, 17);
            this.tslblEstado.Text = "Esperando Comando...";
            // 
            // chkMat
            // 
            this.chkMat.AutoSize = true;
            this.chkMat.Checked = true;
            this.chkMat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMat.Location = new System.Drawing.Point(204, 72);
            this.chkMat.Name = "chkMat";
            this.chkMat.Size = new System.Drawing.Size(57, 17);
            this.chkMat.TabIndex = 16;
            this.chkMat.Text = "Cargar";
            this.chkMat.UseVisualStyleBackColor = true;
            // 
            // chkMeQ
            // 
            this.chkMeQ.AutoSize = true;
            this.chkMeQ.Checked = true;
            this.chkMeQ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMeQ.Location = new System.Drawing.Point(204, 74);
            this.chkMeQ.Name = "chkMeQ";
            this.chkMeQ.Size = new System.Drawing.Size(57, 17);
            this.chkMeQ.TabIndex = 17;
            this.chkMeQ.Text = "Cargar";
            this.chkMeQ.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDirCSV);
            this.groupBox2.Controls.Add(this.chkMat);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(169, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Materiales";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarMeQ);
            this.groupBox3.Controls.Add(this.lblMeQ);
            this.groupBox3.Controls.Add(this.chkMeQ);
            this.groupBox3.Location = new System.Drawing.Point(169, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 98);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Maquinaria y Equipo";
            // 
            // btnBuscarMeQ
            // 
            this.btnBuscarMeQ.Location = new System.Drawing.Point(265, 68);
            this.btnBuscarMeQ.Name = "btnBuscarMeQ";
            this.btnBuscarMeQ.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMeQ.TabIndex = 20;
            this.btnBuscarMeQ.Text = "Buscar";
            this.btnBuscarMeQ.UseVisualStyleBackColor = true;
            this.btnBuscarMeQ.Click += new System.EventHandler(this.btnBuscarMeQ_Click);
            // 
            // lblMeQ
            // 
            this.lblMeQ.Location = new System.Drawing.Point(4, 16);
            this.lblMeQ.Name = "lblMeQ";
            this.lblMeQ.Size = new System.Drawing.Size(336, 49);
            this.lblMeQ.TabIndex = 17;
            this.lblMeQ.Text = "C:\\la que esta en el archivo de config\\mas bnombre.ext";
            // 
            // btnNuevoFormato
            // 
            this.btnNuevoFormato.Location = new System.Drawing.Point(448, 268);
            this.btnNuevoFormato.Name = "btnNuevoFormato";
            this.btnNuevoFormato.Size = new System.Drawing.Size(71, 28);
            this.btnNuevoFormato.TabIndex = 20;
            this.btnNuevoFormato.Text = "Cargar SAP";
            this.btnNuevoFormato.UseVisualStyleBackColor = true;
            this.btnNuevoFormato.Click += new System.EventHandler(this.btnNuevoFormato_Click);
            // 
            // ImpCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 332);
            this.Controls.Add(this.btnNuevoFormato);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImpCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar PO\'s";
            this.Load += new System.EventHandler(this.ImpCSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtManual;
        private System.Windows.Forms.RadioButton rbtAutomatico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDirCSV;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ProgressBar Barra;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblEstado;
        private System.Windows.Forms.CheckBox chkCortos;
        private System.Windows.Forms.CheckBox chkMat;
        private System.Windows.Forms.CheckBox chkMeQ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMeQ;
        private System.Windows.Forms.Button btnBuscarMeQ;
        private System.Windows.Forms.Button btnNuevoFormato;
    }
}