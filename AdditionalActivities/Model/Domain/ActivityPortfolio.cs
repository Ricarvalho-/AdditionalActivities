using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    public class ActivityPortfolio
    {
        public int? Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime EvaluationDate { get; set; }
        public Period SchoolYear { get; set; }
        public Student Student { get; set; }
        public Evaluator Evaluator { get; set; }
    }
}
