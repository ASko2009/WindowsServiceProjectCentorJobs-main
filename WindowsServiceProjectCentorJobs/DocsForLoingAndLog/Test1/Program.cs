using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("укажи что то");
            ///string userchoiz = Console.ReadLine();
            string choice1 = Console.ReadLine();
            Object choice;

            
            
                switch (choice1)
                {
                    case "1":
                        choice = 5;

                        ///Console.WriteLine("int");
                        break;

                    case "2":
                        choice = "hi"; ////Console.WriteLine("string");
                        break;
                    case "3":
                        choice = 3.5;
                        break;
                    default:
                        choice = "6oo";
                        break;

                }
                switch (choice)
                {
                    case int i:
                        Console.WriteLine("int");
                        break;

                    case string b:
                        Console.WriteLine("string");
                        break;
                    case decimal c:
                        Console.WriteLine("Decimal");
                        break;
                }

            


           //// int [] str ={ 1,2,3,4,5,6,11,12,13};
           //// var sub = from i in str where i < 10 select i;
           ////     Console.WriteLine("Values in sub");
           //// foreach (var i in sub)
           //// {
           ////     Console.WriteLine(i);
           //// }
           //// 
           ////
           ////
           //// string str2 ="start";
           //// string a = str2.Length <10 ? a ="true!": a = "false!";
           //// Console.WriteLine(a);
            ////
           //// int t1 = 300;
           //// int t2 = 100;
           //// try
           //// {
           ////     byte sum = checked((byte)(t1 + t2));
           ////     Console.WriteLine(sum);
           //// }
           //// catch (OverflowException ex)
           //// {
           ////     Console.WriteLine(ex.Message);
           //// }


            ////  int[] myArray = { 9, 8, 3, 4 };
            ////  Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());
            ////
            ////
            ////
            ////  string s1 = "Finnish12";
            ////  string s2 = "Finnish14";
            ////  Console.WriteLine($"\ts1 == s2: {s1} b {s2}");
            ////
            ////
            ////
            ////
            ////
            ////
            ////
            ////
            ////
            ////
            ////  StringBuilder sb = new StringBuilder ("NEW GamE");
            ////  ////Console.WriteLine(sb.Append("\n"));
            ////  Console.WriteLine(sb.AppendLine("Hile Flife 3"));
            ///sb.AppendLine("Horizont");
            ///sb.AppendLine("b" +"2");
            ///Console.WriteLine(sb.ToString());
            ///sb.Replace("Hile Flife 3", "Invizeble");
            ///Console.WriteLine(sb.ToString());
            ///Console.WriteLine("sb has {0} chars", sb.Length);

            ////string s1 = @"H""hoho""";
            ///////Console.WriteLine(s1);
            ////string s2 = "HElllo";
            ////string s3 = "HEhho";
            ////////Console.WriteLine("s1 = {0}", s1);
            ////////Console.WriteLine("s2 = {0}", s2);
            ///////Console.WriteLine("CurrentCulture = {0}", s2.Equals (s3, StringComparison.CurrentCultureIgnoreCase));
            ///////Console.WriteLine("OrdinalIgnoreCase case = {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            ///////Console.WriteLine("InvariantCulture case = {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            ////Console.WriteLine("Default rules IndexOf case {0},{1}", s3,s2.IndexOf("l"));
            ////Console.WriteLine("Case IndexOf stringComaries OrdenalIgnorCase {0}",
            ////s2.IndexOf("E", StringComparison.Ordinal));
            ////Console.WriteLine("Case IndexOf InvariantCultureIgnoreCase {0}", s2.IndexOf("e", StringComparison.InvariantCultureIgnoreCase));
















            //// int length = 20;
            //// int length1 = 10;
            //// 
            //// for (; length1 < length; length1++)
            //// {
            //// 
            ////     Console.WriteLine(length1);
            //// }







            ///// string strWhithTabs = "Model\tColor\tSpeed\tPet Name";
            ///// Console.WriteLine(strWhithTabs);
            ///// 
            ///// string strWhithTabs2 = "Evrevon loves \"Hello World\"";
            ///// Console.WriteLine(strWhithTabs2);
            ///// 
            ///// 
            ///// string strWhithTabs3 = @"C:\\Program Files (x86)\\""ATI Technologies""";
            ///// Console.WriteLine(@strWhithTabs3);
            ///// 
            ///// string strWhithTabs4 = "Finnish \r 12";
            ///// Console.WriteLine(strWhithTabs4);
            ///// 
            ///// 
            ///// string s1 = "Finnish12";
            ///// string s2 = "Finnish14";
            ///// Console.WriteLine("s1 == s2: {0}", s1 == s2);
            ///// Console.WriteLine("s1 == Finnish12: {0}", s1=="Finnish12");
            ///// Console.WriteLine("s1 == FINNISH12: {0}", s1 == "FINNISH12");
            ///// Console.WriteLine("s1 == finnish12: {0}", s1 == "finnish12");
            ///// Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            ///// Console.WriteLine("Finnish14.Equals(s2): {0}", "finnish14".Equals(s2));


        }

     








        /////// static void Main(string[] args)
        /////// {
        ///////     DateTime dt = DateTime.Now;
        ///////     Console.WriteLine("The date of mon and yeart {0} {1} {2}", dt.Year, dt.Month, dt.Day);
        ///////
        ///////     dt = dt.AddMonths(2);
        ///////     Console.WriteLine(dt);
        ///////
        ///////     TimeSpan ts = new TimeSpan(18, 30, 0);
        ///////     Console.WriteLine(ts);
        ///////
        ///////     Console.WriteLine(ts.Subtract(new TimeSpan (1,0,0)));
        ///////     Console.WriteLine(dt.);
        /////// }

    }
}
    ////   static void Main(string[] args)
    ////
    ////   {
    ////       
    ////
    ////       ParseFormattrue();
    ////   }
    ////
    ////   static void ParseFormattrue()
    ////   {
    ////       Console.WriteLine("=> Data type parseing with Tryparse:");
    ////       if (bool.TryParse("True", out bool b));
    ////       {
    ////           Console.WriteLine("value {0}", b);
    ////       }
    ////       
    ////       
    ////       
    ////       
    ////
    ////       string value = "22";
    ////       if (double.TryParse(value, out double d))
    ////       {
    ////           Console.WriteLine("value 2 good {0}", d);
    ////       }
    ////       else
    ////       {
    ////           Console.WriteLine("fail 2 {0}", value);
    ////       }
    ////   }
    ////


        ///// static void Main(string[] args)
        ///// {
        /////     var a = Convert.ToInt32(Console.ReadLine());
        ///// 
        /////     switch (a)
        /////     {
        /////         case 1:
        /////             Console.WriteLine("Вы ввели {0} неправильно", a);
        /////             break;
        /////         case 4:
        /////             Console.WriteLine("Вы ввели {0} правильно", a);
        /////             break;
        /////         default:
        ///// 
        /////             break;
        /////     }
        ///// 
        ///// 
        ///// }




        ///////static int Main(string[] args)
        ///////{
        ///////    Console.WriteLine("*****basic*****");
        ///////    GetUserData();
        ///////    Console.ReadLine();
        ///////
        ///////    return 0;
        ///////}
        ///////private static void GetUserData()
        ///////{
        ///////    Console.WriteLine("im9");
        ///////    var im9 = Console.ReadLine();
        ///////    Console.WriteLine("vozrast");
        ///////    var voz = Console.ReadLine();
        ///////    ConsoleColor background = Console.ForegroundColor;
        ///////    Console.ForegroundColor = ConsoleColor.Yellow;
        ///////    Console.WriteLine("HI {0} {1}", im9, voz);
        ///////
        ///////}

    

        /////static void ShowEnvironmentDetails()
        /////{
        /////    foreach (string drive in Environment.GetLogicalDrives())
        /////
        /////        Console.WriteLine("Drive: {0}", drive);
        /////        Console.WriteLine("OS: {0}", Environment.OSVersion);
        /////        Console.WriteLine("Number of process: {0}", Environment.ProcessorCount);
        /////        Console.WriteLine("Net Ver: {0}", Environment.Version);
        /////}
        /////
        /////static int Main (string[] args)
        /////{
        /////    ShowEnvironmentDetails();
        /////    Console.ReadLine();
        /////    return 0;

        //////-------------------------------------------------------------/////

        /////Environment.GetCommandLineArgs();
        /////string[] theArgs = Environment.GetCommandLineArgs();
        /////foreach (string arg in theArgs)
        /////Console.WriteLine("Arg: {0}", arg);
        /////Console.ReadLine();
        /////return 0;


        ////-----------------------------------------------------------------////

        ////for
        ///static int Main (string[] args)
        ////for (int i = 0; i < args.Length; i++)
        ////Console.WriteLine("Arg: {0}", args[i]);
        ////Console.WriteLine("Шалом");
        ////Console.ReadLine();
        ////return -1;

        ////-------------------------------------------------------------/////

        ///foreach
        ///////static int Main (string[] args)
        /// foreach (string a in args)
        /// {
        ///     Console.WriteLine("Arg: {0}", a);
        /// }
        /// return -1;
    
    

