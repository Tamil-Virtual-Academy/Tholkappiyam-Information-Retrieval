namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlTechTerms
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
            this.cmbTechnical = new System.Windows.Forms.ComboBox();
            this.lblChapter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExplain = new System.Windows.Forms.Label();
            this.lblNoorpa = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWord = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTechnical
            // 
            this.cmbTechnical.AllowDrop = true;
            this.cmbTechnical.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTechnical.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTechnical.Font = new System.Drawing.Font("Latha", 9.75F);
            this.cmbTechnical.FormattingEnabled = true;
            this.cmbTechnical.ItemHeight = 20;
            this.cmbTechnical.Location = new System.Drawing.Point(99, 7);
            this.cmbTechnical.MaxDropDownItems = 5;
            this.cmbTechnical.Name = "cmbTechnical";
            this.cmbTechnical.Size = new System.Drawing.Size(267, 28);
            this.cmbTechnical.TabIndex = 47;
            this.cmbTechnical.SelectedIndexChanged += new System.EventHandler(this.cmbTechnical_SelectedIndexChanged);
            // 
            // lblChapter
            // 
            this.lblChapter.AutoSize = true;
            this.lblChapter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapter.ForeColor = System.Drawing.Color.Red;
            this.lblChapter.Location = new System.Drawing.Point(3, 0);
            this.lblChapter.Name = "lblChapter";
            this.lblChapter.Size = new System.Drawing.Size(72, 22);
            this.lblChapter.TabIndex = 46;
            this.lblChapter.Text = "chapter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "தேடுசொல்";
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Font = new System.Drawing.Font("Latha", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplain.ForeColor = System.Drawing.Color.Blue;
            this.lblExplain.Location = new System.Drawing.Point(3, 44);
            this.lblExplain.MaximumSize = new System.Drawing.Size(700, 800);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(50, 20);
            this.lblExplain.TabIndex = 44;
            this.lblExplain.Text = "Explain";
            // 
            // lblNoorpa
            // 
            this.lblNoorpa.AutoSize = true;
            this.lblNoorpa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoorpa.ForeColor = System.Drawing.Color.Red;
            this.lblNoorpa.Location = new System.Drawing.Point(3, 22);
            this.lblNoorpa.MaximumSize = new System.Drawing.Size(550, 500);
            this.lblNoorpa.Name = "lblNoorpa";
            this.lblNoorpa.Size = new System.Drawing.Size(72, 22);
            this.lblNoorpa.TabIndex = 43;
            this.lblNoorpa.Text = "Noorpa";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Latha", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 400);
            this.listBox1.TabIndex = 42;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblChapter);
            this.flowLayoutPanel1.Controls.Add(this.lblNoorpa);
            this.flowLayoutPanel1.Controls.Add(this.lblExplain);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(372, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(719, 344);
            this.flowLayoutPanel1.TabIndex = 48;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblWord.Location = new System.Drawing.Point(375, 7);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(59, 22);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "label1";
            // 
            // UsrCtrlTechTerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cmbTechnical);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Name = "UsrCtrlTechTerms";
            this.Size = new System.Drawing.Size(1107, 474);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTechnical;
        private System.Windows.Forms.Label lblChapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Label lblNoorpa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblWord;
    }
}
