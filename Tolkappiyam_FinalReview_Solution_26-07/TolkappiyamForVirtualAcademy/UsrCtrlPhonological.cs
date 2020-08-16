using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Tolkappiyam.Tools;

namespace TolkappiyamForVirtualAcademy
{
    public partial class UsrCtrlPhonological : UserControl
    {
        List<DisplayForm> lstStartingEndingoutput = new List<DisplayForm>();
        public string NormalOrParsedText { get; set; }
        public UsrCtrlPhonological()
        {
            InitializeComponent();
            rbNormal.Checked = true;

            rbNormalPh2.Checked = true;
        }

        private void UsrCtrlPhonological_Load(object sender, EventArgs e)
        {
            rbNormal.Checked = true;
        }

        private void startdataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            DataGridViewRow row = new DataGridViewRow();
            List<string> tempStartlist = new List<string>();
            int i = e.RowIndex;
            if (i != -1)
            {
                row = startdataGrid.Rows[i];
                string ch = row.Cells[0].Value.ToString();
                List<DisplayForm> lstOut = lstStartingEndingoutput.FindAll(o => o.StartingCharacters.Equals(ch));
                if (lstOut.Count > 0)
                {
                    rtbDisplay.Clear();
                    labelCountPh.Text = "0";
                    foreach (DisplayForm objform in lstOut)
                    {
                        if (!tempStartlist.Contains(objform.Word))
                        {
                            tempStartlist.Add(objform.Word);
                            sb.Append(objform.Word + Environment.NewLine);
                        }
                    }
                    labelCountPh.Text = tempStartlist.Count.ToString();
                    rtbDisplay.Text = sb.ToString();
                }

            }
        }

