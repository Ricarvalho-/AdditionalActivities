using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model
{
    class ActivityCategory
    {
        private string name;
        private int id;
        private Rule rule;
        private List<Activity> activities;

        public ActivityCategory(string name, Rule rule)
        {
            this.Name = name;
            //this.Id =
            this.Rule = rule;
            this.Activities = new List<Activity>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
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

        internal Rule Rule
        {
            get
            {
                return rule;
            }

            set
            {
                rule = value;
            }
        }

        internal List<Activity> Activities
        {
            get
            {
                return activities;
            }

            set
            {
                activities = value;
            }
        }

        public void AddActivity(Activity activity)
        {
            this.Activities.Add(activity);
        }

        public void RemoveActivity(Activity activity)
        {
            this.Activities.Remove(activity);
        }

        public Activity GetActivity(int index)
        {
            return this.Activities[index];
        }

        public void SetActivity(int index, Activity activity)
        {
            this.Activities[index] = activity;
        }
    }
}
