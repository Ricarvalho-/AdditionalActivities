using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.DTO
{
    class ActivityItem
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
    }
}
