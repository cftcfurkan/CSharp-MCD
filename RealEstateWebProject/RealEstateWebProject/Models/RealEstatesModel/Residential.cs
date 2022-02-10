using RealEstateWebProject.ModelBase.RealEstate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.Models.RealEstates
{
    class Residential :IRealEstate, IBuilding
    {
        public int Id { get; set; }
        public int NumberOfBathrooms { get; set; }
        public bool Furnished { get; set; }
        public bool Balcony { get; set; }
        public bool WithinABuildingComplex { get; set; }
        public TitleDeedStatus TitleDeedStatus { get; set; }
        public bool AvailableForViewingWithVideoCall { get; set; }
        public Guid Ad { get; set; }
        public DateTime AdDate { get; set; }
        public Condition Condition { get; set; }
        public string Type { get; set; }
        public int Sq { get; set; }
        public From From { get; set; }
        public EligibleForBankCredit EligibleForBankCredit { get; set; }
        public bool Exchangeable { get; set; }
        public Adress Adress { get; set; }
        public int SqNet { get ; set ; }
        public string NumberOfRooms { get ; set ; }
        public string AgeOfBuilding { get ; set ; }
        public Heating Heating { get ; set ; }
        public UserStatus UserStatus { get ; set ; }
        public string ApartmentComplexName { get ; set ; }
        public string Dues { get ; set ; }

        public static Dictionary<int, Residential> ResidentialDb = new Dictionary<int, Residential>();
        public int Id_Counter = 0;

        public Residential()
        {
            Id_Counter++;
            this.Id = Id_Counter;
        }
    }
    
    public enum TitleDeedStatus
    {
        Commonhold,
        FloorEasement,
        JointOwned,
        LandTitle,
        Unknown
    }
   
}
