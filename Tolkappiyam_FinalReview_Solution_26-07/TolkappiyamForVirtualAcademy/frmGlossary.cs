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
    public partial class frmGlossary : Form
    {
        public frmGlossary()
        {
            InitializeComponent();
        }

        private void frmGlossary_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;

        }

        private void LoadListbox()
        {
            clsGlossary obj = new clsGlossary();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            arrangeTreeview();
        }

        private void arrangeTreeview()
        {
            clsGlossary obj = new clsGlossary();

            treeView1.Nodes.Clear();

            Font font = new Font("Latha", 12, FontStyle.Bold);
            treeView1.ForeColor = Color.Blue;
            treeView1.Font = font;

            List<clsGlossaryDetails> lstEluthu = new List<clsGlossaryDetails>();
            List<clsGlossaryDetails> lstSol = new List<clsGlossaryDetails>();
            List<clsGlossaryDetails> lstPorul = new List<clsGlossaryDetails>();

            if (checkBox1.Checked == true)
            {
                List<string> lstEluthuChapter = new List<string>();
                lstEluthu = obj.RetrieveTechnicalTerms("எழுத்ததிகாரம்");
                if (lstEluthu != null)
                {
                    TreeNode Eparent = new TreeNode();
                    Eparent.Text = "எழுத்ததிகாரம்";
                    //Eparent.ForeColor = Color.Blue;                  
                    treeView1.Nodes.Add(Eparent);

                    foreach (clsGlossaryDetails detail in lstEluthu)
                    {
                        string strChap = detail.Chapter.Trim();
                        if (!lstEluthuChapter.Contains(strChap))
                        {
                            lstEluthuChapter.Add(strChap);
                            TreeNode Echild = new TreeNode();
                            Echild.Text = strChap;
                            Echild.ForeColor = Color.Blue;
                            Echild.NodeFont = new Font("Latha", 10, FontStyle.Regular);
                            Eparent.Nodes.Add(Echild);

                            List<clsGlossaryDetails> lstwithChapters = lstEluthu.FindAll(o => o.Chapter == strChap);

                            foreach (clsGlossaryDetails key in lstwithChapters)
                            {
                                TreeNode Esubchild = new TreeNode();
                                Esubchild.Text = key.Keyword.Trim();
                                Esubchild.ForeColor = Color.Blue;
                                Esubchild.NodeFont = new Font("Latha", 8, FontStyle.Regular);
                                Echild.Nodes.Add(Esubchild);
                            }

                        }
                    }
                }
            }
            if (checkBox2.Checked == true)
            {

                List<string> lstSolChapter = new List<string>();
                lstSol = obj.RetrieveTechnicalTerms("சொல்லதிகாரம்");
                if (lstSol != null)
                {
                    TreeNode Sparent = new TreeNode();
                    Sparent.Text = "சொல்லதிகாரம்";

                    treeView1.Nodes.Add(Sparent);

                    foreach (clsGlossaryDetails detail in lstSol)
                    {
                        string strChap = detail.Chapter.Trim();
                        if (!lstSolChapter.Contains(strChap))
                        {
                            lstSolChapter.Add(strChap);
                            TreeNode Schild = new TreeNode();
                            Schild.Text = strChap;
                            Schild.ForeColor = Color.Blue;
                            Schild.NodeFont = new Font("Latha", 10, FontStyle.Regular);
                            Sparent.Nodes.Add(Schild);

                            List<clsGlossaryDetails> lstwithChapters = lstSol.FindAll(o => o.Chapter == strChap);

                            foreach (clsGlossaryDetails key in lstwithChapters)
                            {
                                TreeNode Ssubchild = new TreeNode();
                                Ssubchild.Text = key.Keyword.Trim();
                                Ssubchild.ForeColor = Color.Blue;
                                Ssubchild.NodeFont = new Font("Latha", 8, FontStyle.Regular);
                                Schild.Nodes.Add(Ssubchild);
                            }

                        }
                    }
                }
            }
            if (checkBox3.Checked == true)
            {
                List<string> lstPorulChapter = new List<string>();
                lstPorul = obj.RetrieveTechnicalTerms("பொருளதிகாரம்");
                if (lstPorul != null)
                {
                    TreeNode Pparent = new TreeNode();
                    Pparent.Text = "பொருளதிகாரம்";

                    treeView1.Nodes.Add(Pparent);

                    foreach (clsGlossaryDetails detail in lstPorul)
                    {
                        string strChap = detail.Chapter.Trim();
                        if (!lstPorulChapter.Contains(strChap))
                        {
                            lstPorulChapter.Add(strChap);
                            TreeNode Pchild = new TreeNode();
                            Pchild.Text = strChap;
                            Pchild.ForeColor = Color.Blue;
                            Pchild.NodeFont = new Font("Latha", 10, FontStyle.Regular);
                            Pparent.Nodes.Add(Pchild);

                            List<clsGlossaryDetails> lstwithChapters = lstPorul.FindAll(o => o.Chapter == strChap);

                            foreach (clsGlossaryDetails key in lstwithChapters)
                            {
                                TreeNode Psubchild = new TreeNode();
                                Psubchild.Text = key.Keyword.Trim();
                                Psubchild.ForeColor = Color.Blue;
                                Psubchild.NodeFont = new Font("Latha", 8, FontStyle.Regular);
                                Pchild.Nodes.Add(Psubchild);
                            }

                        }
                    }
                }
                
            }
            if (treeView1.Nodes.Count > 0)
            {
                treeView1.Nodes[0].Expand();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            arrangeTreeview();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            arrangeTreeview();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            clsGlossary obj = new clsGlossary();
            clsGlossaryDetails objdetail = new clsGlossaryDetails();

            if ((!(e.Node.Text == "எழுத்ததிகாரம்" || e.Node.Text == "சொல்லதிகாரம்" || e.Node.Text == "பொருளதிகாரம்")) && (!(e.Node.Parent.Text == "எழுத்ததிகாரம்" || e.Node.Parent.Text == "சொல்லதிகாரம்" || e.Node.Parent.Text == "பொருளதிகாரம்")))
            {
                string Keyword = e.Node.Text;
                string Chapter = e.Node.Parent.Text;
                //MessageBox.Show(Keyword + "," + Chapter);
                objdetail = obj.Retrievewithkeyword(Chapter, Keyword);
                if (objdetail != null)
                {
                    //rtbExplain.Clear();
                    lblDisplay.Text = string.Empty;
                    lblExplain.Text = string.Empty;


                    lblDisplay.Text = objdetail.Division + "-->" + objdetail.Chapter + "-->" + objdetail.Keyword;
                    //rtbExplain.Text = objdetail.Explanation;
                    lblExplain.Text = objdetail.Explanation;
                }


                

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

       
    }
}
