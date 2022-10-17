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
            

            Console.WriteLine(Config.CONFIGData["QuantityTread"].ToString());
            Console.ReadLine(); 


            ///using var dbContext = new NutshellContext();
            ///Console.WriteLine(dbContext.JobsQwery.Count());
            ///Console.ReadLine();

            XMLQwery qwery = new XMLQwery();
            qwery.ParseQweryFSSPXMLInTableJobsQwery(Directory.GetCurrentDirectory().ToString() + @"\DocsForLoingAndLog\XMLin\Новый1.xml");

       

        }
    }
}
