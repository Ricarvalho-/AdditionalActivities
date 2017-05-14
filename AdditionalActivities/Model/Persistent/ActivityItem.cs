using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ActivityItem() { }

        public override bool IsParent { get { return false; } }

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
