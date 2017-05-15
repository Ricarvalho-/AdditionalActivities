using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.Controller;

namespace AdditionalActivities.Model.Persistent
{
    class Activity : DatabaseObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Observation { get; set; }
        public string Certificate { get; set; }
        public int Id { get; set; }
        public int MinHours { get; set; }
        public int MaxHours { get; set; }
        public int HourStep { get; set; }
        public ActivityCategory Category { get; set; }

        public Activity() {
            //TODO: Define actions that should appear in MultiSelectionHeader's actionComboBox and in DetailsHeader's moreButton contextMenu
            //NOTE: Not included Delete here, because it is in a button in DetailsHeader
            actions = new List<ActionType> {
                new ActionType(Resources.ResourceManager.GetString("delete"), Delete)
                //NOTE: Delete here is only an implementation example, delete actions are added in ViewMediator MultiSelect() method to all objs
            };

            //UNDONE: Set corresponding persistentPropName as in database to filter/order by
            properties = new List<Property> {
                new Property(Resources.ResourceManager.GetString("title"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("certif"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("minHours"), null, Property.PropertyType.Numeric),
                new Property(Resources.ResourceManager.GetString("maxHours"), null, Property.PropertyType.Numeric),
                new Property(Resources.ResourceManager.GetString("hourStep"), null, Property.PropertyType.Numeric)
            };

            //TODO: Define editable fields and readable fields, any type of control can be added (even buttons, or also a header! huahuahuah)
            //NOTE: If a readOnly field should be shown while editing, we can add the same control in fields and editingFields or set control's Enabled property to false
            Label titleLabel = new Label();
            TextBox titleTextBox = new TextBox();

            fields = new List<FieldModel> {
                new FieldModel(Resources.ResourceManager.GetString("title"), titleLabel, () => titleLabel.Text, value => Title = (String)value)
            };
            editingFields = new List<FieldModel> {
                new FieldModel(Resources.ResourceManager.GetString("title"), titleTextBox, () => titleTextBox.Text, value => Title = (String)value)
            };
        }

        public override bool IsParent { get { return false; } }

        public override string ToString()
        {
            return Resources.ResourceManager.GetString("activities");
        }

        public override FieldModel GetTitle(bool editingMode)
        {
            return editingMode ? editingFields[0] : fields[0];
        }

        public override FieldModel GetSubtitle(bool editingMode)
        {
            return editingMode ? editingFields[0] : fields[0];//UNDONE: Set indexes TDB
        }

        public override bool ShouldSave()
        {
            foreach (FieldModel field in editingFields)
                field.Save();

            return false;//UNDONE: Check all required fields and return true if all conditions are met
        }

        //NOTE: Delete here is only an implementation example, so this method will be removed
        private void Delete()
        {
            ModelMediator.Delete(this);
        }
    }
}
