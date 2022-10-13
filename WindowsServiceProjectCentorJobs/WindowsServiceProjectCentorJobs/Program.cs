using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Documents;
using System.Xml;
using WindowsServiceProjectCentorJobs;

namespace WindowsServiceProjectCentorJobs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Console.ReadLine();
            XMLQwery qw = new XMLQwery();
            qw.ParseQweryFSSPXML(@"G:\проект\Сервис\Новый1.xml");

            ////ServiceBase[] ServicesToRun;
            ////ServicesToRun = new ServiceBase[]
            ////{
            ////    new Service1()
            ////};
            ////ServiceBase.Run(ServicesToRun);











            ///XmlDocument xml = new XmlDocument();
            ///xml.Load(@"G:\проект\Сервис\Новый1.xml");
            ///XmlElement element = xml.DocumentElement;
            ///foreach (XmlNode xnope in element)
            ///{
            ///    if (xnope.Attributes.Count > 0)
            ///    {
            ///        XmlNode attr = xnope.Attributes.GetNamedItem("Type");
            ///        if (attr != null)
            ///            Console.WriteLine(attr.Value);
            ///    }
            ///    foreach (XmlNode childnode in xnope.ChildNodes)
            ///    {
            ///        if (childnode.Name == "numberExecutiveDocument")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "identifierFSSP")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "debtorFullName")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "debtorAdress")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "debtorINN")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "debtorKPP")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "debtorType")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "debtorScore")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "bankName")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "targetBankINN")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "targetBankKPP")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "bailiffName")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "bailiffAdress")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "departmentBailiffINN")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "departmentBailiffKPP")
            ///            Console.WriteLine(childnode.InnerText);
            ///        if (childnode.Name == "textOriginal")
            ///            Console.WriteLine(childnode.InnerText);
            ///    }
            ///    Console.WriteLine();
            ///}


        }
    }
}









////Первичная обработка, взять вошедший xml и распарсит его по первым таблицам
///
/// ЗАПРОСЫ
///-Взять документ с 0 статусом, произвести его первичную обработку:
///-Опеределить тип вошедшего документа,
///-Проверить xsd схему по типу;
///-создать дочернее сообщение со статусом 1, 
///-распарсить документ исходя из его типа (создать таблицу соответсвий, создать задания по каждому лицу в отдельности со статсусом 0), 
///-По окончанию распарсивания завершить транзацкию и поменять статус дочернего сообщения на 2.
///
/// Вторичная обработка.
/// 
/// Взять документ со статусом 2, поменять статус на 3.
/// 
/// -запросить данные по счетам (сформировать MQ запросы в другие АБС).
/// -после формирования запроса поменять статус задания на 1. 
/// По окончанию формировнаия сообщений MQ первести дочернее сообщение в статус 31 
/// 
/// Обработка результатов ответов
/// 
/// Взять документ со статусом 31, перевести статус на 4
/// Запросить из таблицы ответов данные по ответному сообщению из АБС.
/// Проверить ответ на xsd схему,
/// распарсить ответ в промежуточную таблицу с явной привзякой задания 
/// поменять статус задания на 2,
/// проверить все задания на статусы,
/// Если все задания со статусом 2, то сформировать ответ используя данные из промежуточной таблицы, поменять статус дочернегог на 41.
/// Если не все задания в статусе 2, то сдвинуть  время исполнения на час и вренуть статус дочернего на 31.

/// ПОСТАНОВЛЕНИЯ 
/// 
///-Взять документ с 0 статусом, произвести его первичную обработку:
///-Опеределить тип вошедшего документа,
///-Проверить xsd схему по типу;
///-создать дочернее сообщение со статусом 1, 
///-распарсить документ в промежуточную таблицу с данными из постановления ФИО или Наименование организации, требования, ИНН,
///-Создать задание  из промежуточной таблицы, присвоить статус 0
///-Поменять статус дочернего на статус 2
///
/// 
/// ВТОРИЧНАЯ ОБРАБОТКА
/// 
/// -Взять данные из промежуточной таблицы на их основе сформировать запрос, 
/// -запросить данные по счетам (сформировать MQ запрос в другие АБС с признаками типа запроса и данными по должнику).
/// -после формирования MQ сообщения поменять статус заданий на 1. 
/// -По окончанию формировнаия сообщений MQ первести дочернее сообщение в статус 31,
/// 
/// ТРЕТИЙ этап обработки.
/// -Поменять статус дочернего сообщения в 32
/// -проверить ответы на xsd схему,
/// -Проверить все ли ответы поступили от АБС, если ответы поступили от всех систем поменять статус задания на 2,
/// -Прочитать все ответы от смежных систем и заполнить промежуточную таблицу данными.
/// -Сформировать задания по каждому найденому счету со статусом 0. 
/// Если не все ответы поступили от систем, то поменять статус сообщения на 31 и повторно обратить к обработке позже
/// 
/// ЧЕТВЕРТЫЙ ЭТАП
/// Поменять статус дочернего на 4
/// -Исходя из сформированных заданий сформировать первичный MQ запросы на исполнение постановления в смежные системы где найдены счета и остаток по счету не 0,
/// -Поменять статус заданий на 1 где было сформировано MQ сообщщение.
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
///
///
/// 
/// определить тип вошедшего документа создать дочернее сообщение,
///Распарсить данные исходя из типа вощедшего документа, присвоить необходимые признаки документов
///разбить документ на укзанных лиц в документе

