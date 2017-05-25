using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.DTO
{
    class ActivityPortfolio
    {
        public int Id { get; set; }
        public int Semester { get; set; }
        public string Title { get; set; }
        public string Evaluator { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime EvaluationDate { get; set; }
        public Student Student { get; set; }

        public ActivityPortfolio() { }
    }
}
