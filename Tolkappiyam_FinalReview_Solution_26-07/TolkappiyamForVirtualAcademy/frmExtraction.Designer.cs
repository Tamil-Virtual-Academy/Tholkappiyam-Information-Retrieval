namespace TolkappiyamForVirtualAcademy
{
    partial class frmExtraction
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.cmbChapter = new System.Windows.Forms.ComboBox();
            this.cmbVerse = new System.Windows.Forms.ComboBox();
            this.cmbLine = new System.Windows.Forms.ComboBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbParsed = new System.Windows.Forms.RadioButton();
            this.rbOriginal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(409, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(367, 26);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "தொல்காப்பியத் தகவல் பெறுபட்டி";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblDivision.ForeColor = System.Drawing.Color.Blue;
            this.lblDivision.Location = new System.Drawing.Point(664, 112);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(79, 19);
            this.lblDivision.TabIndex = 1;
            this.lblDivision.Text = "அதிகாரம்";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(892, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "இயல்";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(892, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "வரி எண்";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(668, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "நூற்பா எண்";
            // 
            // cmbDivision
            // 
            this.cmbDivision.Font = new System.Drawing.Font("Latha", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(765, 104);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(121, 28);
            this.cmbDivision.TabIndex = 5;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // cmbChapter
            // 
            this.cmbChapter.Enabled = false;
            this.cmbChapter.Font = new System.Drawing.Font("Latha", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChapter.FormattingEnabled = true;
            this.cmbChapter.Location = new System.Drawing.Point(965, 104);
            this.cmbChapter.Name = "cmbChapter";
            this.cmbChapter.Size = new System.Drawing.Size(149, 28);
            this.cmbChapter.TabIndex = 6;
            this.cmbChapter.SelectedIndexChanged += new System.EventHandler(this.cmbChapter_SelectedIndexChanged);
            // 
            // cmbVerse
            // 
            this.cmbVerse.Enabled = false;
            this.cmbVerse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVerse.FormattingEnabled = true;
            this.cmbVerse.Location = new System.Drawing.Point(765, 143);
            this.cmbVerse.Name = "cmbVerse";
            this.cmbVerse.Size = new System.Drawing.Size(121, 27);
            this.cmbVerse.TabIndex = 7;
            this.cmbVerse.SelectedIndexChanged += new System.EventHandler(this.cmbVerse_SelectedIndexChanged);
            // 
            // cmbLine
            // 
            this.cmbLine.Enabled = false;
            this.cmbLine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLine.FormattingEnabled = true;
            this.cmbLine.Location = new System.Drawing.Point(965, 143);
            this.cmbLine.Name = "cmbLine";
            this.cmbLine.Size = new System.Drawing.Size(97, 27);
            this.cmbLine.TabIndex = 8;
            this.cmbLine.SelectedIndexChanged += new System.EventHandler(this.cmbLine_SelectedIndexChanged);
            // 
            // rtbText
            // 
            this.rtbText.Font = new System.Drawing.Font("Uni_MenTamizh_lss", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.Location = new System.Drawing.Point(28, 196);
            this.rtbText.Name = "rtbText";
            this.rtbText.ReadOnly = true;
            this.rtbText.Size = new System.Drawing.Size(1086, 418);
            this.rtbText.TabIndex = 12;
            this.rtbText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(31, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "சொல்";
            // 
            // rbParsed
            // 
            this.rbParsed.AutoSize = true;
            this.rbParsed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbParsed.ForeColor = System.Drawing.Color.Blue;
            this.rbParsed.Location = new System.Drawing.Point(186, 109);
            this.rbParsed.Name = "rbParsed";
            this.rbParsed.Size = new System.Drawing.Size(124, 23);
            this.rbParsed.TabIndex = 16;
            this.rbParsed.Text = "பதம்பிரித்தது";
            this.rbParsed.UseVisualStyleBackColor = true;
            this.rbParsed.CheckedChanged += new System.EventHandler(this.rbParsed_CheckedChanged);
            // 
            // rbOriginal
            // 
            this.rbOriginal.AutoSize = true;
            this.rbOriginal.Checked = true;
            this.rbOriginal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbOriginal.ForeColor = System.Drawing.Color.Blue;
            this.rbOriginal.Location = new System.Drawing.Point(37, 109);
            this.rbOriginal.Name = "rbOriginal";
            this.rbOriginal.Size = new System.Drawing.Size(143, 23);
            this.rbOriginal.TabIndex = 17;
            this.rbOriginal.TabStop = true;
            this.rbOriginal.Text = "பதம்பிரிக்காதது";
            this.rbOriginal.UseVisualStyleBackColor = true;
            this.rbOriginal.CheckedChanged += new System.EventHandler(this.rbOriginal_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(24, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "வரி எண்ணிக்கை";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCount.Location = new System.Drawing.Point(174, 629);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(17, 19);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(500, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "(அல்லது)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(30, 50);
            this.label7.MaximumSize = new System.Drawing.Size(500, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(453, 38);
            this.label7.TabIndex = 22;
            this.label7.Text = "தொல்காப்பியத்தில் பயின்றுள்ள  ஒரு சொல்லின் அடிப்படையில் அடிகளைத் தேடல்";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(668, 50);
            this.label8.MaximumSize = new System.Drawing.Size(500, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(430, 38);
            this.label8.TabIndex = 23;
            this.label8.Text = "தொல்காப்பியத்தின் அதிகாரம், இயல், நூற்பா எண், அடி எண் ஆகியவற்றின் அடிப்படையில் தே" +
                "டல்";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Latha", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Location = new System.Drawing.Point(101, 146);
            this.comboBox1.MaxDropDownItems = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 28);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // frmExtraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1128, 680);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbOriginal);
            this.Controls.Add(this.rbParsed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.cmbLine);
            this.Controls.Add(this.cmbVerse);
            this.Controls.Add(this.cmbChapter);
            this.Controls.Add(this.cmbDivision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmExtraction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRetrieval";
            this.Load += new System.EventHandler(this.frmExtraction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.ComboBox cmbChapter;
        private System.Windows.Forms.ComboBox cmbVerse;
        private System.Windows.Forms.ComboBox cmbLine;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbParsed;
        private System.Windows.Forms.RadioButton rbOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}