namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlWordExtract
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbWord = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WordDatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbWord);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.WordDatagrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 387);
            this.panel1.TabIndex = 0;
            // 
            // cmbWord
            // 
            this.cmbWord.AllowDrop = true;
            this.cmbWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWord.Font = new System.Drawing.Font("Latha", 9.75F);
            this.cmbWord.FormattingEnabled = true;
            this.cmbWord.ItemHeight = 20;
            this.cmbWord.Location = new System.Drawing.Point(56, 5);
            this.cmbWord.MaxDropDownItems = 5;
            this.cmbWord.Name = "cmbWord";
            this.cmbWord.Size = new System.Drawing.Size(143, 28);
            this.cmbWord.TabIndex = 33;
            this.cmbWord.SelectedIndexChanged += new System.EventHandler(this.cmbWord_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "தொல்காப்பியச் சொற்கள்";
            // 
            // WordDatagrid
            // 
            this.WordDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.WordDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordDatagrid.Location = new System.Drawing.Point(3, 67);
            this.WordDatagrid.Name = "WordDatagrid";
            this.WordDatagrid.Size = new System.Drawing.Size(217, 320);
            this.WordDatagrid.TabIndex = 5;
            this.WordDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WordDatagrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "சொல்";
            // 
            // rtbDetails
            // 
            this.rtbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDetails.Location = new System.Drawing.Point(232, 0);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.ReadOnly = true;
            this.rtbDetails.Size = new System.Drawing.Size(866, 387);
            this.rtbDetails.TabIndex = 1;
            this.rtbDetails.Text = "";
            // 
            // UsrCtrlWordExtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbDetails);
            this.Controls.Add(this.panel1);
            this.Name = "UsrCtrlWordExtract";
            this.Size = new System.Drawing.Size(1101, 393);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView WordDatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbWord;
    }
}
