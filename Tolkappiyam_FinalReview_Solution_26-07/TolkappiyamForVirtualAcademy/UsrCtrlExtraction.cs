using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace TolkappiyamForVirtualAcademy
{
    public partial class UsrCtrlExtraction : UserControl
    {
        XmlDocument xmlDoc = null;

        string xmlTolkappiyam = string.Empty;


        public bool IsParsed
        {
            get
            {
                return rbParsed.Checked;
            }
        }

        public UsrCtrlExtraction()
        {
            //InitializeComponent();
            InitializeComponent();
            cmbDivision.Items.Add("எழுத்ததிகாரம்");
            cmbDivision.Items.Add("சொல்லதிகாரம்");
            cmbDivision.Items.Add("பொருளதிகாரம்");
            cmbDivision.Text = "தேர்ந்தெடு";

            string appDataPath = Path.Combine(Application.StartupPath, "Data");
            xmlTolkappiyam = Path.Combine(appDataPath, "Tolkappiyam.xml");

            if (xmlDoc == null)
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlTolkappiyam);
            }

            SearchAsUType();
        }

        #region Methods

        private List<clsTolkappiyam> RetrieveDetails(string Query)
        {
            List<clsTolkappiyam> lstResult = new List<clsTolkappiyam>();
            XmlNodeList nodelist = null;

            nodelist = xmlDoc.SelectNodes(Query);

            lstResult.Clear();

            if (nodelist != null)
            {
                foreach (XmlNode node in nodelist)
                {
                    clsTolkappiyam objresult = new clsTolkappiyam();

                    if (node["Division"].InnerXml.ToString() == "எழுத்ததிகாரம்")
                    {
                        objresult.Division = DivisionType.எழுத்ததிகாரம்;
                    }
                    else if (node["Division"].InnerXml.ToString() == "சொல்லதிகாரம்")
                    {
                        objresult.Division = DivisionType.சொல்லதிகாரம்;
                    }
                    else if (node["Division"].InnerXml.ToString() == "பொருளதிகாரம்")
                    {
                        objresult.Division = DivisionType.பொருளதிகாரம்;
                    }

                    objresult.Chapter = node["Chapter"].InnerXml.ToString().Trim();
                    objresult.Verse = node["VerseNo"].InnerXml.ToString().Trim();
                    objresult.Line = node["LineNo"].InnerXml.ToString().Trim();
                    objresult.Text = node["Text"].InnerXml.ToString().Trim();
                    objresult.Original = node["OriginalText"].InnerXml.ToString().Trim();
                    objresult.TextRoman = node["TextRoman"].InnerXml.ToString().Trim();
                    objresult.OriginalRoman = node["OriginalTextRoman"].InnerXml.ToString().Trim();

                    lstResult.Add(objresult);
                }

            }

            return lstResult;
        }

        private void SearchingSingleWord()
        {
            string WordTobeSerached = comboBox1.SelectedItem.ToString();
            List<string> lstcomdetails = new List<string>();
            List<clsTolkappiyam> lstFinalResult = new List<clsTolkappiyam>();
            XmlTextReader reader = null;
            string dummystr = string.Empty;
            bool stringFormat;

            if (string.IsNullOrEmpty(WordTobeSerached))
                MessageBox.Show("Please enter the word");
            else
            {
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

                                if (ss == "Text")
                                    dummystr = reader.Value;

                                if (IsParsed)
                                {
                                    stringFormat = (ss.Equals("Text")) && reader.Value.Split(' ').Contains(WordTobeSerached);
                                }
                                else
                                {
                                    stringFormat = (ss.Equals("OriginalText")) && reader.Value.Split(' ').Contains(WordTobeSerached);
                                }


                                if (stringFormat)
                                {
                                    if (!IsParsed)
                                    {
                                        lstcomdetails.Add(dummystr);
                                    }

                                    lstcomdetails.Add(reader.Value);
                                    do
                                    {
                                        reader.Read();
                                        if (reader.IsStartElement())
                                        {
                                            if (!reader.IsEmptyElement)
                                            {
                                                lstcomdetails.Add(reader.ReadString());
                                            }
                                            else
                                            {
                                                lstcomdetails.Add("");
                                            }
                                        }

                                    } while (!reader.Name.Equals("Verse"));
                                    clsTolkappiyam objresult = new clsTolkappiyam();
                                    objresult.Text = lstcomdetails[0].ToString();
                                    objresult.Original = lstcomdetails[1].ToString();
                                    objresult.Division = objresult.stringToEnum(lstcomdetails[2].ToString());
                                    objresult.Chapter = lstcomdetails[3].ToString();
                                    objresult.Verse = lstcomdetails[6].ToString();
                                    objresult.Line = lstcomdetails[7].ToString();

                                    lstFinalResult.Add(objresult);
                                    lstcomdetails.Clear();
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

                Display(lstFinalResult, DisplayType.Word);
            }
        }

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

                                if (IsParsed && ss == "Text")
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
                                else if ((!IsParsed) && (ss == "OriginalText"))
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


            if (lstcomdetails.Count > 1)
            {
                foreach (string str in lstcomdetails)
                {
                    comboBox1.Items.Add(str);
                }

            }
        }

        private void Display(List<clsTolkappiyam> lstAllVerses, DisplayType type)
        {
            StringBuilder sb = new StringBuilder();
            TextFormat objformat = new TextFormat();

            if (lstAllVerses.Count == 0)
            {
                rtbText.Clear();
                rtbText.SelectedText = "No such word Exist";
                lblCount.Text = "0";
            }
            else
            {
                if (type == DisplayType.Word)
                {
                    foreach (clsTolkappiyam obj in lstAllVerses)
                    {
                        rtbText.SelectionColor = Color.Blue;
                        rtbText.SelectedText = "parsed : ";


                        if (IsParsed)
                        {
                            objformat = SplitWords(obj.Text);

                            rtbText.SelectionColor = Color.Black;
                            rtbText.SelectedText = objformat.leftWords;

                            rtbText.SelectionColor = Color.Red;
                            rtbText.SelectedText = " " + objformat.MiddleWord;

                            rtbText.SelectionColor = Color.Black;
                            rtbText.SelectedText = " " + objformat.rightWords + Environment.NewLine;

                        }
                        else
                        {
                            rtbText.SelectionColor = Color.Black;
                            rtbText.SelectedText = obj.Text + Environment.NewLine;
                        }

                        rtbText.SelectionColor = Color.Blue;
                        rtbText.SelectedText = "Original : ";


                        if (!IsParsed)
                        {
                            objformat = SplitWords(obj.Original);

                            rtbText.SelectionColor = Color.Black;
                            rtbText.SelectedText = objformat.leftWords;

                            rtbText.SelectionColor = Color.Red;
                            rtbText.SelectedText = " " + objformat.MiddleWord;

                            rtbText.SelectionColor = Color.Black;
                            rtbText.SelectedText = " " + objformat.rightWords + Environment.NewLine;
                        }
                        else
                        {
                            rtbText.SelectionColor = Color.Black;
                            rtbText.SelectedText = obj.Original + Environment.NewLine;
                        }


                        rtbText.SelectionColor = Color.Blue;
                        rtbText.SelectedText = "Division/Chapter/Verse : ";


                        rtbText.SelectionColor = Color.Black;
                        rtbText.SelectedText = obj.Division + " / " + obj.Chapter + " / " + obj.Verse + Environment.NewLine;

                        rtbText.SelectedText = Environment.NewLine + Environment.NewLine;
                    }

                }
                if (type == DisplayType.Line)
                {

                    foreach (clsTolkappiyam obj in lstAllVerses)
                    {
                        sb.Append("Division     :   ").AppendLine(obj.Division.ToString());
                        sb.Append("Chapter     :   ").AppendLine(obj.Chapter);
                        sb.Append("Verse      :   ").AppendLine(obj.Verse);
                        sb.Append("Line       :   ").Append(obj.Text).AppendLine(" (ParsedForm) ");
                        sb.Append("              ").Append(obj.Original).AppendLine(" (OriginalForm) ");
                        sb.Append("              ").Append(obj.TextRoman).AppendLine(" (ParsedForm - Roman) ");
                        sb.Append("              ").Append(obj.OriginalRoman).AppendLine(" (OriginalForm - Roman) ");

                    }
                    rtbText.Text = sb.ToString();
                }
                else if (type == DisplayType.Verse)
                {

                    sb.Append("Division     :   ").AppendLine(lstAllVerses[0].Division.ToString());
                    sb.Append("Chapter     :   ").AppendLine(lstAllVerses[0].Chapter);
                    sb.Append("Verse       :   ").AppendLine(lstAllVerses[0].Verse);

                    int lineno = 1;

                    sb.Append("    ").AppendLine("ParsedForm : ");
                    foreach (clsTolkappiyam cls in lstAllVerses)
                    {
                        sb.Append("        ").Append(lineno.ToString()).Append(") ").AppendLine(cls.Text);
                        lineno = lineno + 1;
                    }
                    sb.Append("    ").AppendLine("OriginalForm : ");
                    foreach (clsTolkappiyam cls in lstAllVerses)
                    {
                        sb.Append("        ").AppendLine(cls.Original);

                    }
                    sb.Append("    ").AppendLine("ParsedForm - Roman : ");
                    foreach (clsTolkappiyam cls in lstAllVerses)
                    {
                        sb.Append("        ").AppendLine(cls.TextRoman);

                    }
                    sb.Append("    ").AppendLine("OriginalForm - Roman : ");
                    foreach (clsTolkappiyam cls in lstAllVerses)
                    {
                        sb.Append("        ").AppendLine(cls.OriginalRoman);

                    }
                    sb.Append(Environment.NewLine);

                    rtbText.Text = sb.ToString();
                }

                else if (type == DisplayType.Chapter)
                {

                    List<string> lstverse = new List<string>();
                    sb.Append("Division     :   ").AppendLine(lstAllVerses[0].Division.ToString());
                    sb.Append("Chapter     :   ").AppendLine(lstAllVerses[0].Chapter);
                    foreach (clsTolkappiyam obj in lstAllVerses)
                    {
                        if (!lstverse.Contains(obj.Verse))
                        {
                            lstverse.Add(obj.Verse);
                            List<clsTolkappiyam> lstall = new List<clsTolkappiyam>();
                            lstall = lstAllVerses.FindAll(o => o.Verse == obj.Verse);
                            sb.Append("Verse : ").AppendLine(obj.Verse);

                            int lineno = 1;

                            sb.Append("    ").AppendLine("ParsedForm : ");
                            foreach (clsTolkappiyam cls in lstall)
                            {
                                sb.Append("        ").Append(lineno.ToString()).Append(") ").AppendLine(cls.Text);
                                lineno = lineno + 1;
                            }
                            sb.Append("    ").AppendLine("OriginalForm : ");
                            foreach (clsTolkappiyam cls in lstall)
                            {
                                sb.Append("        ").AppendLine(cls.Original);

                            }
                            sb.Append("    ").AppendLine("ParsedForm - Roman : ");
                            foreach (clsTolkappiyam cls in lstall)
                            {
                                sb.Append("        ").AppendLine(cls.TextRoman);

                            }
                            sb.Append("    ").AppendLine("OriginalForm - Roman : ");
                            foreach (clsTolkappiyam cls in lstall)
                            {
                                sb.Append("        ").AppendLine(cls.OriginalRoman);

                            }
                            sb.Append(Environment.NewLine);

                        }
                        else
                        {
                            continue;
                        }
                    }
                    rtbText.Text = sb.ToString();
                }
                lblCount.Text = lstAllVerses.Count.ToString();
            }

            //rtbText.Text = sb.ToString();
        }



        private TextFormat SplitWords(string str)
        {
            string[] Words = str.Split(' ');
            string leftWords = string.Empty;
            string MiddleWord = string.Empty;
            int MiddlePos = 0;
            string RightWords = string.Empty;

            for (int i = 0; i < Words.Length; i++)
            {
                if (Words[i].Trim() == comboBox1.Text.Trim())
                {
                    MiddleWord = Words[i].Trim();
                    MiddlePos = i;
                    break;
                }
                else
                {
                    leftWords = leftWords + " " + Words[i];

                }
            }

            for (int j = MiddlePos + 1; j < Words.Length; j++)
            {
                RightWords = RightWords + " " + Words[j];
            }

            TextFormat objformat = new TextFormat();
            objformat.leftWords = leftWords;
            objformat.MiddleWord = MiddleWord;
            objformat.rightWords = RightWords;

            return objformat;

        }


        #endregion

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                SearchAsUType();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedItem.ToString();
            rtbText.Clear();

            if (cmbChapter.Text != "தேர்ந்தெடு")
            {
                comboBox1.Text = string.Empty;
                cmbChapter.Enabled = false;
                cmbVerse.Enabled = false;
                cmbLine.Enabled = false;
                cmbDivision.Text = "தேர்ந்தெடு";
                cmbChapter.Text = "தேர்ந்தெடு";
                cmbVerse.Text = "தேர்ந்தெடு";
                cmbLine.Text = "தேர்ந்தெடு";
            }


            SearchingSingleWord();
        }

        private void cmbLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<clsTolkappiyam> lstAllVerses = new List<clsTolkappiyam>();

            string Query = "/Tolkappiyam/Verse[Division = '" + cmbDivision.SelectedItem.ToString() + "' and Chapter = '" + cmbChapter.SelectedItem.ToString() + "' and VerseNo = '" + cmbVerse.SelectedItem.ToString() + "' and LineNo = '" + cmbLine.SelectedItem.ToString() + "']";

            lstAllVerses = RetrieveDetails(Query);

            cmbChapter.Enabled = true;
            cmbVerse.Enabled = true;
            cmbLine.Enabled = true;

            Display(lstAllVerses, DisplayType.Line);
        }

        private void cmbChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lstVerse = new List<string>();
            List<clsTolkappiyam> lstAllVerses = new List<clsTolkappiyam>();

            cmbVerse.Enabled = false;
            cmbLine.Enabled = false;
            cmbLine.Text = "தேர்ந்தெடு";

            string Query = "/Tolkappiyam/Verse[Division = '" + cmbDivision.SelectedItem.ToString() + "' and Chapter = '" + cmbChapter.SelectedItem.ToString() + "']";

            lstAllVerses = RetrieveDetails(Query);

            foreach (clsTolkappiyam obj in lstAllVerses)
            {
                if (!lstVerse.Contains(obj.Verse))
                {
                    lstVerse.Add(obj.Verse);
                }
            }


            this.cmbVerse.SelectedIndexChanged -= new EventHandler(cmbVerse_SelectedIndexChanged);

            cmbVerse.DataSource = lstVerse;
            cmbVerse.Text = "தேர்ந்தெடு";
            cmbLine.Text = "தேர்ந்தெடு";

            this.cmbVerse.SelectedIndexChanged += new EventHandler(cmbVerse_SelectedIndexChanged);

            cmbChapter.Enabled = true;
            cmbVerse.Enabled = true;

            Display(lstAllVerses, DisplayType.Chapter);
        }

        private void cmbVerse_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lstLine = new List<string>();
            List<clsTolkappiyam> lstAllVerses = new List<clsTolkappiyam>();


            cmbLine.Enabled = false;

            string Query = "/Tolkappiyam/Verse[Division = '" + cmbDivision.SelectedItem.ToString() + "' and Chapter = '" + cmbChapter.SelectedItem.ToString() + "' and VerseNo = '" + cmbVerse.SelectedItem.ToString() + "']";

            lstAllVerses = RetrieveDetails(Query);

            foreach (clsTolkappiyam obj in lstAllVerses)
            {
                if (!lstLine.Contains(obj.Line))
                {
                    lstLine.Add(obj.Line);
                }
            }

            this.cmbLine.SelectedIndexChanged -= new EventHandler(cmbLine_SelectedIndexChanged);

            cmbLine.DataSource = lstLine;
            cmbLine.Text = "தேர்ந்தெடு";
            this.cmbLine.SelectedIndexChanged += new EventHandler(cmbLine_SelectedIndexChanged);

            cmbChapter.Enabled = true;
            cmbVerse.Enabled = true;
            cmbLine.Enabled = true;

            Display(lstAllVerses, DisplayType.Verse);
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lstChapter = new List<string>();
            List<clsTolkappiyam> lstAllVerses = new List<clsTolkappiyam>();
            rtbText.Clear();
            comboBox1.Text = string.Empty;
            cmbChapter.Enabled = false;
            cmbVerse.Enabled = false;
            cmbLine.Enabled = false;

            string Query = "/Tolkappiyam/Verse[Division = '" + cmbDivision.SelectedItem.ToString() + "']";

            lstAllVerses = RetrieveDetails(Query);

            foreach (clsTolkappiyam obj in lstAllVerses)
            {
                if (!lstChapter.Contains(obj.Chapter))
                {
                    lstChapter.Add(obj.Chapter);
                }
            }

            this.cmbChapter.SelectedIndexChanged -= new EventHandler(cmbChapter_SelectedIndexChanged);


            cmbChapter.DataSource = lstChapter;
            cmbChapter.Text = "தேர்ந்தெடு";
            cmbLine.Text = "தேர்ந்தெடு";
            cmbVerse.Text = "தேர்ந்தெடு";


            this.cmbChapter.SelectedIndexChanged += new EventHandler(cmbChapter_SelectedIndexChanged);

            cmbChapter.Enabled = true;
        }

        private void rbOriginal_CheckedChanged(object sender, EventArgs e)
        {
            rtbText.Clear();
            comboBox1.Text = string.Empty;
            comboBox1.Items.Clear();
            lblCount.Text = "0";
            SearchAsUType();
        }

        private void rbParsed_CheckedChanged(object sender, EventArgs e)
        {
            rtbText.Clear();
            comboBox1.Text = string.Empty;
            comboBox1.Items.Clear();
            lblCount.Text = "0";
            SearchAsUType();
        }
    }
    public class TextFormat
    {
        public string leftWords;
        public string MiddleWord;
        public string rightWords;
    }

    public enum DisplayType
    {
        Division,
        Chapter,
        Verse,
        Line,
        Word
    }
}
