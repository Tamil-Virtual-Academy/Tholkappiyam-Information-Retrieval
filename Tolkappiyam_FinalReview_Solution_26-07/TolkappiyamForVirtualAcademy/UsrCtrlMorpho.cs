using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TolkappiyamForVirtualAcademy
{
    public partial class UsrCtrlMorpho : UserControl
    {
        List<ParserOutput> lstAllParserOutput = new List<ParserOutput>();

        public UsrCtrlMorpho()
        {
            InitializeComponent();
            LoadRootandSuffixCatinDatagrid();
        }

        private void LoadRootandSuffixCatinDatagrid()
        {
            clsParsingExtraction objExtract = new clsParsingExtraction();
           
            lstAllParserOutput = objExtract.RetrieveAllParsedOutput();

            List<string> lstRootCategory = new List<string>();
            List<string> lstSuffixes = new List<string>();
            
            foreach (ParserOutput output in lstAllParserOutput)
            {
                string[] arrSuff = output.Suffixes.Split('+');
                string[] arrSuffCat = output.SuffixCategory.Split('+');
                
                string[] arrRootCat = output.RootCategory.Split(',');

                

                if (output.RootCategory == "YetToBeFilled")
                    continue;

                for (int i = 0; i < arrRootCat.Length; i++)
                {
                    if (!lstRootCategory.Contains(arrRootCat[i].Trim()))
                    {
                        lstRootCategory.Add(arrRootCat[i].Trim());
                    }
                }


                if (output.SuffixCategory == "YetToBeFilled" || output.SuffixCategory == "NoSuffixCat")
                    continue;
                if (arrSuff.Length != arrSuffCat.Length)
                    continue;

                for (int i = 0; i < arrSuffCat.Length; i++)
                {
                    if (!lstSuffixes.Contains(arrSuffCat[i].Trim()))
                    {
                        if (arrSuffCat[i].Contains(','))
                            continue;
                        else
                            lstSuffixes.Add(arrSuffCat[i].Trim());
                    }
                }
            }

            int Count = 0;
            List<SuffixCatwithCount> lstRoot = new List<SuffixCatwithCount>();
            List<SuffixCatwithCount> lstSuff = new List<SuffixCatwithCount>();

            foreach (string str in lstRootCategory)
            {
                SuffixCatwithCount obj = new SuffixCatwithCount();
                Count = Count + 1;
                obj.எண் = Count;
                obj.விகுதிவகைப்பாடு = str;
                lstRoot.Add(obj);
            }
            RootSuffixDatagrid.DataSource = lstRoot;
            RootSuffixDatagrid.Columns[0].Width = 50;
            RootSuffixDatagrid.Columns[1].Width = 240;

            Count = 0;
          
            foreach (string str in lstSuffixes)
            {
                SuffixCatwithCount obj = new SuffixCatwithCount();
                Count = Count + 1;
                obj.எண் = Count;
                obj.விகுதிவகைப்பாடு = str;
                lstSuff.Add(obj);
            }
            SuffixDatagrid.DataSource = lstSuff;
            SuffixDatagrid.Columns[0].Width = 50;
            SuffixDatagrid.Columns[1].Width = 240;

        }

        private void rtbMorphotactics_TextChanged(object sender, EventArgs e)
        {

        }

        //check root equals or contains
        private void RootSuffixDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            string Root = string.Empty;

            rtbMorphotactics.Clear();

            int i = e.RowIndex;
            if (i != -1)
            {
                row = RootSuffixDatagrid.Rows[i];
                Root = row.Cells[1].Value.ToString();
            }

            List<ParserOutput> FilteredRoot = lstAllParserOutput.FindAll(o => o.RootCategory == Root);

            List<string> SuffixFlow = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (ParserOutput objOutput in FilteredRoot)
            {
                if (objOutput.SuffixCategory == "YetToBeFilled" || objOutput.SuffixCategory == "NoSuffixCat")
                    continue;
                else
                {
                    string str = objOutput.SuffixCategory.Split('+')[0].ToString();
                    if (!SuffixFlow.Contains(str))
                    {
                        SuffixFlow.Add(str);
                        if (string.IsNullOrEmpty(sb.ToString()))
                        {
                            sb.Append(str);
                        }
                        else
                        {
                            sb.Append(", " + str);
                        }
                    }
                }

            }

            rtbMorphotactics.SelectionColor = Color.Blue;
            rtbMorphotactics.SelectedText = Root + "-->";

              if(string.IsNullOrEmpty(sb.ToString()))
                sb.Append("No Flow");

            rtbMorphotactics.SelectionColor = Color.Black;
            rtbMorphotactics.SelectedText = sb.ToString();

        }

        private void SuffixDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            string Suffix = string.Empty;


            int i = e.RowIndex;
            if (i != -1)
            {
                row = SuffixDatagrid.Rows[i];
                Suffix = row.Cells[1].Value.ToString();
            }

            rtbMorphotactics.Clear();
            List<ParserOutput> FilteredSuffix = lstAllParserOutput.FindAll(o => o.SuffixCategory.Contains(Suffix));

            List<string> SuffixFlow = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (ParserOutput objOutput in FilteredSuffix)
            {
                string[] arrCat = objOutput.SuffixCategory.Split('+');

                for (int j = 0; j < arrCat.Length; j++)
                {
                    if (arrCat[j].Equals(Suffix) && (j + 1 < arrCat.Length))
                    {                       
                        if (!SuffixFlow.Contains(arrCat[j+1]))
                        {
                            SuffixFlow.Add(arrCat[j+1]);
                            if (string.IsNullOrEmpty(sb.ToString()))
                            {
                                sb.Append(arrCat[j + 1]);
                            }
                            else
                            {
                                sb.Append(", " + arrCat[j + 1]);
                            }

                        }
                    }
                }

            }

            rtbMorphotactics.SelectionColor = Color.Blue;
            rtbMorphotactics.SelectedText = Suffix + "-->";

            if(string.IsNullOrEmpty(sb.ToString()))
                sb.Append("No Flow");

            rtbMorphotactics.SelectionColor = Color.Black;
            rtbMorphotactics.SelectedText = sb.ToString();




        }
    }
}
