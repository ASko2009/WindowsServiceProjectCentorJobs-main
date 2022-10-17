using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp1
{
    public class Config
    {
        public void Bilder()
        {

            IConfigurationBuilder bild = new ConfigurationBuilder().AddJsonFile(@"G:\проект\WindowsServiceProjectCentorJobs\ConsoleApp1\appSettings.json", true, true);
            IConfigurationRoot root = bild.Build();
            Console.WriteLine( root["QuantityTread"].ToString());
        }


    }
}
