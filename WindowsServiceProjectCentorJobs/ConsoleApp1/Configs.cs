using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.IO;


namespace ConsoleApp1
{
    public static class Config
    {
        public static IConfigurationRoot CONFIGData = Bilder();
        public static IConfigurationRoot Bilder ()
        {
            IConfigurationBuilder bild = new ConfigurationBuilder().AddJsonFile(Directory.GetCurrentDirectory().ToString() + @"\appSettings.json", true, true);
            IConfigurationRoot root = bild.Build();
            return root;



        }

        


    }
    
}
