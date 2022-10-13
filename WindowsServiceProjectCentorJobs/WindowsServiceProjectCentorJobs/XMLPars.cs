using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections.Generic;


namespace WindowsServiceProjectCentorJobs
{
    class XMLQwery
    {
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



        public int LengthXML(string pathToXML)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(pathToXML);
            XmlElement el = doc.DocumentElement;
            return el.ChildNodes.Count;

        }

        public void ParseQweryFSSPXML(string wayIn)
        {

            XmlDocument xml = new XmlDocument();
            xml.Load(wayIn);
            XmlElement element = xml.DocumentElement;
            foreach (XmlNode xnope in element)
            {
                if (xnope.Attributes.Count > 0)
                {
                    XmlNode attr = xnope.Attributes.GetNamedItem("Type");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                foreach (XmlNode childnode in xnope.ChildNodes)
                {
                    if (childnode.Name == "numberExecutiveDocument")
                        numberExecutiveDocument = childnode.InnerText;
                    if (childnode.Name == "identifierFSSP")
                        identifierFSSP = childnode.InnerText;
                    if (childnode.Name == "debtorFullName")
                        debtorFullName = childnode.InnerText;
                    if (childnode.Name == "debtorAdress")
                        debtorAdress = childnode.InnerText;
                    if (childnode.Name == "debtorINN")
                        debtorINN = childnode.InnerText;
                    if (childnode.Name == "debtorKPP")
                        debtorKPP = childnode.InnerText;
                    if (childnode.Name == "debtorType")
                        debtorType = childnode.InnerText;
                    if (childnode.Name == "debtorScore")
                        debtorScore = childnode.InnerText;
                    if (childnode.Name == "bankName")
                        bankName = childnode.InnerText;
                    if (childnode.Name == "targetBankINN")
                        targetBankINN = childnode.InnerText;
                    if (childnode.Name == "targetBankKPP")
                        targetBankKPP = childnode.InnerText;
                    if (childnode.Name == "bailiffName")
                        bailiffName = childnode.InnerText;
                    if (childnode.Name == "bailiffAdress")
                        bailiffAdress = childnode.InnerText;
                    if (childnode.Name == "departmentBailiffINN")
                        departmentBailiffINN = childnode.InnerText;
                    if (childnode.Name == "departmentBailiffKPP")
                        departmentBailiffKPP = childnode.InnerText;
                    if (childnode.Name == "textOriginal")
                        textOriginal = childnode.InnerText;
                }
            }

        }
        
    }
    class ResolutionOnRecoveryDocuments
    {

    }
    class CancellationResolutionOnRecoveryDocuments
    {

    }
    class ArrestAndRecoveryDocuments
    {

    }
    class CancellationArrestAndRecoveryDocuments
    {

    }
    class ArrestDocuments
    {

    }
    class CancellationArrestDocuments
    {


    }
}


