using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.DAO
{
    interface IDAO<T>
    {
        void Save(T obj);
        void Delete(T obj);
        T Read(int id);
        List<T> GetAll();
        List<T> GetByParentID(int id);
    }
}
