using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TolkappiyamForVirtualAcademy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
           //Application.Run(new frmExtraction());
            //Application.Run(new frmFunctional());
            //Application.Run(new frmTolkappiyamforTVA());
            //Application.Run(new CreatingXml());
            //Application.Run(new frmParsing());
            //Application.Run(new frmIndexing());
            //Application.Run(new frmStatistical());
            //Application.Run(new frmSuffMorphoAnalysis());
            //Application.Run(new FrmFirstScreen());
            //Application.Run(new frmGlossary());
            //Application.Run(new frmTechnicalTerms());
            Application.Run(new frmTolMainform());
        }
    }
}
