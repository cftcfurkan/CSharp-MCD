using RealEstateWebProject.ModelBase;
using RealEstateWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.DataAccess
{
    class AdressDataAccess : IDatabase
    {
        static private AdressDataAccess _methods { get; set; }
        public static AdressDataAccess methods
        {
            get
            {
                if (_methods == null)
                    _methods = new AdressDataAccess();
                return _methods;
            }
        }
        public int Create(object adressObj)
        {
            Adress adress = (Adress)adressObj;
            try
            {
                Adress.AdressDb.Add(adress.AdressId, adress);
                return adress.AdressId;
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
                Adress.AdressDb.Remove(id);
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
                return Adress.AdressDb[id];
            }
            catch (Exception)
            {
                return null;

            }
        }

        public List<object> List()
        {
            List<object> adresses = new List<object>();
            foreach (int key in Adress.AdressDb.Keys)
            {
                adresses.Add(Adress.AdressDb[key]);
            }
            return adresses;
        }

        public bool Update(int id,object adr)
        {
            Adress adress = (Adress)adr;
            adress.AdressId = id;
            Adress.AdressDb[id] = adress;
            return true;
        }
    }
}
