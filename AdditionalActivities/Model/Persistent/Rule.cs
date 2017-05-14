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

        public Rule() { }

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
