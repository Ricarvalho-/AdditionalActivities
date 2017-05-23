using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.Model.Persistent
{
    class Student : DatabaseObject
    {
        public string Name { get; set; }
        public string RegisterNumber { get; set; }
        public string RegisterState { get; set; }
        public int Hours { get; set; }
        public Rule Rule { get; set; }

        public Student() { }

        public override bool ShouldSave()
        {
            return true;//HACK: Mock
        }
    }
}
