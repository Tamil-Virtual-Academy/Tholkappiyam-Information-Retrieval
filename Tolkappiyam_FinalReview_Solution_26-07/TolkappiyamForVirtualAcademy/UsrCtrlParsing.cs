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
    public partial class UsrCtrlParsing : UserControl
    {
        public UsrCtrlParsing()
        {
            InitializeComponent();
            loadWordUserControl();
        }
        private void loadWordUserControl()
        {
            UsrCtrlWordExtract wordExtract = new UsrCtrlWordExtract();

            //pnlLoadUsrCtrl.Dock = DockStyle.Fill;

            pnlLoadUsrCtrl.Controls.Clear();

            pnlLoadUsrCtrl.Controls.Add(wordExtract);
            wordExtract.Dock = DockStyle.Fill;
        }

        private void loadRootUserControl()
        {
            UsrCtrlRootExtract RootExtract = new UsrCtrlRootExtract();

            //pnlLoadUsrCtrl.Dock = DockStyle.Fill;

            pnlLoadUsrCtrl.Controls.Clear();

            pnlLoadUsrCtrl.Controls.Add(RootExtract);
            RootExtract.Dock = DockStyle.Fill;
        }

        private void loadPosUserControl()
        {
            UsrCtrlPosExtract PosExtract = new UsrCtrlPosExtract();

            //pnlLoadUsrCtrl.Dock = DockStyle.Fill;

            pnlLoadUsrCtrl.Controls.Clear();

            pnlLoadUsrCtrl.Controls.Add(PosExtract);
            PosExtract.Dock = DockStyle.Fill;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                loadWordUserControl();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                loadRootUserControl();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
             if (radioButton3.Checked)
                loadPosUserControl();
        }
    }
}
