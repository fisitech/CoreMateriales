using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore
{
    public partial class Configura : Form
    {
        public Configura()
        {
            InitializeComponent();
        }

        private void Configura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'core_v2DataSet.users_menus' table. You can move, or remove it, as needed.
            this.bindingSourceMenus.Filter = "cmenu=' '";
            this.users_menusTableAdapter.FillUserMenu(this.core_v2DataSet.users_menus);
            // TODO: This line of code loads data into the 'core_v2DataSet.users' table. You can move, or remove it, as needed.
            
            this.usersTableAdapter.FillLogin(this.core_v2DataSet.users);
            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = System.Windows.Forms.Cursors.WaitCursor;
                Save();
                Cursor = System.Windows.Forms.Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        void Save()
        {
            foreach (DataGridViewRow row in this.dgvLogin.Rows)
            {
                int nid_user = int.Parse(row.Cells[2].Value.ToString());
                bool bactive=bool.Parse(row.Cells[1].Value.ToString());
                usersTableAdapter.UpdateQuery(bactive, nid_user, nid_user);
                

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            }

        private void dgvLogin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String filter = "nid_user='" + dgvLogin.CurrentRow.Cells["nid_user"].Value.ToString() + "'";
            bindingSourceMenus.Filter = filter.ToString();
        }
        void Filtro()
        {
          
        }
    }
}