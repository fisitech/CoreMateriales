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
    public partial class MaterialDanado : Form
    {
        public MaterialDanado()
        {
            InitializeComponent();
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Imagen (*.jpg)|*.jpg";
            dialogo.FilterIndex = 1;
            dialogo.Multiselect = false;
            dialogo.RestoreDirectory = true;

            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                lstFotos.Items.Add(dialogo.FileName.ToString());
            }

        }

        private void lstFotos_DoubleClick(object sender, EventArgs e)
        {
            if (lstFotos.Items.Count > 0)
            {
                lstFotos.Items.RemoveAt(lstFotos.SelectedIndex);
            }
        }

        private void btnBillTransp_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "PDF (*.pdf)|*.pdf";
            dialogo.FilterIndex = 1;
            dialogo.Multiselect = false;
            dialogo.RestoreDirectory = true;

            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txtBillTrasnp.Text =    dialogo.FileName.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validaNoGuia();
            //Insertar();
            //txtNoGuia.Focus();
        }

        private void validaNoGuia()
        {
            //this.materialesDanadoTableAdapter.Fill(this.maquinaria.MaterialesDanado);
            this.valida_nid_skuTableAdapter.FillByNidSku(this.maquinaria.valida_nid_sku, txtNoGuia.Text.Trim());
            if (this.maquinaria.valida_nid_sku.Count == 0)
            {
                DialogResult result = MessageBox.Show("El número de guía no existe, ¿Desea Continuar?", "Advertencia",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Insertar();
                    txtNoGuia.Focus();
                }
                else
                {
                    txtNoGuia.Text = string.Empty;
                    txtNoGuia.Focus();
                }
            }
            else
            {
                Insertar();
                txtNoGuia.Focus();
            }
        }

        void Insertar()
        {

            // si una validacion no es correcta se bota el insert
            if (!Validaciones())
                return;

            int id = Convert.ToInt32(
              this.materialesDanadoTableAdapter.InsertQuery(txtNoGuia.Text, txtComentarios.Text));

              string prefijo;
              string foto;
              string directorioDestino;


            //si se carga un PDF
              if (txtBillTrasnp.Text != "")
              {
                  prefijo = this.materialesDanadoTableAdapter.InsertQuery_detalle(id).ToString();
                  foto = "BILL" + prefijo.ToString(); //+ ".pdf";
                  directorioDestino = ConfigurationManager.AppSettings["dirOUT"].ToString();
                  File.Copy(txtBillTrasnp.Text, directorioDestino + foto);

                  this.materialesDanadoTableAdapter.UpdateQuery(foto, id);
              }

            //carga e inserta las id necesaros para cargar las fotos en el web, en el web se toma el id de la tabal de detalles, y se concatena  DM+ id+.jpg, para poder cargar la foto
            for (int i = 0; i < lstFotos.Items.Count; i++)
            {
                 prefijo = this.materialesDanadoTableAdapter.InsertQuery_detalle(id).ToString();
                 foto = "DM" + prefijo.ToString() + ".jpg";
                 directorioDestino = ConfigurationManager.AppSettings["dirOUT"].ToString();
                File.Copy(lstFotos.Items[i].ToString(), directorioDestino + foto);
                //carga el archivo al servidor con el preficao DMid_detalle.jpg
            }
            Limpiar();
            CargarDatos();






        }

        private void MaterialDanado_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        void CargarDatos()
        {
            this.materialesDanadoTableAdapter.Fill(this.maquinaria.MaterialesDanado);
         }



        
            //if(txtDirFoto.Text != "")
            //{
            //    string foto = "INC" + id.ToString() + ".jpg";
            //    this.materialesIncidenciasTableAdapter.UpdateFoto(foto, id);
            //    string directorioDestino = ConfigurationManager.AppSettings["dirOUT"].ToString();
            //    //if (!File.Exists(foto))//si no existe el archivo 
            //    //{
            //    //    MessageBox.Show("El archivo no existe");
            //    //    return;
            //    //}

            //    File.Copy(txtDirFoto.Text, directorioDestino + foto);
            // }

        bool Validaciones()
        {
            bool resultado = true;


            if (txtNoGuia.Text == "")
            {
               return false;
            }

            //validar que la guia exista;

            //validar que por lo menos aya una foto cargada

            //validar que haya un comentario

            

            return resultado;
        }

        void Limpiar()
        {
            txtNoGuia.Text = "";
            txtComentarios.Clear();
            txtBillTrasnp.Clear();
            lstFotos.Items.Clear();
            txtNoGuia.Focus();
        }

        private void actualizaCamposDGV()
        {

            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                string noGuia = row.Cells[1].Value.ToString();
                string Comentario = row.Cells[2].Value.ToString();

                this.materialesDanadoTableAdapter.UpdateaDgv(noGuia, Comentario, id);
            }
                CargarDatos();
            
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((Keys)e.KeyChar == Keys.Enter)
            //{
            //    dataGridView1.EndEdit();
            //    actualizaCamposDGV();
            //}

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizaCamposDGV();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string noGuia = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Comentario = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea Eliminar?", "Core Materiales", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.materialesDanadoTableAdapter.DeleteDanado(id);
                this.materialesDanadoTableAdapter.DeleteDanadoDetalle(id);
                CargarDatos();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


          
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //string noGuia = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //string Comentario = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if ((Keys)e.KeyChar == Keys.Enter)
            //{
                dataGridView1.EndEdit();
                actualizaCamposDGV();
            //}
        }


    }
}