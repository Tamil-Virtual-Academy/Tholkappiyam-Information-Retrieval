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
using Tolkappiyam.Tools;

namespace TolkappiyamForVirtualAcademy
{
    public partial class UsrCtrlTokenizer : UserControl
    {
        public string Word { get; set; }
        public string OtherForm { get; set; }
        public string Count { get; set; }
        public string CompleteText { get; set; }
        string xmlTolkappiyam = string.Empty;
        

        public UsrCtrlTokenizer()
        {
            InitializeComponent();
            string appDataPath = Path.Combine(Application.StartupPath, "Data");
            xmlTolkappiyam = Path.Combine(appDataPath, "Tolkappiyam.xml");

        }

        private void UsrCtrlTokenizer_Load(object sender, EventArgs e)
        {
            //rbNormal.Checked = true;
            
            LoadWordsWithCount();

            TokenizeTextToWords();
            SearchAsUType();

            pnlStatsDetails.Visible = true;

            rbFrequency.Checked = true;
           
        }

       

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked)
            {
                pnlStatistical.Controls.Clear();
                Word = string.Empty;
                OtherForm = string.Empty;
                Count = string.Empty;
                CompleteText = string.Empty;
                rbFrequency.Checked = false;
                //rbFrequency.Checked = true;
                LoadWordsWithCount();
                TokenizeTextToWords();
                //comboBox1.Items.Clear();
                comboBox1.Text = string.Empty;
                comboBox1.Items.Clear();
                SearchAsUType();
            }
        }

        private void rbParsed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParsed.Checked)
            {
                pnlStatistical.Controls.Clear();
                Word = string.Empty;
                OtherForm = string.Empty;
                Count = string.Empty;
                CompleteText = string.Empty;
                rbFrequency.Checked = false;
                //rbFrequency.Checked = true;
                LoadWordsWithCount();
                TokenizeTextToWords();
                //comboBox1.Items.Clear();
                comboBox1.Text = string.Empty;
                comboBox1.Items.Clear();
                SearchAsUType();
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string wordTobeSearched = comboBox1.Text.Trim();
            string cellValue = string.Empty;
            List<string> lstrowindex = new List<string>();
            if (!string.IsNullOrEmpty(wordTobeSearched))
            {
                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    try
                    {
                        cellValue = row1.Cells["word"].Value.ToString();
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
                dataGridView1.Rows[0].Selected = false;
                dataGridView1.Rows[Int32.Parse(lstrowindex[0])].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, Int32.Parse(lstrowindex[0])];

            }
            else
            {
                MessageBox.Show("Word Not Found");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtSearch.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
           
            int i = e.RowIndex;
            if (i != -1)
            {
                row = dataGridView1.Rows[i];
                Word = row.Cells[0].Value.ToString();
                OtherForm = row.Cells[1].Value.ToString();
                Count = row.Cells[2].Value.ToString();
            }

            //rbFrequency.Checked = true;
            PerformStatisticalOperations();
        }

       

        private void rbFrequency_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFrequency.Checked == true)
            {
                if (string.IsNullOrEmpty(Word) && string.IsNullOrEmpty(Count))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dataGridView1.Rows[0];

                    Word = row.Cells[0].Value.ToString();
                    OtherForm = row.Cells[1].Value.ToString();
                    Count = row.Cells[2].Value.ToString();
                }
                PerformStatisticalOperations();
            }
        }

        private void rbConcord_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConcord.Checked == true)
            {
                PerformStatisticalOperations();
            }
        }

        private void rbngram_CheckedChanged(object sender, EventArgs e)
        {
            if (rbngram.Checked == true)
            {
                PerformStatisticalOperations();
            }
        }       

        private void PerformStatisticalOperations()
        {
            if (rbFrequency.Checked == true)
            {
                UsrCtrlWordFrequency Frequency = new UsrCtrlWordFrequency();
                Frequency.Word = Word;
                Frequency.OtherForm = OtherForm;
                Frequency.Count = Count;
                Frequency.NormalForm = rbNormal.Checked;


                pnlStatistical.Controls.Clear();
                pnlStatistical.Controls.Add(Frequency);
                Frequency.Dock = DockStyle.Fill;

            }
            else if (rbConcord.Checked)
            {
                UsrCtrlConcordancer Concord = new UsrCtrlConcordancer();
                Concord.Word = Word;
                Concord.OtherForm = OtherForm;
                Concord.CompleteText = CompleteText;


                pnlStatistical.Controls.Clear();
                pnlStatistical.Controls.Add(Concord);
                Concord.Dock = DockStyle.Fill;

            }
            else if (rbngram.Checked)
            {
                UsrCtrlNgram ngram = new UsrCtrlNgram();
                ngram.Word = Word;
                ngram.OtherForm = OtherForm;
                ngram.CompleteText = CompleteText;

                pnlStatistical.Controls.Clear();
                pnlStatistical.Controls.Add(ngram);
                ngram.Dock = DockStyle.Fill;

            }
        }

        private void LoadWordsWithCount()
        {
            List<clsTolkappiyam> lstDetails = new List<clsTolkappiyam>();
            commonFunctions objFunction = new commonFunctions();
            StringBuilder sb = new StringBuilder();
            string strCompleteText = string.Empty;

            //this will load the entire Tolkappiyam details
            lstDetails = objFunction.LoadTolkappiyamDetails();


            //use the necessary normal or parsed text details
            foreach (clsTolkappiyam obj in lstDetails)
            {
                if (string.IsNullOrEmpty(sb.ToString()))
                {
                    if (rbNormal.Checked)
                    {
                        sb.Append(obj.Original);
                    }
                    else if (rbParsed.Checked)
                    {
                        sb.Append(obj.Text);
                    }
                }
                else
                {
                    if (rbNormal.Checked)
                    {
                        sb.Append(" ").Append(obj.Original);
                    }
                    else if (rbParsed.Checked)
                    {
                        sb.Append(" ").Append(obj.Text);
                    }
                }
            }

            //CompleteText will contain the either the normal lines or parsed lines seperated by a space
            strCompleteText = sb.ToString();

            Tokenizer objTokenize = new Tokenizer();
            List<WordCount> lstOutput = null;

            //will return unique word with count in sorted order
            if (rbNormal.Checked)
            {
                lstOutput = objTokenize.TokenizeWordswithCount(strCompleteText, objFunction.LoadNormalFormWithSandhi());
            }
            else
            {
                lstOutput = objTokenize.TokenizeWordswithCount(strCompleteText, objFunction.LoadParsedFormWithSandhi());
            }

            lblWordCount.Text = lstOutput.Count.ToString();
            //Display in GridControl

            DataSet ds = new DataSet();
            ds.Tables.Add();
            ds.Tables[0].Columns.Add("சொல்", typeof(string));
            ds.Tables[0].Columns.Add("பிறவடிவங்கள்", typeof(string));
            ds.Tables[0].Columns.Add("எண்ணிக்கை", typeof(string));

            foreach (WordCount result in lstOutput)
            {
                ds.Tables[0].Rows.Add(result.Word, result.OtherForm, result.Count);
                //comboBox1.Items.Add(result.Word);
            }
            
            dataGridView1.DataSource = ds.Tables[0];


            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.RowHeadersDefaultCellStyle = style;
            //dataGridView1.Columns[0]

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 100;

            rbFrequency.Checked = true;

        }

        private void TokenizeTextToWords()
        {
            List<clsTolkappiyam> lstDetails = new List<clsTolkappiyam>();
            commonFunctions objFunction = new commonFunctions();
            StringBuilder sb = new StringBuilder();

            //this will load the entire Tolkappiyam details
            lstDetails = objFunction.LoadTolkappiyamDetails();


            //use the necessary normal or parsed text details
            foreach (clsTolkappiyam obj in lstDetails)
            {
                if (string.IsNullOrEmpty(sb.ToString()))
                {
                    if (rbNormal.Checked)
                    {
                        sb.Append(obj.Original).Append(".");
                    }
                    else if (rbParsed.Checked)
                    {
                        sb.Append(obj.Text).Append(".");
                    }
                }
                else
                {
                    if (rbNormal.Checked)
                    {
                        sb.Append(" ").Append(obj.Original).Append(".");
                    }
                    else if (rbParsed.Checked)
                    {
                        sb.Append(" ").Append(obj.Text).Append(".");
                    }
                }
            }

            //CompleteText will contain the either the normal lines or parsed lines seperated by a space
            CompleteText = sb.ToString();

        }

        //private void comboBox1_TextChanged(object sender, EventArgs e)
        //{
            

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void SearchAsUType()
        {
            string WordTobeSerached = string.Empty;
            List<string> lstcomdetails = new List<string>();
            List<clsTolkappiyam> lstFinalResult = new List<clsTolkappiyam>();
            XmlTextReader reader = null;
            string dummystr = string.Empty;


            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                WordTobeSerached = "அ";
            }
            else
            {
                WordTobeSerached = comboBox1.Text.Trim();
            }

                try
                {
                    reader = new XmlTextReader(xmlTolkappiyam);

                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            string ss = reader.Name;

                            if (!reader.IsEmptyElement)
                            {
                                reader.Read(); // Read the start tag.

                                if ((ss == "Text") || (ss == "OriginalText"))
                                {
                                    dummystr = reader.Value;

                                    if (rbParsed.Checked && ss == "Text")
                                    {
                                        //stringFormat = (ss.Equals("Text")) && reader.Value.Split(' ').ToString().StartsWith(WordTobeSerached);
                                        foreach (string str in reader.Value.Split(' '))
                                        {
                                            if (str.StartsWith(WordTobeSerached))
                                            {
                                                if (!lstcomdetails.Contains(str))
                                                {
                                                    lstcomdetails.Add(str);
                                                }
                                            }
                                        }
                                    }
                                    else if (rbNormal.Checked && ss == "OriginalText")
                                    {
                                        //stringFormat = (ss.Equals("OriginalText")) && reader.Value.Split(' ').ToString().StartsWith(WordTobeSerached);
                                        foreach (string str in reader.Value.Split(' '))
                                        {
                                            if (str.StartsWith(WordTobeSerached))
                                            {
                                                if (!lstcomdetails.Contains(str))
                                                {
                                                    lstcomdetails.Add(str);
                                                }
                                            }
                                        }
                                    }
                                }

                            }

                        }
                    }
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
            //}

            if (lstcomdetails.Count > 1)
            {
                foreach (string str in lstcomdetails)
                {
                    comboBox1.Items.Add(str);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedItem.ToString();
            string wordTobeSearched = comboBox1.Text.Trim();
            string cellValue = string.Empty;
            List<string> lstrowindex = new List<string>();



            if (!string.IsNullOrEmpty(wordTobeSearched))
            {
                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    try
                    {
                        cellValue = row1.Cells[0].Value.ToString();
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
                    dataGridView1.Rows[0].Selected = false;
                    dataGridView1.Rows[Int32.Parse(lstrowindex[0])].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, Int32.Parse(lstrowindex[0])];

                    Display(lstrowindex);
                }
                else
                {
                    if (wordTobeSearched.EndsWith("க்") || wordTobeSearched.EndsWith("த்") || wordTobeSearched.EndsWith("ச்") || wordTobeSearched.EndsWith("ப்"))
                    {
                        comboBox1.Text = wordTobeSearched.Substring(0, wordTobeSearched.Length - 2);
                    }
                }

            }
        }
        private void Display( List<string> lstindex)
        {
            DataGridViewRow row = new DataGridViewRow();

            int i = Int32.Parse(lstindex[0]);
            if (i != -1)
            {
                row = dataGridView1.Rows[i];
                Word = row.Cells[0].Value.ToString();
                OtherForm = row.Cells[1].Value.ToString();
                Count = row.Cells[2].Value.ToString();
            }

            //rbFrequency.Checked = true;
            PerformStatisticalOperations();
            
            //Word = .w
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate_1(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                //comboBox1.Items.Clear();
                SearchAsUType();
            }
        }

        
    }
}
