using RealEstateWebProject.ModelBase;
using RealEstateWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.DataAccess
{
    public class UserDataAccess : IDatabase
    {
        static private UserDataAccess _methods { get; set; }
        public static UserDataAccess methods
        {
            get
            {
                if (_methods == null)
                    _methods = new UserDataAccess();
                return _methods;
            }
        }
        public int Create(object UserObj)
        {
            User user = (User)UserObj;
            try
            {
                User.UserDb.Add(user.UserId, user);
                return user.UserId;
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
                User.UserDb.Remove(id);
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
                return User.UserDb[id];
            }
            catch (Exception)
            {
                return null;

            }
        }

        public List<object> List()
        {
            List<object> Users = new List<object>();
            foreach (int key in User.UserDb.Keys)
            {
                Users.Add(User.UserDb[key]);
            }
            return Users;
        }

        public bool Update(int id, object us)
        {
            User user = (User)us;
            user.UserId = id;
            User.UserDb[id] = user;
            return true;
        }
    }
}
