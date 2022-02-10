using RealEstateWebProject.ModelBase;
using RealEstateWebProject.Models.Advert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.DataAccess.AdvertDataAccess
{
    public class AdvertCommercialDataAccess:IDatabase
    {
        static private AdvertCommercialDataAccess _methods { get; set; }
        public static AdvertCommercialDataAccess methods
        {
            get
            {
                if (_methods == null)
                    _methods = new AdvertCommercialDataAccess();
                return _methods;
            }
        }
        public int Create(object advertCommercialObj)
        {
            AdvertCommercial advertCommercial = (AdvertCommercial)advertCommercialObj;
            try
            {
                AdvertCommercial.AdvertCommercialDb.Add(advertCommercial.Id, advertCommercial);
                return advertCommercial.Id;
            }
            catch
            {
                return -1;
            }

        }

        public bool Delete(int id)
        {
            try
            {
                AdvertCommercial.AdvertCommercialDb.Remove(id);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public object GetById(int id)
        {
            try
            {
                return AdvertCommercial.AdvertCommercialDb[id];
            }
            catch (Exception)
            {
                return null;

            }
        }

        public List<object> List()
        {
            List<object> advertCommercials = new List<object>();
            foreach (int key in AdvertCommercial.AdvertCommercialDb.Keys)
            {
                advertCommercials.Add(AdvertCommercial.AdvertCommercialDb[key]);
            }
            return advertCommercials;
        }

        public bool Update(int id, object adr)
        {
            AdvertCommercial advertCommercial = (AdvertCommercial)adr;
            advertCommercial.Id = id;
            AdvertCommercial.AdvertCommercialDb[id] = advertCommercial;
            return true;
        }
    }
}
