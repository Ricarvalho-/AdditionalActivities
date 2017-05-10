using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    class ActivityCategory : IPersistentObjectModel
    {
        private string title;
        private int id;
        private Rule rule;
        private List<Activity> activities;

        public ActivityCategory(string title, Rule rule)
        {
            this.Title = title;
            this.Rule = rule;
            this.Activities = new List<Activity>();
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
