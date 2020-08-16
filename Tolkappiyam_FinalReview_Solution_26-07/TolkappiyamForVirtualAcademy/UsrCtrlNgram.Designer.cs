namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlNgram
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGramsBefore = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbGramsAfter = new System.Windows.Forms.RadioButton();
            this.txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbOnegram = new System.Windows.Forms.RichTextBox();
            this.rtbBigram = new System.Windows.Forms.RichTextBox();
            this.rtbTrigram = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGramsBefore);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbGramsAfter);
            this.groupBox1.Controls.Add(this.txt);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 50);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // rbGramsBefore
            // 
            this.rbGramsBefore.AutoSize = true;
            this.rbGramsBefore.Checked = true;
            this.rbGramsBefore.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGramsBefore.ForeColor = System.Drawing.Color.Red;
            this.rbGramsBefore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbGramsBefore.Location = new System.Drawing.Point(353, 17);
            this.rbGramsBefore.Name = "rbGramsBefore";
            this.rbGramsBefore.Size = new System.Drawing.Size(171, 21);
            this.rbGramsBefore.TabIndex = 41;
            this.rbGramsBefore.TabStop = true;
            this.rbGramsBefore.Text = "முன்னுள்ள சொற்கள்";
            this.rbGramsBefore.UseVisualStyleBackColor = true;
            this.rbGramsBefore.CheckedChanged += new System.EventHandler(this.rtbGramsBefore_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "தேடுசொல்";
            // 
            // rbGramsAfter
            // 
            this.rbGramsAfter.AutoSize = true;
            this.rbGramsAfter.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGramsAfter.ForeColor = System.Drawing.Color.Red;
            this.rbGramsAfter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbGramsAfter.Location = new System.Drawing.Point(530, 17);
            this.rbGramsAfter.Name = "rbGramsAfter";
            this.rbGramsAfter.Size = new System.Drawing.Size(169, 21);
            this.rbGramsAfter.TabIndex = 42;
            this.rbGramsAfter.Text = "பின்னுள்ள சொற்கள்";
            this.rbGramsAfter.UseVisualStyleBackColor = true;
            this.rbGramsAfter.CheckedChanged += new System.EventHandler(this.rtbGramsAfter_CheckedChanged);
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt.Location = new System.Drawing.Point(98, 17);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(223, 22);
            this.txt.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(71, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(279, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(552, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "label4";
            // 
            // rtbOnegram
            // 
            this.rtbOnegram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOnegram.Location = new System.Drawing.Point(3, 81);
            this.rtbOnegram.Name = "rtbOnegram";
            this.rtbOnegram.Size = new System.Drawing.Size(175, 278);
            this.rtbOnegram.TabIndex = 51;
            this.rtbOnegram.Text = "";
            // 
            // rtbBigram
            // 
            this.rtbBigram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBigram.Location = new System.Drawing.Point(182, 81);
            this.rtbBigram.Name = "rtbBigram";
            this.rtbBigram.Size = new System.Drawing.Size(249, 278);
            this.rtbBigram.TabIndex = 52;
            this.rtbBigram.Text = "";
            // 
            // rtbTrigram
            // 
            this.rtbTrigram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTrigram.Location = new System.Drawing.Point(437, 81);
            this.rtbTrigram.Name = "rtbTrigram";
            this.rtbTrigram.Size = new System.Drawing.Size(264, 278);
            this.rtbTrigram.TabIndex = 53;
            this.rtbTrigram.Text = "";
            // 
            // UsrCtrlNgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbTrigram);
            this.Controls.Add(this.rtbBigram);
            this.Controls.Add(this.rtbOnegram);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsrCtrlNgram";
            this.Size = new System.Drawing.Size(704, 362);
            this.Load += new System.EventHandler(this.UsrCtrlNgram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGramsBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbGramsAfter;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbOnegram;
        private System.Windows.Forms.RichTextBox rtbBigram;
        private System.Windows.Forms.RichTextBox rtbTrigram;
    }
}
