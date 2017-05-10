﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    class ActivityItem : IPersistentObjectModel
    {
        private int id, scheduledHours, deferredHours;
        private string title, observation;
        private Activity activity;
        private ActivityPortfolio portfolio;
        private bool approved;

        public ActivityItem(string title, int scheduledHours, Activity activity, ActivityPortfolio portfolio)
        {
            this.Title = title;
            this.ScheduledHours = scheduledHours;
            this.Activity = activity;
            this.Portfolio = portfolio;
            this.Approved = false;
        }

        public ActivityItem(string name, string observation, int scheduledHours, Activity activity, ActivityPortfolio portfolio)
        {
            this.Title = name;
            this.Observation = observation;
            this.ScheduledHours = scheduledHours;
            this.Activity = activity;
            this.Portfolio = portfolio;
            this.Approved = false;
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

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
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

        public bool Approved
        {
            get
            {
                return approved;
            }

            set
            {
                approved = value;
            }
        }

        public PersistentObjectModelType GetObjectModelType()
        {
            throw new NotImplementedException();
        }

        public List<FieldModel> GetFields(bool editingMode)
        {
            throw new NotImplementedException();
        }

        public string GetTitle()
        {
            throw new NotImplementedException();
        }

        public string GetSubtitle()
        {
            throw new NotImplementedException();
        }

        public bool IsParent()
        {
            throw new NotImplementedException();
        }

        public bool ShouldSave()
        {
            throw new NotImplementedException();
        }
    }
}