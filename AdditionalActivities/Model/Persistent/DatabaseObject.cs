using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    public abstract class DatabaseObject
    {
        protected List<ActionType> actions = new List<ActionType>();
        protected List<Property> properties = new List<Property>();
        protected List<FieldModel> fields = new List<FieldModel>();
        protected List<FieldModel> editingFields = new List<FieldModel>();

        public List<ActionType> Actions { get { return actions; } }
        public List<Property> Properties { get { return properties; } }
        public abstract bool IsParent { get; }

        public abstract override string ToString();
        public abstract FieldModel GetTitle(bool editingMode);
        public abstract FieldModel GetSubtitle(bool editingMode);
        public abstract bool ShouldSave();
        //TODO: setup database
        //public abstract SqlCommand GetAllSqlCmd();
        //public abstract SqlCommand GetDeleteSqlCmd();
        //public abstract SqlCommand GetChildrenSqlCmd();
        //public abstract SqlCommand GetSaveSqlCmd();
        //public abstract DatabaseObject SetupWithDataReader(SqlDataReader reader);


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
            Textual,
            Date,
            Boolean
        }
    }
}
