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
        public int Year { get; set; }
        public int Semester { get; set; }
        public string Evaluator { get; set; }
        public bool IsEvaluated { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime EvaluationDate { get; set; }
        public Student Student { get; set; }

        public ActivityPortfolio(Student student)
        {
            Student = student;
            Year = student.Year;
            Semester = student.Semester;
            IsEvaluated = false;
            DeliveryDate = DateTime.Now;
            EvaluationDate = DateTime.Now;
        }
    }
}
