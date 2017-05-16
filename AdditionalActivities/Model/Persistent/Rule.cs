using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.Model.Persistent
{
    class Rule : DatabaseObject
    {
        public string Title { get; set; }
        public string Course { get; set; }
        public int Year { get; set; }
        public int Hours { get; set; }

        public Rule()
        {
            actions = new List<ActionType> { };
            properties = new List<Property> {
                new Property(Resources.ResourceManager.GetString("title"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("course"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("year"), null, Property.PropertyType.Numeric),
                new Property(Resources.ResourceManager.GetString("hours"), null, Property.PropertyType.Numeric)
            };

            Title = "Regra " + ++objN;
            Course = "Curso " + objN;

            Label nameLabel = new Label();//HACK: Mock
            Label regNL = new Label();//HACK: Mock
            nameLabel.Text = Title;
            regNL.Text = Course;
            fields = new List<FieldModel> {
                new FieldModel(Resources.ResourceManager.GetString("title"), nameLabel, () => nameLabel.Text, value => Title = value.ToString()),//HACK: Mock
                new FieldModel(Resources.ResourceManager.GetString("course"), regNL, () => regNL.Text, value => Course = value.ToString()),//HACK: Mock
            };

            TextBox nameTextBox = new TextBox();//HACK: Mock
            TextBox regNTB = new TextBox();//HACK: Mock
            editingFields = new List<FieldModel> {
                new FieldModel(Resources.ResourceManager.GetString("title"), nameTextBox, () => nameTextBox.Text, value => Title = value.ToString()),//HACK: Mock
                new FieldModel(Resources.ResourceManager.GetString("course"), regNTB, () => regNTB.Text, value => Course = value.ToString()),//HACK: Mock
            };
        }

        public override bool IsParent { get { return true; } }

        public override string ToString()
        {
            return Resources.ResourceManager.GetString("rules");
        }

        public override FieldModel GetTitle(bool editingMode)
        {
            return editingMode ? editingFields[0] : fields[0];//UNDONE: set indexes TDB
        }

        public override FieldModel GetSubtitle(bool editingMode)
        {
            return editingMode ? editingFields[1] : fields[1];//UNDONE: set indexes TDB
        }

        public override bool ShouldSave()
        {
            return false;//HACK: Mock save error message
        }
    }
}
