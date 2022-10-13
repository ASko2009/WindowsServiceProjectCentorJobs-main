using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Documents
{


    class RequestDocumentsIN
    {
        
        public string ErorrList = null;

        public string guidFSSP;
        public string numberExecutiveDocument;
        /// стринговое значение ограниченное 60 знаками
        public string identifierFSSP;
        /// числовой идентификтор, без ограничения
        public string debtorFullName;
        /// Стринговое значение без ограничений по длине с нормализацией по UPPER
        public string debtorAdress;
        /// Стринговое значение без ограничений по длине с нормализацией по UPPER
        public string debtorINN;
        /// текстовый идентификатор, огрниченный длинной поля 10 знаков;
        public string debtorKPP;
        /// текстовый идентификтор, огрниченный длинной поля 9 знаков;
        public string debtorType;
        /// числовой идентификтор, огрниченный длинной поля 1 знак;
        public string debtorScore;
        /// стринговое значение ограниченное 20 знаковж
        public string bankName;
        /// стринговое значение с нормализацией текста 
        public string targetBankINN;
        /// текстовый идентификатор, огрниченный длинной поля 10 знаков;
        public string targetBankKPP;
        /// текстовый идентификатор, огрниченный длинной поля 9 знаков;
        public string bailiffName;
        /// текстовый идентификатор, без ограничения;
        public string bailiffAdress;
        /// текстовый идентификатор, без ограничения;
        public string departmentBailiffINN;
        /// текстовый идентификатор, огрниченный длинной поля 10 знаков;
        public string departmentBailiffKPP;
        /// текстовый идентификатор, огрниченный длинной поля 9 знаков;
        public string textOriginal;


        public bool CheckingFullnessDocument()
        {
            if (string.IsNullOrWhiteSpace(guidFSSP) ||
                string.IsNullOrWhiteSpace(numberExecutiveDocument) ||
                string.IsNullOrWhiteSpace(identifierFSSP) ||
                string.IsNullOrWhiteSpace(debtorFullName) ||
                string.IsNullOrWhiteSpace(debtorAdress) ||
                string.IsNullOrWhiteSpace(debtorINN) ||
                string.IsNullOrWhiteSpace(debtorKPP) ||
                string.IsNullOrWhiteSpace(debtorType) ||
                string.IsNullOrWhiteSpace(bankName) ||
                string.IsNullOrWhiteSpace(targetBankINN) ||
                string.IsNullOrWhiteSpace(targetBankKPP) ||
                string.IsNullOrWhiteSpace(bailiffName) ||
                string.IsNullOrWhiteSpace(bailiffAdress) ||
                string.IsNullOrWhiteSpace(departmentBailiffINN) ||
                string.IsNullOrWhiteSpace(departmentBailiffKPP) ||
                string.IsNullOrWhiteSpace(textOriginal))
                return true;

            else
             return false;
               
        }
        
        
         public string NameZeroElement()
         {

           List<string> nameZero = new List<string>();
            nameZero.Add("GUIDFSSP:" + guidFSSP.ToString());


           if (string.IsNullOrWhiteSpace(numberExecutiveDocument))
               nameZero.Add ("numberExecutiveDocument is fail,");

           if (string.IsNullOrWhiteSpace(identifierFSSP))
               nameZero.Add("identifierFSSP is fail,");

           if (string.IsNullOrWhiteSpace(debtorFullName))
               nameZero.Add("debtorFullName is fail,");

           if (string.IsNullOrWhiteSpace(debtorAdress))
               nameZero.Add("debtorAdress is fail,");

           if (string.IsNullOrWhiteSpace(debtorINN))
               nameZero.Add("debtorINN is fail,");

           if (string.IsNullOrWhiteSpace(debtorKPP))
               nameZero.Add("debtorKPP is fail,");

           if (string.IsNullOrWhiteSpace(debtorType))
               nameZero.Add("debtorType is fail,");

           if (string.IsNullOrWhiteSpace(bankName))
               nameZero.Add("debtorType is fail,");

           if (string.IsNullOrWhiteSpace(targetBankINN))
               nameZero.Add("targetBankINN is fail,");

           if (string.IsNullOrWhiteSpace(targetBankKPP))
               nameZero.Add("targetBankKPP is fail,");

           if (string.IsNullOrWhiteSpace(bailiffName))
               nameZero.Add("bailiffName is fail,");

           if (string.IsNullOrWhiteSpace(bailiffAdress))
               nameZero.Add("bailiffAdress is fail,");

           if (string.IsNullOrWhiteSpace(departmentBailiffINN))
               nameZero.Add("departmentBailiffINN is fail,");

           if (string.IsNullOrWhiteSpace(departmentBailiffKPP))
               nameZero.Add("departmentBailiffKPP is fail,");

           if (string.IsNullOrWhiteSpace(textOriginal))
               nameZero.Add("textOriginal is fail,");

           return string.Join(",", nameZero);

         }



    }
}
