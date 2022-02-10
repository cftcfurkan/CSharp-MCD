using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.Models
{
    public class User
    {
        public static Dictionary<int, User> UserDb = new Dictionary<int, User>();
        
        public int Id_Counter = 0;
        public int UserId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Telephone { get; set; }

        public User()
        {
            Id_Counter++;
            this.UserId = Id_Counter;
        }
    }
}
