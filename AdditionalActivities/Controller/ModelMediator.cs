using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalActivities.Model.Persistent;

namespace AdditionalActivities.Controller
{
    public static class ModelMediator
    {
        public static bool CanSave(DatabaseObject obj)
        {
            return obj.CouldSave();
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

            while(false)//TODO: db.nextLine()
                objs.Add(Create(objType).SetupFromDB(/*param*/));//TBD

            return objs;
        }

        public static List<DatabaseObject> ReadChildren(DatabaseObject parent)
        {
            return parent.ReadChildren();//TBD
        }

        public static void Delete(DatabaseObject obj)
        {
            obj.Delete();
        }
    }
}
