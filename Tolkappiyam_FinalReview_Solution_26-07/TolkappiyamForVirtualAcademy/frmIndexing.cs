using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TolkappiyamForVirtualAcademy
{
    public partial class frmIndexing : Form
    {
        List<IndexedVerses> lstverses = new List<IndexedVerses>();

        public frmIndexing()
        {
            InitializeComponent();
            ProcessStartEndWords();
            rtbunparsedStart.Checked = true;
            rtbParsedStart.Checked = true;
          
        }

        private void ProcessStartEndWords()
        {
            clsParsingExtraction obj = new clsParsingExtraction();
           
            lstverses = obj.ReturnstartendWords();


            List<VerseparsedStart> lstparsedStart = new List<VerseparsedStart>();
            List<VerseparsedEnd> lstparsedEnd = new List<VerseparsedEnd>();
            List<VerseunparsedStart> lstunparsedStart = new List<VerseunparsedStart>();
            List<VerseunparsedEnd> lstunparsedEnd = new List<VerseunparsedEnd>();

            List<string> PS = new List<string>();
            List<string> PE = new List<string>();
            List<string> UPS = new List<string>();
            List<string> UPE = new List<string>();

            int PSC = 0;
            int PEC = 0;
            int UPSC = 0;
            int UPES = 0;


            foreach (IndexedVerses Verse in lstverses)
            {
                VerseparsedStart objparsedStart = new VerseparsedStart();
                VerseparsedEnd objparsedEnd = new VerseparsedEnd();
                VerseunparsedStart objunparsedStart = new VerseunparsedStart();
                VerseunparsedEnd objunparsedEnd = new VerseunparsedEnd();

              

                if (Verse.parsedstart == "மெல்லெழுத்")
                {
                }

                if (!PS.Contains(Verse.parsedstart))
                {
                    PSC = PSC + 1;
                    PS.Add(Verse.parsedstart);
                    List<IndexedVerses> lstMultipleStarts = lstverses.FindAll(o => o.parsedstart == Verse.parsedstart);
                    objparsedStart.தொடக்கச்சொல் = Verse.parsedstart;
                    //objparsedStart.No = PSC;
                    //objparsedStart.Division = Verse.Division;

                    if (lstMultipleStarts.Count == 1)
                    {
                        objparsedStart.நூற்பா = Verse.VerseNo.ToString();
                    }
                    else 
                    {
                        foreach (IndexedVerses objverse in lstMultipleStarts)
                        {
                            if (string.IsNullOrEmpty(objparsedStart.நூற்பா))
                            {
                                objparsedStart.நூற்பா = objverse.VerseNo.ToString();
                            }
                            else
                            {
                                objparsedStart.நூற்பா += "," + objverse.VerseNo.ToString();
                            }
                        }
                    }

                    lstparsedStart.Add(objparsedStart);

                }

                if (!PE.Contains(Verse.parsedend))
                {
                    PEC = PEC + 1;
                    PE.Add(Verse.parsedend);
                    List<IndexedVerses> lstMultipleEnds = lstverses.FindAll(o => o.parsedend == Verse.parsedend);
                    objparsedEnd.இறுதிச்சொல் = Verse.parsedend;
                    //objparsedEnd.No = PEC;
                    //objparsedEnd.Division = Verse.Division;

                    if (lstMultipleEnds.Count == 1)
                    {
                        objparsedEnd.நூற்பா = Verse.VerseNo.ToString();
                    }
                  
                    else
                    {
                        foreach (IndexedVerses objverse in lstMultipleEnds)
                        {
                            if (string.IsNullOrEmpty(objparsedEnd.நூற்பா))
                            {
                                objparsedEnd.நூற்பா = objverse.VerseNo.ToString();
                            }
                            else
                            {
                                objparsedEnd.நூற்பா += "," + objverse.VerseNo.ToString();
                            }
                        }
                    }
                    lstparsedEnd.Add(objparsedEnd);
                }

                if (Verse.unparsedstart == "மெல்லெழுத்")
                {
                }
                if (!UPS.Contains(Verse.unparsedstart))
                {
                    UPSC = UPSC + 1;
                    UPS.Add(Verse.unparsedstart);
                    List<IndexedVerses> lstMultipleStarts = lstverses.FindAll(o => o.unparsedstart == Verse.unparsedstart);
                    objunparsedStart.தொடக்கச்சொல் = Verse.unparsedstart;
                    //objunparsedStart.Division = Verse.Division;
                    //objunparsedStart.No = UPSC;

                    if (lstMultipleStarts.Count == 1)
                    {
                        objunparsedStart.நூற்பா = Verse.VerseNo.ToString();
                    }
                    else
                    {
                        foreach (IndexedVerses objverse in lstMultipleStarts)
                        {
                            if (string.IsNullOrEmpty(objunparsedStart.நூற்பா))
                            {
                                objunparsedStart.நூற்பா = objverse.VerseNo.ToString();
                            }
                            else
                            {
                                objunparsedStart.நூற்பா += "," + objverse.VerseNo.ToString();
                            }
                        }
                    }
                    lstunparsedStart.Add(objunparsedStart);
                }


                if (!UPE.Contains(Verse.unparsedend))
                {
                    UPES = UPES + 1;
                    UPE.Add(Verse.unparsedend);
                    List<IndexedVerses> lstMultipleEnds = lstverses.FindAll(o => o.unparsedend == Verse.unparsedend);
                    objunparsedEnd.இறுதிச்சொல் = Verse.unparsedend;
                    //objunparsedEnd.No = UPES;
                    //objunparsedEnd.Division = Verse.Division;

                    if (lstMultipleEnds.Count == 1)
                    {
                        objunparsedEnd.நூற்பா = Verse.VerseNo.ToString();
                    }
                    else
                    {
                        foreach (IndexedVerses objverse in lstMultipleEnds)
                        {
                            if (string.IsNullOrEmpty(objunparsedEnd.நூற்பா))
                            {
                                objunparsedEnd.நூற்பா = objverse.VerseNo.ToString();
                            }
                            else
                            {
                                objunparsedEnd.நூற்பா += "," + objverse.VerseNo.ToString();
                            }
                        }
                    }
                    lstunparsedEnd.Add(objunparsedEnd);
                }
            }

            lblUPSC.Text = "சொல் எண்ணிக்கை : " + UPSC.ToString();
            lblUPEC.Text = "சொல் எண்ணிக்கை : " + UPES.ToString();
            lblPSC.Text = "சொல் எண்ணிக்கை : " + PSC.ToString();
            lblPEC.Text = "சொல் எண்ணிக்கை : " + PEC.ToString();

            var unparsedStart = lstunparsedStart;
            unparsedStart = unparsedStart.OrderBy(p => p.தொடக்கச்சொல்).ToList();

            var unparsedEnd = lstunparsedEnd;
            unparsedEnd = unparsedEnd.OrderBy(p => p.இறுதிச்சொல்).ToList();

            var parsedStart = lstparsedStart;
            parsedStart = parsedStart.OrderBy(p => p.தொடக்கச்சொல்).ToList();

            var parsedEnd = lstparsedEnd;
            parsedEnd = parsedEnd.OrderBy(p => p.இறுதிச்சொல்).ToList();


            UnparsedStartDatagrid.DataSource = unparsedStart;
            UnparsedEndDatagrid.DataSource = unparsedEnd;
            ParsedStartDatagrid.DataSource = parsedStart;
            ParsedEndDatagrid.DataSource = parsedEnd;


            UnparsedStartDatagrid.Columns[0].Width = 150;
            UnparsedEndDatagrid.Columns[0].Width = 150;
            ParsedStartDatagrid.Columns[0].Width = 150;
            ParsedEndDatagrid.Columns[0].Width = 150;

        }

      

        private void UnparsedStartDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
                        
            string UPstartword = string.Empty;
            string Lines = string.Empty;

            int i = e.RowIndex;
            if (i != -1)
            {
                row = UnparsedStartDatagrid.Rows[i];
                UPstartword = row.Cells[0].Value.ToString();
                Lines = row.Cells[1].Value.ToString();

                if (Lines.Contains(','))
                {
                    DispalyAllLines(UPstartword,ChooseIndexing.UPstart);
                }

            }
        }       

        private void UnparsedEndDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            string UPendword = string.Empty;
            string Lines = string.Empty;

            int i = e.RowIndex;
            if (i != -1)
            {
                row = UnparsedEndDatagrid.Rows[i];
                UPendword = row.Cells[0].Value.ToString();
                Lines = row.Cells[1].Value.ToString();

                if (Lines.Contains(','))
                {
                    DispalyAllLines(UPendword,ChooseIndexing.UPend);
                }

            }
        }

        private void ParsedStartDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            string Pstartword = string.Empty;
            string Lines = string.Empty;

            int i = e.RowIndex;
            if (i != -1)
            {
                row = ParsedStartDatagrid.Rows[i];
                Pstartword = row.Cells[0].Value.ToString();
                Lines = row.Cells[1].Value.ToString();

                if (Lines.Contains(','))
                {
                    DispalyAllLines(Pstartword,ChooseIndexing.Pstart);
                }

            }
        }

        private void ParsedEndDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            string Pendword = string.Empty;
            string Lines = string.Empty;

            int i = e.RowIndex;
            if (i != -1)
            {
                row = ParsedEndDatagrid.Rows[i];
                Pendword = row.Cells[0].Value.ToString();
                Lines = row.Cells[1].Value.ToString();

                if (Lines.Contains(','))
                {
                    DispalyAllLines(Pendword,ChooseIndexing.Pend);
                }

            }
        }

        private void DispalyAllLines(string WordTobeSearched,ChooseIndexing type)
        {
            DisplayAllLines obj = new DisplayAllLines();
            obj.verses = lstverses;
            obj.type = type;
            obj.Word = WordTobeSearched;

            frmSubIndexing objForm = new frmSubIndexing(obj);
            objForm.ShowDialog();
        }

       
      

        private void rtbunparsedStart_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbunparsedStart.Checked)
            {
                cmbOriginal.Text = string.Empty;
                cmbOriginal.Items.Clear();
                foreach (DataGridViewRow row in UnparsedStartDatagrid.Rows)
                {
                    cmbOriginal.Items.Add(row.Cells[0].Value.ToString());
                }
            }
        }

        private void rtbUnparsedend_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbUnparsedend.Checked)
            {
                cmbOriginal.Text = string.Empty;
                cmbOriginal.Items.Clear();
                foreach (DataGridViewRow row in UnparsedEndDatagrid.Rows)
                {
                    cmbOriginal.Items.Add(row.Cells[0].Value.ToString());
                }
            }
        }

        private void rtbParsedStart_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbParsedStart.Checked)
            {
                cmbParsed.Text = string.Empty;
                cmbParsed.Items.Clear();
                foreach (DataGridViewRow row in ParsedStartDatagrid.Rows)
                {
                    cmbParsed.Items.Add(row.Cells[0].Value.ToString());
                }
            }
        }

        private void rtbParsedEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbParsedEnd.Checked)
            {
                cmbParsed.Text = string.Empty;
                cmbParsed.Items.Clear();
                foreach (DataGridViewRow row in ParsedEndDatagrid.Rows)
                {
                    cmbParsed.Items.Add(row.Cells[0].Value.ToString());
                }
                
            }
        }

        private void cmbOriginal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOriginal.Text = cmbOriginal.SelectedItem.ToString();
            string wordTobeSearched = cmbOriginal.SelectedItem.ToString();
            string cellValue = string.Empty;
            List<string> lstrowindex = new List<string>();
            if (!string.IsNullOrEmpty(wordTobeSearched))
            {
                if (rtbunparsedStart.Checked)
                {
                    foreach (DataGridViewRow row1 in UnparsedStartDatagrid.Rows)
                    {
                        try
                        {
                            cellValue = row1.Cells[0].Value.ToString();
                        }
                        catch (Exception ex)
                        { }
                        if (cellValue != null && (cellValue == wordTobeSearched || cellValue.StartsWith(wordTobeSearched)))
                        {
                            if (cellValue == wordTobeSearched)
                            {
                                lstrowindex.Add(row1.Index.ToString());
                                //break;
                            }
                        }
                    }
                    if (lstrowindex.Count > 0)
                    {
                        UnparsedStartDatagrid.Rows[0].Selected = false;

                        UnparsedStartDatagrid.Rows[Int32.Parse(lstrowindex[0])].Selected = true;

                        UnparsedStartDatagrid.CurrentCell = UnparsedStartDatagrid[0, Int32.Parse(lstrowindex[0])];
                    }
                    else
                    {
                        MessageBox.Show("சொல் காணப்படவில்லை");
                    }
                }
                else if (rtbUnparsedend.Checked)
                {
                    foreach (DataGridViewRow row1 in UnparsedEndDatagrid.Rows)
                    {
                        try
                        {
                            cellValue = row1.Cells[0].Value.ToString();
                        }
                        catch (Exception ex)
                        { }
                        if (cellValue != null && (cellValue == wordTobeSearched || cellValue.StartsWith(wordTobeSearched)))
                        {
                            if (cellValue == wordTobeSearched)
                            {
                                lstrowindex.Add(row1.Index.ToString());
                                break;
                            }
                        }
                    }
                    if (lstrowindex.Count > 0)
                    {
                        UnparsedEndDatagrid.Rows[0].Selected = false;
                        UnparsedEndDatagrid.Rows[Int32.Parse(lstrowindex[0])].Selected = true;
                        UnparsedEndDatagrid.CurrentCell = UnparsedEndDatagrid[0, Int32.Parse(lstrowindex[0])];
                    }
                    else
                    {
                        MessageBox.Show("சொல் காணப்படவில்லை");
                    }
                }


            }
            else
            {
                MessageBox.Show("சொல் காணப்படவில்லை");
            }
        }

        private void cmbParsed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbParsed.Text = cmbParsed.SelectedItem.ToString();
            string wordTobeSearched = cmbParsed.SelectedItem.ToString();
            string cellValue = string.Empty;
            List<string> lstrowindex = new List<string>();
            if (!string.IsNullOrEmpty(wordTobeSearched))
            {
                if (rtbParsedStart.Checked)
                {
                    foreach (DataGridViewRow row1 in ParsedStartDatagrid.Rows)
                    {
                        try
                        {
                            cellValue = row1.Cells[0].Value.ToString();
                        }
                        catch (Exception ex)
                        { }
                        if (cellValue != null && (cellValue == wordTobeSearched || cellValue.StartsWith(wordTobeSearched)))
                        {
                            if (cellValue == wordTobeSearched)
                            {
                                lstrowindex.Add(row1.Index.ToString());
                                break;
                            }
                        }
                    }
                    if (lstrowindex.Count > 0)
                    {
                        ParsedStartDatagrid.Rows[0].Selected = false;
                        ParsedStartDatagrid.Rows[Int32.Parse(lstrowindex[0])].Selected = true;
                        ParsedStartDatagrid.CurrentCell = ParsedStartDatagrid[0, Int32.Parse(lstrowindex[0])];
                    }
                    else
                    {
                        MessageBox.Show("சொல் காணப்படவில்லை");
                    }
                }
                else if (rtbParsedEnd.Checked)
                {
                    foreach (DataGridViewRow row1 in ParsedEndDatagrid.Rows)
                    {
                        try
                        {
                            cellValue = row1.Cells[0].Value.ToString();
                        }
                        catch (Exception ex)
                        { }
                        if (cellValue != null && (cellValue == wordTobeSearched || cellValue.StartsWith(wordTobeSearched)))
                        {
                            if (cellValue == wordTobeSearched)
                            {
                                lstrowindex.Add(row1.Index.ToString());
                                break;
                            }
                        }
                    }
                    if (lstrowindex.Count > 0)
                    {
                        ParsedEndDatagrid.Rows[0].Selected = false;
                        ParsedEndDatagrid.Rows[Int32.Parse(lstrowindex[0])].Selected = true;
                        ParsedEndDatagrid.CurrentCell = ParsedEndDatagrid[0, Int32.Parse(lstrowindex[0])];
                    }
                    else
                    {
                        MessageBox.Show("சொல் காணப்படவில்லை");
                    }
                }


            }
            else
            {
                MessageBox.Show("சொல் காணப்படவில்லை");
            }
        }
       
      

    }
}
