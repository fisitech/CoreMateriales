using System.Drawing;
using System;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;


namespace Escaner
{
    class Escaner
    {
      BITMAPINFOHEADER bmi;
       Rectangle bmprect;

        public void GuardaImagen(IntPtr imagen, string dir,string nombre)
        {
            IntPtr bmp = GlobalLock(imagen);
            IntPtr pixptr = GetPixelInfo(bmp);
            nombre = dir + nombre;
            SaveDIBAs(nombre,bmp,pixptr);
        }

        public static bool SaveDIBAs(string picname, IntPtr bminfo, IntPtr pixdat)
        {
            Guid clsid;
            if (!GetCodecClsid(picname + ".jpg", out clsid))
            {
                MessageBox.Show("Unknown picture format for extension " + Path.GetExtension(picname),
                                "Image Codec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            IntPtr img = IntPtr.Zero;
            int st = GdipCreateBitmapFromGdiDib(bminfo, pixdat, ref img);
            if ((st != 0) || (img == IntPtr.Zero))
                return false;

            st = GdipSaveImageToFile(img, picname + ".jpg", ref clsid, IntPtr.Zero);
            GdipDisposeImage(img);
            return st == 0;
        }

        private static ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

        private static bool GetCodecClsid(string picname, out Guid clsid)
        {
            clsid = Guid.Empty;
            string ext = Path.GetExtension(picname);
            if (ext == null)
                return false;
            ext = "*" + ext.ToUpper();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FilenameExtension.IndexOf(ext) >= 0)
                {
                    clsid = codec.Clsid;
                    return true;
                }
            }
            return false;
        }

        protected IntPtr GetPixelInfo(IntPtr bmpptr)
        {
            bmi = new BITMAPINFOHEADER();
            Marshal.PtrToStructure(bmpptr, bmi);

            bmprect.X = bmprect.Y = 0;
            bmprect.Width = bmi.biWidth;
            bmprect.Height = bmi.biHeight;

            if (bmi.biSizeImage == 0)
                bmi.biSizeImage = ((((bmi.biWidth * bmi.biBitCount) + 31) & ~31) >> 3) * bmi.biHeight;

            int p = bmi.biClrUsed;
            if ((p == 0) && (bmi.biBitCount <= 8))
                p = 1 << bmi.biBitCount;
            p = (p * 4) + bmi.biSize + (int)bmpptr;
            return (IntPtr)p;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        internal class BITMAPINFOHEADER
        {
            public int biSize;
            public int biWidth;
            public int biHeight;
            public short biPlanes;
            public short biBitCount;
            public int biCompression;
            public int biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public int biClrUsed;
            public int biClrImportant;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GlobalLock(IntPtr handle);

        [DllImport("gdiplus.dll", ExactSpelling = true)]
        internal static extern int GdipCreateBitmapFromGdiDib(IntPtr bminfo, IntPtr pixdat, ref IntPtr image);

        [DllImport("gdiplus.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        internal static extern int GdipSaveImageToFile(IntPtr image, string filename, [In] ref Guid clsid, IntPtr encparams);

        [DllImport("gdiplus.dll", ExactSpelling = true)]
        internal static extern int GdipDisposeImage(IntPtr image);

    }
}
