using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TolkappiyamForVirtualAcademy
{
    public partial class frmTolkappiyamforTVA : Form
    {
        public frmTolkappiyamforTVA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmExtraction frmExtract = new frmExtraction();
            frmExtract.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFunctional frmFunc = new frmFunctional();
            frmFunc.ShowDialog();
        }
    }
}
