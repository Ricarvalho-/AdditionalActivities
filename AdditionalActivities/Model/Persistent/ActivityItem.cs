using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.Model.Persistent
{
    class ActivityItem : DatabaseObject
    {
        public int Id { get; set; }
        public int ScheduledHours { get; set; }
        public int DeferredHours { get; set; }
        public string Title { get; set; }
        public string Observation { get; set; }
        public bool Approved { get; set; }
        public Activity Activity { get; set; }
        public ActivityPortfolio Portfolio { get; set; }

        public ActivityItem()
        {
            actions = new List<ActionType> { };
            properties = new List<Property> {
                new Property(Resources.ResourceManager.GetString("title"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("obs"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("schedHours"), null, Property.PropertyType.Numeric),
                new Property(Resources.ResourceManager.GetString("defHours"), null, Property.PropertyType.Numeric),
                new Property(Resources.ResourceManager.GetString("approvation"), null, Property.PropertyType.Boolean)
            };
            fields = new List<FieldModel> { };
            editingFields = new List<FieldModel> { };
        }

        public override bool IsParent { get { return false; } }

        public override string ToString()
        {
            return Resources.ResourceManager.GetString("activityItems");
        }

        public override FieldModel GetTitle(bool editingMode)
        {
            return editingMode ? editingFields[0] : fields[0];//UNDONE: set indexes TDB
        }

        public override FieldModel GetSubtitle(bool editingMode)
        {
            return editingMode ? editingFields[0] : fields[0];//UNDONE: set indexes TDB
        }

        public override bool ShouldSave()
        {
            throw new NotImplementedException();
        }
    }
}
