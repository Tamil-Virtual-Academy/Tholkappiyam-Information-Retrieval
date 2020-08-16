namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlTokenizer
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
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbParsed = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlStatsDetails = new System.Windows.Forms.Panel();
            this.rbngram = new System.Windows.Forms.RadioButton();
            this.rbFrequency = new System.Windows.Forms.RadioButton();
            this.rbConcord = new System.Windows.Forms.RadioButton();
            this.pnlStatistical = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlStatsDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordCount.ForeColor = System.Drawing.Color.Blue;
            this.lblWordCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWordCount.Location = new System.Drawing.Point(151, 487);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(16, 17);
            this.lblWordCount.TabIndex = 28;
            this.lblWordCount.Text = "0";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCount.Location = new System.Drawing.Point(6, 487);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(147, 17);
            this.lblCount.TabIndex = 27;
            this.lblCount.Text = "சொல் எண்ணிக்கை";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "உள்ளீடு";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Location = new System.Drawing.Point(224, 3);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(143, 23);
            this.rbNormal.TabIndex = 30;
            this.rbNormal.Text = "பதம்பிரிக்காதது";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbParsed
            // 
            this.rbParsed.AutoSize = true;
            this.rbParsed.Checked = true;
            this.rbParsed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbParsed.Location = new System.Drawing.Point(94, 3);
            this.rbParsed.Name = "rbParsed";
            this.rbParsed.Size = new System.Drawing.Size(124, 23);
            this.rbParsed.TabIndex = 31;
            this.rbParsed.TabStop = true;
            this.rbParsed.Text = "பதம்பிரித்தது";
            this.rbParsed.UseVisualStyleBackColor = true;
            this.rbParsed.CheckedChanged += new System.EventHandler(this.rbParsed_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "தேர்ந்தெடு";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 351);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pnlStatsDetails
            // 
            this.pnlStatsDetails.Controls.Add(this.rbngram);
            this.pnlStatsDetails.Controls.Add(this.rbFrequency);
            this.pnlStatsDetails.Controls.Add(this.rbConcord);
            this.pnlStatsDetails.Location = new System.Drawing.Point(392, 29);
            this.pnlStatsDetails.Name = "pnlStatsDetails";
            this.pnlStatsDetails.Size = new System.Drawing.Size(622, 46);
            this.pnlStatsDetails.TabIndex = 35;
            this.pnlStatsDetails.Visible = false;
            // 
            // rbngram
            // 
            this.rbngram.AutoSize = true;
            this.rbngram.Font = new System.Drawing.Font("Uni_MenTamizh_lss", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbngram.ForeColor = System.Drawing.Color.Blue;
            this.rbngram.Location = new System.Drawing.Point(439, 7);
            this.rbngram.Name = "rbngram";
            this.rbngram.Size = new System.Drawing.Size(176, 30);
            this.rbngram.TabIndex = 3;
            this.rbngram.TabStop = true;
            this.rbngram.Text = "N-gram-ஆய்வி";
            this.rbngram.UseVisualStyleBackColor = true;
            this.rbngram.CheckedChanged += new System.EventHandler(this.rbngram_CheckedChanged);
            // 
            // rbFrequency
            // 
            this.rbFrequency.AutoSize = true;
            this.rbFrequency.Font = new System.Drawing.Font("Uni_MenTamizh_lss", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFrequency.ForeColor = System.Drawing.Color.Blue;
            this.rbFrequency.Location = new System.Drawing.Point(12, 7);
            this.rbFrequency.Name = "rbFrequency";
            this.rbFrequency.Size = new System.Drawing.Size(193, 30);
            this.rbFrequency.TabIndex = 1;
            this.rbFrequency.Text = "வருகைப்புள்ளி";
            this.rbFrequency.UseVisualStyleBackColor = true;
            this.rbFrequency.CheckedChanged += new System.EventHandler(this.rbFrequency_CheckedChanged);
            // 
            // rbConcord
            // 
            this.rbConcord.AutoSize = true;
            this.rbConcord.Font = new System.Drawing.Font("Uni_MenTamizh_lss", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConcord.ForeColor = System.Drawing.Color.Blue;
            this.rbConcord.Location = new System.Drawing.Point(211, 7);
            this.rbConcord.Name = "rbConcord";
            this.rbConcord.Size = new System.Drawing.Size(225, 30);
            this.rbConcord.TabIndex = 2;
            this.rbConcord.TabStop = true;
            this.rbConcord.Text = "சொற்சூழலடைவி";
            this.rbConcord.UseVisualStyleBackColor = true;
            this.rbConcord.CheckedChanged += new System.EventHandler(this.rbConcord_CheckedChanged);
            // 
            // pnlStatistical
            // 
            this.pnlStatistical.Location = new System.Drawing.Point(392, 89);
            this.pnlStatistical.Name = "pnlStatistical";
            this.pnlStatistical.Size = new System.Drawing.Size(704, 362);
            this.pnlStatistical.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Latha", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Location = new System.Drawing.Point(72, 40);
            this.comboBox1.MaxDropDownItems = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate_1);
            this.comboBox1.DisplayMemberChanged += new System.EventHandler(this.comboBox1_DisplayMemberChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(5, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "எண்ணிக்கையுடன் சொல்";
            // 
            // UsrCtrlTokenizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlStatsDetails);
            this.Controls.Add(this.pnlStatistical);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbParsed);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Name = "UsrCtrlTokenizer";
            this.Size = new System.Drawing.Size(1099, 466);
            this.Load += new System.EventHandler(this.UsrCtrlTokenizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlStatsDetails.ResumeLayout(false);
            this.pnlStatsDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbParsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlStatsDetails;
        private System.Windows.Forms.RadioButton rbngram;
        private System.Windows.Forms.RadioButton rbFrequency;
        private System.Windows.Forms.RadioButton rbConcord;
        private System.Windows.Forms.Panel pnlStatistical;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}
