using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TolkappiyamForVirtualAcademy
{
    public partial class frmSubIndexing : Form
    {             
        private string _WordToBeSearched;
        public string WordToBeSearched
        {
            get
            {
                return _WordToBeSearched;
            }
            set
            {
                _WordToBeSearched = value;
            }
        }

        private ChooseIndexing _Option;
        public ChooseIndexing Option
        {
            get
            {
                return _Option;
            }
            set
            {
                _Option = value;
            }
        }

        private List<IndexedVerses> _lstIndexedVerses;
        public List<IndexedVerses> lstIndexedVerses
        {
            get
            {
                return _lstIndexedVerses;
            }
            set
            {
                _lstIndexedVerses = value;
            }
        }
        
        public frmSubIndexing(DisplayAllLines objlines)
        {
            InitializeComponent();
            lstIndexedVerses = objlines.verses;
            Option = objlines.type;
            WordToBeSearched = objlines.Word;
            ProcessLines();
        }

        private void ProcessLines()
        {
            List<IndexedVerses> lstFinalVerses = new List<IndexedVerses>();
            List<FinalVersesFormat> lstFinalVersesToDatagrid = new List<FinalVersesFormat>();
                      
            int count = 0;               

            if (Option == ChooseIndexing.UPstart)
            {
                lstFinalVerses = lstIndexedVerses.FindAll(o => o.unparsedstart == WordToBeSearched);
                    
                foreach (IndexedVerses verses in lstFinalVerses)
                {
                    FinalVersesFormat objFormat = new FinalVersesFormat();
                    count = count + 1;
                    objFormat.எண் = count;
                    objFormat.சொல் = verses.unparsedFirstSecond;
                    objFormat.நூற்பா = verses.VerseNo.ToString();
                    lstFinalVersesToDatagrid.Add(objFormat);
                }
            }
            else if (Option == ChooseIndexing.UPend)
            {
                lstFinalVerses = lstIndexedVerses.FindAll(o => o.unparsedend == WordToBeSearched);
                foreach (IndexedVerses verses in lstFinalVerses)
                {
                    FinalVersesFormat objFormat = new FinalVersesFormat();
                    count = count + 1;
                    objFormat.எண் = count;
                    objFormat.சொல் = verses.unparsedSecondLast;
                    objFormat.நூற்பா = verses.VerseNo.ToString();
                    lstFinalVersesToDatagrid.Add(objFormat);
                }
            }
            else if (Option == ChooseIndexing.Pstart)
            {
                lstFinalVerses = lstIndexedVerses.FindAll(o => o.parsedstart == WordToBeSearched);
                foreach (IndexedVerses verses in lstFinalVerses)
                {
                    FinalVersesFormat objFormat = new FinalVersesFormat();
                    count = count + 1;
                    objFormat.எண் = count;
                    objFormat.சொல் = verses.parsedFirstSecond;
                    objFormat.நூற்பா = verses.VerseNo.ToString();
                    lstFinalVersesToDatagrid.Add(objFormat);
                }

            }
            else
            {
                lstFinalVerses = lstIndexedVerses.FindAll(o => o.parsedend == WordToBeSearched);
                foreach (IndexedVerses verses in lstFinalVerses)
                {
                    FinalVersesFormat objFormat = new FinalVersesFormat();
                    count = count + 1;
                    objFormat.எண் = count;
                    objFormat.சொல் = verses.parsedSecondLast;
                    objFormat.நூற்பா = verses.VerseNo.ToString();
                    lstFinalVersesToDatagrid.Add(objFormat);
                }
            }


            dataGridView1.DataSource = lstFinalVersesToDatagrid;
            dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 200;
          

          

            dataGridView1.Dock = DockStyle.Fill;
        }
    }
    public class FinalVersesFormat
    {
        public int எண் { get; set; }
        public string சொல்{ get; set; }
        public string நூற்பா{ get; set; }
    }
}
