using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
namespace MaterialCore
{
    public partial class Principal : Form
    {

   //     Clases.Conexion conecion; no la e usado todavia
        Clases.Usuario usuario;
  

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            DialogResult accesar;

            usuario = new MaterialCore.Clases.Usuario();
            Login login = new Login();

            accesar = login.ShowDialog();
            usuario = login.usuario;

            if (accesar == DialogResult.Cancel || !usuario.autentificado)
                this.Close();

            else
            {
                usuario = login.usuario;
                login.Dispose();
              //  timer1_Tick(0, e);
            }
        }

        #region Importar PO
        //imporatacion de PO
        void AbrirImpPO()
        {
            ImpCSV.DefInstance.MdiParent = this;
            ImpCSV.DefInstance.Show();
        }
        private void menuPO_importar_Click(object sender, EventArgs e)
        {
            AbrirImpPO();
        }

        #endregion

     

        #region Quimicos
        //Quimicos
        void AbrirQuimicos()
        {
            //con este codigo y el que esta al final de la forma quimicos 
            //evita que se abra mas de una ventana no modal.
            Quimicos.DefInstance.MdiParent = this;
            Quimicos.DefInstance.Show();
        }
        private void menuQuimicos_Click(object sender, EventArgs e)
        {

        }
        private void BotonQuimicos_Click(object sender, EventArgs e)
        {
            AbrirQuimicos();
        }
        #endregion

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuPO_recibo_Click(object sender, EventArgs e)
        {
            ReciboPO.DefInstance.MdiParent = this;
            ReciboPO.DefInstance.Show();
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    switch (keyData)
        //    {
        //        case Keys.Control | Keys.Q:
        //            AbrirQuimicos();
        //            return true;

        //        case Keys.Control | Keys.I:
        //            AbrirImpPO();
        //            return true;

            

        //    }
        //    return false;
        //}

        //private void capturarLineaDePOToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    OrdenesCompra.CapturarOC coc = new OrdenesCompra.CapturarOC();
        //    coc.MdiParent = this;
        //    coc.Show();
        //}

        private void embarquesSinEnviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embarques.Embarques emb = new MaterialCore.Embarques.Embarques();
            emb.MdiParent = this;
            emb.Show();
        }



