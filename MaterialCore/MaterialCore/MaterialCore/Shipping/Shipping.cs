using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.Shipping
{
    public partial class Shipping : Form
    {
        public Shipping()
        {
            InitializeComponent();
        }

        private void Shipping_Load(object sender, EventArgs e)
        {
            this.materialesShippingTableAdapter.Fill(this.maquinaria.MaterialesShipping);
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //int  id;
            //id = Convert.ToInt32(dgvShipping.CurrentRow.Cells["gid"].Value);
            //MessageBox.Show(id.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

       

            //int Id = Convert.ToInt32( dgvShipping.CurrentRow.Cells["gid"].Value);
            //string PackSum = dgvShipping.CurrentRow.Cells["gPackSum"].Value.ToString();
            //DateTime fechaRBI = Convert.ToDateTime(dgvShipping.CurrentRow.Cells["gfechaRBI"].Value);
            //string Transportista = dgvShipping.CurrentRow.Cells["gTransportista"].Value.ToString();
            //string Consignee = dgvShipping.CurrentRow.Cells["gConsignee"].Value.ToString();
            //string Domestic = dgvShipping.CurrentRow.Cells["gDomestic"].Value.ToString();
            //DateTime  fechaLlegada = Convert.ToDateTime(dgvShipping.CurrentRow.Cells["gfechaLlegada"].Value);
            //DateTime fechaDespacho = Convert.ToDateTime(dgvShipping.CurrentRow.Cells["gfechaDespacho"].Value);
            //string NoGuia = dgvShipping.CurrentRow.Cells["gnoGuia"].Value.ToString();
            //string Comentario = dgvShipping.CurrentRow.Cells["gComentarios"].Value.ToString();

            
            //int Id,
            //string PackSum,
            //DateTime fechaRBI,
            //string Transportista,
            //string Consignee,
            //string Domestic,
            //DateTime  fechaLlegada,
            //DateTime fechaDespacho,
            //string NoGuia,
            //string Comentario
            Insertar();

        }


        void Insertar( )
        {

            
            int Id = Convert.ToInt32( dgvShipping.CurrentRow.Cells["gid"].Value);
            string PackSum = dgvShipping.CurrentRow.Cells["gPackSum"].Value.ToString();
            DateTime fechaRBI = Convert.ToDateTime(dgvShipping.CurrentRow.Cells["gfechaRBI"].Value);
            string Transportista = dgvShipping.CurrentRow.Cells["gTransportista"].Value.ToString();
            string Consignee = dgvShipping.CurrentRow.Cells["gConsignee"].Value.ToString();
            string Domestic = dgvShipping.CurrentRow.Cells["gDomestic"].Value.ToString();
            DateTime  fechaLlegada = Convert.ToDateTime(dgvShipping.CurrentRow.Cells["gfechaLlegada"].Value);
            DateTime fechaDespacho = Convert.ToDateTime(dgvShipping.CurrentRow.Cells["gfechaDespacho"].Value);
            string NoGuia = dgvShipping.CurrentRow.Cells["gnoGuia"].Value.ToString();
            string Comentario = dgvShipping.CurrentRow.Cells["gComentarios"].Value.ToString();



            this.materialesShippingTableAdapter.InsertInteligente(Id, PackSum, fechaRBI, Transportista, Consignee,
                Domestic, fechaLlegada, fechaDespacho, NoGuia, Comentario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dgvShipping.CurrentRow.Cells["gid"].Value);
            MessageBox.Show(id.ToString());
        }


    }
}