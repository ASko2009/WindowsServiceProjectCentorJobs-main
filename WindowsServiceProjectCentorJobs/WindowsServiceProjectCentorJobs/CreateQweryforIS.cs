using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections.Generic;

namespace WindowsServiceProjectCentorJobs
{
    class TypeQweryProcessCreateQweryforIS
    {
        public string GUID;
        public string numberExecutiveDocument;
        public string identifierFSSP;
        public string debtorFullName;
        public string debtorAdress;
        public string debtorINN;
        public string debtorKPP;
        public string debtorType;
        public string debtorScore;
        public string bankName;
        public string targetBankINN;
        public string targetBankKPP;
        public string bailiffName;
        public string bailiffAdress;
        public string departmentBailiffINN;
        public string departmentBailiffKPP;
        public string textOriginal;

        public void CreateQweryForInformationSystems(Array[] qweryData)
        {
            XmlDocument xQwery = new XmlDocument();
            xQwery.Load(@"G:\проект\Сервис\Новый2.xml");
            XmlElement xRoot = xQwery.DocumentElement;
            XmlElement element = xQwery.CreateElement("QweryFSSP");

            XmlAttribute attribute = xQwery.CreateAttribute("GUID");
            XmlElement xdebtorFullName = xQwery.CreateElement("debtorFullName");
            XmlElement xdebtorAdress = xQwery.CreateElement("debtorAdress");
            XmlElement xdebtorINN = xQwery.CreateElement("debtorINN");
            XmlElement xdebtorKPP = xQwery.CreateElement("debtorKPP");
            XmlElement xdebtorType = xQwery.CreateElement("debtorType");
            XmlElement xdebtorScore = xQwery.CreateElement("debtorScore");

            XmlText XmlTextGUID = xQwery.CreateTextNode(GUID);
            XmlText XmlTextdebtorFullName = xQwery.CreateTextNode(debtorFullName);
            XmlText XmlTextdebtorAdress = xQwery.CreateTextNode(debtorAdress);
            XmlText XmlTextdebtorINN = xQwery.CreateTextNode(debtorINN);
            XmlText XmlTextdebtorKPP = xQwery.CreateTextNode(debtorKPP);
            XmlText XmlTextdebtorType = xQwery.CreateTextNode(debtorType);
            XmlText XmlTextdebtorScore = xQwery.CreateTextNode(debtorScore);

            attribute.AppendChild(XmlTextGUID);
            xdebtorFullName.AppendChild(XmlTextdebtorFullName);
            xdebtorAdress.AppendChild(XmlTextdebtorAdress);
            xdebtorINN.AppendChild(XmlTextdebtorINN);
            xdebtorKPP.AppendChild(XmlTextdebtorKPP);
            xdebtorType.AppendChild(XmlTextdebtorType);
            xdebtorScore.AppendChild(XmlTextdebtorScore);

            xRoot.AppendChild(element);
            xQwery.Save(@"G:\проект\Сервис\Новый2.xml");



        }
    }
}
