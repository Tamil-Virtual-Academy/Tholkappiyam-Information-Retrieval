using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TolkappiyamForVirtualAcademy
{
    public partial class UsrCtrlSuffixMorpho : UserControl
    {
        public UsrCtrlSuffixMorpho()
        {
            InitializeComponent();
            LoadPnlwithSuffUsrCtrl();
        }
        public void LoadPnlwithSuffUsrCtrl()
        {

            UsrCtrlSuffix objSuff = new UsrCtrlSuffix();

            pnlLoadUsrCtrl.Controls.Clear();
            pnlLoadUsrCtrl.Controls.Add(objSuff);
            objSuff.Dock = DockStyle.Fill;
        }

        public void LoadpnlwithMorphoUsrCtrl()
        {
            UsrCtrlMorpho objMprpho = new UsrCtrlMorpho();
            pnlLoadUsrCtrl.Controls.Clear();
            pnlLoadUsrCtrl.Controls.Add(objMprpho);
            objMprpho.Dock = DockStyle.Fill;

        }

        private void rbSuffix_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSuffix.Checked)
                LoadPnlwithSuffUsrCtrl();
        }

        private void rbMorpho_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMorpho.Checked)
                LoadpnlwithMorphoUsrCtrl();
        }
    }
}
