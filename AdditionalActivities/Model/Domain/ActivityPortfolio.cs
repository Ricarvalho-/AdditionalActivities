using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    public class ActivityPortfolio : DomainObject
    {
        public int? Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime EvaluationDate { get; set; }
        public Period SchoolPeriod { get; set; }
        public Student Student { get; set; }
        public Evaluator Evaluator { get; set; }

        public ActivityPortfolio(Student student)
        {
            Student = student;
            SchoolPeriod = (Period)student.RegistrationPeriod.Copy();
            Evaluator = new Evaluator();
            DeliveryDate = DateTime.Now;
            EvaluationDate = DateTime.Now;
        }
    }
}
