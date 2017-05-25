using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalActivities.Model.DAO;

namespace AdditionalActivities.Controller
{
    public static class ModelMediator
    {
        public static bool CanSave(DatabaseObject obj)
        {
            if (obj.ShouldSave()) {
                //TODO: obj.GetSaveSqlCmd() and execute
                return true;
            }
            else
                return false;
        }
        
        public static DatabaseObject Create(Type objType)
        {
            if (typeof(DatabaseObject).IsAssignableFrom(objType))
                return (DatabaseObject)Activator.CreateInstance(objType);
            else
                return null;
        }

        public static List<DatabaseObject> ReadAll(Type objType)
        {
            if (!typeof(DatabaseObject).IsAssignableFrom(objType))
                return null;

            List<DatabaseObject> objs = new List<DatabaseObject>();

            //sqlCommand = Create(objType).GetAllSqlCmd();

            //TODO: setup SqlCommand

            //try catch finally

            //if(reader.HasRows)
            //  while (reader.Read())
            //      objs.Add(Create(objType).SetupFromDB(reader));

            return objs;
        }

        public static List<DatabaseObject> ReadChildren(DatabaseObject parent)
        {
            return null;//UNDONE: parent.GetChildrenSqlCmd();
        }

        public static void Delete(DatabaseObject obj)
        {
            //UNDONE: obj.GetDeleteSqlCmd();
        }
    }
}
