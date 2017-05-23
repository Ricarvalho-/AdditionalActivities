using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.Controller;

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

        public override bool ShouldSave()
        {
            return false;//UNDONE: Check all required fields and return true if all conditions are met
        }
    }
}
