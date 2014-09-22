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
    public partial class ModificacionEmbarque : Form
    {
        Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();

        public ModificacionEmbarque()
        {
            InitializeComponent();
        }


        private void ModificacionEmbarque_Load(object sender, EventArgs e)
        {
            //  this.materialesPaltetasTableAdapter.Fill(this.embarques.MaterialesPaltetas);
            this.materialesPaltetasTableAdapter.FillByNoEnviadas(this.embarques.MaterialesPaltetas);
        }



        private void btnQuitar_Click(object sender, EventArgs e)
        {

            if (materialesEnviarDataGridView.RowCount > 0)
            {
                DialogResult quitar;

                quitar = MessageBox.Show("¿Estas seguro de quitar el registro del embarque?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (quitar == DialogResult.Yes)
                {
                    //   this.QuitarRegistro(embarques.MaterialesEnviar[materialesEnviarBindingSource.Position].Id.ToString());
                    this.QuitarRegistro(materialesEnviarDataGridView.CurrentRow.Cells["Id2"].Value.ToString());

                    _Bitacora.MatBorro(Convert.ToInt32(materialesEnviarDataGridView.CurrentRow.Cells["Id2"].Value),
                        Convert.ToInt32(materialesEnviarDataGridView.CurrentRow.Cells["g2PO"].Value),
                        Convert.ToInt32(materialesEnviarDataGridView.CurrentRow.Cells["g2Renglon"].Value),
                        materialesEnviarDataGridView.CurrentRow.Cells["NoGuia"].Value.ToString());
                    
                    
                    //if (materialesPaltetasDataGridView.RowCount > 0)
                    //{
                    //    this.materialesEnviarTableAdapter.Fill(this.embarques.MaterialesEnviar, Convert.ToInt32(materialesPaltetasDataGridView.CurrentRow.Cells["Id"].Value));
                    //}
                    CargarLinesPorPaleta();

                }
            }
        }

        private void QuitarRegistro(string Id)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();

            conn.InsertSQL = "UPDATE materialesOC " +
                        " SET cantidadRecibida = cantidadRecibida - " + Convert.ToDecimal(materialesEnviarDataGridView.CurrentRow.Cells["g2Cantidad"].Value) +
                        " WHERE ID = " + Convert.ToInt32(materialesEnviarDataGridView.CurrentRow.Cells["g2PO"].Value) +
                        " AND RenglonId = " + Convert.ToInt32(materialesEnviarDataGridView.CurrentRow.Cells["g2Renglon"].Value);

            conn.insert();

            conn.ExecSQL("DELETE FROM MaterialesEnviar WHERE Id = " + Id);

            conn.FinConexion();
        }
        private void QuitarDeTarima(string Id)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();


            conn.ExecSQL("UPDATE  MaterialesEnviar  set MaterialesPaletasId = NULL, preparado = 0 WHERE Id = " + Id);

            conn.FinConexion();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (materialesPaltetasDataGridView.RowCount > 0)
            {
                if (materialesPaltetasDataGridView.CurrentRow.Cells["Planta"].Value.ToString().ToUpper().Contains("IB"))
                {
                    //carga la forma del tipo inbound
                    ReciboPO rPO = new ReciboPO(true);
                    //le manda el parametro de la palnata para que no se asocie una que no coresponda a la de la paleta.
                    rPO.Planta = materialesPaltetasDataGridView.CurrentRow.Cells["Planta"].Value.ToString();
                    rPO.MaterialesPaletasId = Convert.ToInt32(materialesPaltetasDataGridView.CurrentRow.Cells["Id"].Value);
                    rPO.ShowDialog();
                }
                else
                {

                    ReciboPO rPO = new ReciboPO();
                    //le manda el parametro de la palnata para que no se asocie una que no coresponda a la de la paleta.
                    rPO.Planta = materialesPaltetasDataGridView.CurrentRow.Cells["Planta"].Value.ToString();
                    rPO.MaterialesPaletasId = Convert.ToInt32(materialesPaltetasDataGridView.CurrentRow.Cells["Id"].Value);
                    rPO.ShowDialog();
                }
                //if (materialesPaltetasDataGridView.RowCount > 0)
                //{
                //this.materialesEnviarTableAdapter.Fill(this.embarques.MaterialesEnviar, Convert.ToInt32(materialesPaltetasDataGridView.CurrentRow.Cells["Id"].Value));
                //}
                CargarLinesPorPaleta();

            }
        }

        private void materialesPaltetasDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //if (materialesPaltetasDataGridView.RowCount > 0)
            //    this.materialesEnviarTableAdapter.Fill(this.embarques.MaterialesEnviar, Convert.ToInt32(materialesPaltetasDataGridView.CurrentRow.Cells["Id"].Value));
            CargarLinesPorPaleta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (materialesEnviarDataGridView.RowCount > 0)
            {
                DialogResult quitar;

                quitar = MessageBox.Show("¿Estas seguro de quitar el registro de la paleta pero no desmarcarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (quitar == DialogResult.Yes)
                {
                    //   this.QuitarRegistro(embarques.MaterialesEnviar[materialesEnviarBindingSource.Position].Id.ToString());

                    //    this.QuitarRegistro(materialesEnviarDataGridView.CurrentRow.Cells["Id2"].Value.ToString());
                    QuitarDeTarima(materialesEnviarDataGridView.CurrentRow.Cells["Id2"].Value.ToString());

                    _Bitacora.MatDesmarco(Convert.ToInt32(materialesEnviarDataGridView.CurrentRow.Cells["Id2"].Value),
                          Convert.ToInt32(materialesEnviarDataGridView.CurrentRow.Cells["g2PO"].Value),
                          Convert.ToInt32(materialesEnviarDataGridView.CurrentRow.Cells["g2Renglon"].Value),
                          materialesEnviarDataGridView.CurrentRow.Cells["NoGuia"].Value.ToString());
                    


                    //if (materialesPaltetasDataGridView.RowCount > 0)
                    //{
                    //this.materialesEnviarTableAdapter.Fill(this.embarques.MaterialesEnviar, Convert.ToInt32(materialesPaltetasDataGridView.CurrentRow.Cells["Id"].Value));
                    //lblRegistros.Text = materialesEnviarDataGridView.RowCount.ToString();
                    CargarLinesPorPaleta();


                }
            }
        }

        void CargarLinesPorPaleta()
        {
            if (materialesPaltetasDataGridView.RowCount > 0)
            {
                this.materialesEnviarTableAdapter.Fill(this.embarques.MaterialesEnviar, Convert.ToInt32(materialesPaltetasDataGridView.CurrentRow.Cells["Id"].Value));
                lblRegistros.Text = materialesEnviarDataGridView.RowCount.ToString();
            }
            else
                lblRegistros.Text = "0";
        }

        private void btnQuitarTodos_Click(object sender, EventArgs e)
        {
            //-
            if (materialesEnviarDataGridView.RowCount > 0)
            {
                DialogResult quitar;

                quitar = MessageBox.Show("¿Estas seguro de quitar TODOS los registro del embarque?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (quitar == DialogResult.Yes)
                {
                    for (int i = 0; i < materialesEnviarDataGridView.Rows.Count; i++)
                    {
                        string id = materialesEnviarDataGridView.Rows[i].Cells["Id2"].Value.ToString();
                        int po = Convert.ToInt32(materialesEnviarDataGridView.Rows[i].Cells["g2PO"].Value);
                        int renglon = Convert.ToInt32(materialesEnviarDataGridView.Rows[i].Cells["g2Renglon"].Value);
                        decimal cantidad = Convert.ToDecimal(materialesEnviarDataGridView.Rows[i].Cells["g2Cantidad"].Value);


                        this.QuitarRegistro2(id, po, renglon, cantidad);


                        _Bitacora.MatBorro(Convert.ToInt32(materialesEnviarDataGridView.Rows[i].Cells["Id2"].Value),
                       Convert.ToInt32(materialesEnviarDataGridView.Rows[i].Cells["g2PO"].Value),
                       Convert.ToInt32(materialesEnviarDataGridView.Rows[i].Cells["g2Renglon"].Value),
                       materialesEnviarDataGridView.Rows[i].Cells["NoGuia"].Value.ToString());

                    }
                    CargarLinesPorPaleta();
                }
            }
            //-
        }

        private void btnRegresarTodos_Click(object sender, EventArgs e)
        {
            if (materialesEnviarDataGridView.RowCount > 0)
            {
                DialogResult quitar;
                quitar = MessageBox.Show("¿Estas seguro de regresar TODOS los registros a partidas no enviadas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (quitar == DialogResult.Yes)
                {
                    for (int i = 0; i < materialesEnviarDataGridView.Rows.Count; i++)
                    {
                        QuitarDeTarima(materialesEnviarDataGridView.Rows[i].Cells["Id2"].Value.ToString());

                        _Bitacora.MatDesmarco(Convert.ToInt32(materialesEnviarDataGridView.Rows[i].Cells["Id2"].Value),
                      Convert.ToInt32(materialesEnviarDataGridView.Rows[i].Cells["g2PO"].Value),
                      Convert.ToInt32(materialesEnviarDataGridView.Rows[i].Cells["g2Renglon"].Value),
                      materialesEnviarDataGridView.Rows[i].Cells["NoGuia"].Value.ToString());
                    }
                    CargarLinesPorPaleta();
                }
            }
        }

        private void QuitarRegistro2(string Id, int PO, int Renglon, decimal Cantidad)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();

            conn.InsertSQL = "UPDATE materialesOC " +
                        " SET cantidadRecibida = cantidadRecibida - " + Cantidad +
                        " WHERE ID = " + PO +
                        " AND RenglonId = " + Renglon;

            conn.insert();

            conn.ExecSQL("DELETE FROM MaterialesEnviar WHERE Id = " + Id);

            conn.FinConexion();
        }

        private void materialesEnviarDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (materialesEnviarDataGridView.RowCount > 0)
            {
                switch (e.ColumnIndex)
                {
                    case 9:
                   if ( Convert.ToBoolean( materialesEnviarDataGridView.CurrentRow.Cells["escaneado"].Value)) //si ya esta escaneado
                           break;

                       if (materialesPaltetasDataGridView.CurrentRow.Cells["Planta"].Value.ToString().ToUpper().Contains("IB")) // si es de planta INBOUND
                           break;

                       if (materialesEnviarDataGridView.CurrentRow.Cells["NoGuia"].Value.ToString().ToUpper().Contains("LOCAL")) // si guia LOCAL
                           break;

                   if (!ValidarGuiaDigitalizada(materialesEnviarDataGridView.CurrentRow.Cells["NoGuia"].Value.ToString()))
                   {
                       //Validar si ya se digitalizo el numero de guia
                       OrdenesCompra.EscanearPL escaner = new MaterialCore.OrdenesCompra.EscanearPL(materialesEnviarDataGridView.CurrentRow.Cells["NoGuia"].Value.ToString());
                       escaner.ShowDialog();
                       CargarLinesPorPaleta();

                   }
                   break;
            }
        }

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