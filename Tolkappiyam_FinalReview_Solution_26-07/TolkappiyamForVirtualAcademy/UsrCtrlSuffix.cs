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
    public partial class UsrCtrlSuffix : UserControl
    {
        List<SuffixCategoryDetails> lstAllDetailsOfSuffCat = new List<SuffixCategoryDetails>();

        public string SuffixCategory { get; set; }

        public UsrCtrlSuffix()
        {
            InitializeComponent();
            LoadSuffixinDatagrid();
        }

        private void LoadSuffixinDatagrid()
        {
            clsParsingExtraction objExtract = new clsParsingExtraction();
            List<ParserOutput> lstAllParserOutput = new List<ParserOutput>();
            lstAllParserOutput = objExtract.RetrieveAllParsedOutput();
            List<string> lstSuffixes = new List<string>();

            foreach (ParserOutput output in lstAllParserOutput)
            {
                string []arrSuff = output.Suffixes.Split('+');
                string []arrSuffCat = output.SuffixCategory.Split('+');
                if (output.SuffixCategory == "YetToBeFilled" || output.SuffixCategory == "NoSuffixCat")
                    continue;
                if (arrSuff.Length != arrSuffCat.Length)
                    continue;

                for (int i = 0; i < arrSuffCat.Length; i++)
                {
                    if (!lstSuffixes.Contains(arrSuffCat[i].Trim()))
                    {
                        lstSuffixes.Add(arrSuffCat[i].Trim());
                    }
                }
            }
          
            int Count = 0;
            List<SuffixCatwithCount> lst = new List<SuffixCatwithCount>();
            foreach(string str in lstSuffixes)
            {
                SuffixCatwithCount obj = new SuffixCatwithCount();
                Count = Count + 1;
                obj.எண் = Count;
                obj.விகுதிவகைப்பாடு = str;
                lst.Add(obj);
            }
            SuffixDatagrid.DataSource = lst;
            SuffixDatagrid.Columns[0].Width = 50;
            SuffixDatagrid.Columns[1].Width = 240;
            
        }

        private void SuffixDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            clsParsingExtraction objExtract = new clsParsingExtraction();
            ParserOutput ParserDetails = new ParserOutput();           

            int i = e.RowIndex;
            if (i != -1)
            {
                row = SuffixDatagrid.Rows[i];
                SuffixCategory = row.Cells[1].Value.ToString();
            }

            lstAllDetailsOfSuffCat = objExtract.ReturnAllSuffixesofCategory(SuffixCategory);

            List<SuffixwithCount> lstSuffixes = new List<SuffixwithCount>();

            int count = 0;
            foreach (SuffixCategoryDetails str in lstAllDetailsOfSuffCat)
            {
                if (lstSuffixes.FindAll(o => o.விகுதி.Equals(str.Suffixes)).Count == 0)
                {
                    SuffixwithCount obj = new SuffixwithCount();
                    count = count + 1;

                    obj.விகுதி = str.Suffixes;
                    obj.எண் = count;

                    lstSuffixes.Add(obj);
                }

            }

            IndividualSuffixesdatagrid.DataSource = lstSuffixes;
            IndividualSuffixesdatagrid.Columns[0].Width = 50;
            IndividualSuffixesdatagrid.Columns[1].Width = 240;

            rtbWordsofSuffixes.Clear();
       }

        private void IndividualSuffixesdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
           
            string Suffix = string.Empty;

            int i = e.RowIndex;
            if (i != -1)
            {
                row = IndividualSuffixesdatagrid.Rows[i];
                Suffix = row.Cells[1].Value.ToString();
            }

            List<SuffixCategoryDetails> lstWordsofSuffixes = lstAllDetailsOfSuffCat.FindAll(o => o.Suffixes == Suffix);
            List<SuffixCategoryDetails> lstWordsofSuffixes1 = lstWordsofSuffixes.FindAll(o => o.SuffixCat == SuffixCategory);

            StringBuilder sb = new StringBuilder();
            foreach (SuffixCategoryDetails detail in lstWordsofSuffixes)
            {
                sb.AppendLine(detail.Word);
            }

            rtbWordsofSuffixes.Text = sb.ToString();

        }    

      
    }
    public class SuffixCatwithCount
    {
        public int எண் { get; set; }
        public string விகுதிவகைப்பாடு { get; set; }
    }

    public class SuffixwithCount
    {
        public int எண் { get; set; }
        public string விகுதி { get; set; }
    }

}
