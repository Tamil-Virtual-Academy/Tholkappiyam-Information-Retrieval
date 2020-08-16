namespace TolkappiyamForVirtualAcademy
{
    partial class frmSuffMorphoAnalysis
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
            this.rbSuffix = new System.Windows.Forms.RadioButton();
            this.rbMorpho = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLoadUsrCtrl = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSuffix
            // 
            this.rbSuffix.AutoSize = true;
            this.rbSuffix.Checked = true;
            this.rbSuffix.Location = new System.Drawing.Point(66, 53);
            this.rbSuffix.Name = "rbSuffix";
            this.rbSuffix.Size = new System.Drawing.Size(206, 28);
            this.rbSuffix.TabIndex = 4;
            this.rbSuffix.TabStop = true;
            this.rbSuffix.Text = "இலக்கண விகுதிகள்";
            this.rbSuffix.UseVisualStyleBackColor = true;
            this.rbSuffix.CheckedChanged += new System.EventHandler(this.rbSuffix_CheckedChanged);
            // 
            // rbMorpho
            // 
            this.rbMorpho.AutoSize = true;
            this.rbMorpho.Location = new System.Drawing.Point(493, 53);
            this.rbMorpho.Name = "rbMorpho";
            this.rbMorpho.Size = new System.Drawing.Size(181, 28);
            this.rbMorpho.TabIndex = 5;
            this.rbMorpho.Text = "விகுதிவருகைகள்";
            this.rbMorpho.UseVisualStyleBackColor = true;
            this.rbMorpho.CheckedChanged += new System.EventHandler(this.rbMorpho_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbMorpho);
            this.groupBox1.Controls.Add(this.rbSuffix);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(218, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(121, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "தொல்காப்பிய இலக்கண விகுதிகள் மற்றும் விகுதிவருகை";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // pnlLoadUsrCtrl
            // 
            this.pnlLoadUsrCtrl.Location = new System.Drawing.Point(40, 148);
            this.pnlLoadUsrCtrl.Name = "pnlLoadUsrCtrl";
            this.pnlLoadUsrCtrl.Size = new System.Drawing.Size(1090, 469);
            this.pnlLoadUsrCtrl.TabIndex = 1;
            // 
            // frmSuffMorphoAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1152, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlLoadUsrCtrl);
            this.Name = "frmSuffMorphoAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuffMorphoAnalysis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSuffix;
        private System.Windows.Forms.RadioButton rbMorpho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLoadUsrCtrl;
    }
}