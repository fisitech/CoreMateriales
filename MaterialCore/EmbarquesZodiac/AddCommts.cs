using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace MaterialCore.EmbarquesZodiac
{
     
    public partial class AddCommts : Form
    {
        
        int [] id;
        string[] oldCommnts;

        public AddCommts(int[] ID, string[] comments)
        {
            InitializeComponent();
            oldCommnts = comments;
            id = ID;
        }

       private void btnAdd_Click(object sender, EventArgs e)
        {

           // h a c e r  un c i c l o que agregue 
            this.Cursor = Cursors.WaitCursor;
            for (int x = 0; x < id.Length; x++)
            {
                String addCommts = oldCommnts[x].ToString() + System.Environment.NewLine + txtAddCmmts.Text.Trim() + System.Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt") + "  -  " + MaterialCore.Clases.Logueado.Login;
                this.embarquesZodiacTableAdapter.AddComments(addCommts, id[x]);
            }
            this.Close();
            this.Cursor = Cursors.Default;
        }

        private void AddCommts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'core_v2DataSet.EmbarquesZodiac' table. You can move, or remove it, as needed.
         }
    }
}