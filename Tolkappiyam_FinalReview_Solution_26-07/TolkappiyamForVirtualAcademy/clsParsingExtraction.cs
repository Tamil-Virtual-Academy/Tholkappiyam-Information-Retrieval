using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace TolkappiyamForVirtualAcademy
{
    public class clsParsingExtraction
    {
        XmlDocument xmlDoc = null;
        string appDataPath,xmlTolkappiyamParsed,xmlTolkappiyam = string.Empty;
                           
        public void initialize()
        {
            appDataPath = Path.Combine(Application.StartupPath, "Data");
            xmlTolkappiyamParsed = Path.Combine(appDataPath, "TolkappiyamParsed_Final.xml");

            if (xmlDoc == null)
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlTolkappiyamParsed);
            }
        }
        
        public ParserOutput RetrieveParsingDetailsWithWord(string InflectedWord)
        {
            ParserOutput ObjOutput = new ParserOutput();

            string Query = "/Tolkappiyam/WordDetail[Inflectedword = '" + InflectedWord + "']";

            ObjOutput = RetrieveSingleDetails(Query);
            
            return ObjOutput;
        }

        public List<string> RetrieveParsingDetailsWithRoot(string Root)
        {
            List<string> lstObjOutput = new List<string>();

            string Query = "/Tolkappiyam/WordDetail[Root = '" + Root + "']";

            lstObjOutput = RetrieveMultipleleDetails(Query);

            return lstObjOutput;

        }

        public List<string> RetrieveParsingDetailsWithPos(string Pos)
        {
            List<string> lstObjOutput = new List<string>();

            string Query = "/Tolkappiyam/WordDetail[Tagging = '" + Pos + "']";

            lstObjOutput = RetrieveMultipleleDetails(Query);

            return lstObjOutput;

        }
        
        private List<string> RetrieveMultipleleDetails(string Query)
        {
            List<string> lstResult = new List<string>();
            XmlNodeList nodelist = null;
          
            initialize();


            nodelist = xmlDoc.SelectNodes(Query);
           
            lstResult.Clear();

            if (nodelist != null)
            {
                foreach (XmlNode node in nodelist)
                {
                   lstResult.Add(node["Inflectedword"].InnerXml.ToString().Trim());
                }

            }

            return lstResult;
        }

        private ParserOutput RetrieveSingleDetails(string Query)
        {
            ParserOutput objresult = new ParserOutput();
            XmlNode Singlenode = null;

            initialize();
                                  
            Singlenode = xmlDoc.SelectSingleNode(Query);

            if (Singlenode != null)
            {       
                objresult.Word = Singlenode["Inflectedword"].InnerXml.ToString().Trim();
                objresult.Meaning = Singlenode["Meaning"].InnerXml.ToString().Trim();
                objresult.PosOutput = Singlenode["Tagging"].InnerXml.ToString().Trim();
                objresult.Root = Singlenode["Root"].InnerXml.ToString().Trim();
                objresult.RootCategory = Singlenode["RootCategory"].InnerXml.ToString().Trim();
                objresult.Suffixes = Singlenode["Suffix"].InnerXml.ToString().Trim();
                objresult.SuffixCategory = Singlenode["SuffixCategory"].InnerXml.ToString().Trim();

                if (objresult.Suffixes == "NoSuffix")
                {
                    objresult.Suffixes = "விகுதிகள் இல்லை";
                    objresult.SuffixCategory = "---";
                }
            }

            return objresult;
        }

        public List<IndexedVerses> ReturnstartendWords()
        {
            List<IndexedVerses> lstStartendWords = new List<IndexedVerses>();
            appDataPath = Path.Combine(Application.StartupPath, "Data");
            xmlTolkappiyam = Path.Combine(appDataPath, "Tolkappiyam.xml");

            if (xmlDoc == null)
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlTolkappiyam);
            }

            XmlNodeList nodelist = null;

            for (int verse = 1; verse <= 1610; verse++)
            {
                string Query = "/Tolkappiyam/Verse[VerseNo = " + verse + "]";

                nodelist = xmlDoc.SelectNodes(Query);

                int count = nodelist.Count;

                if (nodelist != null && nodelist.Count>0)
                {
                    XmlNode nodestart = nodelist[0];
                    XmlNode nodeend= nodelist[count-1];
                    IndexedVerses objVerse = new IndexedVerses();
                    objVerse.VerseNo = Int32.Parse(nodestart["VerseNo"].InnerXml.Trim());
                    objVerse.Division = nodestart["Division"].InnerXml.ToString().Trim();

                    objVerse.parsedstart = nodestart["Text"].InnerXml.ToString().Trim().Split(' ')[0].Trim();
                    objVerse.unparsedstart = nodestart["OriginalText"].InnerXml.ToString().Trim().Split(' ')[0].Trim();

                    if (nodestart["Text"].InnerXml.ToString().Trim().Split(' ').Length > 1)
                    {
                        objVerse.parsedFirstSecond = objVerse.parsedstart + " " + nodestart["Text"].InnerXml.ToString().Trim().Split(' ')[1].Trim();
                    }
                    else
                    {
                        objVerse.parsedFirstSecond = objVerse.parsedstart;
                    }
                    if (nodestart["OriginalText"].InnerXml.ToString().Trim().Split(' ').Length > 1)
                    {
                        objVerse.unparsedFirstSecond = objVerse.unparsedstart + " " + nodestart["OriginalText"].InnerXml.ToString().Trim().Split(' ')[1].Trim();
                    }
                    else
                    {
                        objVerse.unparsedFirstSecond = objVerse.unparsedstart;
                    }
                                                        
                    int lastparsedCount = nodeend["Text"].InnerXml.ToString().Trim().Split(' ').Length;
                    int lastunparsedCount = nodeend["OriginalText"].InnerXml.ToString().Trim().Split(' ').Length;
                    objVerse.parsedend = nodeend["Text"].InnerXml.ToString().Trim().Split(' ')[lastparsedCount - 1].Trim();
                    objVerse.unparsedend = nodeend["OriginalText"].InnerXml.ToString().Trim().Split(' ')[lastunparsedCount - 1].Trim();

                    if (lastparsedCount > 1)
                    {
                        objVerse.parsedSecondLast = nodeend["Text"].InnerXml.ToString().Trim().Split(' ')[lastparsedCount - 2].Trim() + " " + objVerse.parsedend;
                    }
                    else
                    {
                        objVerse.parsedSecondLast = objVerse.parsedend;
                    }
                    if (lastunparsedCount > 1)
                    {
                        objVerse.unparsedSecondLast = nodeend["OriginalText"].InnerXml.ToString().Trim().Split(' ')[lastunparsedCount - 2].Trim() + " " + objVerse.unparsedend;
                    }
                    else
                    {
                        objVerse.unparsedSecondLast = objVerse.unparsedend;
                    }

                    lstStartendWords.Add(objVerse);
                }

            }

            return lstStartendWords;
          
        }

        public List<ParserOutput> RetrieveAllParsedOutput()
        {               
            List<ParserOutput> lstFinalParsedOutput = new List<ParserOutput>();
            List<string> lstDetails = new List<string>();

            initialize();

            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(xmlTolkappiyamParsed);

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (!reader.IsEmptyElement)
                        {
                            string ss = reader.Name;

                            reader.Read(); // Read the start tag. 

                            if (ss == "WordDetail")
                            {
                                do
                                {
                                    reader.Read();
                                    if (reader.IsStartElement())
                                    {
                                        //if (!reader.IsEmptyElement)
                                        //{
                                            lstDetails.Add(reader.ReadString());
                                        //}
                                    }

                                } while (!reader.Name.Equals("WordDetail"));

                                ParserOutput objresult = new ParserOutput();
                                objresult.Word = lstDetails[0].ToString();
                                objresult.Meaning = lstDetails[1].ToString();
                                objresult.PosOutput = lstDetails[2].ToString();
                                objresult.Root = lstDetails[3].ToString();
                                objresult.RootCategory = lstDetails[4].ToString();
                                objresult.Suffixes = lstDetails[5].ToString();
                                objresult.SuffixCategory = lstDetails[6].ToString();

                                lstFinalParsedOutput.Add(objresult);
                                lstDetails.Clear();

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

            return lstFinalParsedOutput;
        }

        public List<SuffixCategoryDetails> ReturnAllSuffixesofCategory(string SuffixCategory)
        {
            List<SuffixCategoryDetails> lstSuffixCatDetails = new List<SuffixCategoryDetails>();
            List<ParserOutput> lstAllParsedOutputs = new List<ParserOutput>();
            List<ParserOutput> lstFilteredParsedOutputs = new List<ParserOutput>();


            lstAllParsedOutputs = RetrieveAllParsedOutput();

            lstFilteredParsedOutputs = lstAllParsedOutputs.FindAll(o => o.SuffixCategory.Contains(SuffixCategory));

            foreach (ParserOutput filteredout in lstFilteredParsedOutputs)
            {
                string[] arrSuff = filteredout.Suffixes.Split('+');
                string[] arrSuffCat = filteredout.SuffixCategory.Split('+');
              
                if (arrSuff.Length != arrSuffCat.Length)
                    continue;
                if (arrSuff[0] == "YetToBeFilled")
                    continue;

                for (int i = 0; i < arrSuffCat.Length; i++)
                {
                    if (arrSuffCat[i] == SuffixCategory)
                    {
                        SuffixCategoryDetails objdet = new SuffixCategoryDetails();
                        objdet.SuffixCat = arrSuffCat[i];
                        objdet.Suffixes = arrSuff[i];
                        objdet.Word = filteredout.Word;

                        lstSuffixCatDetails.Add(objdet);
                    }
                }
            }

            return lstSuffixCatDetails;

        }

    }
    public class WordExtraction
    {
        public int எண் { get; set; }
        public string சொல் { get; set; }
    }
    public class RootExtraction
    {
        public int எண் { get; set; }
        public string வேர்ச்சொல் { get; set; }
    }
    public class PosExtraction
    {

        public int எண் { get; set; }
        public string இலக்கணவகை { get; set; }
    }
    public class ParserOutput
    {
        public string Word { get; set; }
        public string Meaning { get; set; }
        public string PosOutput { get; set; }
        public string Root { get; set; }
        public string RootCategory { get; set; }
        public string Suffixes { get; set; }
        public string SuffixCategory { get; set; } 
    }
    public class IndexedVerses
    {
        public int VerseNo {get;set;}
        public string parsedstart { get; set; }
        public string parsedend { get; set; }
        public string parsedFirstSecond { get; set; }
        public string parsedSecondLast { get; set; }
        public string unparsedstart {get;set;}
        public string unparsedend {get;set;}       
        public string unparsedFirstSecond { get; set; }
        public string unparsedSecondLast { get; set; }       
        public string Division {get;set;}
    }
    public class VerseparsedStart
    {
        //public int No { get; set; }
        public string தொடக்கச்சொல் { get; set; }
        public string நூற்பா { get; set; }       
        //public string Division { get; set; }
    }

    public class VerseparsedEnd
    {
        //public int No { get; set; }
        public string இறுதிச்சொல் { get; set; }
        public string நூற்பா { get; set; }
        //public string Division { get; set; }       

    }
    
    public class VerseunparsedStart
    {
        //public int No { get; set; }
        public string தொடக்கச்சொல் { get; set; }
        public string நூற்பா { get; set; }       
        //public string Division { get; set; }        

    }
    public class VerseunparsedEnd
    {
        //public int No { get; set; }
        public string இறுதிச்சொல் { get; set; }
        public string நூற்பா { get; set; }            
        //public string Division { get; set; }        

    }
    public class DisplayAllLines
    {
        public List<IndexedVerses> verses { get; set; }
        public ChooseIndexing type { get; set; }
        public string Word { get; set; }

    }
    public class SuffixCategoryDetails
    {
        public string Word { get; set; }
        public string SuffixCat { get; set; }
        public string Suffixes { get; set; }
    }
    public enum ChooseIndexing
    {
        UPstart,
        UPend,
        Pstart,
        Pend
    };
}
