using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TolkappiyamForVirtualAcademy
{
    public partial class UsrCtrlWordFrequency : UserControl
    {
        public string Word { get; set; }
        public string OtherForm { get; set; }
        public string Count { get; set; }
        public bool NormalForm { get; set; }

        public UsrCtrlWordFrequency()
        {
            InitializeComponent();
        }

        private void UsrCtrlWordFrequency_Load(object sender, EventArgs e)
        {
            decimal count = Convert.ToDecimal(Count);
            decimal freq = 0;
            StringBuilder sb = new StringBuilder();


            if (NormalForm == true)
            {
                freq = (count / 15762) * 100;
                freq = Math.Round(freq, 2);
            }
            else
            {
                freq = (count / 17515) * 100;
                freq = Math.Round(freq, 2);
            }

            sb.Append("சொல் :  ").AppendLine(Word).AppendLine();
            sb.Append("வருகை எண்ணிக்கை :  ").AppendLine(Count).AppendLine();
            if (!string.IsNullOrEmpty(OtherForm))
            {
                sb.Append("பிற வடிவங்கள் :  ").AppendLine(OtherForm).AppendLine();
            }
            sb.Append("நிகழ்வெண் :  ").AppendLine(freq.ToString());



           
            rtbFrequency.Text = sb.ToString();

        }






    }
}
