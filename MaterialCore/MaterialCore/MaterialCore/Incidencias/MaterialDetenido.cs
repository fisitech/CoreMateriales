using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace MaterialCore.Incidencias
{
    public partial class MaterialDetenido : Form
    {
        public MaterialDetenido()
        {
            InitializeComponent();
        }



        private void MaterialDetenido_Load(object sender, EventArgs e)
        {
            CargarIncidencias();
            cmbTipo.Text  = "(Seleccione uno)";
        

        }

        void CargarIncidencias()
        {
            this.materialesIncidenciasTableAdapter.FillByFecha(this.incidencias.MaterialesIncidencias);
        }

        void InsertarIncidencia()
        {
           int id;
            id = Convert.ToInt32(

            this.materialesIncidenciasTableAdapter.InsertQuery(
                AInteger(txtPO.Text),
                AInteger(txtLinea.Text),
                txtNoGuia.Text,
                txtComentario.Text,
                cmbTipo.Text,
              null,
             Clases.Logueado.nid_usuario));


            if(txtDirFoto.Text != "")
            {

                string foto = "INC" + id.ToString() + ".jpg";
                this.materialesIncidenciasTableAdapter.UpdateFoto(foto, id);

                string directorioDestino = ConfigurationManager.AppSettings["dirOUT"].ToString();
                //if (!File.Exists(foto))//si no existe el archivo 
                //{
                //    MessageBox.Show("El archivo no existe");
                //    return;
                //}

                File.Copy(txtDirFoto.Text, directorioDestino + foto);



             }
            CargarIncidencias();



        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
       //VALIDAR LOS CAMPOS LLENOS
            if (cmbTipo.Text == "(Seleccione uno)")
            {
                MessageBox.Show("Seleccione un tipo de incidencia");
                return;
            }

            InsertarIncidencia();
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Imagen (*.jpg)|*.jpg";
            dialogo.FilterIndex = 1;
            dialogo.Multiselect = false;
            dialogo.RestoreDirectory = true;

            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
                txtDirFoto.Text = dialogo.FileName.ToString();
        }


        void Limpiar()
        {
            txtDirFoto.Text = "";
            txtPO.Text = "";
            txtLinea.Text = "";
            txtNoGuia.Text = "";
            txtComentario.Text = "";
            cmbTipo.Text = "(Seleccione uno)";

        }

        Int32? AInteger(string numero)
        {
            int? resultado;

            if (numero == "")
                resultado = null;
            else
                resultado = Convert.ToInt32(numero);

            return resultado;
        }

        private void txtPO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || (Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Back)
            {
            }
            else
                e.Handled = true;

        }

        private void txtLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || (Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Back)
            {
            }
            else
                e.Handled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

    }
}