using System;
using RealEstateWebProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.ModelBase.RealEstate
{
    interface IRealEstate
    {
        int Id { get; set; }
        Guid Ad { get; set; }
        DateTime AdDate { get; set; }
        Condition Condition { get; set; }
        string Type { get; set; }
        int Sq { get; set; }
        From From { get; set; }
        EligibleForBankCredit EligibleForBankCredit { get; set; }
        bool Exchangeable { get; set; }
        Adress Adress { get; set; }

    }
    public enum Condition
    {
        ForSale,
        ForRent
    } 
    public enum From
    {
        Owner,
        RealEstateAgency,
        Bank,
        Developer
    }
    public enum EligibleForBankCredit
    {
        Yes,
        No,
        Unknown
    }
    

}