        private void modificarEmbarquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embarques.ModificacionEmbarque modemb = new Embarques.ModificacionEmbarque();
            modemb.MdiParent = this;
            modemb.Show();
        }

        private void obtenerDatosComplementariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embarques.DatosComplementarios obj = new MaterialCore.Embarques.DatosComplementarios();
            obj.MdiParent = this;
            obj.Show();

        }

        private void materialesYEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialesMQ.ReciborMQ objMEQ = new MaterialCore.MaterialesMQ.ReciborMQ();
            objMEQ.MdiParent = this;
            objMEQ.Show();
        }



        private void crearPaletaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Embarques.CrearTarima tar = new Embarques.CrearTarima();
            tar.MdiParent = this;
            tar.Show();
        }

        private void rehacerPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embarques.RehacerTarima tarima = new MaterialCore.Embarques.RehacerTarima();
            tarima.MdiParent = this;
            tarima.Show();
        }

        private void crearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embarques.CrearTarima tar = new Embarques.CrearTarima();
            tar.MdiParent = this;
            tar.Show();
        }

        private void modificarPaletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embarques.RehacerTarima tarima = new MaterialCore.Embarques.RehacerTarima();
            tarima.MdiParent = this;
            tarima.Show();
        }

        private void quimicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirQuimicos();
        }

        private void digitalizarPOsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialCore.OrdenesCompra.EscanearPL epl = new MaterialCore.OrdenesCompra.EscanearPL();
            epl.ShowDialog();
        }

        private void reciboDePOsINBOUNDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReciboPO recibo = new ReciboPO(true);

            recibo.MdiParent = this;
            recibo.Show();

        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormaRecibosPOINBOUND();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormaRecibosPO();
        }

        private void menu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormaEmbarquesSinEmbiar();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormaModificarEmbarque();
        }

        private void crearPaletaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            abrirFormaCrearTarima();
        }

        private void rehacerPaletaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrirFormaRehacerTarima();
        }

        private void maquinariaYEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormaMaquinariaEquipo();
        }

        private void consignacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormaConsignacion();
        }

        private void iTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormaITAR();
        }


        void abrirFormaRecibosPO()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "ReciboPO")
                {
                    f.Activate();
                    return;
                }
            }

            ReciboPO forma = new ReciboPO();
            forma.MdiParent = this;
            forma.Show();
        }

        void abrirFormaRecibosPOINBOUND()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "ReciboPO")
                {
                    f.Activate();
                    return;
                }
            }
            ReciboPO forma = new ReciboPO(true);
            forma.MdiParent = this;
            forma.Show();
        }

        void abrirFormaEmbarquesSinEmbiar()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Embarques")
                {
                    f.Activate();
                    return;
                }
            }
            Embarques.Embarques forma = new MaterialCore.Embarques.Embarques();
            forma.MdiParent = this;
            forma.Show();
        }

        void abrirFormaModificarEmbarque()
        {
                        foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "ModificacionEmbarque")
                {
                    f.Activate();
                    return;
                }
            }
            Embarques.ModificacionEmbarque forma = new MaterialCore.Embarques.ModificacionEmbarque();
            forma.MdiParent = this;
            forma.Show();
        }

        void abrirFormaCrearTarima()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "CrearTarima")
                {
                    f.Activate();
                    return;
                }
            }
            Embarques.CrearTarima forma = new MaterialCore.Embarques.CrearTarima();
            forma.MdiParent = this;
            forma.Show();
        }

        void abrirFormaRehacerTarima()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "RehacerTarima")
                {
                    f.Activate();
                    return;
                }
            }
            Embarques.RehacerTarima forma = new MaterialCore.Embarques.RehacerTarima();
            forma.MdiParent = this;
            forma.Show();
        }

        void abrirFormaMaquinariaEquipo()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "ReciborMQ")
                {
                    f.Activate();
                    return;
                }
            }
            MaterialesMQ.ReciborMQ forma = new MaterialCore.MaterialesMQ.ReciborMQ();
            forma.MdiParent = this;
            forma.Show();
        }

        void abrirFormaConsignacion()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Consignacion")
                {
                    f.Activate();
                    return;
                }
            }
            Catalogos.Consignacion forma = new MaterialCore.Catalogos.Consignacion();
            forma.MdiParent = this;
            forma.Show();
        }

        void abrirFormaITAR()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "ITAR")
                {
                    f.Activate();
                    return;
                }
            }
            Catalogos.ITAR forma = new MaterialCore.Catalogos.ITAR();
            forma.MdiParent = this;
            forma.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void reciboDeMeQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialesMQ.ReciborMQ objMEQ = new MaterialCore.MaterialesMQ.ReciborMQ();
            objMEQ.MdiParent = this;
            objMEQ.Show();
        }

        private void embarquesDespachadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embarques.EmbarquesEmbiados obj = new MaterialCore.Embarques.EmbarquesEmbiados();
            obj.MdiParent = this;
            obj.Show();
        }

        private void reciboDePOsIBOUNDAutomaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReciboPO recibo = new ReciboPO(true,true);

            recibo.MdiParent = this;
            recibo.Show();
        }

        private void digitalizarPOsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MaterialCore.OrdenesCompra.EscanearPL epl = new MaterialCore.OrdenesCompra.EscanearPL();
            epl.ShowDialog();
        }

        private void reciboDePOsINBOUNDAutomaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReciboPO recibo = new ReciboPO(true, true);

            recibo.MdiParent = this;
            recibo.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();
            _Bitacora.MixCerro();
        }

        private void digitalizarINBOUNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialCore.OrdenesCompra.EscanearPLInbound epl = new MaterialCore.OrdenesCompra.EscanearPLInbound();
            epl.ShowDialog();
        }

        private void cargarIncidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Incidencias.MaterialDetenido mat = new MaterialCore.Incidencias.MaterialDetenido();
            mat.MdiParent = this;
            mat.Show();
        }

        private void incidenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Incidencias.MaterialDetenido mat = new MaterialCore.Incidencias.MaterialDetenido();
            mat.MdiParent = this;
            mat.Show();
        }

        private void shipingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shipping.Shipping ship = new MaterialCore.Shipping.Shipping();
            ship.MdiParent = this;
            ship.Show();
        }

        private void materialDañadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Incidencias.MaterialDanado danado = new MaterialCore.Incidencias.MaterialDanado();
            danado.MdiParent = this;
            danado.Show();
        }




    }
}