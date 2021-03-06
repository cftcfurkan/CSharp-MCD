using RealEstateWebProject.ModelBase.Advert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.Models.Advert
{
    public class AdvertResidential : IAdvert
    {
        public int Id { get; set; }
        public Guid Ad { get; set; }
        public string AdTitle { get ; set ; }
        public int Sq { get ; set ; }
        public string Price { get ; set ; }
        public DateTime AdDate { get ; set ; }
        public string CityTown { get ; set ; }
        public string NumberOfRooms { get; set; }

        public static Dictionary<int, AdvertResidential> AdvertResidentialDb = new Dictionary<int, AdvertResidential>();
        public int Id_Counter = 0;

        public AdvertResidential()
        {
            Id_Counter++;
            this.Id = Id_Counter;
        }

    }
    
}
