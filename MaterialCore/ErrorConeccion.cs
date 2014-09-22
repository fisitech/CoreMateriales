using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MaterialCore
{
    
    public partial class ErrorConeccion : Form
    {
        bool _ok = false;
        Thread hiloConexion;
        Clases.Conexion con = new Clases.Conexion(true);
        public ErrorConeccion()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hiloConexion = new Thread(new ThreadStart(Hilo1));
            hiloConexion.Start();
          }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ErrorConeccion_Load(object sender, EventArgs e)
        {
            hiloConexion = new Thread(new ThreadStart(Hilo1));
            hiloConexion.Start();
        }
        public void Hilo1()
        {
            visible(false);
            Texto("Conectando...");
            if (con.Reconectar() == true)
            {
                 Texto("Conexion exitosa");
                 Thread.Sleep(1000);
                 closeforma();
                  hiloConexion.Abort();
            }
            else
            {
                  Texto("Error de conexion...");
                  visible(true);
            hiloConexion.Abort();
            }
        }

        private delegate void UpdateStatusDelegate( String message);
        private delegate void UpdateStatusDelegate2(bool estado);
        private delegate void UpdateStatusDelegate3();
     
        private void Texto( String message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateStatusDelegate(Texto), new object[] { message });
                return;
            }
            lblerror.Text = message;
        }

        private void visible(bool estado)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateStatusDelegate2(visible), new object[] { estado });
                return;
            }
            button1.Visible = estado;
            button2.Visible = estado;
        }
        private void closeforma()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateStatusDelegate3(closeforma), new object[] {  });
                return;
            }
            this.Close();
        }
    }//---------------------------
}