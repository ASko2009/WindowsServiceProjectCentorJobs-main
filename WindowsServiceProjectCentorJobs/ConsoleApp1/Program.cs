using ConsoleApp1.connectionEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using WindowsServiceProjectCentorJobs;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using ConsoleApp1;

namespace WitheProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Config conf = new Config();
            conf.Bilder();
            Console.ReadLine();

            ///using var dbContext = new NutshellContext();
            ///Console.WriteLine(dbContext.JobsQwery.Count());
            ///Console.ReadLine();

            XMLQwery qwery = new XMLQwery();
            qwery.ParseQweryFSSPXMLInTableJobsQwery(@"G:\проект\WindowsServiceProjectCentorJobs-main\DocsForLoingAndLog\XMLin\Новый1.xml");

       

        }
    }
}
