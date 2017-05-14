using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Activity() { }

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
