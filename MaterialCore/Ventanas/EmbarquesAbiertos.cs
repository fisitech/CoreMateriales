using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MaterialCore.Ventanas
{
    public partial class EmbarquesAbiertos : Form
    {
        Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();

        int _idCliente;
        int _nid_deploy = 0;
        public EmbarquesAbiertos(int idCliente)
        {
            _idCliente = idCliente;
            InitializeComponent();
        }

        private void EmbarquesAbiertos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'catalogos.Transportistas' table. You can move, or remove it, as needed.
            this.transportistasTableAdapter.Fill(this.catalogos.Transportistas);
            this.despachosAbiertosTableAdapter.FillbyCliente(this.catalogos.DespachosAbiertos, _idCliente);
        }

        public int Nid_deploy{
                get{return _nid_deploy ;}
        }

        private void dgvEmbarques_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmbarques.RowCount > 0)
            {
                if(dgvEmbarques.CurrentRow.Index > -1)
                {
                despachosAbiertosBindingSource.Position = dgvEmbarques.CurrentRow.Index;

                _nid_deploy = Convert.ToInt32(this.catalogos.DespachosAbiertos[despachosAbiertosBindingSource.Position]["nid_deploy"]);
                    //catalogos.DespachosAbiertos[ despachosAbiertosBindingSource.
                this.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GenerarDespacho(string transportista, string caja)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            SqlDataReader despachosDR;
            int resultado = 0;

            //despachosDR = conn.getLector(//"SET DATEFORMAT YMD;" +
            //                "SELECT nid_deploy " +
            //                "FROM deploys " +
            //                "WHERE " +
            //                    "CONVERT(DATETIME,CONVERT(VARCHAR(11),dcreation)) = " +
            //                        "CONVERT(DATETIME,CONVERT(VARCHAR(11),GETDATE())) " +
            //                    "AND nid_filial = 70 and bclosed = 0");

            //if (despachosDR.Read())
            //{
            //    resultado = Convert.ToInt32(despachosDR["nid_deploy"]);
            //}
            //else
            //{
            //    despachosDR.Close();

                conn.InsertSQL = "INSERT INTO deploys " +
                                       "(nid_filial, dcreation , dEndSelection,bclosed, nid_user) " +
                                 "VALUES " +
                                       "(@nid_filial, GETDATE(), GETDATE(), 0, @nid_user);";

                conn.InsertParametros.Add("@nid_filial", SqlDbType.Int, 4).Value = 70;
                conn.InsertParametros.Add("@nid_user", SqlDbType.Int, 4).Value = 1;

                conn.insert();

                despachosDR = conn.getLector("SELECT IDENT_CURRENT('deploys') as nid_deploy");

                if (despachosDR.Read())
                {
                    resultado = Convert.ToInt32(despachosDR["nid_deploy"]);

                }
                despachosDR.Close();

                //Inserta un despacho ficticio en la tabla, este se puede cambiar desde el sistema por el rela
                conn.InsertSQL = string.Format("insert into carriers_deploys values (getdate(), '{0}', '{1}', " + resultado + ", 1, 0, 0, null)",transportista,caja);
                conn.insert();


            //llegada ya libarada autyomatica
                //conn.InsertSQL = "insert into carriers_arrivals (cname_driver,cve_transp,nid_filial,nid_transport_type,cbox_number,ctype,nbill_type,cstatus) "+
                //                            "values('soltelo automatico','SOTELO',70,1,'X','out',1,'A')";
                //conn.insert();


            //}
            conn.FinConexion();

            return resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNoCaja.Text == "")
            {
                MessageBox.Show("Falta agregar el número de caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtNoCaja.Focus();
                return;
            }


            if (DialogResult.Yes ==
                MessageBox.Show("¿Esta seguro en crear un despacho nuevo?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {

                string transp = cmbTransportista.SelectedValue.ToString();
                string caja = txtNoCaja.Text;

            int despacho = Convert.ToInt32(GenerarDespacho(transp, caja));
            _Bitacora.MatCreaDespacho(despacho.ToString());

           this.despachosAbiertosTableAdapter.FillbyCliente(this.catalogos.DespachosAbiertos, _idCliente);
                button2.Enabled = false;
            }
        }

        private void dgvEmbarques_KeyDown(object sender, KeyEventArgs e)
        {


            if (dgvEmbarques.RowCount > 0)
            {
                if (dgvEmbarques.CurrentRow.Index > -1)
                {
                    if (e.KeyCode == Keys.Insert /*|| e.KeyCode == Keys.Enter*/)
                    {
                        e.Handled = false;

                        despachosAbiertosBindingSource.Position = dgvEmbarques.CurrentRow.Index;

                        _nid_deploy = Convert.ToInt32(this.catalogos.DespachosAbiertos[despachosAbiertosBindingSource.Position]["nid_deploy"]);
                        //catalogos.DespachosAbiertos[ despachosAbiertosBindingSource.
                        this.Visible = false;
                    }
                }
            }




        }


    }
}