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
            properties = new List<Property> { };
            fields = new List<FieldModel> { };
            editingFields = new List<FieldModel> { };
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
            return editingMode ? editingFields[0] : fields[0];//UNDONE: set indexes TDB
        }

        public override bool ShouldSave()
        {
            throw new NotImplementedException();
        }
    }
}
