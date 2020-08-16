using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TolkappiyamForVirtualAcademy
{
    public partial class UsrCtrlRootExtract : UserControl
    {
        string appDatapath, txtstrWord = string.Empty;

        public UsrCtrlRootExtract()
        {
            InitializeComponent();
            FillDatagrid();
        }

       

        private void RootDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            clsParsingExtraction objExtract = new clsParsingExtraction();
            
            string RootWord = string.Empty;

            int i = e.RowIndex;
            if (i != -1)
            {
                row = RootDatagrid.Rows[i];
                RootWord = row.Cells[1].Value.ToString();
            }

            //label2.Text = "List of Words in the Tolkappiyam with Root '" + RootWord + "'";
            label2.Text = "'" + RootWord + "' வேர்ச்சொல்லையுடைய தொல்காப்பியச் சொற்பட்டியல் ";
            

            List<string> lstParserDetails = new List<string>();

            lstParserDetails = objExtract.RetrieveParsingDetailsWithRoot(RootWord);


            List<WordExtraction> lstRoots = new List<WordExtraction>();

            int num = 1;
            foreach (string output in lstParserDetails)
            {
                WordExtraction objword = new WordExtraction();
                objword.எண் = num;
                objword.சொல் = output;

                lstRoots.Add(objword);

                num = num + 1;
            }

            InflectedDatagrid.DataSource = lstRoots;
            InflectedDatagrid.Columns[0].Width = 40;
            InflectedDatagrid.Columns[1].Width = 180;

            rtbDetails.Clear();
        }

        private void InflectedDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            clsParsingExtraction objExtract = new clsParsingExtraction();
            ParserOutput ParserDetails = new ParserOutput();

            string InflectedWord = string.Empty;

            int i = e.RowIndex;
            if (i != -1)
            {
                row = InflectedDatagrid.Rows[i];
                InflectedWord = row.Cells[1].Value.ToString();
            }

            ParserDetails = objExtract.RetrieveParsingDetailsWithWord(InflectedWord);

            rtbDetails.Clear();

            FormatOutput(ParserDetails);
        }

        private void FormatOutput(ParserOutput output)
        {

            rtbDetails.SelectionColor = Color.Blue;
            rtbDetails.SelectedText = Environment.NewLine + output.Word + Environment.NewLine + Environment.NewLine;

            rtbDetails.SelectionColor = Color.Black;
            rtbDetails.SelectedText = Environment.NewLine + "இலக்கணவகை : ";
            rtbDetails.SelectionColor = Color.Blue;
            rtbDetails.SelectedText = output.PosOutput + Environment.NewLine + Environment.NewLine;

            rtbDetails.SelectionColor = Color.Black;
            rtbDetails.SelectedText = "வேர்ச்சொல் : ";
            rtbDetails.SelectionColor = Color.Blue;
            rtbDetails.SelectedText = output.Root + Environment.NewLine + Environment.NewLine;

            rtbDetails.SelectionColor = Color.Black;
            rtbDetails.SelectedText = "வேர்ச்சொல் வகைப்பாடு : ";
            rtbDetails.SelectionColor = Color.Blue;
            rtbDetails.SelectedText = output.RootCategory + Environment.NewLine + Environment.NewLine;

            rtbDetails.SelectionColor = Color.Black;
            rtbDetails.SelectedText = "விகுதிகள் : ";
            rtbDetails.SelectionColor = Color.Blue;
            rtbDetails.SelectedText = output.Suffixes + Environment.NewLine + Environment.NewLine;

            rtbDetails.SelectionColor = Color.Black;
            rtbDetails.SelectedText = "விகுதி வகைப்பாடு : ";
            rtbDetails.SelectionColor = Color.Blue;
            rtbDetails.SelectedText = output.SuffixCategory + Environment.NewLine + Environment.NewLine;




        }

        private void FillDatagrid()
        {
            appDatapath = Path.Combine(Application.StartupPath, "Data");
            txtstrWord = Path.Combine(appDatapath, "txtWriteRoot.txt");
            List<RootExtraction> lstRoots = new List<RootExtraction>();

            StreamReader reader = new StreamReader(txtstrWord);

            string line = string.Empty;
            int i = 1;
            while ((line = reader.ReadLine()) != null)
            {
                RootExtraction objword = new RootExtraction();
                objword.எண் = i;
                objword.வேர்ச்சொல் = line;
                lstRoots.Add(objword);
                cmbRoot.Items.Add(line);
                i = i + 1;
            }

            RootDatagrid.DataSource = lstRoots;
            RootDatagrid.Columns[0].Width = 50;
            RootDatagrid.Columns[1].Width = 180;


            reader.Close();
        }

       

        private void cmbRoot_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoot.Text = cmbRoot.SelectedItem.ToString();
            string wordTobeSearched = cmbRoot.SelectedItem.ToString();
            string cellValue = string.Empty;
            List<string> lstrowindex = new List<string>();
            if (!string.IsNullOrEmpty(wordTobeSearched))
            {
                foreach (DataGridViewRow row1 in RootDatagrid.Rows)
                {
                    try
                    {
                        cellValue = row1.Cells[1].Value.ToString();
                    }
                    catch (Exception ex)
                    { }
                    if (cellValue != null && (cellValue == wordTobeSearched || cellValue.StartsWith(wordTobeSearched)))
                    {
                        if (cellValue == wordTobeSearched)
                        {
                            lstrowindex.Add(row1.Index.ToString());
                            break;
                        }
                    }
                }
                if (lstrowindex.Count > 0)
                {
                    RootDatagrid.Rows[0].Selected = false;
                    RootDatagrid.Rows[Int32.Parse(lstrowindex[0])].Selected = true;
                    RootDatagrid.CurrentCell = RootDatagrid[0, Int32.Parse(lstrowindex[0])];
                }

                DataGridViewRow row = new DataGridViewRow();
                clsParsingExtraction objExtract = new clsParsingExtraction();

                string RootWord = string.Empty;

                int i = Int32.Parse(lstrowindex[0]);
                if (i != -1)
                {
                    row = RootDatagrid.Rows[i];
                    RootWord = row.Cells[1].Value.ToString();
                }

                label2.Text = "List of Words in the Tolkappiyam with Root '" + RootWord + "'";

                List<string> lstParserDetails = new List<string>();

                lstParserDetails = objExtract.RetrieveParsingDetailsWithRoot(RootWord);


                List<WordExtraction> lstRoots = new List<WordExtraction>();

                int num = 1;
                foreach (string output in lstParserDetails)
                {
                    WordExtraction objword = new WordExtraction();
                    objword.எண் = num;
                    objword.சொல் = output;

                    lstRoots.Add(objword);

                    num = num + 1;
                }

                InflectedDatagrid.DataSource = lstRoots;
                InflectedDatagrid.Columns[0].Width = 40;
                InflectedDatagrid.Columns[1].Width = 180;

                rtbDetails.Clear();


            }
        }
    }
}
