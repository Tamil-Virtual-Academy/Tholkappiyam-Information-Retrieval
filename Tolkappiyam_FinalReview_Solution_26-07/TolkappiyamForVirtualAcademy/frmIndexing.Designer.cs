namespace TolkappiyamForVirtualAcademy
{
    partial class frmIndexing
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
            this.UnparsedStartDatagrid = new System.Windows.Forms.DataGridView();
            this.ParsedStartDatagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbParsedStart = new System.Windows.Forms.RadioButton();
            this.rtbParsedEnd = new System.Windows.Forms.RadioButton();
            this.rtbUnparsedend = new System.Windows.Forms.RadioButton();
            this.rtbunparsedStart = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbOriginal = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbParsed = new System.Windows.Forms.ComboBox();
            this.UnparsedEndDatagrid = new System.Windows.Forms.DataGridView();
            this.ParsedEndDatagrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUPSC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUPEC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPSC = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPEC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UnparsedStartDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParsedStartDatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnparsedEndDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParsedEndDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Uni_MenTamizh_lss", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(373, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "தொடக்கச்சொல் இறுதிச்சொல் நூற்பா பட்டி";
            // 
            // UnparsedStartDatagrid
            // 
            this.UnparsedStartDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnparsedStartDatagrid.Location = new System.Drawing.Point(8, 186);
            this.UnparsedStartDatagrid.Name = "UnparsedStartDatagrid";
            this.UnparsedStartDatagrid.Size = new System.Drawing.Size(316, 406);
            this.UnparsedStartDatagrid.TabIndex = 1;
            this.UnparsedStartDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnparsedStartDatagrid_CellClick);
            // 
            // ParsedStartDatagrid
            // 
            this.ParsedStartDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParsedStartDatagrid.Location = new System.Drawing.Point(684, 186);
            this.ParsedStartDatagrid.Name = "ParsedStartDatagrid";
            this.ParsedStartDatagrid.Size = new System.Drawing.Size(316, 406);
            this.ParsedStartDatagrid.TabIndex = 2;
            this.ParsedStartDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParsedStartDatagrid_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "உள்ளீடு";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "உள்ளீடு";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(883, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "பதம்பிரித்த வடிவம்";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(239, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "பதம்பிரிக்காத வடிவம்";
            // 
            // rtbParsedStart
            // 
            this.rtbParsedStart.AutoSize = true;
            this.rtbParsedStart.Location = new System.Drawing.Point(402, 7);
            this.rtbParsedStart.Name = "rtbParsedStart";
            this.rtbParsedStart.Size = new System.Drawing.Size(101, 21);
            this.rtbParsedStart.TabIndex = 15;
            this.rtbParsedStart.Text = "தொடக்கம்";
            this.rtbParsedStart.UseVisualStyleBackColor = true;
            this.rtbParsedStart.CheckedChanged += new System.EventHandler(this.rtbParsedStart_CheckedChanged);
            // 
            // rtbParsedEnd
            // 
            this.rtbParsedEnd.AutoSize = true;
            this.rtbParsedEnd.Location = new System.Drawing.Point(527, 7);
            this.rtbParsedEnd.Name = "rtbParsedEnd";
            this.rtbParsedEnd.Size = new System.Drawing.Size(67, 21);
            this.rtbParsedEnd.TabIndex = 16;
            this.rtbParsedEnd.Text = "முடிவு";
            this.rtbParsedEnd.UseVisualStyleBackColor = true;
            this.rtbParsedEnd.CheckedChanged += new System.EventHandler(this.rtbParsedEnd_CheckedChanged);
            // 
            // rtbUnparsedend
            // 
            this.rtbUnparsedend.AutoSize = true;
            this.rtbUnparsedend.Location = new System.Drawing.Point(516, 7);
            this.rtbUnparsedend.Name = "rtbUnparsedend";
            this.rtbUnparsedend.Size = new System.Drawing.Size(67, 21);
            this.rtbUnparsedend.TabIndex = 18;
            this.rtbUnparsedend.Text = "முடிவு";
            this.rtbUnparsedend.UseVisualStyleBackColor = true;
            this.rtbUnparsedend.CheckedChanged += new System.EventHandler(this.rtbUnparsedend_CheckedChanged);
            // 
            // rtbunparsedStart
            // 
            this.rtbunparsedStart.AutoSize = true;
            this.rtbunparsedStart.Location = new System.Drawing.Point(395, 7);
            this.rtbunparsedStart.Name = "rtbunparsedStart";
            this.rtbunparsedStart.Size = new System.Drawing.Size(101, 21);
            this.rtbunparsedStart.TabIndex = 17;
            this.rtbunparsedStart.Text = "தொடக்கம்";
            this.rtbunparsedStart.UseVisualStyleBackColor = true;
            this.rtbunparsedStart.CheckedChanged += new System.EventHandler(this.rtbunparsedStart_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbUnparsedend);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbOriginal);
            this.panel1.Controls.Add(this.rtbunparsedStart);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 40);
            this.panel1.TabIndex = 19;
            // 
            // cmbOriginal
            // 
            this.cmbOriginal.AllowDrop = true;
            this.cmbOriginal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOriginal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOriginal.Font = new System.Drawing.Font("Latha", 9.75F);
            this.cmbOriginal.FormattingEnabled = true;
            this.cmbOriginal.ItemHeight = 20;
            this.cmbOriginal.Location = new System.Drawing.Point(72, 6);
            this.cmbOriginal.MaxDropDownItems = 5;
            this.cmbOriginal.Name = "cmbOriginal";
            this.cmbOriginal.Size = new System.Drawing.Size(289, 28);
            this.cmbOriginal.TabIndex = 31;
            this.cmbOriginal.SelectedIndexChanged += new System.EventHandler(this.cmbOriginal_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbParsedEnd);
            this.panel2.Controls.Add(this.rtbParsedStart);
            this.panel2.Controls.Add(this.cmbParsed);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(688, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 40);
            this.panel2.TabIndex = 20;
            // 
            // cmbParsed
            // 
            this.cmbParsed.AllowDrop = true;
            this.cmbParsed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbParsed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParsed.Font = new System.Drawing.Font("Latha", 9.75F);
            this.cmbParsed.FormattingEnabled = true;
            this.cmbParsed.ItemHeight = 20;
            this.cmbParsed.Location = new System.Drawing.Point(71, 6);
            this.cmbParsed.MaxDropDownItems = 5;
            this.cmbParsed.Name = "cmbParsed";
            this.cmbParsed.Size = new System.Drawing.Size(305, 28);
            this.cmbParsed.TabIndex = 25;
            this.cmbParsed.SelectedIndexChanged += new System.EventHandler(this.cmbParsed_SelectedIndexChanged);
            // 
            // UnparsedEndDatagrid
            // 
            this.UnparsedEndDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnparsedEndDatagrid.Location = new System.Drawing.Point(330, 186);
            this.UnparsedEndDatagrid.Name = "UnparsedEndDatagrid";
            this.UnparsedEndDatagrid.Size = new System.Drawing.Size(316, 406);
            this.UnparsedEndDatagrid.TabIndex = 21;
            this.UnparsedEndDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnparsedEndDatagrid_CellClick);
            // 
            // ParsedEndDatagrid
            // 
            this.ParsedEndDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParsedEndDatagrid.Location = new System.Drawing.Point(1006, 186);
            this.ParsedEndDatagrid.Name = "ParsedEndDatagrid";
            this.ParsedEndDatagrid.Size = new System.Drawing.Size(316, 406);
            this.ParsedEndDatagrid.TabIndex = 22;
            this.ParsedEndDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParsedEndDatagrid_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(9, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "தொடக்கச் சொற்கள்";
            // 
            // lblUPSC
            // 
            this.lblUPSC.AutoSize = true;
            this.lblUPSC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblUPSC.ForeColor = System.Drawing.Color.Blue;
            this.lblUPSC.Location = new System.Drawing.Point(5, 605);
            this.lblUPSC.Name = "lblUPSC";
            this.lblUPSC.Size = new System.Drawing.Size(16, 17);
            this.lblUPSC.TabIndex = 24;
            this.lblUPSC.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(327, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "இறுதிச் சொற்கள்";
            // 
            // lblUPEC
            // 
            this.lblUPEC.AutoSize = true;
            this.lblUPEC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblUPEC.ForeColor = System.Drawing.Color.Blue;
            this.lblUPEC.Location = new System.Drawing.Point(327, 605);
            this.lblUPEC.Name = "lblUPEC";
            this.lblUPEC.Size = new System.Drawing.Size(16, 17);
            this.lblUPEC.TabIndex = 26;
            this.lblUPEC.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(685, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "தொடக்கச் சொற்கள்";
            // 
            // lblPSC
            // 
            this.lblPSC.AutoSize = true;
            this.lblPSC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPSC.ForeColor = System.Drawing.Color.Blue;
            this.lblPSC.Location = new System.Drawing.Point(685, 605);
            this.lblPSC.Name = "lblPSC";
            this.lblPSC.Size = new System.Drawing.Size(16, 17);
            this.lblPSC.TabIndex = 28;
            this.lblPSC.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(1003, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "இறுதிச் சொற்கள்";
            // 
            // lblPEC
            // 
            this.lblPEC.AutoSize = true;
            this.lblPEC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPEC.ForeColor = System.Drawing.Color.Blue;
            this.lblPEC.Location = new System.Drawing.Point(1003, 605);
            this.lblPEC.Name = "lblPEC";
            this.lblPEC.Size = new System.Drawing.Size(16, 17);
            this.lblPEC.TabIndex = 30;
            this.lblPEC.Text = "0";
            // 
            // frmIndexing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1334, 642);
            this.Controls.Add(this.lblPEC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblPSC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblUPEC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUPSC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ParsedEndDatagrid);
            this.Controls.Add(this.UnparsedEndDatagrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ParsedStartDatagrid);
            this.Controls.Add(this.UnparsedStartDatagrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIndexing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIndexing";
            ((System.ComponentModel.ISupportInitialize)(this.UnparsedStartDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParsedStartDatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnparsedEndDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParsedEndDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UnparsedStartDatagrid;
        private System.Windows.Forms.DataGridView ParsedStartDatagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rtbParsedStart;
        private System.Windows.Forms.RadioButton rtbParsedEnd;
        private System.Windows.Forms.RadioButton rtbUnparsedend;
        private System.Windows.Forms.RadioButton rtbunparsedStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView UnparsedEndDatagrid;
        private System.Windows.Forms.DataGridView ParsedEndDatagrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUPSC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUPEC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPSC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPEC;
        private System.Windows.Forms.ComboBox cmbOriginal;
        private System.Windows.Forms.ComboBox cmbParsed;
    }
}