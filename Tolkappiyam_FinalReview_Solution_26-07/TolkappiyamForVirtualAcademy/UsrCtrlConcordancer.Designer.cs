namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlConcordancer
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
            this.grpConcordVariable = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblLeftvar = new System.Windows.Forms.Label();
            this.lblRightvar = new System.Windows.Forms.Label();
            this.cmbLeftVar = new System.Windows.Forms.ComboBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.cmbRightVar = new System.Windows.Forms.ComboBox();
            this.rtbConcord = new System.Windows.Forms.RichTextBox();
            this.grpConcordVariable.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConcordVariable
            // 
            this.grpConcordVariable.Controls.Add(this.txtInput);
            this.grpConcordVariable.Controls.Add(this.lblLeftvar);
            this.grpConcordVariable.Controls.Add(this.lblRightvar);
            this.grpConcordVariable.Controls.Add(this.cmbLeftVar);
            this.grpConcordVariable.Controls.Add(this.lblInput);
            this.grpConcordVariable.Controls.Add(this.cmbRightVar);
            this.grpConcordVariable.Location = new System.Drawing.Point(3, 3);
            this.grpConcordVariable.Name = "grpConcordVariable";
            this.grpConcordVariable.Size = new System.Drawing.Size(626, 46);
            this.grpConcordVariable.TabIndex = 37;
            this.grpConcordVariable.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Latha", 6.75F);
            this.txtInput.Location = new System.Drawing.Point(111, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(153, 22);
            this.txtInput.TabIndex = 43;
            // 
            // lblLeftvar
            // 
            this.lblLeftvar.AutoSize = true;
            this.lblLeftvar.Font = new System.Drawing.Font("Latha", 6.75F, System.Drawing.FontStyle.Bold);
            this.lblLeftvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLeftvar.Location = new System.Drawing.Point(284, 20);
            this.lblLeftvar.Name = "lblLeftvar";
            this.lblLeftvar.Size = new System.Drawing.Size(84, 14);
            this.lblLeftvar.TabIndex = 37;
            this.lblLeftvar.Text = "இடது மாறிகள்";
            // 
            // lblRightvar
            // 
            this.lblRightvar.AutoSize = true;
            this.lblRightvar.Font = new System.Drawing.Font("Latha", 6.75F, System.Drawing.FontStyle.Bold);
            this.lblRightvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRightvar.Location = new System.Drawing.Point(459, 21);
            this.lblRightvar.Name = "lblRightvar";
            this.lblRightvar.Size = new System.Drawing.Size(88, 14);
            this.lblRightvar.TabIndex = 38;
            this.lblRightvar.Text = "வலது மாறிகள்";
            // 
            // cmbLeftVar
            // 
            this.cmbLeftVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbLeftVar.FormattingEnabled = true;
            this.cmbLeftVar.Items.AddRange(new object[] {
            "1இ",
            "2இ",
            "3இ",
            "4இ",
            "5இ"});
            this.cmbLeftVar.Location = new System.Drawing.Point(374, 17);
            this.cmbLeftVar.Name = "cmbLeftVar";
            this.cmbLeftVar.Size = new System.Drawing.Size(59, 21);
            this.cmbLeftVar.TabIndex = 39;
            this.cmbLeftVar.Text = "1இ";
            this.cmbLeftVar.SelectedIndexChanged += new System.EventHandler(this.cmbLeftVar_SelectedIndexChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Latha", 6.75F, System.Drawing.FontStyle.Bold);
            this.lblInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInput.Location = new System.Drawing.Point(6, 20);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(99, 14);
            this.lblInput.TabIndex = 36;
            this.lblInput.Text = "உள்ளீட்டுச் சொல்";
            // 
            // cmbRightVar
            // 
            this.cmbRightVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbRightVar.FormattingEnabled = true;
            this.cmbRightVar.Items.AddRange(new object[] {
            "1வ",
            "2வ",
            "3வ",
            "4வ",
            "5வ"});
            this.cmbRightVar.Location = new System.Drawing.Point(549, 16);
            this.cmbRightVar.Name = "cmbRightVar";
            this.cmbRightVar.Size = new System.Drawing.Size(62, 21);
            this.cmbRightVar.TabIndex = 40;
            this.cmbRightVar.Text = "1வ";
            this.cmbRightVar.SelectedIndexChanged += new System.EventHandler(this.cmbRightVar_SelectedIndexChanged);
            // 
            // rtbConcord
            // 
            this.rtbConcord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConcord.Location = new System.Drawing.Point(3, 64);
            this.rtbConcord.Name = "rtbConcord";
            this.rtbConcord.Size = new System.Drawing.Size(698, 295);
            this.rtbConcord.TabIndex = 38;
            this.rtbConcord.Text = "";
            // 
            // UsrCtrlConcordancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbConcord);
            this.Controls.Add(this.grpConcordVariable);
            this.Name = "UsrCtrlConcordancer";
            this.Size = new System.Drawing.Size(704, 362);
            this.Load += new System.EventHandler(this.UsrCtrlConcordancer_Load);
            this.grpConcordVariable.ResumeLayout(false);
            this.grpConcordVariable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConcordVariable;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblLeftvar;
        private System.Windows.Forms.Label lblRightvar;
        private System.Windows.Forms.ComboBox cmbLeftVar;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.ComboBox cmbRightVar;
        private System.Windows.Forms.RichTextBox rtbConcord;
    }
}
