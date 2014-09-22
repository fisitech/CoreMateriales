using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MaterialCore.Embarques
{
    public partial class Embarques : Form
    {
        Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();


        public Embarques()
        {
            InitializeComponent();
        }

        private void Embarques_Load(object sender, EventArgs e)
        {            
            this.materialesSinEnviarPlantaTableAdapter.Fill(this.embarques1.MaterialesSinEnviarPlanta);
        }

        private void QuitarRegistro(string Id)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
                        conn.InsertSQL = "UPDATE materialesOC " +
                        " SET cantidadRecibida = cantidadRecibida - " + dgvDetalleEmbarque.Rows[dgvDetalleEmbarque.CurrentRow.Index].Cells["CantidadRecibida"].Value.ToString() +
                        " WHERE ID = " + dgvDetalleEmbarque.Rows[dgvDetalleEmbarque.CurrentRow.Index].Cells["NumeroPO"].Value.ToString() +
                        " AND RenglonId = " + dgvDetalleEmbarque.Rows[dgvDetalleEmbarque.CurrentRow.Index].Cells["LineaPO"].Value.ToString();
            conn.insert();

            _Bitacora.MatBorro(Convert.ToInt32(Id), 
                Convert.ToInt32( dgvDetalleEmbarque.Rows[dgvDetalleEmbarque.CurrentRow.Index].Cells["NumeroPO"].Value),
              Convert.ToInt32(  dgvDetalleEmbarque.Rows[dgvDetalleEmbarque.CurrentRow.Index].Cells["LineaPO"].Value),
                dgvDetalleEmbarque.Rows[dgvDetalleEmbarque.CurrentRow.Index].Cells["NoGuia"].Value.ToString());


            //conn.InsertSQL = "UPDATE materialesOC " +
            //            " SET cantidadRecibida = cantidadRecibida - " + embarques1.MaterialesSinEnviar[materialesSinEnviarBindingSource.Position].CantidadRecibida +
            //            " WHERE ID = " + embarques1.MaterialesSinEnviar[materialesSinEnviarBindingSource.Position].MaterialesOCId +
            //            " AND RenglonId = " + embarques1.MaterialesSinEnviar[materialesSinEnviarBindingSource.Position].RenglonId;

            //conn.insert();

            conn.ExecSQL("DELETE FROM MaterialesEnviar WHERE Id = " + Id);

            conn.FinConexion();
        }

        private void QuitarRegistroTodos(string Id, decimal cantidad, int PO, int Linea)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            conn.InsertSQL = "UPDATE materialesOC " +
            " SET cantidadRecibida = cantidadRecibida - " + cantidad +
            " WHERE ID = " + PO +
            " AND RenglonId = " + Linea;
            conn.insert();

            conn.ExecSQL("DELETE FROM MaterialesEnviar WHERE Id = " + Id);
            conn.FinConexion();
        }

        private void ActualizarRegistro(int Id, string planta)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();

            conn.InsertSQL = "UPDATE MaterialesEnviar " +
                        " SET Planta = '" + planta + "'" +
                        " WHERE ID = " + Id;
                    

            conn.insert();

            conn.FinConexion();
        }

        private void dgvPlantas_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvPlantas.Rows.Count > 0)
            {
                CargaLineas();
                //string po = "%";

                //if (txtFiltroPO.Text != "")
                //{
                //    po = txtFiltroPO.Text;
                //}


                //this.materialesSinEnviarTableAdapter.FillByPlantaFiltro(
                //    this.embarques1.MaterialesSinEnviar,
                //    dgvPlantas.CurrentRow.Cells["gPlanta"].Value.ToString(),
                //    po
                //    );
                //lblRegistros.Text = dgvDetalleEmbarque.RowCount.ToString();
            }
            else
                lblRegistros.Text = "0";
        }

        //private void dgvDetalleEmbarque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //            DialogResult quitar;

        //    quitar = MessageBox.Show("¿Estas seguro de quitar el registro del embarque?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        //    if(quitar == DialogResult.Yes)
        //    {
        //        this.QuitarRegistro(embarques1.MaterialesSinEnviar[materialesSinEnviarBindingSource.Position]["Id"].ToString());
        //        MessageBox.Show("El registro ha sido quitado");

        //        this.materialesSinEnviarTableAdapter.FillByPlanta(this.embarques1.MaterialesSinEnviar, embarques1.MaterialesSinEnviarPlanta[materialesSinEnviarPlantaBindingSource.Position]["Planta"].ToString());
        //        dgvDetalleEmbarque.Refresh();
        //    }
            
        //}

        private void dgvDetalleEmbarque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       if(dgvDetalleEmbarque.RowCount > 0)
       {
           //se asegura de apuntar al binding correcto
           materialesSinEnviarBindingSource.Position = dgvDetalleEmbarque.CurrentRow.Index;
           switch (e.ColumnIndex)
           {
               case 10: //Editar
                   DialogResult quitar;

                   quitar = MessageBox.Show("¿Esta seguro de quitar el registro del embarque?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                   if (quitar == DialogResult.Yes)
                   {




                       this.QuitarRegistro(dgvDetalleEmbarque.CurrentRow.Cells["gId"].Value.ToString());
                  //     this.QuitarRegistro(embarques1.MaterialesSinEnviar[materialesSinEnviarBindingSource.Position]["Id"].ToString());
                       MessageBox.Show("El registro ha sido quitado");

                       this.materialesSinEnviarTableAdapter.FillByPlanta(this.embarques1.MaterialesSinEnviar, embarques1.MaterialesSinEnviarPlanta[materialesSinEnviarPlantaBindingSource.Position]["Planta"].ToString());
                       dgvDetalleEmbarque.Refresh();
                   }
                   break;

               case 8:

                   if ( Convert.ToBoolean( dgvDetalleEmbarque.CurrentRow.Cells["gescaneado"].Value)) //si ya esta escaneado
                           break;

                       if (dgvDetalleEmbarque.CurrentRow.Cells["PlantaID"].Value.ToString().ToUpper().Contains("IB")) // si es de planta INBOUND
                           break;

                       if (dgvDetalleEmbarque.CurrentRow.Cells["NoGuia"].Value.ToString().ToUpper().Contains("LOCAL")) // si guia LOCAL
                           break;

                   if (!ValidarGuiaDigitalizada(dgvDetalleEmbarque.CurrentRow.Cells["NoGuia"].Value.ToString()))
                   {
                       //Validar si ya se digitalizo el numero de guia
                       OrdenesCompra.EscanearPL escaner = new MaterialCore.OrdenesCompra.EscanearPL(dgvDetalleEmbarque.CurrentRow.Cells["NoGuia"].Value.ToString());
                       escaner.ShowDialog();
                       CargaLineas();

                   }





                   //break
                   break;




           }

            }
        }

        private void btnPaleta_Click(object sender, EventArgs e)
        {

            if (dgvDetalleEmbarque.RowCount > 0)
            {
                MaterialCore.Embarques.CrearTarima tarima = new CrearTarima(dgvPlantas.CurrentRow.Cells["gPlanta"].Value.ToString());
                tarima.ShowDialog();
                CargaLineas();
            }
            //this.materialesSinEnviarTableAdapter.FillByPlanta(this.embarques1.MaterialesSinEnviar, embarques1.MaterialesSinEnviarPlanta[materialesSinEnviarPlantaBindingSource.Position]["Planta"].ToString());


        }


        private void txtFiltroPO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || (Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Back) 
            {
                if ((Keys)e.KeyChar == Keys.Enter)
                {
                    CargaLineas();
                }
            }
            else
                e.Handled = true;
        




        }

        void CargaLineas()
        {

          string po = "%";

                if (txtFiltroPO.Text != "")
                {
                    po = txtFiltroPO.Text;
                }

                this.materialesSinEnviarTableAdapter.FillByPlantaFiltro(
              this.embarques1.MaterialesSinEnviar,
              dgvPlantas.CurrentRow.Cells["gPlanta"].Value.ToString(),
              po);
               lblRegistros.Text = dgvDetalleEmbarque.RowCount.ToString();
        }

        private void dgvDetalleEmbarque_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleEmbarque.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {

                string planta = dgvDetalleEmbarque.Rows[e.RowIndex].Cells["PlantaID"].Value.ToString();
                string guia = dgvDetalleEmbarque.Rows[e.RowIndex].Cells["NoGuia"].Value.ToString();

                if (planta.ToUpper().Contains("DD"))
                {
                    Detenidos.Detenidos objDet = new MaterialCore.Detenidos.Detenidos(guia);

                    if (!objDet.ConTarimab || !objDet.SinEmbiarb)
                    {
                        Detenidos.DetenidosForma objForma = new MaterialCore.Detenidos.DetenidosForma(guia, planta);

                        objForma.ShowDialog();

                        if (!objForma.Resultado)
                        {
                            return;
                        }
                        else
                        {
                            objForma.Dispose();
                        }

                    }
                }


            ActualizarRegistro(Convert.ToInt32(dgvDetalleEmbarque.Rows[e.RowIndex].Cells["gID"].Value),planta);
            
                this.materialesSinEnviarTableAdapter.FillByPlanta(this.embarques1.MaterialesSinEnviar, embarques1.MaterialesSinEnviarPlanta[materialesSinEnviarPlantaBindingSource.Position]["Planta"].ToString());

            }





        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtFiltroPO.Clear();
            this.materialesSinEnviarPlantaTableAdapter.Fill(this.embarques1.MaterialesSinEnviarPlanta);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            if(dgvPlantas.Rows.Count == 0)
                return;


            txtFiltroPO.Clear();
            CargaLineas();

            if (dgvDetalleEmbarque.Rows.Count == 0)
                return;


            string planta =    dgvPlantas.CurrentRow.Cells["gPlanta"].Value.ToString();

            if (DialogResult.Yes ==
                MessageBox.Show("¿Esta seguro de borrar todas las partidas de la planta: "   +planta+     "? ", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                for (int i = 0; i < dgvDetalleEmbarque.Rows.Count; i++)
                {
                    //deberia ser int
                    string id = dgvDetalleEmbarque.Rows[i].Cells["gId"].Value.ToString();
                    decimal cantidad = Convert.ToDecimal(dgvDetalleEmbarque.Rows[i].Cells["CantidadRecibida"].Value);
                    int PO = Convert.ToInt32(dgvDetalleEmbarque.Rows[i].Cells["NumeroPO"].Value);
                    int Linea=Convert.ToInt32(dgvDetalleEmbarque.Rows[i].Cells["LineaPO"].Value);
                    QuitarRegistroTodos(id, cantidad, PO, Linea);

                    _Bitacora.MatBorro(Convert.ToInt32( id), PO, Linea, dgvDetalleEmbarque.Rows[i].Cells["NoGuia"].Value.ToString());

                }

                this.materialesSinEnviarTableAdapter.FillByPlanta(this.embarques1.MaterialesSinEnviar, embarques1.MaterialesSinEnviarPlanta[materialesSinEnviarPlantaBindingSource.Position]["Planta"].ToString());
                dgvDetalleEmbarque.Refresh();



            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargaLineas();
        }

        bool ValidarGuiaDigitalizada(string guia)
        {
            SqlDataReader datos;

            MaterialCore.Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            bool resultado = true;

            datos = conn.getLector("SELECT     id, nid_sku, fecha, escaneado, nid_cliente " +
                                                "FROM         sku_escanear " +
                                                "WHERE     (nid_cliente = 70) AND (escaneado = 0) AND nid_sku = '" + guia + "'" +
                                                " ORDER BY fecha DESC");

            if (datos.Read())
            {
                resultado = false;
            }

            datos.Close();
            return resultado;
        }

    }
}