using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.Models
{
    public class Adress
    {
        public static Dictionary<int, Adress> AdressDb = new Dictionary<int, Adress>();
        public int Id_Counter = 0;
        public int AdressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public Adress()
        {
            Id_Counter++;
            this.AdressId = Id_Counter;
        }
    }
}
