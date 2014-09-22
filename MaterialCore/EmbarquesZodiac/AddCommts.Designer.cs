namespace MaterialCore.EmbarquesZodiac
{
    partial class AddCommts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCommts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddCmmts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bindingSourceAddComments = new System.Windows.Forms.BindingSource(this.components);
            this.core_v2DataSet = new MaterialCore.core_v2DataSet();
            this.embarquesZodiacTableAdapter = new MaterialCore.core_v2DataSetTableAdapters.EmbarquesZodiacTableAdapter();
            this.materialesEmbarquesTableAdapter1 = new MaterialCore.core_v2DataSetTableAdapters.MaterialesEmbarquesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAddComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.core_v2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddCmmts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 238);
            this.panel1.TabIndex = 2;
            // 
            // txtAddCmmts
            // 
            this.txtAddCmmts.Location = new System.Drawing.Point(16, 30);
            this.txtAddCmmts.Multiline = true;
            this.txtAddCmmts.Name = "txtAddCmmts";
            this.txtAddCmmts.Size = new System.Drawing.Size(562, 171);
            this.txtAddCmmts.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comments";
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(503, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bindingSourceAddComments
            // 
            this.bindingSourceAddComments.DataMember = "EmbarquesZodiac";
            this.bindingSourceAddComments.DataSource = this.core_v2DataSet;
            // 
            // core_v2DataSet
            // 
            this.core_v2DataSet.DataSetName = "core_v2DataSet";
            this.core_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // embarquesZodiacTableAdapter
            // 
            this.embarquesZodiacTableAdapter.ClearBeforeFill = true;
            // 
            // materialesEmbarquesTableAdapter1
            // 
            this.materialesEmbarquesTableAdapter1.ClearBeforeFill = true;
            // 
            // AddCommts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 238);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddCommts";
            this.Text = "Add new comments";
            this.Load += new System.EventHandler(this.AddCommts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAddComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.core_v2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddCmmts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bindingSourceAddComments;
        private core_v2DataSet core_v2DataSet;
        private MaterialCore.core_v2DataSetTableAdapters.EmbarquesZodiacTableAdapter embarquesZodiacTableAdapter;
        private MaterialCore.core_v2DataSetTableAdapters.MaterialesEmbarquesTableAdapter materialesEmbarquesTableAdapter1;
    }
}