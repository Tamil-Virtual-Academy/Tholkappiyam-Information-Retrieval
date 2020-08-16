using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace TolkappiyamForVirtualAcademy
{
    public class clsGlossary
    {
        XmlDocument xmlDoc = null;
        string appDataPath, xmlGlossary = string.Empty;

        public void initialize()
        {
            appDataPath = Path.Combine(Application.StartupPath, "Data");
            xmlGlossary = Path.Combine(appDataPath, "TechnicalTerms.xml");

            if (xmlDoc == null)
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlGlossary);
            }
        }
      

        

        public clsGlossaryDetails Retrievewithkeyword(string Keyword)
        {
            clsGlossaryDetails objDetail = new clsGlossaryDetails();
            XmlNode node = null;

            initialize();
            string Query = "/Tolkappiyam/TechnicalTerm[Keyword = '" + Keyword + "']";
            node = xmlDoc.SelectSingleNode(Query);

            if (node != null)
            {
                objDetail.Keyword = node["Keyword"].InnerXml.ToString().Trim();
                objDetail.Explanation = node["Explanation"].InnerXml.ToString() + node["Explanation1"].InnerXml.ToString();
                objDetail.Noorpa = node["Noorpa"].InnerXml.ToString().Trim();
                objDetail.Chapter = node["Chapter"].InnerXml.ToString().Trim();
            }

            return objDetail;
        }



    }
    public class clsGlossaryDetails
    {
        public string Keyword { get; set; }
        public string Explanation { get; set; }
        public string Noorpa { get; set; }
        public string Chapter { get; set; }
    }
}
