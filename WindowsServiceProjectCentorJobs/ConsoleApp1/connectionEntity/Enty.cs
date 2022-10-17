using Documents;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp1.connectionEntity
{
    public class Enty
    {

        [Key]
        public Int64 ID { get; set; }
        public Int64 IDCentr { get; set; }
        public string FSSPType { get; set; }
        public string FSSPGUID { get; set; }
        public int StateJob { get; set; }
        public DateTime DateINStart { get; set; }
        public int InWork { get; set; }
        public DateTime LastСhange { get; set; }
        public string debtorFullName { get; set; }
        public string debtorAdress { get; set; }
        public string debtorINN { get; set; }
        public string debtorKPP { get; set; }
        public string debtorType { get; set; }
        public string debtorScore { get; set; }
        public string targetBankINN { get; set; }
        public string bankName { get; set; }
        public string targetBankKPP { get; set; }
        public string bailiffName { get; set; }
        public string bailiffAdress { get; set; }
        public string departmentBailiffINN { get; set; }
        public string departmentBailiffKPP { get; set; }
        public string textOriginal { get; set; }
        public string ErorrList { get; set; }
        public DateTime NextStart { get; set; }

        public void InsertBdQweryState0(RequestDocumentsIN doc, int state, Int64 idCentr)
        {
            IDCentr = idCentr;
            FSSPType = doc.FSSPType;
            FSSPGUID = doc.guidFSSP;
            StateJob = state;
            DateINStart = DateTime.Now;
            InWork = 0;
            LastСhange = DateTime.Now;
            NextStart = DateTime.Now.AddMinutes(30);
            debtorFullName = doc.debtorFullName;
            debtorAdress = doc.debtorAdress;
            debtorINN = doc.debtorINN;
            debtorKPP = doc.debtorKPP;
            debtorType = doc.debtorType;
            debtorScore = doc.debtorScore;
            targetBankINN = doc.targetBankINN;
            bankName = doc.bankName;
            targetBankKPP = doc.targetBankKPP;
            bailiffName = doc.bailiffName;
            bailiffAdress = doc.bailiffAdress;
            departmentBailiffINN = doc.departmentBailiffINN;
            departmentBailiffKPP = doc.departmentBailiffKPP;
            textOriginal = doc.textOriginal;
            ErorrList = doc.ErorrList;
        }



    }

    public class NutshellContext : DbContext
    {

        public DbSet<Enty> JobsQwery { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.CONFIGData["ConnectionString1"]);
            ///"Server =DESKTOP-IVGI18B\\SQLEXPRESS; Database =TestFSSP; Trusted_Connection=True;");
        }


    }

    public class GetDocinBDstate0
    {
        public XElement xmlDocs;
        public int numberOfThreads;



    }

}
