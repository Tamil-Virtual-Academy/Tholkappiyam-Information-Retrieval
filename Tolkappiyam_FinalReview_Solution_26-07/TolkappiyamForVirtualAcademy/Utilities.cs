using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;


namespace TolkappiyamForVirtualAcademy
{        
    public class clsTolkappiyam
    {
        public DivisionType Division { get; set; }
        public string Chapter { get; set; }
        public string Verse { get; set; }
        public string Line { get; set; }
        public string Text { get; set; }
        public string Original { get; set; }
        public string TextRoman { get; set; }
        public string OriginalRoman { get; set; }


        public DivisionType stringToEnum(string str)
        {
            //DivisionType type = DivisionType.எழுத்ததிகாரம்;
            switch (str)
            {
                case "எழுத்ததிகாரம்":
                    return DivisionType.எழுத்ததிகாரம்;

                case "சொல்லதிகாரம்":
                    return DivisionType.சொல்லதிகாரம்;

                case "பொருளதிகாரம்":
                    return DivisionType.பொருளதிகாரம்;

                default:
                    return DivisionType.எழுத்ததிகாரம்;

            }


        }
    }

    public class commonFunctions
    {
        public List<clsTolkappiyam> LoadTolkappiyamDetails()
        {
            string appDataPath = Path.Combine(Application.StartupPath, "Data");
            string xmlTolkappiyam = Path.Combine(appDataPath, "Tolkappiyam.xml");
            List<string> lstDetails = new List<string>();
            List<clsTolkappiyam> lstcomdetails = new List<clsTolkappiyam>();
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(xmlTolkappiyam);

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (!reader.IsEmptyElement)
                        {

                            string ss = reader.Name;

                            reader.Read(); // Read the start tag. 

                            if (ss == "Verse")
                            {
                                do
                                {
                                    reader.Read();
                                    if (reader.IsStartElement())
                                    {
                                        if (!reader.IsEmptyElement)
                                        {
                                            lstDetails.Add(reader.ReadString());
                                        }
                                    }

                                } while (!reader.Name.Equals("Verse"));

                                clsTolkappiyam objresult = new clsTolkappiyam();
                                objresult.Text = lstDetails[0].ToString();
                                objresult.Original = lstDetails[1].ToString();
                                objresult.Division = objresult.stringToEnum(lstDetails[2].ToString());
                                objresult.Chapter = lstDetails[3].ToString();
                                objresult.Verse = lstDetails[6].ToString();
                                objresult.Line = lstDetails[7].ToString();

                                lstcomdetails.Add(objresult);
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

            return lstcomdetails;
        }

        public List<string> SearchAsUType(bool IsParsed,string str)
        {
            string appDataPath = Path.Combine(Application.StartupPath, "Data");
            string xmlTolkappiyam = Path.Combine(appDataPath, "Tolkappiyam.xml");
            string WordTobeSerached = str;
            List<string> lstcomdetails = new List<string>();
           
            XmlTextReader reader = null;
           
                     
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
                                //dummystr = reader.Value;

                                if (IsParsed && ss == "Text")
                                {
                                    //stringFormat = (ss.Equals("Text")) && reader.Value.Split(' ').ToString().StartsWith(WordTobeSerached);
                                    foreach (string txtstr in reader.Value.Split(' '))
                                    {
                                        if (txtstr.StartsWith(WordTobeSerached))
                                        {
                                            if (!lstcomdetails.Contains(txtstr))
                                            {
                                                lstcomdetails.Add(txtstr);
                                            }
                                        }
                                    }
                                }
                                else if ((!IsParsed) && (ss == "OriginalText"))
                                {
                                    //stringFormat = (ss.Equals("OriginalText")) && reader.Value.Split(' ').ToString().StartsWith(WordTobeSerached);
                                    foreach (string Orgstr in reader.Value.Split(' '))
                                    {
                                        if (Orgstr.StartsWith(WordTobeSerached))
                                        {
                                            if (!lstcomdetails.Contains(Orgstr))
                                            {
                                                lstcomdetails.Add(Orgstr);
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


            return lstcomdetails;
            
        }

        public List<string> LoadNormalFormWithSandhi()
        {
            string appDataPath = Path.Combine(Application.StartupPath, "Data");
            string txtNormalSandhi = Path.Combine(appDataPath, "txtNormalSandhi.txt");
            
            List<string> lstNormalEndingwithSandhi = new List<string>();
            string line = string.Empty;
            StreamReader reader = new StreamReader(txtNormalSandhi);

            while ((line = reader.ReadLine()) != null)
            {
                lstNormalEndingwithSandhi.Add(line);
            }

            reader.Close();


            return lstNormalEndingwithSandhi;

        }

        public List<string> LoadParsedFormWithSandhi()
        {
            string appDataPath = Path.Combine(Application.StartupPath, "Data");
            string txtParsedSandhi = Path.Combine(appDataPath, "txtParsedSandhi.txt");
            List<string> lstParsedEndingwithSandhi = new List<string>();

            string line = string.Empty;
            StreamReader reader = new StreamReader(txtParsedSandhi);

            while ((line = reader.ReadLine()) != null)
            {
                lstParsedEndingwithSandhi.Add(line);
            }

            reader.Close();
            return lstParsedEndingwithSandhi;
        }
    }
    
    public enum DivisionType
    {
        எழுத்ததிகாரம்,
        சொல்லதிகாரம்,
        பொருளதிகாரம்
    }
    public enum TypeForm
    {
        NormalForm,
        ParsedForm
    }

}
