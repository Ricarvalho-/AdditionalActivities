using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model
{
    class Activity
    {
        string name;
        string description;
        string observation;
        string certificate;
        int minHours;
        int maxHours;
        int hourStep;
        int id;
        ActivityCategory category;
    }
}
