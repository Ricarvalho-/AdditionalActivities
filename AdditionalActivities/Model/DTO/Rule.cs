using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.DTO
{
    class Rule
    {
        public string Title { get; set; }
        public string Course { get; set; }
        public int Year { get; set; }
        public int Hours { get; set; }

        public Rule() { }
    }
}
