using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ActivityPortfolio() { }

        public override bool IsParent { get { return true; } }

        public override List<ActionType> Actions { get { throw new NotImplementedException(); } }

        public override List<Property> Properties { get { throw new NotImplementedException(); } }

        protected override List<FieldModel> Fields { get { throw new NotImplementedException(); } }

        protected override List<FieldModel> EditingFields { get { throw new NotImplementedException(); } }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override FieldModel GetTitle(bool editingMode)
        {
            throw new NotImplementedException();
        }

        public override FieldModel GetSubtitle(bool editingMode)
        {
            throw new NotImplementedException();
        }

        public override bool ShouldSave()
        {
            throw new NotImplementedException();
        }
    }
}
