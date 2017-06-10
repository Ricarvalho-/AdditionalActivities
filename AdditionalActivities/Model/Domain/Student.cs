using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    public class Student : DomainObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int AchievedHours { get; set; }
        public int RegistrationNumber { get; set; }
        public RegistrationState RegistrationState { get; set; }
        public Period RegistrationPeriod { get; set; }
        public Rule Rule { get; set; }
        //public List<ActivityPortfolio> Portfolios { get; set; }
        
        //TODO: Methods
        public Student()
        {
            Rule = new Rule(new Course());
            RegistrationPeriod = new Period();
            RegistrationPeriod.Year = 2000;
            RegistrationPeriod.Semester = 1;
            RegistrationState = RegistrationState.Regular;
        }

        public Student(Course course, string nameOrRegistrationNumber)
        {
            if (course != null)
                Rule = new Rule(course);
            else
                Rule = new Rule(new Course());

            RegistrationPeriod = new Period();
            RegistrationPeriod.Year = 2000;
            RegistrationPeriod.Semester = 1;
            RegistrationState = RegistrationState.Regular;

            int registrationNumber;
            if (int.TryParse(nameOrRegistrationNumber, out registrationNumber))
                RegistrationNumber = registrationNumber;
            else
                Name = nameOrRegistrationNumber;
        }
    }
    //TODO: States
    public enum RegistrationState {
        Regular,
        Trancada,
        Formado
    };
}
