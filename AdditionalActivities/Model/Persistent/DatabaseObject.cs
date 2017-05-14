using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    public abstract class DatabaseObject
    {
        public List<ActionType> Actions { get; protected set; }
        public List<Property> Properties { get; protected set; }
        protected List<FieldModel> fields;
        protected List<FieldModel> editingFields;
        
        public abstract FieldModel GetTitle(bool editingMode);
        public abstract FieldModel GetSubtitle(bool editingMode);
        public abstract List<DatabaseObject> ReadChildren();
        public abstract DatabaseObject SetupFromDB(/*param*/);//TBD
        public abstract bool IsParent();
        public abstract bool CouldSave();
        public abstract void Delete();

        public List<FieldModel> GetFields(bool editingMode)
        {
            return editingMode ? editingFields : fields;
        }
    }

    //MuiltiItemOperations
    public class ActionType
    {
        public string Label { get; private set; }
        public Action Action { get; private set; }

        public ActionType(string label, Action action)
        {
            Label = label;
            Action = action;
        }

        public void ActionHandler(object sender, EventArgs e)
        {
            Action();
        }

        public override string ToString()
        {
            return Label;
        }
    }

    //Filter/Order Props
    public class Property
    {
        public string Label { get; private set; }
        public string PersistentPropName { get; private set; }
        public PropertyType Type { get; private set; }

        public Property(string label, string persistentPropName, PropertyType type)
        {
            Label = label;
            PersistentPropName = persistentPropName;
            Type = type;
        }

        public enum PropertyType
        {
            Numeric,
            Textual
        }
    }
}
