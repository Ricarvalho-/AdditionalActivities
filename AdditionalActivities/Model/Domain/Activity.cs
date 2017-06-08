using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    public class Activity : DomainObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinHours { get; set; }
        public int MaxHours { get; set; }
        public int HourStep { get; set; }
        public ActivityCategory Category { get; set; }
        public Rule Rule { get; set; }

        public Activity()//UNDONE: Receive basic info, e.g.: Rule by previous screen
        {
            MinHours = 1;
            MaxHours = 1;
            HourStep = 1;
            Category = new ActivityCategory();
            Rule = new Rule();
        }
    }
}
