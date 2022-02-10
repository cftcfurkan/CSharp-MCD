using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.ModelBase
{
    interface IDatabase
    {
        int Create(object nesne);
        bool Delete(int id);
        bool Update(int id, object nesne);
        object GetById(int id);

        List<Object> List();
    }
}
