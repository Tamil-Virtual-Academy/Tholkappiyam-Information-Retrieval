using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tolkappiyam.Tools
{
    public class Concordenser
    {
        #region string Initialize
        public List<string> lstDelimiters = new List<string>()
        { 
            ",",
            ".",
            "/",
            "<",
            ">",
            "?",
            ";",
            ":",
            "'",
            "[",
            "]",
            "{",
            "}",
            "]",
            "[",
            "|",
            "=",
            "+",
            "-",
            "_",
            ")",
            "(",
            "*",
            "&",
            "^",
            "%",
            "$",
            "#",
            "!",
            "@",
            "~",
            "`",
            "‘",
            "’",
            "'",
            "“",
            "”",
            "““",
            "”“",
            "\\",
            "\"",
            "\"\"",
            "\r\n",
            "\n"
        };
        #endregion

        public List<ConcordOutputForm> DoConcordence_New(string WordTobeFound, string leftVar, string rightVar, List<string> lsttokenizedWord)
        {
            
            List<string> lstConcordOutput = new List<string>();
            List<ConcordOutputForm> lstFormattedConcordOutput = new List<ConcordOutputForm>();
            int totalLength = 0;


            //if (!string.IsNullOrEmpty(CompleteText))
            //{
            //    lsttokenizedWord = TokenizeWords(CompleteText);
            //}

            totalLength = Int32.Parse(leftVar) + Int32.Parse(rightVar) + 1;
            string[] arrConcordenseChangedForm = new string[Int32.Parse(leftVar) + Int32.Parse(rightVar) + 1];

            //string[] arrConcordenseOriginalForm = new string[Int32.Parse(leftVar) + Int32.Parse(rightVar) + 1];

            for (int i = 0; i < lsttokenizedWord.Count; i++)
            {
                int loop = 0;
                if ((lsttokenizedWord.Count - i) >= totalLength)
                {
                    int begin = i;
                    for (loop = 0; loop < totalLength; loop++)
                    {
                        arrConcordenseChangedForm[loop] = lsttokenizedWord[i];
                        // arrConcordenseOriginalForm[loop] = lsttokenizedWord[i].OriginalForm;
                        i++;
                    }
                    i = begin;
                    string dummy = string.Empty;

                    dummy = arrConcordenseChangedForm[Int32.Parse(leftVar)];
                    //check cond
                    foreach (string delim in lstDelimiters)
                    {

                        if (dummy.Contains(delim))
                        {
                            //arrConcordense[Int32.Parse(leftVar)] = arrConcordense[Int32.Parse(leftVar)].Replace(delim, "");
                            dummy = dummy.Replace(delim, "");
                        }
                    }

                    if (dummy.Equals(WordTobeFound))
                    {
                        string answer = string.Empty;
                        //foreach(string ans in arrConcordenseChangedForm)
                        //{
                        //    if(string.IsNullOrEmpty(answer))
                        //    {
                        //        answer = ans;
                        //    }
                        //    else
                        //    {
                        //        answer = answer + " " + ans;
                        //    }
                        //}
                        foreach (string ans in arrConcordenseChangedForm)
                        {
                            if (string.IsNullOrEmpty(answer))
                            {
                                answer = ans;
                            }
                            else
                            {
                                answer = answer + " " + ans;
                            }
                        }
                        lstConcordOutput.Add(answer);
                    }
                }
                else
                    break;
            }


            lstFormattedConcordOutput = FormatResult(lstConcordOutput, leftVar, rightVar, WordTobeFound);

            return lstFormattedConcordOutput;

        }
              
        private List<ConcordOutputForm> FormatResult(List<string> lstConcordOutput, string leftVar, string rightVar, string Key)
        {
            List<ConcordOutputForm> lstOutput = new List<ConcordOutputForm>();

            foreach (string Output in lstConcordOutput)
            {
                ConcordOutputForm objOutput = new ConcordOutputForm();
                string leftVariables = string.Empty;
                string rightVariables = string.Empty;
                //bool hasFound = false;

                try
                {
                    string[] arrOutputDatas = Output.Split(' ');
                    for (int i = 0; i < Int32.Parse(leftVar); i++)
                    {
                        if (string.IsNullOrEmpty(objOutput.LeftVariables))
                        {
                            objOutput.LeftVariables = arrOutputDatas[i];
                        }
                        else
                        {
                            objOutput.LeftVariables = objOutput.LeftVariables + " " + arrOutputDatas[i];
                        }
                    }
                    objOutput.keyWord = " " + arrOutputDatas[Int32.Parse(leftVar)] + " ";

                    for (int i = Int32.Parse(leftVar) + 1; i <= (Int32.Parse(leftVar) + Int32.Parse(rightVar)); i++)
                    {
                        if (string.IsNullOrEmpty(objOutput.RightVariables))
                        {
                            objOutput.RightVariables = arrOutputDatas[i];
                        }
                        else
                        {
                            objOutput.RightVariables = objOutput.RightVariables + " " + arrOutputDatas[i];
                        }
                    }
                    //string left = objOutput.LeftVariables;
                    //string leftWords = string.Empty;
                    //string Rightwords = string.Empty;
                    //string[] arrleft = left.Split(' ');
                    //foreach (string str in arrleft)
                    //{
                    //    string[] arrsplit = str.Split('_');
                    //    if (string.IsNullOrEmpty(leftWords))
                    //    {
                    //        leftWords = arrsplit[0];
                    //        leftVariables = arrsplit[1];
                    //    }
                    //    else
                    //    {
                    //        leftWords = leftWords + " " + arrsplit[0];
                    //        leftVariables = leftVariables + " " + arrsplit[1];
                    //    }
                    //}
                    //objOutput.LeftVariables = leftVariables;
                    //objOutput.leftWords = leftWords;


                    //string right = objOutput.RightVariables;
                    //string rightWords = string.Empty;
                    //string rightvariables = string.Empty;
                    //string[] arrright = right.Split(' ');
                    //foreach (string str in arrright)
                    //{
                    //    string[] arrsplit = str.Split('_');
                    //    if (string.IsNullOrEmpty(rightWords))
                    //    {
                    //        rightWords = arrsplit[0];
                    //        rightvariables = arrsplit[1];
                    //    }
                    //    else
                    //    {
                    //        rightWords = rightWords + " " + arrsplit[0];
                    //        rightvariables = rightvariables + " " + arrsplit[1];
                    //    }
                    //}
                    //objOutput.RightVariables = rightvariables;
                    //objOutput.RightWords = rightWords;



                    //string[] arrmiddle = objOutput.keyWord.Split('_');
                    //objOutput.keyWord = arrmiddle[1];
                    //objOutput.KeywordWord = arrmiddle[0];

                    lstOutput.Add(objOutput);
                }
                catch (Exception ex) { throw ex; }
            }
            return lstOutput;
        }

        
    }
    public class ConcordOutputForm
    {
        public string LeftVariables { get; set; }
        public string keyWord { get; set; }
        public string RightVariables { get; set; }
        public string FileName { get; set; }
        public string lineNo { get; set; }
        public string leftWords { get; set; }
        public string RightWords { get; set; }
        public string KeywordWord { get; set; }

    }
}
