using RealEstateWebProject.ModelBase.RealEstate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.Models.RealEstates
{
    public class Land :IRealEstate
    {
        public int Id { get; set; }
        public int SqPrice { get; set; }
        public string RealEstate { get; set; } = "land";
        public string ZoningStatus { get; set; }
        public int BlockNumber { get; set; }
        public int ParcelNumber { get; set; }
        public string ThreaderNumber { get; set; }
        public double LandToBuildingRatio { get; set; }
        public double HeightRestriction { get; set; }
        public LandStatus LandStatus { get; set; }
        public bool LandInExchangeForFlat { get; set; }
        public Guid Ad { get ; set ; }
        public DateTime AdDate { get ; set ; }
        public Condition Condition { get ; set ; }
        public string Type { get ; set ; }
        public int Sq { get ; set ; }
        public From From { get ; set ; }
        public EligibleForBankCredit EligibleForBankCredit { get ; set ; }
        public bool Exchangeable { get ; set ; }
        public Adress Adress { get ; set ; }

        public static Dictionary<int, Land> LandDb = new Dictionary<int, Land>();
        public int Id_Counter = 0;

        public Land()
        {
            Id_Counter++;
            this.Id = Id_Counter;
        }
    }
    public enum LandStatus
    {
        Allocation,
        DetachedParcel,
        JointTitleDeed,
        RighttoUseOwnership
    }
   
}
