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
        public int Year { get; set; }
        public int Semester { get; set; }
        public int AchievedHours { get; set; }
        public string RegistrationNumber { get; set; }
        public RegistrationState RegistrationState { get; set; }
        public Course Course { get; set; }
        public Rule Rule { get; set; }
        //public List<ActivityPortfolio> Portfolios { get; set; }

        //TODO: Methods
        public Student()
        {
            Course = new Course();
            Rule = new Rule(Course);
            Year = 2000;
            Semester = 1;
            RegistrationState = RegistrationState.Regular;
        }

        public Student(Course course, string name)
        {
            Course = course != null ? course : new Course();
            Rule = new Rule(Course);
            Name = name;
            Year = 2000;
            Semester = 1;
            RegistrationState = RegistrationState.Regular;
        }
    }
    //TODO: States
    public enum RegistrationState {
        Regular,
        Trancada,
        Formado
    };
}
