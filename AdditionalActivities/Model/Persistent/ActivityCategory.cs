﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    class ActivityCategory : DatabaseObject
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public Rule Rule { get; set; }

        public ActivityCategory() { }

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
