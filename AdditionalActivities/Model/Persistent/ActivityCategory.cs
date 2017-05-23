using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.Model.Persistent
{
    class ActivityCategory : DatabaseObject
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public Rule Rule { get; set; }

        public ActivityCategory() { }

        public override bool ShouldSave()
        {
            throw new NotImplementedException();
        }
    }
}
