using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    class ActivityCategory : DatabaseObject
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public Rule Rule { get; set; }
        public List<Activity> Activities { get; set; }

        public ActivityCategory() { }

        public ActivityCategory(string title, Rule rule)
        {
            Title = title;
            Rule = rule;
            Activities = new List<Activity>();
            //TODO: set actions, properties, field, editingFields lists
        }

        public void AddActivity(Activity activity)
        {
            Activities.Add(activity);
        }

        public void RemoveActivity(Activity activity)
        {
            Activities.Remove(activity);
        }

        public Activity GetActivity(int index)
        {
            return Activities[index];
        }

        public void SetActivity(int index, Activity activity)
        {
            Activities[index] = activity;
        }

        public override FieldModel GetTitle(bool editingMode)
        {
            throw new NotImplementedException();
        }

        public override FieldModel GetSubtitle(bool editingMode)
        {
            throw new NotImplementedException();
        }

        public override List<DatabaseObject> ReadChildren()
        {
            throw new NotImplementedException();
        }

        public override DatabaseObject SetupFromDB()
        {
            throw new NotImplementedException();
        }

        public override bool IsParent()
        {
            throw new NotImplementedException();
        }

        public override bool CouldSave()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
