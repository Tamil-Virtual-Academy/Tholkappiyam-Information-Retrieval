namespace TolkappiyamForVirtualAcademy
{
    partial class UsrCtrlSuffixMorpho
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
            this.rbMorpho = new System.Windows.Forms.RadioButton();
            this.rbSuffix = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLoadUsrCtrl = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMorpho);
            this.groupBox1.Controls.Add(this.rbSuffix);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbMorpho
            // 
            this.rbMorpho.AutoSize = true;
            this.rbMorpho.Location = new System.Drawing.Point(265, 31);
            this.rbMorpho.Name = "rbMorpho";
            this.rbMorpho.Size = new System.Drawing.Size(181, 28);
            this.rbMorpho.TabIndex = 5;
            this.rbMorpho.Text = "விகுதிவருகைகள்";
            this.rbMorpho.UseVisualStyleBackColor = true;
            this.rbMorpho.CheckedChanged += new System.EventHandler(this.rbMorpho_CheckedChanged);
            // 
            // rbSuffix
            // 
            this.rbSuffix.AutoSize = true;
            this.rbSuffix.Checked = true;
            this.rbSuffix.Location = new System.Drawing.Point(6, 31);
            this.rbSuffix.Name = "rbSuffix";
            this.rbSuffix.Size = new System.Drawing.Size(206, 28);
            this.rbSuffix.TabIndex = 4;
            this.rbSuffix.TabStop = true;
            this.rbSuffix.Text = "இலக்கண விகுதிகள்";
            this.rbSuffix.UseVisualStyleBackColor = true;
            this.rbSuffix.CheckedChanged += new System.EventHandler(this.rbSuffix_CheckedChanged);
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
            this.pnlLoadUsrCtrl.Location = new System.Drawing.Point(3, 77);
            this.pnlLoadUsrCtrl.Name = "pnlLoadUsrCtrl";
            this.pnlLoadUsrCtrl.Size = new System.Drawing.Size(1095, 394);
            this.pnlLoadUsrCtrl.TabIndex = 4;
            // 
            // UsrCtrlSuffixMorpho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pnlLoadUsrCtrl);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsrCtrlSuffixMorpho";
            this.Size = new System.Drawing.Size(1107, 474);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMorpho;
        private System.Windows.Forms.RadioButton rbSuffix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLoadUsrCtrl;
    }
}
