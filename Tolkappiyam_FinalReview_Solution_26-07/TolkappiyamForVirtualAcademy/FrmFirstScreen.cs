using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TolkappiyamForVirtualAcademy.Properties;

namespace TolkappiyamForVirtualAcademy
{
    public partial class FrmFirstScreen : Form
    {
        public FrmFirstScreen()
        {
            InitializeComponent();
        }

        private void picDE_MouseHover(object sender, EventArgs e)
        {
            picDE.Image = Resources.DE2;
        }

        private void picSA_MouseHover(object sender, EventArgs e)
        {
            picSA.Image = Resources.SA2;
        }

        private void picPA_MouseHover(object sender, EventArgs e)
        {
            picPA.Image = Resources.PA2;
        }

        private void picDE_MouseLeave(object sender, EventArgs e)
        {
            picDE.Image = Resources.DE1;
        }

        private void picSA_MouseLeave(object sender, EventArgs e)
        {
            picSA.Image = Resources.SA1;
        }

        private void picPA_MouseLeave(object sender, EventArgs e)
        {
            picPA.Image = Resources.PA1;
        }

        private void picParsing_MouseHover(object sender, EventArgs e)
        {
            picParsing.Image = Resources.Par2;
        }

        private void picParsing_MouseLeave(object sender, EventArgs e)
        {
            //picParsing.Image = Resources.
            picParsing.Image = Resources.Par1;
        }

        private void picSuff_MouseHover(object sender, EventArgs e)
        {
            picSuff.Image = Resources.Suff1;
        }

        private void picSuff_MouseLeave(object sender, EventArgs e)
        {
            picSuff.Image = Resources.Suff1;
        }

        private void picMorpho_MouseHover(object sender, EventArgs e)
        {
            picMorpho.Image = Resources.MR2;
        }

        private void picMorpho_MouseLeave(object sender, EventArgs e)
        {
            picMorpho.Image = Resources.MR1;
        }

        private void picPOS_MouseHover(object sender, EventArgs e)
        {
            picPOS.Image = Resources.Pos2;
        }

        private void picPOS_MouseLeave(object sender, EventArgs e)
        {
            picPOS.Image = Resources.Pos1;
        }

        private void picIndex_MouseHover(object sender, EventArgs e)
        {
            picIndex.Image = Resources.Index2;
        }

        private void picIndex_MouseLeave(object sender, EventArgs e)
        {
            picIndex.Image = Resources.Index1;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.Close3a;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.Close3b;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picDE_Click(object sender, EventArgs e)
        {
            //frmExtraction objextract = new frmExtraction();
            //objextract.ShowDialog();
        }

        private void picSA_Click(object sender, EventArgs e)
        {
            //frmStatistical objStats = new frmStatistical();
            //objStats.ShowDialog();
        }

        private void picPA_Click(object sender, EventArgs e)
        {
            //frmFunctional objFunctional = new frmFunctional();
            //objFunctional.ShowDialog();
        }

        private void picParsing_Click(object sender, EventArgs e)
        {
            //frmParsing objparsing = new frmParsing();
            //objparsing.ShowDialog();
        }

        private void picSuff_Click(object sender, EventArgs e)
        {
            //frmSuffMorphoAnalysis objsuff = new frmSuffMorphoAnalysis();
            //objsuff.ShowDialog();
        }

        private void picMorpho_Click(object sender, EventArgs e)
        {
            //frmSuffMorphoAnalysis objsuff = new frmSuffMorphoAnalysis();
            //objsuff.ShowDialog();
        }

        private void picPOS_Click(object sender, EventArgs e)
        {
            //frmParsing objparsing = new frmParsing();
            //objparsing.ShowDialog();
        }

        private void picIndex_Click(object sender, EventArgs e)
        {
            //frmIndexing objIndex = new frmIndexing();
            //objIndex.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmTechnicalTerms objGlossary = new frmTechnicalTerms();
            //objGlossary.ShowDialog();
        }

     

       
    }
}
