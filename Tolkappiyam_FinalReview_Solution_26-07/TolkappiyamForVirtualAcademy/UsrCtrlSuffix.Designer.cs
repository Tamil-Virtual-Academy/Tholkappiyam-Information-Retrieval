namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlSuffix
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuffixDatagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.IndividualSuffixesdatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbWordsofSuffixes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SuffixDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndividualSuffixesdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SuffixDatagrid
            // 
            this.SuffixDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuffixDatagrid.Location = new System.Drawing.Point(12, 29);
            this.SuffixDatagrid.Name = "SuffixDatagrid";
            this.SuffixDatagrid.Size = new System.Drawing.Size(338, 362);
            this.SuffixDatagrid.TabIndex = 1;
            this.SuffixDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuffixDatagrid_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "தொல்காப்பிய விகுதிவகைப்பாட்டு பட்டி";
            // 
            // IndividualSuffixesdatagrid
            // 
            this.IndividualSuffixesdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IndividualSuffixesdatagrid.Location = new System.Drawing.Point(356, 29);
            this.IndividualSuffixesdatagrid.Name = "IndividualSuffixesdatagrid";
            this.IndividualSuffixesdatagrid.Size = new System.Drawing.Size(240, 362);
            this.IndividualSuffixesdatagrid.TabIndex = 8;
            this.IndividualSuffixesdatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IndividualSuffixesdatagrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(352, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "விகுதிகள்";
            // 
            // rtbWordsofSuffixes
            // 
            this.rtbWordsofSuffixes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbWordsofSuffixes.Location = new System.Drawing.Point(639, 29);
            this.rtbWordsofSuffixes.Name = "rtbWordsofSuffixes";
            this.rtbWordsofSuffixes.ReadOnly = true;
            this.rtbWordsofSuffixes.Size = new System.Drawing.Size(312, 362);
            this.rtbWordsofSuffixes.TabIndex = 39;
            this.rtbWordsofSuffixes.Text = "";
            // 
            // UsrCtrlSuffix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbWordsofSuffixes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IndividualSuffixesdatagrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SuffixDatagrid);
            this.Name = "UsrCtrlSuffix";
            this.Size = new System.Drawing.Size(961, 394);
            ((System.ComponentModel.ISupportInitialize)(this.SuffixDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndividualSuffixesdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SuffixDatagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView IndividualSuffixesdatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbWordsofSuffixes;
    }
}
