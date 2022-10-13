using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using WindowsServiceProjectCentorJobs;

namespace WitheProject
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLQwery qwery = new XMLQwery();
            qwery.ParseQweryFSSPXMLInTableJobsQwery(@"G:\проект\DocsForLoingAndLog\XMLin\Новый1.xml");
        }
    }
}
