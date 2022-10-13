using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceProjectCentorJobs
{
    interface IDataProvider
    {
        string GetData();

    }
    interface IDataProcessor
    {
        void ProcessorData(IDataProvider dataProvider);

    }
    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessorData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "ДАнные из БД";
        }
    }
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "ДАнные из ФАЙЛА";
        }
    }
    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "ДАнные из API";
        }
    }


    class Programm
    {
        static void Main2(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessorData(new DbDataProvider());
            dataProcessor.ProcessorData(new FileDataProvider());
            dataProcessor.ProcessorData(new APIDataProvider());
        } 


    }
}