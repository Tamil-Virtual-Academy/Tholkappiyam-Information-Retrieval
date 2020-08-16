namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlMorpho
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
            this.label2 = new System.Windows.Forms.Label();
            this.RootSuffixDatagrid = new System.Windows.Forms.DataGridView();
            this.rtbMorphotactics = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuffixDatagrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RootSuffixDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuffixDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "வேர்ச்சொல் வகைப்பாட்டு பட்டியல்";
            // 
            // RootSuffixDatagrid
            // 
            this.RootSuffixDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RootSuffixDatagrid.Location = new System.Drawing.Point(13, 31);
            this.RootSuffixDatagrid.Name = "RootSuffixDatagrid";
            this.RootSuffixDatagrid.Size = new System.Drawing.Size(237, 360);
            this.RootSuffixDatagrid.TabIndex = 8;
            this.RootSuffixDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RootSuffixDatagrid_CellClick);
            // 
            // rtbMorphotactics
            // 
            this.rtbMorphotactics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMorphotactics.Location = new System.Drawing.Point(586, 31);
            this.rtbMorphotactics.Name = "rtbMorphotactics";
            this.rtbMorphotactics.ReadOnly = true;
            this.rtbMorphotactics.Size = new System.Drawing.Size(506, 360);
            this.rtbMorphotactics.TabIndex = 40;
            this.rtbMorphotactics.Text = "";
            this.rtbMorphotactics.TextChanged += new System.EventHandler(this.rtbMorphotactics_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(582, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "தொல்காப்பிய விகுதிவருகை";
            // 
            // SuffixDatagrid
            // 
            this.SuffixDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuffixDatagrid.Location = new System.Drawing.Point(272, 31);
            this.SuffixDatagrid.Name = "SuffixDatagrid";
            this.SuffixDatagrid.Size = new System.Drawing.Size(308, 360);
            this.SuffixDatagrid.TabIndex = 42;
            this.SuffixDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuffixDatagrid_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(268, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "விகுதி வகைப்பாட்டு பட்டியல்";
            // 
            // UsrCtrlMorpho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SuffixDatagrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbMorphotactics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RootSuffixDatagrid);
            this.Name = "UsrCtrlMorpho";
            this.Size = new System.Drawing.Size(1095, 394);
            ((System.ComponentModel.ISupportInitialize)(this.RootSuffixDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuffixDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RootSuffixDatagrid;
        private System.Windows.Forms.RichTextBox rtbMorphotactics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SuffixDatagrid;
        private System.Windows.Forms.Label label3;
    }
}
