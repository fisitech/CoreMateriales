using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace MaterialCore.MaterialesMQ
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }
        Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();

        //Ventanas.Cargando cargando = new MaterialCore.Ventanas.Cargando();

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
          
            //cargando.Show();
            //Application.DoEvents();

            if (dgvPartidas.RowCount <= 0)
            {
                //cargando.Hide();
                return;
            }

            lblCargando.Visible = true;
            Application.DoEvents();
            GenerarArchivos();

            lblCargando.Visible = false;
            //cargando.Hide();

        }


        void GenerarArchivos()
        {
          

            GenearPorProveedores();
/* ESTA PARTE FUNCIONA BIEN PERO DA ERRO ENALGUNAS MAQUNAS

            Clases.MeQExcel GDC = new MaterialCore.Clases.MeQExcel(ConfigurationManager.AppSettings["dirPDF"].ToString(),Convert.ToInt32(txtConsecutivo.Text) );

            DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter Meq = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter();
            Meq.UpdatePreparado(Convert.ToInt32(txtConsecutivo.Text));

            if (GDC.mensaje == "")
                MessageBox.Show("Archivo Excel creado correctamente en el  directorio: " + ConfigurationManager.AppSettings["dirPDF"].ToString());
            else
                MessageBox.Show(GDC.mensaje);
            */

            ExcelConPO();
            ExcelSinPO();
            _Bitacora.MeqCreoArchivo(txtConsecutivo.Text);


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(txtConsecutivo.Text != "")
            {
            this.generarTXTTableAdapter.FillBytodos(maquinaria.GenerarTXT, 70, Convert.ToInt32(txtConsecutivo.Text));
            ContadorPO();
            }
        }

        private void txtConsecutivo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                btnFiltrar_Click(0, null);
            }
        }

        private void GenearPorProveedores()
        {
            //si existe hay que borrarla para crearla limpia
            int consecutivo = Convert.ToInt32(txtConsecutivo.Text);

            DataSets.MaquinariaTableAdapters.ProveedoresTXTTableAdapter proTA = new MaterialCore.DataSets.MaquinariaTableAdapters.ProveedoresTXTTableAdapter();
            DataSets.Maquinaria.ProveedoresTXTDataTable proDT = new MaterialCore.DataSets.Maquinaria.ProveedoresTXTDataTable();

            DataSets.MaquinariaTableAdapters.GenerarTXTTableAdapter txtTA = new MaterialCore.DataSets.MaquinariaTableAdapters.GenerarTXTTableAdapter();
            DataSets.Maquinaria.GenerarTXTDataTable txtDT = new MaterialCore.DataSets.Maquinaria.GenerarTXTDataTable();

            proTA.FillbyConsecutivo(proDT, consecutivo);

       


            string Carpeta = ConfigurationManager.AppSettings["dirPDF"].ToString() + "\\MeQ\\Proveedores - " + consecutivo;

            if (System.IO.Directory.Exists(Carpeta))
            {
                DeleteRecursiveFolder(Carpeta);
            }

            if (!System.IO.Directory.Exists(Carpeta))
            {
                System.IO.Directory.CreateDirectory(Carpeta);
            }


            Clases.ExportarTXT ojbTXT = new MaterialCore.Clases.ExportarTXT();
            foreach (DataRow r in proDT.Rows)
            {
                txtTA.FillByProveedor( txtDT,70,
                   consecutivo,
                     r["Proveedor"].ToString());

                if (!System.IO.Directory.Exists(Carpeta))
                {
                    System.IO.Directory.CreateDirectory(Carpeta);
                }

                ojbTXT.exportarMQ(Carpeta + "\\" + consecutivo + "-" + Convert.ToString(r["Proveedor"]) + ".txt", txtDT);


            }
         
        }

                   
					
				 private void DeleteRecursiveFolder(string pFolderPath)
        {
            foreach (string Folder in Directory.GetDirectories(pFolderPath))
            {
                DeleteRecursiveFolder(Folder);
            }

            foreach (string file in Directory.GetFiles(pFolderPath))
            {
                FileInfo fi = new FileInfo(file);
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            Directory.Delete(pFolderPath);
        }


        #region Contadores


        void ContadorPO()
        {
            int ConPO = dgvPartidas.RowCount;
            int SinPO = 0;
            int Padres = 0;
            lblTotal.Text = dgvPartidas.RowCount.ToString();

        
            for (int i = 0; i < dgvPartidas.RowCount; i++)
            {
                dgvPartidas.Rows[i].DefaultCellStyle.BackColor = Color.White;
                dgvPartidas.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                if (Convert.ToInt32(dgvPartidas.Rows[i].Cells["gHijo"].Value) == 0)
                    dgvPartidas.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(141, 180, 227);
                else
                    dgvPartidas.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(197, 217, 241);

                if (dgvPartidas.Rows[i].Cells["gPO"].Value.ToString() == "0")
                {
                    SinPO += 1;
                }
                else
                {
                    if (dgvPartidas.Rows[i].Cells["gHijo"].Value.ToString() == "0")
                        Padres += 1;
                }
               }

            lblTotalSin.Text = SinPO.ToString();
            ConPO -= SinPO;
            lblToltaCon.Text = ConPO.ToString();
            lblPadres.Text = Padres.ToString();


        }


        #endregion


        //añadido para evitar erro de violacion de memoria
        void ExcelSinPO()
        {

            Clases.MeQExcel GDC = new MaterialCore.Clases.MeQExcel(ConfigurationManager.AppSettings["dirPDF"].ToString(), Convert.ToInt32(txtConsecutivo.Text),true);

            //DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter Meq = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter();
            //Meq.UpdatePreparado(Convert.ToInt32(txtConsecutivo.Text));
            if (GDC.mensaje == "")
                MessageBox.Show("Archivos de MeQ creados correctamente en el  directorio: " + ConfigurationManager.AppSettings["dirPDF"].ToString());
            else
                MessageBox.Show(GDC.mensaje);

          }

        void ExcelConPO()
        {

            Clases.MeQExcel GDC = new MaterialCore.Clases.MeQExcel(ConfigurationManager.AppSettings["dirPDF"].ToString(), Convert.ToInt32(txtConsecutivo.Text),false);

            DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter Meq = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter();
            Meq.UpdatePreparado(Convert.ToInt32(txtConsecutivo.Text));

         
        }

        


    }
}