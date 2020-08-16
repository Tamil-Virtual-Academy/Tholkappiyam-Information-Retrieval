namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlWordFrequency
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
            this.rtbFrequency = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbFrequency
            // 
            this.rtbFrequency.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFrequency.Location = new System.Drawing.Point(0, 0);
            this.rtbFrequency.Name = "rtbFrequency";
            this.rtbFrequency.ReadOnly = true;
            this.rtbFrequency.Size = new System.Drawing.Size(701, 359);
            this.rtbFrequency.TabIndex = 0;
            this.rtbFrequency.Text = "";
            // 
            // UsrCtrlWordFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbFrequency);
            this.Name = "UsrCtrlWordFrequency";
            this.Size = new System.Drawing.Size(704, 362);
            this.Load += new System.EventHandler(this.UsrCtrlWordFrequency_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFrequency;
    }
}
