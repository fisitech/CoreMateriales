namespace MaterialCore
{
    partial class Configura
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
            this.dgvLogin = new System.Windows.Forms.DataGridView();
            this.bactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nid_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.labelMenus = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.labelSubmenus = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.cloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceLogin = new System.Windows.Forms.BindingSource(this.components);
            this.core_v2DataSet = new MaterialCore.core_v2DataSet();
            this.niduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nidpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidmenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bactiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceMenus = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new MaterialCore.core_v2DataSetTableAdapters.usersTableAdapter();
            this.users_menusTableAdapter = new MaterialCore.core_v2DataSetTableAdapters.users_menusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.core_v2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogin
            // 
            this.dgvLogin.AllowUserToAddRows = false;
            this.dgvLogin.AllowUserToDeleteRows = false;
            this.dgvLogin.AllowUserToOrderColumns = true;
            this.dgvLogin.AutoGenerateColumns = false;
            this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cloginDataGridViewTextBoxColumn,
            this.bactive,
            this.nid_user});
            this.dgvLogin.DataSource = this.bindingSourceLogin;
            this.dgvLogin.Location = new System.Drawing.Point(7, 22);
            this.dgvLogin.Name = "dgvLogin";
            this.dgvLogin.Size = new System.Drawing.Size(260, 407);
            this.dgvLogin.TabIndex = 0;
            this.dgvLogin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogin_CellClick);
            // 
            // bactive
            // 
            this.bactive.DataPropertyName = "bactive";
            this.bactive.FalseValue = "False";
            this.bactive.HeaderText = "Activo";
            this.bactive.Name = "bactive";
            this.bactive.TrueValue = "True";
            // 
            // nid_user
            // 
            this.nid_user.DataPropertyName = "nid_user";
            this.nid_user.HeaderText = "nid_user";
            this.nid_user.Name = "nid_user";
            this.nid_user.ReadOnly = true;
            this.nid_user.Visible = false;
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Location = new System.Drawing.Point(4, 6);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(48, 13);
            this.labelUsuarios.TabIndex = 1;
            this.labelUsuarios.Text = "Usuarios";
            // 
            // labelMenus
            // 
            this.labelMenus.AutoSize = true;
            this.labelMenus.Location = new System.Drawing.Point(273, 22);
            this.labelMenus.Name = "labelMenus";
            this.labelMenus.Size = new System.Drawing.Size(39, 13);
            this.labelMenus.TabIndex = 2;
            this.labelMenus.Text = "Menus";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AllowUserToOrderColumns = true;
            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.niduserDataGridViewTextBoxColumn,
            this.nidpersonDataGridViewTextBoxColumn,
            this.cloginDataGridViewTextBoxColumn1,
            this.cemailDataGridViewTextBoxColumn,
            this.cidmenuDataGridViewTextBoxColumn,
            this.cmenuDataGridViewTextBoxColumn,
            this.bactiveDataGridViewCheckBoxColumn});
            this.dgvMenu.DataSource = this.bindingSourceMenus;
            this.dgvMenu.Location = new System.Drawing.Point(276, 43);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(478, 150);
            this.dgvMenu.TabIndex = 3;
            // 
            // labelSubmenus
            // 
            this.labelSubmenus.AutoSize = true;
            this.labelSubmenus.Location = new System.Drawing.Point(273, 196);
            this.labelSubmenus.Name = "labelSubmenus";
            this.labelSubmenus.Size = new System.Drawing.Size(57, 13);
            this.labelSubmenus.TabIndex = 4;
            this.labelSubmenus.Text = "Submenus";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(276, 212);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(478, 145);
            this.dataGridView3.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(273, 406);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(354, 406);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelConfig
            // 
            this.panelConfig.Controls.Add(this.buttonCancel);
            this.panelConfig.Controls.Add(this.dgvLogin);
            this.panelConfig.Controls.Add(this.buttonSave);
            this.panelConfig.Controls.Add(this.labelUsuarios);
            this.panelConfig.Controls.Add(this.labelSubmenus);
            this.panelConfig.Controls.Add(this.dataGridView3);
            this.panelConfig.Controls.Add(this.labelMenus);
            this.panelConfig.Controls.Add(this.dgvMenu);
            this.panelConfig.Location = new System.Drawing.Point(12, 13);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(757, 434);
            this.panelConfig.TabIndex = 8;
            // 
            // cloginDataGridViewTextBoxColumn
            // 
            this.cloginDataGridViewTextBoxColumn.DataPropertyName = "clogin";
            this.cloginDataGridViewTextBoxColumn.HeaderText = "Usuarios";
            this.cloginDataGridViewTextBoxColumn.Name = "cloginDataGridViewTextBoxColumn";
            // 
            // bindingSourceLogin
            // 
            this.bindingSourceLogin.DataMember = "users";
            this.bindingSourceLogin.DataSource = this.core_v2DataSet;
            // 
            // core_v2DataSet
            // 
            this.core_v2DataSet.DataSetName = "core_v2DataSet";
            this.core_v2DataSet.EnforceConstraints = false;
            this.core_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // niduserDataGridViewTextBoxColumn
            // 
            this.niduserDataGridViewTextBoxColumn.DataPropertyName = "nid_user";
            this.niduserDataGridViewTextBoxColumn.HeaderText = "nid_user";
            this.niduserDataGridViewTextBoxColumn.Name = "niduserDataGridViewTextBoxColumn";
            this.niduserDataGridViewTextBoxColumn.Visible = false;
            // 
            // nidpersonDataGridViewTextBoxColumn
            // 
            this.nidpersonDataGridViewTextBoxColumn.DataPropertyName = "nid_person";
            this.nidpersonDataGridViewTextBoxColumn.HeaderText = "nid_person";
            this.nidpersonDataGridViewTextBoxColumn.Name = "nidpersonDataGridViewTextBoxColumn";
            this.nidpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // cloginDataGridViewTextBoxColumn1
            // 
            this.cloginDataGridViewTextBoxColumn1.DataPropertyName = "clogin";
            this.cloginDataGridViewTextBoxColumn1.HeaderText = "clogin";
            this.cloginDataGridViewTextBoxColumn1.Name = "cloginDataGridViewTextBoxColumn1";
            this.cloginDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cemailDataGridViewTextBoxColumn
            // 
            this.cemailDataGridViewTextBoxColumn.DataPropertyName = "cemail";
            this.cemailDataGridViewTextBoxColumn.HeaderText = "cemail";
            this.cemailDataGridViewTextBoxColumn.Name = "cemailDataGridViewTextBoxColumn";
            this.cemailDataGridViewTextBoxColumn.Visible = false;
            // 
            // cidmenuDataGridViewTextBoxColumn
            // 
            this.cidmenuDataGridViewTextBoxColumn.DataPropertyName = "cid_menu";
            this.cidmenuDataGridViewTextBoxColumn.HeaderText = "cid_menu";
            this.cidmenuDataGridViewTextBoxColumn.Name = "cidmenuDataGridViewTextBoxColumn";
            this.cidmenuDataGridViewTextBoxColumn.Visible = false;
            // 
            // cmenuDataGridViewTextBoxColumn
            // 
            this.cmenuDataGridViewTextBoxColumn.DataPropertyName = "cmenu";
            this.cmenuDataGridViewTextBoxColumn.HeaderText = "Menu";
            this.cmenuDataGridViewTextBoxColumn.Name = "cmenuDataGridViewTextBoxColumn";
            // 
            // bactiveDataGridViewCheckBoxColumn
            // 
            this.bactiveDataGridViewCheckBoxColumn.DataPropertyName = "bactive";
            this.bactiveDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.bactiveDataGridViewCheckBoxColumn.Name = "bactiveDataGridViewCheckBoxColumn";
            // 
            // bindingSourceMenus
            // 
            this.bindingSourceMenus.DataMember = "users_menus";
            this.bindingSourceMenus.DataSource = this.core_v2DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // users_menusTableAdapter
            // 
            this.users_menusTableAdapter.ClearBeforeFill = true;
            // 
            // Configura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 460);
            this.Controls.Add(this.panelConfig);
            this.Name = "Configura";
            this.Text = "Configura";
            this.Load += new System.EventHandler(this.Configura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.core_v2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogin;
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.Label labelMenus;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label labelSubmenus;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.BindingSource bindingSourceLogin;
        private core_v2DataSet core_v2DataSet;
        private MaterialCore.core_v2DataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid_user;
        private System.Windows.Forms.BindingSource bindingSourceMenus;
        private MaterialCore.core_v2DataSetTableAdapters.users_menusTableAdapter users_menusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn niduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nidpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidmenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bactiveDataGridViewCheckBoxColumn;
    }
}