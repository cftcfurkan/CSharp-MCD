using RealEstateWebProject.ModelBase;
using RealEstateWebProject.Models.Advert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.DataAccess.AdvertDataAccess
{
    public class AdvertResidentialDataAccess: IDatabase
    {
        static private AdvertResidentialDataAccess _methods { get; set; }
        public static AdvertResidentialDataAccess methods
        {
            get
            {
                if (_methods == null)
                    _methods = new AdvertResidentialDataAccess();
                return _methods;
            }
        }
        public int Create(object advertResidentialObj)
        {
            AdvertResidential advertResidential = (AdvertResidential)advertResidentialObj;
            try
            {
                AdvertResidential.AdvertResidentialDb.Add(advertResidential.Id, advertResidential);
                return advertResidential.Id;
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
                AdvertResidential.AdvertResidentialDb.Remove(id);
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
                return AdvertResidential.AdvertResidentialDb[id];
            }
            catch (Exception)
            {
                return null;

            }
        }

        public List<object> List()
        {
            List<object> advertResidentials = new List<object>();
            foreach (int key in AdvertResidential.AdvertResidentialDb.Keys)
            {
                advertResidentials.Add(AdvertResidential.AdvertResidentialDb[key]);
            }
            return advertResidentials;
        }

        public bool Update(int id, object adr)
        {
            AdvertResidential advertResidential = (AdvertResidential)adr;
            advertResidential.Id = id;
            AdvertResidential.AdvertResidentialDb[id] = advertResidential;
            return true;
        }
    }
}
