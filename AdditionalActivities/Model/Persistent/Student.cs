using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.Model.Persistent
{
    class Student : DatabaseObject
    {
        public string Name { get; set; }
        public string RegisterNumber { get; set; }
        public string RegisterState { get; set; }
        public int Hours { get; set; }
        public Rule Rule { get; set; }

        public Student()
        {
            actions = new List<ActionType> { };
            properties = new List<Property> {
                new Property(Resources.ResourceManager.GetString("name"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("regNumber"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("regState"), null, Property.PropertyType.Textual),
                new Property(Resources.ResourceManager.GetString("accHours"), null, Property.PropertyType.Numeric)
            };

            Name = "Aluno " + ++objN;
            RegisterNumber = "123" + objN + "-" + objN;

            Label nameLabel = new Label();//HACK: Mock
            Label regNL = new Label();//HACK: Mock
            Label regSL = new Label();//HACK: Mock
            Label hourL = new Label();//HACK: Mock
            nameLabel.Text = Name;
            regNL.Text = RegisterNumber;
            regSL.Text = RegisterState;
            hourL.Text = Hours + "";
            fields = new List<FieldModel> {
                new FieldModel(Resources.ResourceManager.GetString("name"), nameLabel, () => nameLabel.Text, value => Name = value.ToString()),//HACK: Mock
                new FieldModel(Resources.ResourceManager.GetString("regNumber"), regNL, () => regNL.Text, value => RegisterNumber = value.ToString()),//HACK: Mock
                new FieldModel(Resources.ResourceManager.GetString("regState"), regSL, () => regSL.Text, value => RegisterState = value.ToString()),//HACK: Mock
                new FieldModel(Resources.ResourceManager.GetString("accHours"), hourL, () => hourL.Text, value => Hours = 16)//HACK: Mock
            };

            TextBox nameTextBox = new TextBox();//HACK: Mock
            TextBox regNTB = new TextBox();//HACK: Mock
            TextBox regSTB = new TextBox();//HACK: Mock
            TextBox hourTD = new TextBox();//HACK: Mock
            editingFields = new List<FieldModel> {
                new FieldModel(Resources.ResourceManager.GetString("name"), nameTextBox, () => nameTextBox.Text, value => Name = value.ToString()),//HACK: Mock
                new FieldModel(Resources.ResourceManager.GetString("regNumber"), regNTB, () => regNTB.Text, value => RegisterNumber = value.ToString()),//HACK: Mock
                new FieldModel(Resources.ResourceManager.GetString("regState"), regSTB, () => regSTB.Text, value => RegisterState = value.ToString()),//HACK: Mock
                new FieldModel(Resources.ResourceManager.GetString("accHours"), hourTD, () => hourTD.Text, value => Hours = 16)//HACK: Mock
            };
        }

        public override bool IsParent { get { return true; } }

        public override string ToString()
        {
            return Resources.ResourceManager.GetString("students");
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
            foreach (FieldModel field in editingFields)
                field.Save();
            return true;//HACK: Mock
        }
    }
}
