using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tolkappiyam.Tools;

namespace TolkappiyamForVirtualAcademy
{
    public partial class UsrCtrlNgram : UserControl
    {
        public string Word { get; set; }
        public string OtherForm { get; set; }
        public string CompleteText { get; set; }

        public UsrCtrlNgram()
        {
            InitializeComponent();
        }

        private void UsrCtrlNgram_Load(object sender, EventArgs e)
        {
            txt.Text = Word;
            PerformNgram();
        }

        private void rtbGramsAfter_CheckedChanged(object sender, EventArgs e)
        {
            PerformNgram();

        }

        private void rtbGramsBefore_CheckedChanged(object sender, EventArgs e)
        {
            PerformNgram();
        }

        private void PerformNgram()
        {
            Tokenizer objTokenize = new Tokenizer();
            List<string> lstTokenizedWords = null;

            Concordenser objConcord = new Concordenser();
            List<ConcordOutputForm> lstconcordenserOutput = new List<ConcordOutputForm>();

            lstTokenizedWords = objTokenize.TokenizeWords_ConcordNgram(CompleteText);
                      
            lstconcordenserOutput = objConcord.DoConcordence_New(Word, "3", "3", lstTokenizedWords);

            if (rbGramsBefore.Checked)
            {
                if (lstconcordenserOutput.Count > 0)
                {
                    rtbOnegram.Clear();
                    rtbBigram.Clear();
                    rtbTrigram.Clear();

                    label1.Text = "N - 1";
                    label2.Text = "N - 2";
                    label4.Text = "N - 3";

                    foreach (ConcordOutputForm output in lstconcordenserOutput)
                    {
                        string[] arr = output.LeftVariables.Split(' ');
                        rtbOnegram.SelectionColor = Color.Black;
                        rtbOnegram.SelectedText = arr[2].ToString();
                        rtbOnegram.SelectionColor = Color.Red;
                        rtbOnegram.SelectedText = output.keyWord + Environment.NewLine;

                        rtbBigram.SelectionColor = Color.Black;
                        rtbBigram.SelectedText = arr[1] + " " + arr[2];
                        rtbBigram.SelectionColor = Color.Red;
                        rtbBigram.SelectedText = output.keyWord + Environment.NewLine;

                        rtbTrigram.SelectionColor = Color.Black;
                        rtbTrigram.SelectedText = arr[0] + " " + arr[1] + " " + arr[2];
                        rtbTrigram.SelectionColor = Color.Red;
                        rtbTrigram.SelectedText = output.keyWord + Environment.NewLine;
                    }
                }

                if (!string.IsNullOrEmpty(OtherForm))
                {
                    foreach (string str in OtherForm.Split(','))
                    {
                        lstconcordenserOutput = objConcord.DoConcordence_New(str.Trim(), "3", "3", lstTokenizedWords);

                        if (lstconcordenserOutput.Count > 0)
                        {
                            foreach (ConcordOutputForm output in lstconcordenserOutput)
                            {
                                string[] arr = output.LeftVariables.Split(' ');
                                rtbOnegram.SelectionColor = Color.Black;
                                rtbOnegram.SelectedText = arr[2];
                                rtbOnegram.SelectionColor = Color.Red;
                                rtbOnegram.SelectedText = output.keyWord + Environment.NewLine;

                                rtbBigram.SelectionColor = Color.Black;
                                rtbBigram.SelectedText = arr[1] + " " + arr[2];
                                rtbBigram.SelectionColor = Color.Red;
                                rtbBigram.SelectedText = output.keyWord + Environment.NewLine;

                                rtbTrigram.SelectionColor = Color.Black;
                                rtbTrigram.SelectedText = arr[0] + " " + arr[1] + " " + arr[2];
                                rtbTrigram.SelectionColor = Color.Red;
                                rtbTrigram.SelectedText = output.keyWord + Environment.NewLine;
                            }
                        }
                    }
                }
            }
            else if (rbGramsAfter.Checked)
            {
                if (lstconcordenserOutput.Count > 0)
                {
                    rtbOnegram.Clear();
                    rtbBigram.Clear();
                    rtbTrigram.Clear();

                    label1.Text = "N + 1";
                    label2.Text = "N + 2";
                    label4.Text = "N + 3";

                    foreach (ConcordOutputForm output in lstconcordenserOutput)
                    {
                        string[] arr = output.RightVariables.Split(' ');
                       
                        rtbOnegram.SelectionColor = Color.Red;
                        rtbOnegram.SelectedText = output.keyWord;
                        rtbOnegram.SelectionColor = Color.Black;
                        rtbOnegram.SelectedText = arr[0] + Environment.NewLine;

                       
                        rtbBigram.SelectionColor = Color.Red;
                        rtbBigram.SelectedText = output.keyWord;
                        rtbBigram.SelectionColor = Color.Black;
                        rtbBigram.SelectedText = arr[0] + " " + arr[1] + Environment.NewLine;

                        
                        rtbTrigram.SelectionColor = Color.Red;
                        rtbTrigram.SelectedText = output.keyWord;
                        rtbTrigram.SelectionColor = Color.Black;
                        rtbTrigram.SelectedText = arr[0] + " " + arr[1] + " " + arr[2] + Environment.NewLine;
                    }
                }

                if (!string.IsNullOrEmpty(OtherForm))
                {
                    foreach (string str in OtherForm.Split(','))
                    {
                        lstconcordenserOutput = objConcord.DoConcordence_New(str.Trim(), "3", "3", lstTokenizedWords);

                        if (lstconcordenserOutput.Count > 0)
                        {
                            foreach (ConcordOutputForm output in lstconcordenserOutput)
                            {
                                string[] arr = output.RightVariables.Split(' ');

                                rtbOnegram.SelectionColor = Color.Red;
                                rtbOnegram.SelectedText = output.keyWord;
                                rtbOnegram.SelectionColor = Color.Black;
                                rtbOnegram.SelectedText = arr[0].ToString() + Environment.NewLine;


                                rtbBigram.SelectionColor = Color.Red;
                                rtbBigram.SelectedText = output.keyWord;
                                rtbBigram.SelectionColor = Color.Black;
                                rtbBigram.SelectedText = arr[0] + " " + arr[1] + Environment.NewLine;


                                rtbTrigram.SelectionColor = Color.Red;
                                rtbTrigram.SelectedText = output.keyWord;
                                rtbTrigram.SelectionColor = Color.Black;
                                rtbTrigram.SelectedText = arr[0] + " " + arr[1] + " " + arr[2] + Environment.NewLine;
                            }
                        }
                    }
                }
            }
        




        }
      
    }
}
