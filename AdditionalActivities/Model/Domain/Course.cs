using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    public class Course : DomainObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
        //public List<Rule> Rules { get; set; }
    }
}
