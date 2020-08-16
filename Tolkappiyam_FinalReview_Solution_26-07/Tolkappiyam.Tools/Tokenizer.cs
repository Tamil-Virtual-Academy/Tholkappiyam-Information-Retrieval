using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tolkappiyam.Tools
{
    public class Tokenizer
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

        //This function will get the string and return a list of tokenized words
        public List<WordCount> TokenizeWordswithCount(string CompleteText,List<string> lstSandhiWords)
        {
            List<string> lstcorrectWords = new List<string>();
            List<string> lstWithoutSandhiWords = new List<string>();
            List<WordCount> lstWordCounts = new List<WordCount>();
            
            //first split will space
            string[] arrWords = CompleteText.Split(' ');

            //words with duplication
            foreach (string input in arrWords)
            {
                string Word = input.Trim();

                if (!string.IsNullOrEmpty(Word))
                {
                    lstcorrectWords.Add(Word);
                }
            }

            //remove duplicates and remove sandhiending words
            foreach (string str in lstcorrectWords)
            {
                bool hassandhi = false;

                if(str.EndsWith("க்") || str.EndsWith("த்") || str.EndsWith("ச்") || str.EndsWith("ப்"))
                {
                    hassandhi = true;
                }

                if (hassandhi)
                {
                    if (!lstSandhiWords.Contains(str.Substring(0, str.Length - 2)))
                    {
                        //int normalwithsandhi = CountOccurenceOfValue(lstcorrectWords, str.Substring(0, str.Length - 2));
                        ////int normalwithsandhi = lstcorrectWords.Where(x => x.Equals(str.Substring(0, str.Length - 2))).Count();

                        //if (normalwithsandhi == 0 && !lstWithoutSandhiWords.Contains(str))
                        //{
                        if (!lstWithoutSandhiWords.Contains(str))
                        {
                            lstWithoutSandhiWords.Add(str);
                        }
                    
                        //}
                    }

                }
                else
                {
                    if (!lstWithoutSandhiWords.Contains(str))
                    {
                        lstWithoutSandhiWords.Add(str);
                    }
                }
                
            }

            foreach (string str in lstWithoutSandhiWords)
            {
                WordCount Wc = new WordCount();
                int cc = 0;

                int normal = 0;
                int normalKa = 0;
                int normalsa = 0;
                int normalta = 0; 
                int normalpa = 0;

                string WordOtherForm = string.Empty;

                normal = CountOccurenceOfValue(lstcorrectWords, str);

                if (lstSandhiWords.Contains(str))
                {                    
                    //normal = lstcorrectWords.Where(x => x.Equals(str)).Count();

                    if (lstcorrectWords.Contains(str + "க்"))
                    {
                        normalKa = CountOccurenceOfValue(lstcorrectWords, str + "க்");
                        //normalKa = lstcorrectWords.Where(x => x.Equals(str + "க்")).Count();
                    }
                    if (lstcorrectWords.Contains(str + "ச்"))
                    {
                        normalsa = CountOccurenceOfValue(lstcorrectWords, str + "ச்");
                        //normalsa = lstcorrectWords.Where(x => x.Equals(str + "ச்")).Count();
                    }
                    if (lstcorrectWords.Contains(str + "த்"))
                    {
                        normalta = CountOccurenceOfValue(lstcorrectWords, str + "த்");
                        //normalta = lstcorrectWords.Where(x => x.Equals(str + "த்")).Count();
                    }
                    if (lstcorrectWords.Contains(str + "ப்"))
                    {
                        normalpa = CountOccurenceOfValue(lstcorrectWords, str + "ப்");
                        //normalpa = lstcorrectWords.Where(x => x.Equals(str + "ப்")).Count();
                    }
                }


                Wc.Word = str;

                if (normalKa > 0)
                {
                    WordOtherForm = str + "க்";
                }
                if (normalsa > 0)
                {
                    if (string.IsNullOrEmpty(WordOtherForm))
                    {
                        WordOtherForm = str + "ச்";
                    }
                    else
                    {
                        WordOtherForm = WordOtherForm + "," + str + "ச்";
                    }
                }
                if (normalta > 0)
                {
                    if (string.IsNullOrEmpty(WordOtherForm))
                    {
                        WordOtherForm = str + "த்";
                    }
                    else
                    {
                        WordOtherForm = WordOtherForm + "," + str + "த்";
                    }
                }
                if (normalpa > 0)
                {
                    if (string.IsNullOrEmpty(WordOtherForm))
                    {
                        WordOtherForm = str + "ப்";
                    }
                    else
                    {
                        WordOtherForm = WordOtherForm + "," + str + "ப்";
                    }
                }



                Wc.OtherForm = WordOtherForm;
                Wc.Count = normal + normalKa + normalsa + normalta + normalpa;

                lstWordCounts.Add(Wc);

            }

            lstWordCounts.Sort();
            return lstWordCounts;
        }

        public List<string> TokenizeWords_ConcordNgram(string CompleteText)
        {
            List<string> lstcorrectWords = new List<string>();
          
            //first split will space
            string[] arrWords = CompleteText.Split(' ');

            //words with duplication
            foreach (string input in arrWords)
            {
                string Word = input.Trim();

                if (!string.IsNullOrEmpty(Word))
                {
                    lstcorrectWords.Add(Word);
                }
            }

            return lstcorrectWords;
        }


        //old
        public List<string> TokenizeWords(string CompleteText)
        {
            List<string> lstexceptionalWords = new List<string>();
            List<string> lstcorrectWords = new List<string>();
            List<string> lstFinalcorrectwords = new List<string>();

            //first split will space
            string[] arrWords = CompleteText.Split(' ');

            //handle delimiters
            foreach (string input in arrWords)
            {
                string Word = input.Trim();
                bool containDelim = false;
                int delimcount = 0;

                if (string.IsNullOrEmpty(Word))
                {
                    //lstcorrectWords.Add(Word);
                    continue;
                }

                //if the word itself is a delimiter then append it to the previous text
                if (lstDelimiters.Contains(Word))
                {
                    if (lstcorrectWords.Count > 0)
                    {
                        lstcorrectWords[lstcorrectWords.Count - 1] = lstcorrectWords[lstcorrectWords.Count - 1] + Word;
                        continue;
                    }
                }

                //check whether a word has a delimiter
                foreach (string delim in lstDelimiters)
                {
                    if (Word.Contains(delim))
                    {
                        if (delim != "." && delim != "-")
                        {
                            containDelim = true;
                            break;
                        }
                    }
                }

                //if no delimter add text to the list
                if (containDelim == false)
                {
                    lstcorrectWords.Add(Word);
                }

                //replace the delim with delim + space and then split
                else
                {
                    foreach (string delim in lstDelimiters)
                    {
                        if (Word.Contains(delim))
                        {
                            if (delim == "\r\n" || delim == "\n")
                            {
                                Word = Word.Replace(delim, " ");
                            }
                            else
                            {
                                Word = Word.Replace(delim, delim + " ");
                            }
                        }
                    }

                    string[] arrsplit = Word.Split(' ');
                    if (arrsplit.Length > 1)
                    {
                        foreach (string str in arrsplit)
                        {
                            lstcorrectWords.Add(str);
                        }
                    }
                }
            }
            //Format the output
            foreach (string text in lstcorrectWords)
            {
                if (string.IsNullOrEmpty(text))
                    continue;

                else if (lstDelimiters.Contains(text))
                {
                    if (lstFinalcorrectwords.Count > 0)
                    {
                        lstFinalcorrectwords[lstFinalcorrectwords.Count - 1] = lstFinalcorrectwords[lstFinalcorrectwords.Count - 1] + text;
                        continue;
                    }
                }

                else
                {
                    lstFinalcorrectwords.Add(text);
                }
            }

            return lstFinalcorrectwords;
        }


        static int CountOccurenceOfValue(List<string> list, string valueToFind)
        {
            return ((from temp in list where temp.Equals(valueToFind) select temp).Count());
        }

        public List<WordTokenizerResult> FindFrequency(List<string> lstcorrectWords)
        {
            List<string> lstfoundAlready = new List<string>();
            List<WordTokenizerResult> lstResult = new List<WordTokenizerResult>();

            int totalCount = lstcorrectWords.Count;

            lstResult.Clear();
            for (int i = 0; i < lstcorrectWords.Count; i++)
            {
                string currentWord = lstcorrectWords[i];
                WordTokenizerResult clsTokenizer = new WordTokenizerResult();

                if (string.IsNullOrEmpty(currentWord.Trim()))
                    continue;

                if (!lstfoundAlready.Contains(currentWord))
                {
                    lstfoundAlready.Add(currentWord);
                }
                else
                {
                    continue;
                }
                decimal count = 0;
                decimal freq = 0;

                for (int j = 0; j < lstcorrectWords.Count; j++)
                {
                    if (currentWord.Equals(lstcorrectWords[j]))
                    {
                        count = count + 1;
                        lstcorrectWords[j] = " ";
                    }
                }

                clsTokenizer.Word = currentWord;
                clsTokenizer.Count = count.ToString();
                freq = (count / totalCount) * 100;
                freq = Math.Round(freq, 2);
                clsTokenizer.Frequency = freq.ToString();
                lstResult.Add(clsTokenizer);
            }
            //the lstResult has all the tokenized words, now storing it in a xml file


            //sorting the list with respect to frequency


            lstResult.Sort();

            return lstResult;

            //int count1 = 0;
            ////create the xml file
            //foreach (WordTokenizerResult obj in lstResult)
            //{
            //    count1 = count1 + 1;
            //    XmlNode node = freqnameDoc.CreateNode(XmlNodeType.Element, "entry", null);

            //    XmlNode dicid = freqnameDoc.CreateElement("Number");
            //    dicid.InnerText = count1.ToString();


            //    XmlNode dicname = freqnameDoc.CreateElement("word");
            //    dicname.InnerText = obj.Word;

            //    XmlNode type = freqnameDoc.CreateElement("count");
            //    type.InnerText = obj.Count;

            //    XmlNode id = freqnameDoc.CreateElement("frequency");
            //    id.InnerText = obj.Frequency;


            //    node.AppendChild(dicid);
            //    node.AppendChild(dicname);
            //    node.AppendChild(type);
            //    node.AppendChild(id);

            //    freqnameDoc.DocumentElement.AppendChild(node);
            //}
            //try
            //{
            //    freqnameDoc.Save(xmlnewFile);
            //}
            //catch (Exception ex) { }
        }

        
    }
    public class WordTokenizerResult : IComparable<WordTokenizerResult>
    {
        public string Word { get; set; }
        public string Count { get; set; }
        public string Frequency { get; set; }

        public int CompareTo(WordTokenizerResult other)
        {
            if (Convert.ToDecimal(this.Frequency) < Convert.ToDecimal(other.Frequency)) return 1;
            else if (Convert.ToDecimal(this.Frequency) > Convert.ToDecimal(other.Frequency)) return -1;
            else return 0;
        }
    }
    public class WordCount : IComparable<WordCount>
    {
        public string Word { get; set; }
        public string OtherForm { get; set; }
        public int Count { get; set; }

        public int CompareTo(WordCount other)
        {
            if (this.Count < other.Count) return 1;
            else if (this.Count > other.Count) return -1;
            else return 0;

        }




    }
}
