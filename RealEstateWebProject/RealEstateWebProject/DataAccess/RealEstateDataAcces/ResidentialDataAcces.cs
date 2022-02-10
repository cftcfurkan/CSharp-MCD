using System;
using RealEstateWebProject.ModelBase;
using RealEstateWebProject.Models.RealEstates;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.DataAccess.RealEstateDataAcces
{
    public class ResidentialDataAcces :IDatabase
    {
        static private ResidentialDataAcces _methods { get; set; }
        public static ResidentialDataAcces methods
        {
            get
            {
                if (_methods == null)
                    _methods = new ResidentialDataAcces();
                return _methods;
            }
        }
        public int Create(Object res)
        {
            Land residential = (Land)res;
            try
            {
                Land.LandDb.Add(residential.Id, residential);
                return residential.Id;
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
                Residential.ResidentialDb.Remove(id);
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
                Residential residential = Residential.ResidentialDb[id];
                return residential;
            }
            catch
            {
                return -1;
            }
        }
        public List<object> List()
        {
            List<object> residentials = new List<object>();
            foreach (int key in Residential.ResidentialDb.Keys)
            {//TODO :Add yazdıktan sonra kontrol edilmedi.
                residentials.Add(Residential.ResidentialDb[key]);
            }
            return residentials;
        }
        public bool Update(int id ,Object lan)
        {
            return true;
        }
    }
}
