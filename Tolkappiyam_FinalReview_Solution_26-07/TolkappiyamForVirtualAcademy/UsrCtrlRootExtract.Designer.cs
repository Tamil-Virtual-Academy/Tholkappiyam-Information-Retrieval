namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlRootExtract
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
            this.cmbRoot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RootDatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.InflectedDatagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RootDatagrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflectedDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRoot);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RootDatagrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 387);
            this.panel1.TabIndex = 1;
            // 
            // cmbRoot
            // 
            this.cmbRoot.AllowDrop = true;
            this.cmbRoot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRoot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRoot.Font = new System.Drawing.Font("Latha", 9.75F);
            this.cmbRoot.FormattingEnabled = true;
            this.cmbRoot.ItemHeight = 20;
            this.cmbRoot.Location = new System.Drawing.Point(102, 12);
            this.cmbRoot.MaxDropDownItems = 5;
            this.cmbRoot.Name = "cmbRoot";
            this.cmbRoot.Size = new System.Drawing.Size(104, 28);
            this.cmbRoot.TabIndex = 32;
            this.cmbRoot.SelectedIndexChanged += new System.EventHandler(this.cmbRoot_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(-2, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "தொல்காப்பிய வேர்ச்சொற்கள்";
            // 
            // RootDatagrid
            // 
            this.RootDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.RootDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RootDatagrid.Location = new System.Drawing.Point(3, 65);
            this.RootDatagrid.Name = "RootDatagrid";
            this.RootDatagrid.Size = new System.Drawing.Size(213, 319);
            this.RootDatagrid.TabIndex = 5;
            this.RootDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RootDatagrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "வேர்ச்சொல்";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbDetails);
            this.panel2.Controls.Add(this.InflectedDatagrid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(225, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 384);
            this.panel2.TabIndex = 2;
            // 
            // rtbDetails
            // 
            this.rtbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDetails.Location = new System.Drawing.Point(249, 27);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.ReadOnly = true;
            this.rtbDetails.Size = new System.Drawing.Size(621, 354);
            this.rtbDetails.TabIndex = 2;
            this.rtbDetails.Text = "";
            // 
            // InflectedDatagrid
            // 
            this.InflectedDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.InflectedDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InflectedDatagrid.Location = new System.Drawing.Point(3, 27);
            this.InflectedDatagrid.Name = "InflectedDatagrid";
            this.InflectedDatagrid.Size = new System.Drawing.Size(240, 357);
            this.InflectedDatagrid.TabIndex = 1;
            this.InflectedDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InflectedDatagrid_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 0;
            // 
            // UsrCtrlRootExtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UsrCtrlRootExtract";
            this.Size = new System.Drawing.Size(1101, 393);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RootDatagrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflectedDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView RootDatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.DataGridView InflectedDatagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRoot;
    }
}
