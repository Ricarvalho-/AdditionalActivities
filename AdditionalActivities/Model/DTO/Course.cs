using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.DTO
{
    class Course
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public Rule Rule { get; set; }

        public Course() { }
    }
}
