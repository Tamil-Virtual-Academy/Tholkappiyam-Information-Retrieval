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
    public partial class UsrCtrlPosExtract : UserControl
    {
        string appDatapath, txtstrWord = string.Empty;
        public UsrCtrlPosExtract()
        {
            InitializeComponent();
            FillDatagrid();
        }
        
      

        private void PosDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            clsParsingExtraction objExtract = new clsParsingExtraction();

            string Pos = string.Empty;

            int i = e.RowIndex;
            if (i != -1)
            {
                row = PosDatagrid.Rows[i];
                Pos = row.Cells[1].Value.ToString();
            }

            //label2.Text = "List of Words in the Tolkappiyam with WordCategory '" + Pos + "'";
            label2.Text = "'" + Pos + "' சொல்வகைப்பாட்டினையுடைய தொல்காப்பியச் சொற்பட்டியல் ";

            List<string> lstParserDetails = new List<string>();

            lstParserDetails = objExtract.RetrieveParsingDetailsWithPos(Pos);


            List<WordExtraction> lstWordcategory = new List<WordExtraction>();

            int num = 1;
            foreach (string output in lstParserDetails)
            {
                WordExtraction objword = new WordExtraction();
                objword.எண் = num;
                objword.சொல் = output;

                lstWordcategory.Add(objword);

                num = num + 1;
            }

            InflectedDatagrid.DataSource = lstWordcategory;
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
            rtbDetails.SelectedText = "விகுதி வகைப்பாடு : ";
            rtbDetails.SelectionColor = Color.Blue;
            rtbDetails.SelectedText = output.Suffixes + Environment.NewLine + Environment.NewLine;

            rtbDetails.SelectionColor = Color.Black;
            rtbDetails.SelectedText = "SuffixCategory : ";
            rtbDetails.SelectionColor = Color.Blue;
            rtbDetails.SelectedText = output.SuffixCategory + Environment.NewLine + Environment.NewLine;




        }

        private void FillDatagrid()
        {
            appDatapath = Path.Combine(Application.StartupPath, "Data");
            txtstrWord = Path.Combine(appDatapath, "txtWritePos.txt");
            List<PosExtraction> lstPos = new List<PosExtraction>();

            StreamReader reader = new StreamReader(txtstrWord);

            string line = string.Empty;
            int i = 1;
            while ((line = reader.ReadLine()) != null)
            {
                PosExtraction objword = new PosExtraction();
                objword.எண் = i;
                objword.இலக்கணவகை = line;
                lstPos.Add(objword);
                
                i = i + 1;
            }

            PosDatagrid.DataSource = lstPos;
            PosDatagrid.Columns[0].Width = 50;
            PosDatagrid.Columns[1].Width = 320;


            reader.Close();
        }
    }
}