        private void EnddataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            DataGridViewRow row = new DataGridViewRow();
            List<string> tempEndlist = new List<string>();
            int i = e.RowIndex;
            if (i != -1)
            {
                row = EnddataGrid.Rows[i];
                string ch = row.Cells[0].Value.ToString();
                List<DisplayForm> lstOut = lstStartingEndingoutput.FindAll(o => o.EndingCharacters.Equals(ch));
                if (lstOut.Count > 0)
                {
                    rtbDisplay.Clear();
                    foreach (DisplayForm objform in lstOut)
                    {
                        if (!tempEndlist.Contains(objform.Word))
                        {
                            tempEndlist.Add(objform.Word);
                            sb.Append(objform.Word + Environment.NewLine);
                        }
                    }
                    labelCountPh.Text = tempEndlist.Count.ToString();
                    rtbDisplay.Text = sb.ToString();
                }

            }
        }

        private void TwoConsdataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            DataGridViewRow row = new DataGridViewRow();
            List<string> tempTwoClusterList = new List<string>();
            int i = e.RowIndex;
            if (i != -1)
            {
                row = TwoConsdataGrid.Rows[i];
                string ch = row.Cells[0].Value.ToString();
                List<DisplayForm> lstOut = lstStartingEndingoutput.FindAll(o => o.TwoConsonantClusters.Equals(ch));
                if (lstOut.Count > 0)
                {
                    rtbDisplay.Clear();
                    foreach (DisplayForm objform in lstOut)
                    {
                        if (!tempTwoClusterList.Contains(objform.Word))
                        {
                            tempTwoClusterList.Add(objform.Word);
                            sb.Append(objform.Word + Environment.NewLine);
                        }
                    }
                    labelCountPh.Text = tempTwoClusterList.Count.ToString();
                    rtbDisplay.Text = sb.ToString();
                }

            }
        }

        private void ThreeConsdataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            DataGridViewRow row = new DataGridViewRow();
            List<string> tempThreeClusterList = new List<string>();

            int i = e.RowIndex;
            if (i != -1)
            {
                row = ThreeConsdataGrid.Rows[i];
                string ch = row.Cells[0].Value.ToString();
                List<DisplayForm> lstOut = lstStartingEndingoutput.FindAll(o => o.ThreeConsonantCluster.Equals(ch));
                if (lstOut.Count > 0)
                {
                    rtbDisplay.Clear();
                    foreach (DisplayForm objform in lstOut)
                    {
                        if (!tempThreeClusterList.Contains(objform.Word))
                        {
                            tempThreeClusterList.Add(objform.Word);
                            sb.Append(objform.Word + Environment.NewLine + Environment.NewLine);
                        }
                    }
                    labelCountPh.Text = tempThreeClusterList.Count.ToString();
                    rtbDisplay.Text = sb.ToString();
                }
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked)
            {
                TokenizeTextToWords();
            }
        }

        private void rbParsed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParsed.Checked)
            {
                TokenizeTextToWords();
            }
        }

        private void PerformPhonemicOperations()
        {
            PhonemicRules objphoneme = new PhonemicRules();
            List<string> lstDatalist = new List<string>();


            foreach (string str in NormalOrParsedText.Split(' '))
            {
                if (!string.IsNullOrEmpty(str) && !lstDatalist.Contains(str))
                    lstDatalist.Add(str.Trim());
            }

            try
            {
                lstStartingEndingoutput = objphoneme.CheckPhonemicCharacters(lstDatalist);
            }
            catch (Exception ex) { throw ex; };


            List<string> lstStart = new List<string>();
            List<string> lstEnd = new List<string>();
            List<string> lstTwo = new List<string>();
            List<string> lstThree = new List<string>();


            if (lstStartingEndingoutput.Count > 0)
            {
                foreach (DisplayForm objDisplay in lstStartingEndingoutput)
                {
                    string start = objDisplay.StartingCharacters;
                    string end = objDisplay.EndingCharacters;
                    string Two = objDisplay.TwoConsonantClusters;
                    string Three = objDisplay.ThreeConsonantCluster;


                    if (!string.IsNullOrEmpty(start))
                    {
                        if (!lstStart.Contains(start))
                        {
                            lstStart.Add(start);
                        }
                    }

                    if (!string.IsNullOrEmpty(end))
                    {
                        if (!lstEnd.Contains(end))
                        {
                            lstEnd.Add(end);
                        }
                    }

                    if (objDisplay.hasTwoCluster)
                    {
                        if (!string.IsNullOrEmpty(Two))
                        {
                            if (!lstTwo.Contains(Two))
                            {
                                lstTwo.Add(Two);
                            }
                        }
                    }

                    if (objDisplay.hasThreeCluster)
                    {
                        if (!string.IsNullOrEmpty(Three))
                        {
                            if (!lstThree.Contains(Three))
                            {
                                lstThree.Add(Three);
                            }
                        }
                    }
                }

                DataTable dtstart = new DataTable();
                dtstart.Columns.Add("சொல் முதல் எழுத்துகள்");

                foreach (string ch in lstStart)
                {
                    dtstart.Rows.Add(ch);
                }
                startdataGrid.DataSource = dtstart;



                DataTable dtEnd = new DataTable();
                dtEnd.Columns.Add("சொல் இறுதி எழுத்துகள்");

                foreach (string ch in lstEnd)
                {
                    dtEnd.Rows.Add(ch);
                }
                EnddataGrid.DataSource = dtEnd;


                DataTable dtTwo = new DataTable();
                dtTwo.Columns.Add("இரண்டு மெய் மயக்கம்");

                foreach (string ch in lstTwo)
                {
                    dtTwo.Rows.Add(ch);
                }
                TwoConsdataGrid.DataSource = dtTwo;

                DataTable dtThree = new DataTable();
                dtThree.Columns.Add("மூன்று மெய் மயக்கம்");

                foreach (string ch in lstThree)
                {
                    dtThree.Rows.Add(ch);
                }
                ThreeConsdataGrid.DataSource = dtThree;


                //displaying first itemm by default
                StringBuilder sb = new StringBuilder();
                DataGridViewRow row = new DataGridViewRow();
                List<string> tempStartlist = new List<string>();
                row = startdataGrid.Rows[0];
                string ch1 = row.Cells[0].Value.ToString();
                List<DisplayForm> lstOut = lstStartingEndingoutput.FindAll(o => o.StartingCharacters.Equals(ch1));
                if (lstOut.Count > 0)
                {
                    rtbDisplay.Clear();
                    foreach (DisplayForm objform in lstOut)
                    {
                        if (!tempStartlist.Contains(objform.Word))
                        {
                            tempStartlist.Add(objform.Word);
                            sb.Append(objform.Word + Environment.NewLine);
                        }
                    }
                    labelCountPh.Text = tempStartlist.Count.ToString();
                    rtbDisplay.Text = sb.ToString();
                }

            }
        }

        private void TokenizeTextToWords()
        {
            List<clsTolkappiyam> lstDetails = new List<clsTolkappiyam>();
            commonFunctions objFunction = new commonFunctions();
            StringBuilder sb = new StringBuilder();

            //this will load the entire Tolkappiyam details
            lstDetails = objFunction.LoadTolkappiyamDetails();


            //use the necessary normal or parsed text details


            //CompleteText will contain the either the normal lines or parsed lines seperated by a space



            if (tabFunctional.SelectedTab == tabPage3)
            {
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
                NormalOrParsedText = sb.ToString();
                NormalOrParsedText = NormalOrParsedText.Replace('.', ' ');
                PerformPhonemicOperations();
            }
            else if (tabFunctional.SelectedTab == tabPage4)
            {
                foreach (clsTolkappiyam obj in lstDetails)
                {
                    if (string.IsNullOrEmpty(sb.ToString()))
                    {
                        if (rbNormalPh2.Checked)
                        {
                            sb.Append(obj.Original).Append(".");
                        }
                        else if (rbParsedPh2.Checked)
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
                NormalOrParsedText = sb.ToString();
                NormalOrParsedText = NormalOrParsedText.Replace('.', ' ');
                DoSyllabicStructureForAll();
            }

        }

        private void rbNormalPh2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormalPh2.Checked)
            {
                rtbPh2.Clear();
                TokenizeTextToWords();
            }
        }

        private void rbParsedPh2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParsedPh2.Checked)
            {
                rtbPh2.Clear();
                TokenizeTextToWords();
            }
        }

        private void tabFunctional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabFunctional.SelectedTab == tabPage3)
            {
                rbNormal.Checked = true;
            }
            else if (tabFunctional.SelectedTab == tabPage4)
            {
                rbParsedPh2.Checked = true;
            }
        }

        private void dataGridViewSyllable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            PhonemicRules objRules = new PhonemicRules();
            SyllabicOutput objOutput = new SyllabicOutput();

            string FinalOutput = string.Empty;

            int i = e.RowIndex;
            if (i != -1)
            {
                row = dataGridViewSyllable.Rows[i];
                string Word = row.Cells[0].Value.ToString();

                objOutput = objRules.CreateSyllables(Word);
                if (objOutput.lstSyllables != null)
                {
                    FinalOutput = FormatSyllables(objOutput);
                }

                rtbPh2.Text = FinalOutput;
            }
        }
        private string FormatSyllables(SyllabicOutput objOutput1)
        {
            SyllabicOutput objOutput = new SyllabicOutput();
            objOutput = objOutput1;
            string strOut = string.Empty;
            if (objOutput.lstSyllables != null)
            {

                string[] arrOutput = new string[objOutput.lstSyllables.Count];


                for (int i = 0; i < objOutput.lstSyllables.Count; i++)
                {
                    //sb.Clear();
                    string str = objOutput.lstSyllFormat[i];
                    string str1 = objOutput.lstSyllables[i];

                    string[] arr = str1.Split(new char[] { 'அ', 'ஆ', 'இ', 'ஈ', 'உ', 'ஊ', 'எ', 'ஏ', 'ஐ', 'ஒ', 'ஓ', 'ஔ', 'ஃ' });
                    str1 = str1.Remove(0, arr[0].Length);
                    string str2 = str1.Substring(0, 1);

                    arrOutput[i] = "      " + str2 + "         " + (i + 1).ToString() + Environment.NewLine + Environment.NewLine + arr[0] + "          " + arr[1];

                }


                for (int j = 0; j < arrOutput.Length; j++)
                {
                    if (string.IsNullOrEmpty(strOut))
                    {
                        strOut = arrOutput[j];
                    }
                    else
                    {
                        strOut = strOut + Environment.NewLine + "- - - - - - - - - - - " + Environment.NewLine + arrOutput[j];
                    }

                }
            }


            return strOut;
        }

        private void DoSyllabicStructureForAll()
        {

            List<string> lstDatalistPh2 = new List<string>();


            foreach (string str in NormalOrParsedText.Split(' '))
            {
                if (!string.IsNullOrEmpty(str) && !lstDatalistPh2.Contains(str))
                    lstDatalistPh2.Add(str.Trim());
            }



            DataTable dtData = new DataTable();
            dtData.Columns.Add("சொல்");
            dtData.Columns.Add("ஒலியசை அமைப்பு");
            PhonemicRules objRules = new PhonemicRules();
            SyllabicOutput objOutput = new SyllabicOutput();
            foreach (string word in lstDatalistPh2)
            {
                objOutput = objRules.CreateSyllables(word.Trim());
                if (objOutput.lstSyllables != null && objOutput.lstSyllables.Count > 0)
                {
                    string syllabText = string.Empty;
                    foreach (string syllab in objOutput.lstSyllables)
                    {
                        if (string.IsNullOrEmpty(syllabText))
                        {
                            syllabText = syllab;
                        }
                        else
                        {
                            syllabText = syllabText + "---" + syllab;
                        }
                    }
                    dtData.Rows.Add(word, syllabText);
                }

            }

            dataGridViewSyllable.DataSource = dtData;
            dataGridViewSyllable.Columns[0].Width = 150;
            dataGridViewSyllable.Columns[1].Width = 550;
        }
        
    }
}
