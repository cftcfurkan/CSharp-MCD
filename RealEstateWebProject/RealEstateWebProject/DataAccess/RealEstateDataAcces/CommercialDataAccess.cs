using RealEstateWebProject.ModelBase;
using RealEstateWebProject.Models.RealEstates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RealEstateWebProject.DataAccess.RealEstateDataAcces
{
    public class CommercialDataAccess : IDatabase
    {

        static private CommercialDataAccess _methods { get; set; }
        public static CommercialDataAccess methods
        {
            get
            {
                if (_methods == null)
                    _methods = new CommercialDataAccess();
                return _methods;
            }
        }
        public int Create(Object com)
        {
            Commercial commercial = (Commercial)com;
            try
            {
                Commercial.CommercialDb.Add(commercial.Id, commercial);
                return commercial.Id;
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
                Commercial.CommercialDb.Remove(id);
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
                Commercial obj = Commercial.CommercialDb[id];
                return obj;
            }
            catch
            {
                return -1;
            }
        }

        public List<object> List()
        {
            List<object> commercials = new List<object>();
            foreach (int key in Commercial.CommercialDb.Keys)
            {//TODO :Add yazdıktan sonra kontrol edilmedi.
                commercials.Add(Commercial.CommercialDb[key]);
            }
            return commercials;
        }
        public bool Update(int id, Object com)
        {
            return true;

        }
    }
}
