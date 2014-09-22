using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore
{
    public partial class POActivos : Form
    {
        string _nid_po;



        public POActivos()
        {
            InitializeComponent();
        }

        private void POActivos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quimicos.MaterialesOCPO' table. You can move, or remove it, as needed.
            this.materialesOCPOTableAdapter.Fill(this.quimicos.MaterialesOCPO);
            // TODO: This line of code loads data into the 'quimicos.MaterialesOC' table. You can move, or remove it, as needed.            
            materialesOCPODataGridView.Focus();

        }        

        public string Nid_po
        {
            get { return _nid_po; }
        }

        private void materialesOCDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (materialesOCPODataGridView.RowCount > 0)
                _nid_po = materialesOCPODataGridView.CurrentRow.Cells[0].Value.ToString();
            else
                _nid_po = "";
        }
       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
 
                case Keys.Escape:
                    this.Close();
                    return true;

                case Keys.Enter:
                    this.Close();
                    return true;

                case Keys.Space:
                    this.Close();
                    return true;

            }
            return false;
        }

        private void materialesOCPODataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}