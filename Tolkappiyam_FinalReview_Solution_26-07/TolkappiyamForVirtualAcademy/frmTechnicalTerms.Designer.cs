namespace TolkappiyamForVirtualAcademy
{
    partial class frmTechnicalTerms
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblNoorpa = new System.Windows.Forms.Label();
            this.lblExplain = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblChapter = new System.Windows.Forms.Label();
            this.cmbTechnical = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(391, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "தொல்காப்பியக் கலைக்களஞ்சியம்";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(22, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 368);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblNoorpa
            // 
            this.lblNoorpa.AutoSize = true;
            this.lblNoorpa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoorpa.ForeColor = System.Drawing.Color.Red;
            this.lblNoorpa.Location = new System.Drawing.Point(391, 152);
            this.lblNoorpa.MaximumSize = new System.Drawing.Size(550, 500);
            this.lblNoorpa.Name = "lblNoorpa";
            this.lblNoorpa.Size = new System.Drawing.Size(0, 22);
            this.lblNoorpa.TabIndex = 3;
            //this.lblNoorpa.Click += new System.EventHandler(this.lblNoorpa_Click);
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Font = new System.Drawing.Font("Latha", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplain.ForeColor = System.Drawing.Color.Blue;
            this.lblExplain.Location = new System.Drawing.Point(391, 260);
            this.lblExplain.MaximumSize = new System.Drawing.Size(700, 800);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(0, 20);
            this.lblExplain.TabIndex = 4;
            //this.lblExplain.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "தேடுசொல்";
            // 
            // lblChapter
            // 
            this.lblChapter.AutoSize = true;
            this.lblChapter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapter.ForeColor = System.Drawing.Color.Red;
            this.lblChapter.Location = new System.Drawing.Point(391, 124);
            this.lblChapter.Name = "lblChapter";
            this.lblChapter.Size = new System.Drawing.Size(0, 22);
            this.lblChapter.TabIndex = 39;
            // 
            // cmbTechnical
            // 
            this.cmbTechnical.AllowDrop = true;
            this.cmbTechnical.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTechnical.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTechnical.Font = new System.Drawing.Font("Latha", 9.75F);
            this.cmbTechnical.FormattingEnabled = true;
            this.cmbTechnical.ItemHeight = 20;
            this.cmbTechnical.Location = new System.Drawing.Point(109, 77);
            this.cmbTechnical.MaxDropDownItems = 5;
            this.cmbTechnical.Name = "cmbTechnical";
            this.cmbTechnical.Size = new System.Drawing.Size(267, 28);
            this.cmbTechnical.TabIndex = 40;
            this.cmbTechnical.SelectedIndexChanged += new System.EventHandler(this.cmbTechnical_SelectedIndexChanged);
            // 
            // frmTechnicalTerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1139, 511);
            this.Controls.Add(this.cmbTechnical);
            this.Controls.Add(this.lblChapter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblExplain);
            this.Controls.Add(this.lblNoorpa);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmTechnicalTerms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTechnicalTerms";
            //this.Load += new System.EventHandler(this.frmTechnicalTerms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblNoorpa;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblChapter;
        private System.Windows.Forms.ComboBox cmbTechnical;
    }
}