using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Logging
{
    class LogInFile
    {

        public static void СreateEntryInFile(string textError)
        {
            string pathToFile = @"G:\проект\WindowsServiceProjectCentorJobs-main\DocsForLoingAndLog\log" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";


            using (FileStream fileLog = new FileStream(pathToFile, FileMode.Append))
            using (StreamWriter stream = new StreamWriter(fileLog))
             stream.WriteLine("{0} {1}", DateTime.Now.ToString("dd.MM.yyyy-HH.mm.ss"),textError);

        }


    }
}
