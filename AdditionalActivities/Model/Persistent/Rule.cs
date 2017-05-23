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

        public Rule() { }

        public override bool ShouldSave()
        {
            return false;//HACK: Mock save error message
        }
    }
}
