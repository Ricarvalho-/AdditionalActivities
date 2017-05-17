using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.Model.Persistent
{
    class ActivityPortfolio : DatabaseObject
    {
        public int Id { get; set; }
        public int Semester { get; set; }
        public string Title { get; set; }
        public string Evaluator { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime EvaluationDate { get; set; }
        public Student Student { get; set; }

        public ActivityPortfolio()
        {
            actions = new List<ActionType> { };
            properties = new List<Property> {
                new Property(Resources.ResourceManager.GetString("title"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("semester"), null, Property.PropertyType.Numeric),
                new Property(Resources.ResourceManager.GetString("evaluator"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("delDate"), null, Property.PropertyType.Date),
                new Property(Resources.ResourceManager.GetString("evalDate"), null, Property.PropertyType.Date)
            };

            Title = "Portifólio " + ++objN;
            Semester = objN * 100;

            Label nameLabel = new Label();//HACK: Mock
            Label regNL = new Label();//HACK: Mock
            nameLabel.Text = Title;
            regNL.Text = Semester.ToString();
            fields = new List<FieldModel> {
                new FieldModel(Resources.ResourceManager.GetString("title"), nameLabel, () => nameLabel.Text, value => Title = value.ToString()),//HACK: Mock
                new FieldModel(Resources.ResourceManager.GetString("semester"), regNL, () => regNL.Text, value => Semester = 1565),//HACK: Mock
            };

            TextBox nameTextBox = new TextBox();//HACK: Mock
            TextBox regNTB = new TextBox();//HACK: Mock
            editingFields = new List<FieldModel> {
                new FieldModel(Resources.ResourceManager.GetString("title"), nameTextBox, () => nameTextBox.Text, value => Title = value.ToString()),//HACK: Mock
                new FieldModel(Resources.ResourceManager.GetString("semester"), regNTB, () => regNTB.Text, value => Semester = 1565),//HACK: Mock
            };
        }

        public override bool IsParent { get { return true; } }

        public override string ToString()
        {
            return Resources.ResourceManager.GetString("portfolios");
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
            return false;//throw new NotImplementedException();
        }
    }
}
