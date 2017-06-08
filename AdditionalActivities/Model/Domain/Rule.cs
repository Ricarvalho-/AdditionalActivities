using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    public class Rule : DomainObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int RequiredHours { get; set; }
        public int Year { get; set; }
        public Course Course { get; set; }
        //public List<Activity> Activities { get; set; }

        public Rule()//HACK: Only here to don't crash
        {
            Course = new Course();
        }
    }
}
