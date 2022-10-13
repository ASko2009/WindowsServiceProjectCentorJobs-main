using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsServiceProjectCentorJobs;

namespace Documents
{


    class RequestDocumentsIN
    {
        public int quantityError = 0;
        public string fail = null;

        
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


        ///добавить обработку для денег
        ///Возможно реализовать простые геттеры сетторы под поля а после проверять на заполненность данными перебором массива переменных
        ///

        public void SetDataForRequest(string inData, ref string fieldInData, Boolean checkLength, int maxLength = 0, int minLength = 0)
        {
            string inDataTrim = inData.Trim();
            if (string.IsNullOrEmpty(inDataTrim))
            {
                fail +=  "Поле пустое ";
                quantityError++;
                fieldInData = null;
            }
            else
            {
                if (checkLength)
                {
                    if (!(inDataTrim.Length > maxLength && inDataTrim.Length < minLength))
                    {

                        fail += (nameof(fieldInData) + " Ошибка длинны поля MaxLength/MinLength ");
                        quantityError++;
                        fieldInData = null;
                    }

                    else
                    {
                        try
                        { 
                            fieldInData = inDataTrim; 
                        }
                        
                        catch
                        {
                            fail += "Ошибка на этапе присвоения поля";
                            quantityError++;
                            fieldInData = null;
                        }
                 
                        
                    }
                }
                else
                {
                    try
                    {
                        fieldInData = inDataTrim;
                    }

                    catch
                    {
                        fail += "Ошибка на этапе присвоения поля";
                        quantityError++;
                        fieldInData = null;
                    }
                }
            }
        }
    }

    ///RequestDocumentsIN documents = new RequestDocumentsIN();
    ///documents.SetDataForRequest(inData: datas, fieldinData: ref documents.numberExecutiveDocument, true, MaxLength: 40, MinLength: 40);
    ///documents.SetDataForRequest(inData: datas, fieldinData: ref documents.identifierFSSP, true, MaxLength: 20, MinLength: 20);
    ///documents.SetDataForRequest(inData: datas, fieldinData: ref documents.debtorFullName, true, MaxLength: 24, MinLength: 24);


    class ResolutionOnRecoveryDocuments
    {

    }
    class CancellationResolutionOnRecoveryDocuments
    {

    }
    class ArrestAndRecoveryDocuments
    { 
    
    }
    class CancellationArrestAndRecoveryDocuments
    {

    }
    class ArrestDocuments
    {

    }
    class CancellationArrestDocuments
    { 
    
    
    }
}
