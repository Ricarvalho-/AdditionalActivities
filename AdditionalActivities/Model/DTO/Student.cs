using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.DTO
{
    class Student
    {
        public string Name { get; set; }
        public string RegisterNumber { get; set; }
        public string RegisterState { get; set; }
        public int Hours { get; set; }
        public Rule Rule { get; set; }

        public Student() { }
    }
}
