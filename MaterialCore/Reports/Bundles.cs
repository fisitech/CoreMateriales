using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.Reports
{
    public partial class Bundles : Form
    {
        public Bundles()
        {
            InitializeComponent();
        }

        private void Bundles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'core_v2DataSet.ai_Reporte_Bultos_V2' table. You can move, or remove it, as needed.
            this.ai_Reporte_Bultos_V2TableAdapter.FillCoreReports(this.core_v2DataSet.ai_Reporte_Bultos_V2);

        }
    }
}