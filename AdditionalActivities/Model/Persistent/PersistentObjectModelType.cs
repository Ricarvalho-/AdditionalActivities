using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    public class PersistentObjectModelType
    {
        List<ActionType> actions;
        List<Property> properties;
        ModelType type;

        public PersistentObjectModelType(List<ActionType> actions, List<Property> properties, ModelType type)
        {
            this.actions = actions;
            this.properties = properties;
            this.type = type;
        }

        public List<ActionType> Actions
        {
            get
            {
                return actions;
            }
        }

        public List<Property> Properties
        {
            get
            {
                return properties;
            }
        }

        public ModelType Type
        {
            get
            {
                return type;
            }
        }
    }

    public class ActionType
    {
        string label;
        Action action;

        public ActionType(string label, Action action)
        {
            this.label = label;
            this.action = action;
        }

        public string Label
        {
            get
            {
                return label;
            }
        }

        public Action Action
        {
            get
            {
                return action;
            }
        }
    }

    public class Property
    {
        string label;
        string persistentPropName;
        PropertyType type;

        public Property(string label, string persistentPropName, PropertyType type)
        {
            this.label = label;
            this.persistentPropName = persistentPropName;
            this.type = type;
        }

        public string Label
        {
            get
            {
                return label;
            }
        }

        public string PersistentPropName
        {
            get
            {
                return persistentPropName;
            }
        }

        public PropertyType Type
        {
            get
            {
                return type;
            }
        }

        public enum PropertyType
        {
            Numeric,
            Textual
        }
    }

    public enum ModelType
    {
        Activity,
        ActivityCategory,
        ActivityItem,
        ActivityPortfolio,
        Rule,
        Student
    }
}
