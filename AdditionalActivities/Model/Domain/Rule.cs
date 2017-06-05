﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    class Rule
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int RequiredHours { get; set; }
        public Course Course { get; set; }
        public List<Activity> Activities { get; set; }
        //Year
    }
}
