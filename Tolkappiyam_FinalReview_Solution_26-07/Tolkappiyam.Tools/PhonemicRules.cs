using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Tolkappiyam.Tools
{
    public class PhonemicRules
    {
        public List<DisplayForm> CheckPhonemicCharacters(List<string> lstWords)
        {
            List<DisplayForm> lstOutput = new List<DisplayForm>();
            string glyphForm = string.Empty;
            string syllabicForm = string.Empty;

            foreach (string word in lstWords)
            {
                Regex reg1 = new Regex(@"[A-Za-z0-9]");
                if (reg1.IsMatch(word))
                {
                    continue;
                }
                DisplayForm objForm = new DisplayForm();
                glyphForm = ConvertToGlyph.Glyph_Category(word);
                syllabicForm = ConvertToGlyph.Glyph_Category1(word);
                syllabicForm = syllabicForm.Replace("<", "V");
                string start = string.Empty;
                string End = string.Empty;

                objForm.Word = word;

                if (glyphForm.Length > 2)
                {
                    if (syllabicForm.StartsWith("V"))
                    {
                        start = glyphForm.Substring(0, 1);
                    }
                    else
                    {
                        start = glyphForm.Substring(0, 2);
                    }

                    objForm.StartingCharacters = start;



                    if (syllabicForm.EndsWith("V"))
                    {
                        End = glyphForm.Substring(glyphForm.Length - 1, 1);
                    }
                    else
                    {
                        End = glyphForm.Substring(glyphForm.Length - 2, 2);
                    }

                    objForm.EndingCharacters = End;
                }

                if (glyphForm.Length > 4)
                {
                    if (syllabicForm.Contains("CC"))
                    {
                        string temp = syllabicForm;
                        temp = temp.Replace("CC", "&");
                        string[] arr = temp.Split('&');
                        int Count = 0;
                        for (int i = 0; i < arr[0].Length; i++)
                        {
                            if (arr[0][i].ToString() == "V")
                            {
                                Count = Count + 1;
                            }
                            else
                            {
                                Count = Count + 2;
                            }
                        }
                        objForm.hasTwoCluster = true;
                        objForm.TwoConsonantClusters = glyphForm[Count].ToString() + glyphForm[Count + 1].ToString() + glyphForm[Count + 2].ToString() + glyphForm[Count + 3].ToString();
                    }
                }

                if (glyphForm.Length > 6)
                {
                    if (syllabicForm.Contains("CCC"))
                    {
                        string temp1 = syllabicForm;
                        temp1 = temp1.Replace("CCC", "&");
                        string[] arr = temp1.Split('&');
                        int Count = 0;
                        for (int i = 0; i < arr[0].Length; i++)
                        {
                            if (arr[0][i].ToString() == "V")
                            {
                                Count = Count + 1;
                            }
                            else
                            {
                                Count = Count + 2;
                            }
                        }
                        objForm.hasThreeCluster = true;
                        objForm.ThreeConsonantCluster = glyphForm[Count].ToString() + glyphForm[Count + 1].ToString() + glyphForm[Count + 2].ToString() + glyphForm[Count + 3].ToString() + glyphForm[Count + 4].ToString() + glyphForm[Count + 5].ToString();

                    }
                }

                if (objForm.TwoConsonantClusters == null)
                {
                    objForm.TwoConsonantClusters = string.Empty;
                }
                if (objForm.ThreeConsonantCluster == null)
                {
                    objForm.ThreeConsonantCluster = string.Empty;
                }
                if (objForm.StartingCharacters == null)
                {
                    objForm.StartingCharacters = string.Empty;
                }
                if (objForm.EndingCharacters == null)
                {
                    objForm.EndingCharacters = string.Empty;
                }


                lstOutput.Add(objForm);
            }
            return lstOutput;
        }

        public SyllabicOutput CreateSyllables(string Word)
        {
            string FirstChar = string.Empty;
            string LastChar = String.Empty;
            bool hasFirstSyll = false;
            bool hasLastSyll = false;
            SyllabicOutput objSyllable = new SyllabicOutput();
            string glyphForm = ConvertToGlyph.Glyph_Category(Word);
            string syllForm = ConvertToGlyph.Glyph_Category1(Word);


            //Normalization

            //for (int i = 0; i < syllForm.Length - 2; i++)
            //{
            //    string ss = syllForm[i].ToString() + syllForm[i + 1].ToString() + syllForm[i + 2].ToString();
            //    int Count =0;
            //    if (ss == "VCV" || ss == "VC<")
            //    {
            //        for(int j=0;j<i+1;j++)
            //        {
            //            if(syllForm[j].ToString() == "V" || syllForm[j].ToString() == "<" )
            //            {
            //                Count = Count + 1;
            //            }
            //            else
            //            {
            //                Count = Count +2;
            //            }
            //        }



            //        syllForm = syllForm.Insert(i + 1, "C");
            //        glyphForm = glyphForm.Insert(Count, glyphForm.Substring(Count, 2));

            //    }

            //}
            syllForm = syllForm.Replace('<', 'V');
            string syllFormCopy = syllForm;

            if (syllForm.StartsWith("CCV"))
            {
                hasFirstSyll = true;
                FirstChar = "CC";
                syllFormCopy = syllFormCopy.Remove(0, 2);
            }
            else if (syllForm.StartsWith("CV"))
            {
                hasFirstSyll = true;
                FirstChar = "C";
                syllFormCopy = syllFormCopy.Remove(0, 1);
            }
            if (syllFormCopy.EndsWith("VCC"))
            {
                hasLastSyll = true;
                LastChar = "CC";
                syllFormCopy = syllFormCopy.Remove(syllFormCopy.Length - 2, 2);
            }
            else if (syllFormCopy.EndsWith("VC"))
            {
                hasLastSyll = true;
                LastChar = "C";
                syllFormCopy = syllFormCopy.Remove(syllFormCopy.Length - 1, 1);
            }

            int vowelCount = 0;
            for (int i = 0; i < syllFormCopy.Length; i++)
            {
                if (syllFormCopy[i].Equals('V'))
                {
                    vowelCount = vowelCount + 1;
                }
            }

            if (vowelCount > 0 && syllFormCopy.StartsWith("V") && syllFormCopy.EndsWith("V"))
            {
                string[] arrsyllable = new string[vowelCount];
                string[] arrConsonant = syllFormCopy.Split('V');

                for (int j = 0; j < arrsyllable.Length; j++)
                {
                    arrsyllable[j] = "V";
                }


                for (int i = 0; i < arrConsonant.Length; i++)
                {
                    if (string.IsNullOrEmpty(arrConsonant[i]))
                        continue;

                    if (arrConsonant[i] == "C")
                    {
                        arrsyllable[i] = "C" + arrsyllable[i];
                    }
                    else if (arrConsonant[i] == "CC")
                    {
                        arrsyllable[i - 1] = arrsyllable[i - 1] + "C";
                        arrsyllable[i] = "C" + arrsyllable[i];
                    }
                    else if (arrConsonant[i] == "CCC")
                    {
                        arrsyllable[i - 1] = arrsyllable[i - 1] + "CC";
                        arrsyllable[i] = "C" + arrsyllable[i];
                    }
                }

                if (hasFirstSyll)
                {
                    arrsyllable[0] = FirstChar + arrsyllable[0];
                }

                if (hasLastSyll)
                {
                    arrsyllable[arrsyllable.Length - 1] = arrsyllable[arrsyllable.Length - 1] + LastChar;
                }

                List<string> lstOutput = new List<string>();

                for (int i = 0; i < arrsyllable.Length; i++)
                {
                    string temp = arrsyllable[i];
                    int count = 0;
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (temp[j].Equals('C'))
                            count = count + 2;
                        else if (temp[j].Equals('V'))
                            count = count + 1;
                    }
                    lstOutput.Add(glyphForm.Substring(0, count));
                    glyphForm = glyphForm.Remove(0, count);
                }

                objSyllable.Word = Word;
                objSyllable.lstSyllables = lstOutput;

                List<string> lstTemp = new List<string>();
                foreach (string str in arrsyllable)
                {
                    lstTemp.Add(str);
                }
                objSyllable.lstSyllFormat = lstTemp;



            }//main if ends
            return objSyllable;
        }//Fn ends
    }
    public class DisplayForm
    {
        public string Word { get; set; }
        public string StartingCharacters { get; set; }
        public string EndingCharacters { get; set; }
        public bool hasTwoCluster { get; set; }
        public string TwoConsonantClusters { get; set; }
        public bool hasThreeCluster { get; set; }
        public string ThreeConsonantCluster { get; set; }
    }
    public class SyllabicOutput
    {
        public string Word { get; set; }
        public List<string> lstSyllables { get; set; }
        public List<string> lstSyllFormat { get; set; }
        public bool isValid { get; set; }
    }

    public class SyllabicFormat
    {
        public string Word { get; set; }
        public string[] arrSyllables { get; set; }
        public string Output { get; set; }

    }
    public static class ConvertToGlyph
    {
        static string StrVwl;
        static string StrVwl1;
        static string StrOutput;
        static string StrCons;
        static string StrCons1;
        static int IntTemp;
        static int IntTemp1;
        static int arrcnt1;
        static String ArrayInput;
        public static string StrOutput11;

        //Function to Convert the Input String into Phonemic Format
        public static string Glyph_Category(string StrGlyph)
        {
            //Clear the variables
            Clear_Variable1();

            //Loading an Input array
            ArrayInput = StrGlyph.Trim();


            for (arrcnt1 = 0; arrcnt1 <= ArrayInput.Length - 1; arrcnt1++)
            {
                IntTemp = Convert.ToInt32(Convert.ToChar(ArrayInput[arrcnt1]));

                // Only Vowels

                if ((IntTemp >= 2949 & IntTemp <= 2964))
                {
                    StrCons = string.Empty;
                    StrVwl = ArrayInput[arrcnt1].ToString();

                    StrCons1 = string.Empty;
                    StrVwl1 = Long_Short_Vowel1(IntTemp).ToString();

                    //dot Characters
                }
                else if (IntTemp == 3021)
                {
                    StrVwl = string.Empty;
                    StrVwl1 = string.Empty;
                    StrCons = string.Empty;
                    StrCons1 = string.Empty;

                    //Plain Glyphs
                }
                else if ((IntTemp > 3005 & IntTemp1 < 3021))
                {
                    StrVwl = Convert.ToChar(IntTemp - 56).ToString();
                    StrVwl1 = Long_Short_Vowel1(IntTemp - 56).ToString();

                    StrCons = string.Empty;
                    StrCons1 = string.Empty;

                    //Consonants with and without Glyphs 
                }
                else if ((IntTemp >= 2965 & IntTemp <= 3001))
                {
                    if (arrcnt1 == ArrayInput.Length - 1)
                    {
                        IntTemp1 = IntTemp;
                    }
                    else
                    {
                        IntTemp1 = Convert.ToInt32(Convert.ToChar(ArrayInput[arrcnt1 + 1]));
                    }

                    if ((IntTemp1 > 3005 & IntTemp1 <= 3021))
                    {
                        StrCons = ArrayInput[arrcnt1] + Convert.ToChar(3021).ToString();
                        StrVwl = string.Empty;
                        StrCons1 = "C";
                        StrVwl1 = string.Empty;
                    }
                    else
                    {
                        StrCons = ArrayInput[arrcnt1] + Convert.ToChar(3021).ToString();
                        StrVwl = Convert.ToChar(2949).ToString();
                        StrCons1 = "C";
                        StrVwl1 = "V";

                    }
                }
                else
                {
                    StrCons = string.Empty;
                    StrVwl = string.Empty;
                    StrCons1 = string.Empty;
                    StrVwl1 = string.Empty;

                }
                StrOutput = StrOutput + StrCons + StrVwl;
                StrOutput11 = StrOutput11 + StrCons1 + StrVwl1;
            }
            arrcnt1 = 0;
            return StrOutput;
        }

        public static string Glyph_Category1(string StrGlyph)
        {
            //Clear the variables
            Clear_Variable1();

            //Loading an Input array
            ArrayInput = StrGlyph.Trim();


            for (arrcnt1 = 0; arrcnt1 <= ArrayInput.Length - 1; arrcnt1++)
            {
                IntTemp = Convert.ToInt32(Convert.ToChar(ArrayInput[arrcnt1]));

                // Only Vowels

                if ((IntTemp >= 2949 & IntTemp <= 2964))
                {
                    StrCons = string.Empty;
                    StrVwl = ArrayInput[arrcnt1].ToString();

                    StrCons1 = string.Empty;
                    StrVwl1 = Long_Short_Vowel1(IntTemp).ToString();

                    //dot Characters
                }
                else if (IntTemp == 3021)
                {
                    StrVwl = string.Empty;
                    StrVwl1 = string.Empty;
                    StrCons = string.Empty;
                    StrCons1 = string.Empty;

                    //Plain Glyphs
                }
                else if ((IntTemp > 3005 & IntTemp1 < 3021))
                {
                    StrVwl = Convert.ToChar(IntTemp - 56).ToString();
                    StrVwl1 = Long_Short_Vowel1(IntTemp - 56).ToString();

                    StrCons = string.Empty;
                    StrCons1 = string.Empty;

                    //Consonants with and without Glyphs 
                }
                else if ((IntTemp >= 2965 & IntTemp <= 3001))
                {
                    if (arrcnt1 == ArrayInput.Length - 1)
                    {
                        IntTemp1 = IntTemp;
                    }
                    else
                    {
                        IntTemp1 = Convert.ToInt32(Convert.ToChar(ArrayInput[arrcnt1 + 1]));
                    }

                    if ((IntTemp1 > 3005 & IntTemp1 <= 3021))
                    {
                        StrCons = ArrayInput[arrcnt1] + Convert.ToChar(3021).ToString();
                        StrVwl = string.Empty;
                        StrCons1 = "C";
                        StrVwl1 = string.Empty;
                    }
                    else
                    {
                        StrCons = ArrayInput[arrcnt1] + Convert.ToChar(3021).ToString();
                        StrVwl = Convert.ToChar(2949).ToString();
                        StrCons1 = "C";
                        StrVwl1 = "V";

                    }
                }
                else
                {
                    StrCons = string.Empty;
                    StrVwl = string.Empty;
                    StrCons1 = string.Empty;
                    StrVwl1 = string.Empty;

                }
                StrOutput = StrOutput + StrCons + StrVwl;
                StrOutput11 = StrOutput11 + StrCons1 + StrVwl1;
            }
            arrcnt1 = 0;
            return StrOutput11;
        }

        private static object Long_Short_Vowel1(int i)
        {
            string strtmp = null;
            switch (i)
            {
                case 2950:
                    strtmp = "<";
                    break;
                case 2952:
                    strtmp = "<";
                    break;
                case 2954:
                    strtmp = "<";
                    break;
                case 2959:
                case 2960:
                    strtmp = "<";
                    break;
                case 2963:
                case 2964:
                    strtmp = "<";
                    break;
                default:
                    strtmp = "V";
                    break;
            }
            return strtmp;
        }

        private static void Clear_Variable1()
        {
            IntTemp = 0;
            IntTemp1 = 0;
            arrcnt1 = 0;
            StrOutput = string.Empty;
            StrOutput11 = string.Empty;
            StrCons = string.Empty;
            StrCons1 = string.Empty;
            StrVwl = string.Empty;
            StrVwl1 = string.Empty;
        }

    }

    public class Recover
    {
        public static string Recover_Org(string StrOrg1)
        {
            if (StrOrg1.Equals("உடைய"))
            {
            }
            try
            {
                string StrOrg = string.Empty;
                int IntOrg = 0;
                int IntOrg1 = 0;
                int IntOrg2 = 0;
                int IntCnt = 0;
                string[] Array_Org = new string[StrOrg1.Length];

                //Loading an Input array
                for (int i = 0; i < StrOrg1.Length; i++)
                {
                    Array_Org[i] = StrOrg1.Substring(i, 1);

                }
                for (int jj = 0; jj <= Array_Org.Length - 1; jj++)
                {
                    IntCnt = jj;

                    if (IntCnt == Array_Org.Length)
                    {
                        break; // TODO: might not be correct. Was : Exit For
                    }

                    IntOrg = Convert.ToInt16(Convert.ToChar(Array_Org[IntCnt]));
                    // Only Vowels
                    if ((IntOrg >= 2949 & IntOrg <= 2964) | IntOrg == 2947)
                    {
                        if (!(IntOrg == 2947))
                        {
                            if (!(IntCnt > 0))
                            {
                                StrOrg = StrOrg + Convert.ToChar(Array_Org[IntCnt]);
                            }
                            else
                            {
                                if ((Convert.ToInt16(Convert.ToChar(Array_Org[IntCnt - 1])) >= 2949 & Convert.ToInt16(Convert.ToChar(Array_Org[IntCnt - 1])) <= 2964))
                                {
                                    StrOrg = StrOrg + Convert.ToChar(Array_Org[IntCnt]);
                                }
                            }
                        }
                        else
                        {
                            StrOrg = StrOrg + Convert.ToChar(Array_Org[IntCnt]);
                        }


                        //Consonants with and without Glyphs 
                    }
                    else if ((IntOrg >= 2965 & IntOrg <= 3001))
                    {
                        if (IntCnt == Array_Org.Length - 2)
                        {
                            IntOrg1 = Convert.ToInt16(Convert.ToChar(Array_Org[IntCnt + 1]));
                            IntOrg2 = 0;
                        }
                        else
                        {
                            IntOrg1 = Convert.ToInt16(Convert.ToChar(Array_Org[IntCnt + 1]));
                            IntOrg2 = Convert.ToInt16(Convert.ToChar(Array_Org[IntCnt + 2]));
                        }

                        if ((IntOrg1 == 3021))
                        {
                            if ((IntOrg2 >= 2949 & IntOrg2 <= 2964))
                            {
                                if (IntOrg2 == 2949)
                                {
                                    StrOrg = StrOrg + Convert.ToChar(IntOrg);
                                }
                                else
                                {
                                    StrOrg = StrOrg + Convert.ToChar(IntOrg) + Convert.ToChar(IntOrg2 + 56);
                                }
                            }
                            else
                            {
                                StrOrg = StrOrg + Convert.ToChar(IntOrg) + Convert.ToChar(IntOrg1);
                            }
                        }
                    }
                }
                return StrOrg;
            }
            catch (Exception ex)
            {
                throw;
                {
                    return StrOrg1;
                }
            }
        }
    }

}
