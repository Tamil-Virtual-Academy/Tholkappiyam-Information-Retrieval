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
    public partial class UsrCtrlWordExtract : UserControl
    {
        string appDatapath, txtstrWord = string.Empty;

        public UsrCtrlWordExtract()
        {
            InitializeComponent();
            FillDatagrid();
        }          

        private void WordDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            clsParsingExtraction objExtract = new clsParsingExtraction();
            ParserOutput ParserDetails = new ParserOutput();

            string InflectedWord = string.Empty;

            int i = e.RowIndex;
            if (i != -1)
            {
                row = WordDatagrid.Rows[i];
                InflectedWord = row.Cells[1].Value.ToString();
            }

            ParserDetails = objExtract.RetrieveParsingDetailsWithWord(InflectedWord);

            rtbDetails.Clear();

            FormatOutput(ParserDetails);

        }

        private void FormatOutput(ParserOutput output)
        {
           
                rtbDetails.SelectionColor = Color.Blue;
                rtbDetails.SelectedText = Environment.NewLine + output.Word + Environment.NewLine  + Environment.NewLine;

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
                rtbDetails.SelectedText = "விகுதி : ";
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
            txtstrWord = Path.Combine(appDatapath, "txtWriteWord.txt");
            List<WordExtraction> lstInflected = new List<WordExtraction>();

            StreamReader reader = new StreamReader(txtstrWord);

            string line = string.Empty;
            int i = 1;
            while ((line = reader.ReadLine()) != null)
            {
                WordExtraction objword = new WordExtraction();
                objword.எண் = i;
                objword.சொல் = line;
                lstInflected.Add(objword);
                cmbWord.Items.Add(line);
                i = i + 1;
            }
                        
            WordDatagrid.DataSource = lstInflected;
            WordDatagrid.Columns[0].Width = 50;
            WordDatagrid.Columns[1].Width = 240;


            reader.Close();
        }

        private void cmbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbWord.Text = cmbWord.SelectedItem.ToString();
            string wordTobeSearched = cmbWord.SelectedItem.ToString();
            string cellValue = string.Empty;
            List<string> lstrowindex = new List<string>();
            if (!string.IsNullOrEmpty(wordTobeSearched))
            {
                foreach (DataGridViewRow row1 in WordDatagrid.Rows)
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
                    WordDatagrid.Rows[0].Selected = false;
                    WordDatagrid.Rows[Int32.Parse(lstrowindex[0])].Selected = true;
                    WordDatagrid.CurrentCell = WordDatagrid[0, Int32.Parse(lstrowindex[0])];
                }
            }
            DataGridViewRow row = new DataGridViewRow();
            clsParsingExtraction objExtract = new clsParsingExtraction();
            ParserOutput ParserDetails = new ParserOutput();

            string InflectedWord = string.Empty;

            int i = Int32.Parse(lstrowindex[0]);
            if (i != -1)
            {
                row = WordDatagrid.Rows[i];
                InflectedWord = row.Cells[1].Value.ToString();
            }

            ParserDetails = objExtract.RetrieveParsingDetailsWithWord(InflectedWord);

            rtbDetails.Clear();

            FormatOutput(ParserDetails);
        }
    }
}
