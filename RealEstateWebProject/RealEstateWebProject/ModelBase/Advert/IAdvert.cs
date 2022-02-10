using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.ModelBase.Advert
{
    interface IAdvert
    {
        string AdTitle { get; set; }
        int Sq { get; set; }
        string Price { get; set; }
        Guid Ad { get; set; }
        int Id { get; set; }
        DateTime AdDate { get; set; }
        string CityTown { get; set; }
    }
}
