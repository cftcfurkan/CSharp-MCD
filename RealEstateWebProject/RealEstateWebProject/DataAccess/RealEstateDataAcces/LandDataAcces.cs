using RealEstateWebProject.ModelBase;
using RealEstateWebProject.Models.RealEstates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.DataAccess.RealEstateDataAcces
{
    public class LandDataAcces :IDatabase

    {
        static private LandDataAcces _methods { get; set; }
        public static LandDataAcces methods
        {
            get
            {
                if (_methods == null)
                    _methods = new LandDataAcces();
                return _methods;
            }
        }
        public int Create(Object lan)
        {
            Land land = (Land)lan;
            try
            {
                Land.LandDb.Add(land.Id, land);
                return land.Id;
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
                Land.LandDb.Remove(id);
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
                Land lan = Land.LandDb[id];
                return lan;
            }
            catch
            {
                return -1;
            }
        }

        public List<object> List()
        {
            List<object> lands = new List<object>();
            foreach (int key in Land.LandDb.Keys)
            {//TODO :Add yazdıktan sonra kontrol edilmedi.
                lands.Add(Land.LandDb[key]);
            }
            return lands;
        }
        public bool Update(int id,Object com)
        {
            return true;
           
        }
    }
}
