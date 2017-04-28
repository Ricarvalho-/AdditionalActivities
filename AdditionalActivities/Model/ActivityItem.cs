using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model
{
    class ActivityItem
    {
        private int id, scheduledHours, deferredHours;
        private string observation;
        private Activity activity;
        private ActivityPortfolio portfolio;

        public ActivityItem(int scheduledHours, Activity activity, ActivityPortfolio portfolio)
        {
            //this.Id =
            this.ScheduledHours = scheduledHours;
            this.Activity = activity;
            this.Portfolio = portfolio;
        }

        public ActivityItem(int scheduledHours, string observation, Activity activity, ActivityPortfolio portfolio)
        {
            //this.Id =
            this.ScheduledHours = scheduledHours;
            this.Observation = observation;
            this.Activity = activity;
            this.Portfolio = portfolio;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int ScheduledHours
        {
            get
            {
                return scheduledHours;
            }

            set
            {
                scheduledHours = value;
            }
        }

        public int DeferredHours
        {
            get
            {
                return deferredHours;
            }

            set
            {
                deferredHours = value;
            }
        }

        public string Observation
        {
            get
            {
                return observation;
            }

            set
            {
                observation = value;
            }
        }

        internal Activity Activity
        {
            get
            {
                return activity;
            }

            set
            {
                activity = value;
            }
        }

        internal ActivityPortfolio Portfolio
        {
            get
            {
                return portfolio;
            }

            set
            {
                portfolio = value;
            }
        }
    }
}
