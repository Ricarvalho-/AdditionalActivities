using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model
{
    class ActivityItem
    {
        int id;
        int scheduledHours;
        int deferredHours;
        string observation;
        Activity activity;
        ActivityPortfolio portfolio;
    }
}
