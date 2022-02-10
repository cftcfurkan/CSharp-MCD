using RealEstateWebProject.ModelBase.Advert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.Models.Advert
{
    public class AdvertLand:IAdvert
    {
        public string AdTitle { get; set; }
        public int Sq { get; set; }
        public int SqPrice { get; set; }
        public string Price { get; set; }    
        public DateTime AdDate { get; set; }
        public string CityTown { get; set; }
        public Guid Ad { get ; set ; }
        public int Id { get ; set ; }

        public static Dictionary<int, AdvertLand> AdvertLandDb = new Dictionary<int, AdvertLand>();
        public int Id_Counter = 0;
        public AdvertLand()
        {
            Id_Counter++;
            this.Id = Id_Counter;
        }

    }
}
