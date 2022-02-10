using RealEstateWebProject.ModelBase.RealEstate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.Models.RealEstates
{
    class Commercial : IRealEstate, IBuilding
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public Guid Ad { get; set; }
        public DateTime AdDate { get; set; }
        public Condition Condition { get; set; }
        public string Type { get; set; }
        public int Sq { get; set; }
        public From From { get; set; }
        public EligibleForBankCredit EligibleForBankCredit { get; set; }
        public bool Exchangeable { get; set; }
        public Adress Adress { get; set; }
        public int SqNet { get; set; }
        public string NumberOfRooms { get; set; }
        public string AgeOfBuilding { get; set; }
        public Heating Heating { get; set; }
        public UserStatus UserStatus { get; set; }
        public string ApartmentComplexName { get; set; }
        public string Dues { get; set; }

        public static Dictionary<int, Commercial> CommercialDb = new Dictionary<int, Commercial>();
        public int Id_Counter = 0;

        public Commercial()
        {
            Id_Counter++;
            this.Id = Id_Counter;
        }

    }
}
