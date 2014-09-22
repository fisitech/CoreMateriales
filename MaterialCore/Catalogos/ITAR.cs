using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.Catalogos
{
    public partial class ITAR : Form
    {
        private ToolTip ttNuevo;
        private ToolTip ttEditar;
        private ToolTip ttBorrar;

        public ITAR()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.E:
                    UpdateRegistro();
                    return true;

                case Keys.Escape:
                    this.Close();
                    return true;

                case Keys.Control | Keys.N:
                    InsertRegistro();
                    return true;

                case Keys.Delete:
                    DeleteRegistro();
                    return true;

                case Keys.Control | Keys.D:
                    DeleteRegistro();
                    return true;

                case Keys.Up:
                    if (!dgQuimicos.Focused)
                        dgQuimicos.Focus();
                    return false;

                case Keys.Down:
                    if (!dgQuimicos.Focused)
                        dgQuimicos.Focus();
                    return false;


            }
            return false;
        }

        private void ITAR_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            this.ToolTipControles();
        }



        void ActualizarGrid()
        {
            this.materialesITARTableAdapter.Fill(this.catalogos.MaterialesITAR);
        }

        void ToolTipControles()
        {
            ttNuevo = new ToolTip();
            ttEditar = new ToolTip();
            ttBorrar = new ToolTip();

            ttNuevo.SetToolTip(this.btnNuevo, "Ctrl + N");
            ttEditar.SetToolTip(this.btnEditar, "Ctrl + E");
            ttBorrar.SetToolTip(this.btnBorrar, "Ctrl + D, Supr");
        }

        void UpdateRegistro()
        {
            string idnueva = txtID_quimico.Text;
            string descripcion = txtDescripcion.Text;
            string id = dgQuimicos.CurrentRow.Cells[0].Value.ToString();

            if (id != idnueva) //evalua que el id no se repita
            {
                for (int i = 0; i < dgQuimicos.Rows.Count; i++)
                {
                    if (idnueva == dgQuimicos.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("El id ya existe, no se puede editar el registro");
                        return;
                    }
                }
            }
            this.materialesITARTableAdapter.UpdateQuery(descripcion, id, 70);

            dgQuimicos.Rows[dgQuimicos.CurrentRow.Index].Cells[0].Value = idnueva;
            dgQuimicos.Rows[dgQuimicos.CurrentRow.Index].Cells[1].Value = descripcion;
        }

        void DeleteRegistro()
        {
            if (dgQuimicos.CurrentRow == null)
                return;

            if (dgQuimicos.Focused && dgQuimicos.CurrentRow.Index > -1)
            {
                if (DialogResult.Yes ==
                    MessageBox.Show("¿Quiere borrar el quimico?", "Alerta", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    string id = dgQuimicos.CurrentRow.Cells[0].Value.ToString();
                    this.materialesITARTableAdapter.DeleteQuery(id);

                    //borra el renglon sin refrescar el grid completamente
                    dgQuimicos.Rows.RemoveAt(dgQuimicos.CurrentRow.Index);
                }
            }
        }//fin de DeleteRegistro

        void InsertRegistro()
        {
            string id = txtID_quimico.Text;
            string descripcion = txtDescripcion.Text;

            for (int i = 0; i < dgQuimicos.Rows.Count; i++)
            {
                if (id == dgQuimicos.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("La ID ya existe, no se puede agregar el nuevo registro");
                    return;
                }
            }
            this.materialesITARTableAdapter.InsertQuery(id, descripcion, 70);
            ActualizarGrid();

            //    dgQuimicos.Rows.Add(id,descripcion);
        }


        private void dgQuimicos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgQuimicos.RowCount > 0)
            {
                txtID_quimico.Text = dgQuimicos.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgQuimicos.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txtID_quimico.Text == "")
            {
                MessageBox.Show("Debe agregar un numero de parte");
                return;
            }

            InsertRegistro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtID_quimico.Text == "")
            {
                MessageBox.Show("Debe agregar un numero de parte");
                return;
            }
            UpdateRegistro();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DeleteRegistro();
        }

    }//----------------------
}