using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TwainLib;
using System.Collections;
using Escaner;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;

namespace Twain
{

  public class Principal : System.Windows.Forms.Form, IMessageFilter
    {
      public string _Mensaje;
        private bool msgfilter;
        private   TwainLib.Twain tw;
     

      string _dir;
        string _nombre;
      string _destino;
    //  string _destino2;
      

      public string Mensaje {

          get { return _Mensaje; }
      }

      public Principal()
      {
      
          _dir = System.IO.Path.GetTempPath() + "\\";

          tw = new TwainLib.Twain();
          tw.Init(this.Handle);
      }


        public Principal(string direccion)
        {
            _dir = direccion;
   
            tw = new TwainLib.Twain();
            tw.Init(this.Handle);
        }



      protected override void Dispose(bool disposing)
      {
          if (disposing)
          {
              tw.Finish();
              //if (components != null)
              //{
              //    components.Dispose();
              //}
          }
          base.Dispose(disposing);
      }

   public bool  ScanPDF(string nombre,string destino)
        {
            bool bien = true;
            try
            {
          

                _destino = destino + @"\";
                _nombre = nombre;
                if (!msgfilter)
                {
                    //this.Enabled = false;
                    msgfilter = true;
                    Application.AddMessageFilter(this);
                }
                tw.Acquire();
            }
            catch
            {
                bien = false;   
            }
            return bien;
        }

    public string  SelectScaner()
        {
          return  tw.Select();
        }

        bool IMessageFilter.PreFilterMessage(ref Message m)
        {
            TwainCommand cmd = tw.PassMessage(ref m);
            if (cmd == TwainCommand.Not)
                return false;

            switch (cmd)
            {
                case TwainCommand.CloseRequest:
                    {
                       // _Mensaje = "CloseRequest";
                        EndingScan();
                        tw.CloseSrc();
                        break;
                    }
                case TwainCommand.CloseOk:
                    {
                    //    _Mensaje = "CloseOk";
                        EndingScan();
                        tw.CloseSrc();
                        break;
                    }
                case TwainCommand.DeviceEvent:
                    {
                   //     _Mensaje = "DeviceEvent";
                        break;
                    }

                case TwainCommand.Null:
                    {
                     //   _Mensaje = "Null";
                        EndingScan();
                        tw.CloseSrc();
                        break;
                    }

                case TwainCommand.TransferReady:
                    {
                        _Mensaje = "TransferReady";
                        ArrayList pics = tw.TransferPictures();
                        EndingScan();
                        tw.CloseSrc(); 

                        if (pics.Count == 0)
                        {
                            _Mensaje = "NoHojas";
                            return true;
                        }


            
                       // picnumber++; quitar                        //inicializacion de clase para guardar imagen
                    Escaner.Escaner objEscaner = new Escaner.Escaner();
                        //crea el documento pdf donde se le agregaran hojas
                        PdfDocument documento = new PdfDocument();

                        for (int i = 0; i < pics.Count; i++)
                        {
                            IntPtr img = (IntPtr)pics[i]; //var que contiene la imagen actual
                            int picnum = i + 1;
                            objEscaner.GuardaImagen(img, _dir, _nombre + picnum.ToString());

                            //codigo para crear pdf
                            PdfPage hoja = documento.AddPage();
                            XGraphics gfx = XGraphics.FromPdfPage(hoja);
                            XImage jpg = XImage.FromFile(_dir + _nombre + picnum.ToString() + ".jpg");
                            gfx.DrawImage(jpg, 0, 0, hoja.Width, hoja.Height);

                            jpg.Dispose();    //para poder eliminar la foto
                            File.Delete(_dir + _nombre +  picnum.ToString() + ".jpg");
                            //fin codigo para grear PDF
                        }
                        //ya con todas las paginas agregadas cuarda el archivo pdf;
                        if (documento.PageCount > 0)
                            documento.Save(_dir + _nombre +".pdf");
                        documento.Dispose();

                        if (_destino == @"\")
                            _destino = _dir;

                        File.Move(_dir + _nombre + ".pdf", _destino + _nombre + ".pdf");
                        _Mensaje = "TransferReadyFin";
                        return true;

                    }
            }

            return true;
        }

        private void EndingScan()
        {
            if (msgfilter)
            {
                Application.RemoveMessageFilter(this);
                msgfilter = false;
           //     this.Enabled = true;
             //   this.Activate();
            }
        }



    }
}
