namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlPosExtract
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.InflectedDatagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PosDatagrid = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflectedDatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbDetails);
            this.panel2.Controls.Add(this.InflectedDatagrid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(404, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 384);
            this.panel2.TabIndex = 4;
            // 
            // rtbDetails
            // 
            this.rtbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDetails.Location = new System.Drawing.Point(252, 24);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.ReadOnly = true;
            this.rtbDetails.Size = new System.Drawing.Size(442, 360);
            this.rtbDetails.TabIndex = 2;
            this.rtbDetails.Text = "";
            // 
            // InflectedDatagrid
            // 
            this.InflectedDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.InflectedDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InflectedDatagrid.Location = new System.Drawing.Point(6, 27);
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
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PosDatagrid);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 387);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "இலக்கண வகைப்பாட்டிற்குரிய சொற்கள்";
            // 
            // PosDatagrid
            // 
            this.PosDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.PosDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PosDatagrid.Location = new System.Drawing.Point(3, 27);
            this.PosDatagrid.Name = "PosDatagrid";
            this.PosDatagrid.Size = new System.Drawing.Size(389, 357);
            this.PosDatagrid.TabIndex = 5;
            this.PosDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PosDatagrid_CellClick);
            // 
            // UsrCtrlPosExtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UsrCtrlPosExtract";
            this.Size = new System.Drawing.Size(1101, 393);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflectedDatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.DataGridView InflectedDatagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView PosDatagrid;
        private System.Windows.Forms.Label label3;
    }
}
