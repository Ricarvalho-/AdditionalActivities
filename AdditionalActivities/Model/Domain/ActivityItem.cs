using AdditionalActivities.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    public class ActivityItem : DomainObject
    {
        public int? Id { get; set; }
        public int ScheduledHours { get; set; }
        public int DeferredHours { get; set; }
        public string Name { get; set; }
        public string Observation { get; set; }
        public string Certificate { get; set; }
        public ApprovationState Approvation { get; set; }
        public Activity Activity { get; set; }
        public ActivityPortfolio Portfolio { get; set; }

        public ActivityItem(ActivityPortfolio portfolio)
        {
            Portfolio = portfolio;
            Activity = new Activity(Portfolio.Student.Rule);
            Approvation = ApprovationState.Aprovado;
        }
    }

    public enum ApprovationState
    {
        Aprovado,
        Avaliando,
        Reprovado
    };
}
