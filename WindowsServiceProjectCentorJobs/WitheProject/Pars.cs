using System;
using System.Xml;
using System.Xml.Linq;
using Documents;
using Logging;




/// <summary>
/// заполнение сделать закртым отдачу публичынм
/// </summary>
namespace WindowsServiceProjectCentorJobs
{
    class XMLQwery
    {
        public void ParseQweryFSSPXMLInTableJobsQwery(string wayIn)
        {
            XElement elementsXML = XElement.Load(wayIn);
            foreach (XElement oneQwery in elementsXML.Elements())
            {
                RequestDocumentsIN doc = new RequestDocumentsIN();

                foreach (XElement elementsOneQwery in oneQwery.Elements())
                {

                    switch (oneQwery.Attribute("GUID").Name.LocalName)
                    {
                        case "GUID":
                            {
                                doc.guidFSSP = oneQwery.Attribute("GUID").Value;
                                break;
                            }
                    }

                    switch (elementsOneQwery.Name.ToString())
                    {
                        case "numberExecutiveDocument":
                            doc.numberExecutiveDocument = elementsOneQwery.Value.ToString();
                            break;

                        case "identifierFSSP":
                            doc.identifierFSSP = elementsOneQwery.Value.ToString();
                            break;

                        case "bailiffName":
                            doc.bailiffName = elementsOneQwery.Value;
                            break;

                        case "bailiffAdress":
                            doc.bailiffAdress = elementsOneQwery.Value;
                            break;

                        case "departmentBailiffINN":
                            doc.departmentBailiffINN = elementsOneQwery.Value;
                            break;

                        case "departmentBailiffKPP":
                            doc.departmentBailiffKPP = elementsOneQwery.Value;
                            break;

                        case "debtorFullName":
                            doc.debtorFullName = elementsOneQwery.Value;
                            break;

                        case "debtorAdress":
                            doc.debtorAdress = elementsOneQwery.Value;
                            break;

                        case "debtorINN":
                            doc.debtorINN = elementsOneQwery.Value;
                            break;

                        case "debtorKPP":
                            doc.debtorKPP = elementsOneQwery.Value;
                            break;

                        case "debtorType":
                            doc.debtorType = elementsOneQwery.Value;
                            break;

                        case "textOriginal":
                            doc.textOriginal = elementsOneQwery.Value;
                            break;

                        case "bankName":
                            doc.bankName = elementsOneQwery.Value;
                            break;

                        case "targetBankINN":
                            doc.targetBankINN = elementsOneQwery.Value;
                            break;

                        case "targetBankKPP":
                            doc.targetBankKPP = elementsOneQwery.Value;
                            break;
                    }
                }

                if (doc.CheckingFullnessDocument())
                {
                    LogInFile.СreateEntryInFile(doc.NameZeroElement());
                    doc.ErorrList = doc.NameZeroElement();
                    ///занести в базу строку с со статусом 
                    CvtOut cvt = new CvtOut();
                    cvt.CreateBeadCvtQweryForFSSP(GUID: doc.guidFSSP, errorText: doc.NameZeroElement());
                }



                else
                {
                    Console.WriteLine("OK");
                }
                ///открыть коннект к базе передать данные для заполнния  










            }


        }


    }
}


        //public int LengthXML(string pathToXML)
        //{
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(pathToXML);
        //    XmlElement el = doc.DocumentElement;
        //    return el.ChildNodes.Count;
        //}



        //public string LengthXMLT(string pathToXML)
        //{
        //XmlDocument doc = new XmlDocument();
        //doc.Load(pathToXML);
        //XmlElement el = doc.DocumentElement;
        /////return el.ChildNodes.Count;
        //return el.GetElementsByTagName("debtorINN").ToString();
        //}
        //public void LengthXMLTE(string pathToXML)
        //{
        //XElement elementsXML = XElement.Load(pathToXML);
        //Console.WriteLine(elementsXML.Elements().Count());
        //var el = elementsXML.Element("DocFSSP");
        //int x = el.Elements().Count();
        //Console.WriteLine(x);
        //}




        ///public string numberExecutiveDocument;
        ///public string identifierFSSP;
        ///public string debtorFullName;
        ///public string debtorAdress;
        ///public string debtorINN;
        ///public string debtorKPP;
        ///public string debtorType;
        ///public string debtorScore;
        ///public string bankName;
        ///public string targetBankINN;
        ///public string targetBankKPP;
        ///public string bailiffName;
        ///public string bailiffAdress;
        ///public string departmentBailiffINN;
        ///public string departmentBailiffKPP;
        ///public string textOriginal;


        //public void ParseQweryFSSPXML(string wayIn)
        //{

        //XmlDocument xml = new XmlDocument();
        //xml.Load(wayIn);
        //XmlElement element = xml.DocumentElement;
        //foreach (XmlNode xnope in element)
        //{
        //if (xnope.Attributes.Count > 0)
        //{
        //XmlNode attr = xnope.Attributes.GetNamedItem("Type");
        //if (attr != null)
        //Console.WriteLine(attr.Value);
        //}
        //foreach (XmlNode childnode in xnope.ChildNodes)
        //{
        //if (childnode.Name == "numberExecutiveDocument")
        //numberExecutiveDocument = childnode.InnerText;
        //if (childnode.Name == "identifierFSSP")
        //identifierFSSP = childnode.InnerText;
        //if (childnode.Name == "debtorFullName")
        //debtorFullName = childnode.InnerText;
        //if (childnode.Name == "debtorAdress")
        //debtorAdress = childnode.InnerText;
        //if (childnode.Name == "debtorINN")
        //debtorINN = childnode.InnerText;
        //if (childnode.Name == "debtorKPP")
        //debtorKPP = childnode.InnerText;
        //if (childnode.Name == "debtorType")
        //debtorType = childnode.InnerText;
        //if (childnode.Name == "debtorScore")
        //debtorScore = childnode.InnerText;
        //if (childnode.Name == "bankName")
        //bankName = childnode.InnerText;
        //if (childnode.Name == "targetBankINN")
        //targetBankINN = childnode.InnerText;
        //if (childnode.Name == "targetBankKPP")
        //targetBankKPP = childnode.InnerText;
        //if (childnode.Name == "bailiffName")
        //bailiffName = childnode.InnerText;
        //if (childnode.Name == "bailiffAdress")
        //bailiffAdress = childnode.InnerText;
        //if (childnode.Name == "departmentBailiffINN")
        //departmentBailiffINN = childnode.InnerText;
        //if (childnode.Name == "departmentBailiffKPP")
        //departmentBailiffKPP = childnode.InnerText;
        //if (childnode.Name == "textOriginal")
        //textOriginal = childnode.InnerText;
        //}
        //}
        //}

    

