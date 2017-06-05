using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    class Activity
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public int MinHours { get; set; }
        public int MaxHours { get; set; }
        public int HourStep { get; set; }
        public ActivityCategory Category { get; set; }
        public Rule Rule { get; set; }
    }
}
