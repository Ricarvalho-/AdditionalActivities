using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    public abstract class DatabaseObject
    {
        public abstract bool ShouldSave();
        //TODO: setup database
        //public abstract SqlCommand GetAllSqlCmd();
        //public abstract SqlCommand GetDeleteSqlCmd();
        //public abstract SqlCommand GetChildrenSqlCmd();
        //public abstract SqlCommand GetSaveSqlCmd();
        //public abstract DatabaseObject SetupWithDataReader(SqlDataReader reader);
    }
}
