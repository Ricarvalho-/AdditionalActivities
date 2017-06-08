using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    public class Period : DomainObject
    {
        public int Year { get; set; }
        public int Semester { get; set; }
    }
}
