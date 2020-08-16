using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TolkappiyamForVirtualAcademy
{
    public partial class UsrCtrlTechTerms : UserControl
    {
        public UsrCtrlTechTerms()
        {
            InitializeComponent();
            FillTechnicalTerms();
            RetrieveDetails(listBox1.Items[0].ToString());
        }

        private void FillTechnicalTerms()
        {
            string appDatapath = Path.Combine(Application.StartupPath, "Data");
            string txtstrWord = Path.Combine(appDatapath, "TechnicalTerms.txt");
            List<string> lstWords = new List<string>();

            StreamReader reader = new StreamReader(txtstrWord);

            string line = string.Empty;

            while ((line = reader.ReadLine()) != null)
            {
                listBox1.Items.Add(line.Trim());
                cmbTechnical.Items.Add(line.Trim());
            }
            reader.Close();
        }


        private void RetrieveDetails(string Keyword)
        {
            clsGlossary obj = new clsGlossary();
            clsGlossaryDetails objdetail = new clsGlossaryDetails();

            objdetail = obj.Retrievewithkeyword(Keyword);
            if (objdetail != null)
            {
                //rtbExplain.Clear();
                lblNoorpa.Text = string.Empty;
                lblExplain.Text = string.Empty;
                lblWord.Text = string.Empty;


                lblWord.Text = "சொல் : " + Keyword;

                lblChapter.Text = "இயல் : " + objdetail.Chapter;


                if (!string.IsNullOrEmpty(objdetail.Noorpa))
                {
                    lblNoorpa.Text = "நூற்பா : " +Environment.NewLine + "      "+ objdetail.Noorpa;
                }
                //rtbExplain.Text = objdetail.Explanation;
                lblExplain.Text = "விளக்கம் : " + Environment.NewLine + "      " + objdetail.Explanation;
            }






        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveDetails(listBox1.SelectedItem.ToString());
        }

        private void cmbTechnical_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTechnical.Text = cmbTechnical.SelectedItem.ToString();
            // Set the search string:
            string myString = cmbTechnical.SelectedItem.ToString();
            // Set the search string:
            // Search starting from index -1:
            int index = listBox1.FindString(myString, -1);
            if (index != -1)
            {
                // Select the found item:
                listBox1.SetSelected(index, true);

                RetrieveDetails(myString);

            }
        }

    }
}
