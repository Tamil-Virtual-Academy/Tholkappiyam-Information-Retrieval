﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TolkappiyamForVirtualAcademy
{
    public partial class frmStatistical : Form
    {
        public frmStatistical()
        {
            InitializeComponent();            
            LoadDatagrid();

        }
        private void LoadDatagrid()
        {            
             UsrCtrlTokenizer Tokenizerusrctrl = new UsrCtrlTokenizer();
             pnlTokenizer.Controls.Clear();
             pnlTokenizer.Controls.Add(Tokenizerusrctrl);
             Tokenizerusrctrl.Dock = DockStyle.Fill;
        }
    }
}
