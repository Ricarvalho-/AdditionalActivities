using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    public abstract class DatabaseObject
    {
        public abstract bool IsParent { get; }
        public abstract List<ActionType> Actions { get; }
        public abstract List<Property> Properties { get; }
        protected abstract List<FieldModel> Fields { get; }
        protected abstract List<FieldModel> EditingFields { get; }

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
            return editingMode ? EditingFields : Fields;
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
