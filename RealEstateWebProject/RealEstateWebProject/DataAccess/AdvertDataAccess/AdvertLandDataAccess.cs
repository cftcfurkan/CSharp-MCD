using RealEstateWebProject.ModelBase;
using RealEstateWebProject.Models.Advert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.DataAccess.AdvertDataAccess
{
    public class AdvertLandDataAccess : IDatabase
    {
        static private AdvertLandDataAccess _methods { get; set; }
        public static AdvertLandDataAccess methods
        {
            get
            {
                if (_methods == null)
                    _methods = new AdvertLandDataAccess();
                return _methods;
            }
        }
        public int Create(object advertLandObj)
        {
            AdvertLand advertLand = (AdvertLand)advertLandObj;
            try
            {
                AdvertLand.AdvertLandDb.Add(advertLand.Id, advertLand);
                return advertLand.Id;
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
                AdvertLand.AdvertLandDb.Remove(id);
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
                return AdvertLand.AdvertLandDb[id];
            }
            catch (Exception)
            {
                return null;

            }
        }

        public List<object> List()
        {
            List<object> advertLands = new List<object>();
            foreach (int key in AdvertLand.AdvertLandDb.Keys)
            {
                advertLands.Add(AdvertLand.AdvertLandDb[key]);
            }
            return advertLands;
        }

        public bool Update(int id, object adr)
        {
            AdvertLand advertLand = (AdvertLand)adr;
            advertLand.Id = id;
            AdvertLand.AdvertLandDb[id] = advertLand;
            return true;
        }
    }
}
