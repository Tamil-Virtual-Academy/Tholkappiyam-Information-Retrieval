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
    public partial class frmTolMainform : Form
    {
        public frmTolMainform()
        {
            InitializeComponent();
        }

      
       

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Extract2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Extract1;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.Statistical2;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.Statistical1;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Phono2;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Phono1;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.Parse2;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.Parse1;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.Suffix2;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.Suffix1;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = Resources.Index2;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Resources.Index1;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Resources.Terms2;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Resources.Terms1;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = Resources.Close3b;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Resources.Close3a;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UsrCtrlExtraction objExtract = new UsrCtrlExtraction();
            pnlFill.Controls.Clear();
            pnlFill.Controls.Add(objExtract);
            objExtract.Dock = DockStyle.Fill;
            label2.Text = "தொல்காப்பியத் தகவல் பெறுபட்டி";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            UsrCtrlStatistical objstats = new UsrCtrlStatistical();
            pnlFill.Controls.Clear();
            pnlFill.Controls.Add(objstats);
            objstats.Dock = DockStyle.Fill;
            label2.Text = "தொல்காப்பிய புள்ளியல் ஆய்வு";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UsrCtrlPhonological objPhono = new UsrCtrlPhonological();
            pnlFill.Controls.Clear();
            pnlFill.Controls.Add(objPhono);
            objPhono.Dock = DockStyle.Fill;
            label2.Text = "தொல்காப்பிய ஒலியனியல் ஆய்வு";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UsrCtrlParsing objParse = new UsrCtrlParsing();
            pnlFill.Controls.Clear();
            pnlFill.Controls.Add(objParse);
            objParse.Dock = DockStyle.Fill;
            label2.Text = "சொல் பகுப்பாய்வு விவரம்";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            UsrCtrlSuffixMorpho objSuffMorph = new UsrCtrlSuffixMorpho();
            pnlFill.Controls.Clear();
            pnlFill.Controls.Add(objSuffMorph);
            objSuffMorph.Dock = DockStyle.Fill;
            label2.Text = "தொல்காப்பிய இலக்கண விகுதிகள் மற்றும் விகுதிவருகை";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            UsrCtrlIndexing objIndex = new UsrCtrlIndexing();
            pnlFill.Controls.Clear();
            pnlFill.Controls.Add(objIndex);
            objIndex.Dock = DockStyle.Fill;
            label2.Text = "தொடக்கச்சொல் இறுதிச்சொல் நூற்பா பட்டி";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            UsrCtrlTechTerms objTechterms = new UsrCtrlTechTerms();
            pnlFill.Controls.Clear();
            pnlFill.Controls.Add(objTechterms);
            objTechterms.Dock = DockStyle.Fill;
            label2.Text = "தொல்காப்பியக் கலைக்களஞ்சியம்";
        }

        private void frmTolMainform_Load(object sender, EventArgs e)
        {
            UsrCtrlExtraction objExtract = new UsrCtrlExtraction();
            pnlFill.Controls.Clear();
            pnlFill.Controls.Add(objExtract);
            objExtract.Dock = DockStyle.Fill;
            label2.Text = "தொல்காப்பியத் தகவல் பெறுபட்டி";
        }
    }
}
