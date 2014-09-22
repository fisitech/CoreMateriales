using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.Embarques
{
    public partial class EmbarquesEmbiados : Form
    {
        public EmbarquesEmbiados()
        {
            InitializeComponent();
        }

        private void EmbarquesEmbiados_Load(object sender, EventArgs e)
        {


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string NoGuia = "%";
            string PO = "%";
            string Linea = "%";
            string Caja = "%";
            string NumParte = "%";
            string Embarque = "%";
            string Consecutivo = "%";

            if (txtNoGuia.Text != "")
                NoGuia = txtNoGuia.Text;

            if (txtPO.Text != "")
                PO = txtPO.Text;

            if (txtLinea.Text != "")
                Linea = txtLinea.Text;

            if (txtNoCaja.Text != "")
                Caja = txtNoCaja.Text;

            if (txtNoParte.Text != "")
                NumParte = txtNoParte.Text;

            if (txtEmbarque.Text != "")
                Embarque = txtEmbarque.Text;

            if (txtConsecutivo.Text != "")
                Consecutivo = txtConsecutivo.Text;

            //string NoGuia = txtNoGuia.Text;
            //int PO = int.Parse(txtPO.Text);
            //int Linea = int.Parse(txtLinea.Text);
            //string Caja = txtNoCaja.Text;
            //string NumParte = txtNoParte.Text;
            //int Embarque = int.Parse( txtEmbarque.Text);
            //int Consecutivo =  int.Parse(txtConsecutivo.Text);

            //this.partidasDespachadasTableAdapter.Fill(this.embarques.PartidasDespachadas, NoGuia, PO, Linea, Caja, NumParte,Embarque,Consecutivo);
            this.partidasDespachadasTableAdapter.Fill(this.embarques.PartidasDespachadas, NoGuia, PO, Linea, Caja, NumParte, Embarque, Consecutivo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNoGuia.Text = "";
            txtPO.Text = "";
            txtLinea.Text = "";
            txtNoCaja.Text = "";
            txtNoParte.Text = "";
            txtEmbarque.Text = "";
            txtConsecutivo.Text = "";
          
        }











    }
}