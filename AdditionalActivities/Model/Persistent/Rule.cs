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
            properties = new List<Property> { };
            fields = new List<FieldModel> { };
            editingFields = new List<FieldModel> { };
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
            return editingMode ? editingFields[0] : fields[0];//UNDONE: set indexes TDB
        }

        public override bool ShouldSave()
        {
            return false;//HACK: Mock save error message
        }
    }
}
