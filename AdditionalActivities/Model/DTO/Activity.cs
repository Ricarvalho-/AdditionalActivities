using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.DTO
{
    class Activity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Observation { get; set; }
        public string Certificate { get; set; }
        public int Id { get; set; }
        public int MinHours { get; set; }
        public int MaxHours { get; set; }
        public int HourStep { get; set; }
        public Course Category { get; set; }

        public Activity() { }
    }
}
