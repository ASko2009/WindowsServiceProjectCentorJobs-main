using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Documents;

namespace Documents
{
    class CvtOut 
    {
        public void CreateBeadCvtQweryForFSSP(string GUID, string errorText)
        {

            XElement Cvt =
                new XElement("Documents",
                  new XElement("QweryFSSP", new XAttribute("type", "Responce"), new XAttribute("GUID", GUID),
                   new XElement("StatysQwery", "-1"),
                   new XElement("ErrorText", errorText )
                   ));
            Console.WriteLine(Cvt.ToString());

        }
    
    
    }
    
}
