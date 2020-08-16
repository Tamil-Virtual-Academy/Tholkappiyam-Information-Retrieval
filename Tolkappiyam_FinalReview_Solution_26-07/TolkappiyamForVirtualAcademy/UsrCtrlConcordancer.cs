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
    public partial class UsrCtrlConcordancer : UserControl
    {
        public string Word { get; set; }
        public string OtherForm { get; set; }       
        public string CompleteText { get; set; }

        public UsrCtrlConcordancer()
        {
            InitializeComponent();
           
        }        

        private void UsrCtrlConcordancer_Load(object sender, EventArgs e)
        {
            txtInput.Text = Word;
           
            FnConcord();          
        }

        private void cmbLeftVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLeftVar.Text = cmbLeftVar.SelectedItem.ToString();
           
            FnConcord();
        }

        private void cmbRightVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRightVar.Text = cmbRightVar.SelectedItem.ToString();
            FnConcord();
        }

        private void FnConcord()
        {           
            Tokenizer objTokenize = new Tokenizer();
            List<string> lstTokenizedWords = null;

            Concordenser objConcord = new Concordenser();
            List<ConcordOutputForm> lstconcordenserOutput = new List<ConcordOutputForm>();

            lstTokenizedWords = objTokenize.TokenizeWords_ConcordNgram(CompleteText);

            string left = cmbLeftVar.Text.ToString();
            left = left.Substring(0, 1);
            string right = cmbRightVar.Text.ToString();
            right = right.Substring(0, 1);
                
            lstconcordenserOutput = objConcord.DoConcordence_New(Word, left, right, lstTokenizedWords);

            string alltText = string.Empty;
            if (string.IsNullOrEmpty(OtherForm))
            {
                alltText = Word;
            }
            else
            {
                alltText = Word + "," + OtherForm;
            }

            if (lstconcordenserOutput.Count > 0)
            {
                rtbConcord.Clear();

                rtbConcord.SelectionColor = Color.Blue;
                rtbConcord.SelectedText = "சொற்சூழல் அடைவி : " + alltText + Environment.NewLine + Environment.NewLine;


                foreach (ConcordOutputForm output in lstconcordenserOutput)
                {
                    rtbConcord.SelectionColor = Color.Black;
                    rtbConcord.SelectedText = output.LeftVariables;

                    rtbConcord.SelectionColor = Color.Red;
                    rtbConcord.SelectedText = output.keyWord;

                    rtbConcord.SelectionColor = Color.Black;
                    rtbConcord.SelectedText = output.RightVariables + Environment.NewLine;
                }
            }

            if (!string.IsNullOrEmpty(OtherForm))
            {
                foreach (string str in OtherForm.Split(','))
                {
                    lstconcordenserOutput = objConcord.DoConcordence_New(str.Trim(), left, right, lstTokenizedWords);

                    if (lstconcordenserOutput.Count > 0)
                    {                     

                        foreach (ConcordOutputForm output in lstconcordenserOutput)
                        {
                            rtbConcord.SelectionColor = Color.Black;
                            rtbConcord.SelectedText = output.LeftVariables;

                            rtbConcord.SelectionColor = Color.Red;
                            rtbConcord.SelectedText = output.keyWord;

                            rtbConcord.SelectionColor = Color.Black;
                            rtbConcord.SelectedText = output.RightVariables + Environment.NewLine;
                        }
                    }
                }
            }
            


            }
        

        

       
    }
}
