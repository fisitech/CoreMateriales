using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.Detenidos
{
    public partial class DetenidosForma : Form
    {

        public bool _Resultado = true;
        string _Guia;
        string _Planta;


        public bool Resultado {
            get { return _Resultado; }
        }

        public DetenidosForma(string guia, string planta   )
        {
            InitializeComponent();

            _Guia = guia;
            _Planta = planta;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _Resultado = false;
            this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dgvConTarima.RowCount > 0)
            {
                this.detenerPartidaConTarimaTableAdapter.UpdateConTarima(_Planta, _Guia);
            }

            if (dgvSinEnviar.RowCount > 0)
            {
                this.detenerPartidaSinEnviarTableAdapter.UpdateSinEnviar(_Planta, _Guia);
            }

            _Resultado = true;
            this.Visible = false;
        }

        private void DetenidosForma_Load(object sender, EventArgs e)
        {

            this.detenerPartidaConTarimaTableAdapter.FillByGuia(this.embarques.DetenerPartidaConTarima, _Guia);
            this.detenerPartidaSinEnviarTableAdapter.FillByGuia(this.embarques.DetenerPartidaSinEnviar, _Guia);


        }







    }
}