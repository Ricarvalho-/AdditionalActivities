using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    class Student
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }
        public RegistrationState RegistrationState { get; set; }
        public Period RegistrationPeriod { get; set; }
        public int AchievedHours { get; set; }
        public Rule Rule { get; set; }
        public Course Course { get; set; }//Would be get by rule
        //TODO: Portofolio list
        //TODO: Methods
}
    //TODO: States
    enum RegistrationState { };
}
