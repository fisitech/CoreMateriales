using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.Embarques
{
    public partial class DatosComplementarios : Form
    {
        public DatosComplementarios()
        {
            InitializeComponent();
        }

        private void DatosComplementarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'embarques.DatosComplementarios' table. You can move, or remove it, as needed.
            this.datosComplementariosTableAdapter.Fill(this.embarques.DatosComplementarios);

        }

        private void btnCrearDocumento_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
            Clases.GuardaDatosComplementarios GDC = 
                        new MaterialCore.Clases.GuardaDatosComplementarios(
                        dgvDatos.CurrentRow.Cells["gCaja"].Value.ToString(),
                        dgvDatos.CurrentRow.Cells["gTransportista"].Value.ToString(),
                        dgvDatos.CurrentRow.Cells["gTarimas"].Value.ToString(),
                        dgvDatos.CurrentRow.Cells["gBultos"].Value.ToString(),
                        dgvDatos.CurrentRow.Cells["gPeso"].Value.ToString(),
                         dgvDatos.CurrentRow.Cells["gNid_deploy"].Value.ToString()
                        );
                            
          }//fin if
        }


    }
}