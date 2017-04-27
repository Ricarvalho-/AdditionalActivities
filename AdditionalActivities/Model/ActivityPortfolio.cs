using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model
{
    class ActivityPortfolio
    {
        int semester;
        string evaluator;
        DateTime deliveryDate;
        DateTime evaluationDate;
        List<ActivityItem> items;
        Student student;
    }
}
